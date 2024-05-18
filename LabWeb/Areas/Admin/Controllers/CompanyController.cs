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
    public class CompanyController : Controller, ICompanyController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public CompanyController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            //var claimsIdentity = (ClaimsIdentity)User.Identity;
            //var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

            List<Company> objCompanyList = _unitOfWork.Company.GetAll(includeProperties: "Officer").ToList();
            //if(objCompanyList != null)
            //{
            //    objCompanyList = _unitOfWork.Company.GetAll(x=>x.ApplicationUserId == userId ).ToList();
            //}
            return View(objCompanyList);
        }
        public IActionResult Upsert(int? id)
        {

            CompanyVM companyVM = new()
            {
                OfficerList = _unitOfWork.Officer.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                Company = new Company()
            };
            if (id == null || id == 0)
            {
                //Create

                return View(companyVM);
            }
            else
            {
                //update

                companyVM.Company = _unitOfWork.Company.Get(u => u.Id == id);
                return View(companyVM);
            }
        }
        [HttpPost]
        public IActionResult Upsert(CompanyVM companyVM, IFormFile? file)
        {
            //var claimsIdentity = (ClaimsIdentity)User.Identity;
            //var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
            //companyVM.Company.ApplicationUserId = userId;

            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string companyPath = Path.Combine(wwwRootPath, @"images\company");

                    if (!string.IsNullOrEmpty(companyVM.Company.ImageUrl))
                    {
                        // Delete the old images

                        var oldImagePath =
                            Path.Combine(wwwRootPath, companyVM.Company.ImageUrl.TrimStart('\\'));


                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                    using (var fileStream = new FileStream(Path.Combine(companyPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    companyVM.Company.ImageUrl = @"\images\company\" + fileName;
                }

                if (companyVM.Company.Id == 0)
                {
                    _unitOfWork.Company.Add(companyVM.Company);
                }
                else
                {
                    _unitOfWork.Company.Update(companyVM.Company);
                }

                _unitOfWork.Save();
                TempData["success"] = "Company Created Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                companyVM.OfficerList = _unitOfWork.Officer.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                });
                return View(companyVM);
            }
        }
        //public IActionResult Delete(int? id)
        //{
        //    if (id == null || id == 0)
        //    {
        //        return NotFound();
        //    }
        //    Company? companyFromDb = _unitOfWork.Company.Get(u => u.Id == id);
        //    if (companyFromDb == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(companyFromDb);

        //}
        //[HttpPost, ActionName("Delete")]
        //public IActionResult DeletePOST(int? id)
        //{

        //    var companyToBeDeleted = _unitOfWork.Company.Get(u => u.Id == id);
        //    if (companyToBeDeleted == null)
        //    {
        //        return Json(new { success = false, Message = "Error while deleting" });
        //    }
        //    var oldImagePath =
        //                    Path.Combine(_webHostEnvironment.WebRootPath,
        //                    companyToBeDeleted.ImageUrl.TrimStart('\\'));


        //    if (System.IO.File.Exists(oldImagePath))
        //    {
        //        System.IO.File.Delete(oldImagePath);
        //    }

        //    _unitOfWork.Company.Remove(companyToBeDeleted);
        //    _unitOfWork.Save();

        //    TempData["success"] = "Company Deleted Successfully";

        //    return RedirectToAction("Index");

        //}


        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Company> objCompanyList = _unitOfWork.Company.GetAll(includeProperties: "Officer").ToList();
            return Json(new { data = objCompanyList });
        }
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var companyToBeDeleted = _unitOfWork.Company.Get(u => u.Id == id);
            if (companyToBeDeleted == null)
            {
                return Json(new { success = false, Message = "Error while deleting" });
            }
            var oldImagePath =
                            Path.Combine(_webHostEnvironment.WebRootPath,
                            companyToBeDeleted.ImageUrl.TrimStart('\\'));


            if (System.IO.File.Exists(oldImagePath))
            {
                System.IO.File.Delete(oldImagePath);
            }

            _unitOfWork.Company.Remove(companyToBeDeleted);
            _unitOfWork.Save();


            return Json(new { success = true, message = "Delete Successful" });
        }
        #endregion
    }
}
