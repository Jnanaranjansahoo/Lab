using Lab.DataAcess.Data;
using Lab.DataAcess.Repository.IRepository;
using Lab.Models;
using Lab.Models.ViewModels;
using Lab.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Claims;

namespace LabWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    
    //[Authorize(Roles = SD.Role_Officer)]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db;
        
        public UserController(ApplicationDbContext db)
        {
           _db = db;
        }
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult GetAll()
        {
            List<ApplicationUser> objUserList = _db.ApplicationUsers.Include(u => u.Officer).ToList();
            return Json(new { data = objUserList });
        }




        #region API CALLS


        //[HttpGet]
        //public IActionResult GetAll()
        //{
        //    List<ApplicationUser> objUserList = _db.ApplicationUsers.Include(u=>u.Officer).ToList();
        //    return Json(new { data = objUserList });
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


            //return Json(new { success = true, message = "Delete Successful" });
        //}
        #endregion























        //public IActionResult Delete(int? id)
        //{
        //    if (id == null || id == 0)
        //    {
        //        return NotFound();
        //    }
        //    Client? clientFromDb = _unitOfWork.Client.Get(u => u.Id == id);
        //    if (clientFromDb == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(clientFromDb);

        //}
        //[HttpPost, ActionName("Delete")]
        //public IActionResult DeletePOST(int? id)
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

        //    TempData["success"] = "Client Deleted Successfully";

        //    return RedirectToAction("Index");

        //}












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
