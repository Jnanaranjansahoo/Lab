using Lab.DataAcess.Data;
using Lab.DataAcess.Repository.IRepository;
using Lab.Models;
using Lab.Models.ViewModels;
using Lab.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Security.Claims;

namespace LabWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    
    //[Authorize(Roles = SD.Role_Officer)]
    public class ClientController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ClientController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
            var isAdmin = User.IsInRole("Admin");

            List<Client> objClientList;

            //if (User.IsInRole(SD.Role_Admin))
            //{
            //    objClientList = _unitOfWork.Client.GetAll(includeProperties: "ApplicationUser").ToList();
            //}
            //else
            //{
            //    var cliaimsIdentity = (ClaimsIdentity)User.Identity;
            //    var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

            //}

            if (isAdmin)
            {
                objClientList = _unitOfWork.Client.GetAll(includeProperties: "Officer").ToList();
            }
            else
            {
                objClientList = _unitOfWork.Client.GetAll(x => x.ApplicationUserId == userId, includeProperties: "Officer").ToList();
            }

            ViewBag.ClientCount = objClientList.Count;
            ViewBag.Total = objClientList.Count * 120;
            return View(objClientList);
        }
        public IActionResult Upsert(int? id)
        {

            ClientVM clientVM = new()
            {
                OfficerList = _unitOfWork.Officer.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                
                
                Client = new Client()
            };
            if (id == null || id == 0)
            {
                //Create
                
                return View(clientVM);
            }
            else
            {
                //update

                clientVM.Client = _unitOfWork.Client.Get(u => u.Id == id);
                return View(clientVM);
            }
        }
        [HttpPost]
        public IActionResult Upsert(ClientVM clientVM, IFormFile? file)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
            clientVM.Client.ApplicationUserId = userId;

            //ClientVM clientVMFormDb = _unitOfWork.Client.Get(u=>u.ApplicationUserId == userId);

            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string clientPath = Path.Combine(wwwRootPath, @"images\client");

                    if (!string.IsNullOrEmpty(clientVM.Client.ImageUrl))
                    {
                        // Delete the old images

                        var oldImagePath =
                            Path.Combine(wwwRootPath, clientVM.Client.ImageUrl.TrimStart('\\'));


                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                    using (var fileStream = new FileStream(Path.Combine(clientPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    clientVM.Client.ImageUrl = @"\images\client\" + fileName;
                }

                if (clientVM.Client.Id == 0)
                {
                    _unitOfWork.Client.Add(clientVM.Client);
                }
                else
                {
                    _unitOfWork.Client.Update(clientVM.Client);
                }

                _unitOfWork.Save();
                TempData["success"] = "Client Created Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                clientVM.OfficerList = _unitOfWork.Officer.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                });
                return View(clientVM);
            }
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Client? clientFromDb = _unitOfWork.Client.Get(u => u.Id == id);
            if (clientFromDb == null)
            {
                return NotFound();
            }

            return View(clientFromDb);

        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {

            var clientToBeDeleted = _unitOfWork.Client.Get(u => u.Id == id);
            if (clientToBeDeleted == null)
            {
                return Json(new { success = false, Message = "Error while deleting" });
            }
            var oldImagePath =
                            Path.Combine(_webHostEnvironment.WebRootPath,
                            clientToBeDeleted.ImageUrl.TrimStart('\\'));


            if (System.IO.File.Exists(oldImagePath))
            {
                System.IO.File.Delete(oldImagePath);
            }

            _unitOfWork.Client.Remove(clientToBeDeleted);
            _unitOfWork.Save();

            TempData["success"] = "Client Deleted Successfully";

            return RedirectToAction("Index");

        }


        //#region API CALLS

        //[HttpGet]
        //public IActionResult GetAll()
        //{
        //    List<Client> objClientList = _unitOfWork.Client.GetAll(includeProperties: "Officer").ToList();
        //    return Json(new { data = objClientList });
        //}
        //[HttpDelete]
        //public IActionResult Delete(int? id)
        //{
        //    var clientToBeDeleted = _unitOfWork.Client.Get(u => u.Id == id);
        //    if (clientToBeDeleted == null)
        //    {
        //        return Json(new { success = false, Message = "Error while deleting" });
        //    }
        //    var oldImagePath =
        //                    Path.Combine(_webHostEnvironment.WebRootPath,
        //                    clientToBeDeleted.ImageUrl.TrimStart('\\'));


        //    if (System.IO.File.Exists(oldImagePath))
        //    {
        //        System.IO.File.Delete(oldImagePath);
        //    }

        //    _unitOfWork.Client.Remove(clientToBeDeleted);
        //    _unitOfWork.Save();


        //    return Json(new { success = true, message = "Delete Successful" });
        //}
        //#endregion
    }
}
