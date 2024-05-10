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

namespace LabWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = SD.Role_Admin)]
    public class CompController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CompController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
            List<Officer> objOfficerList = _unitOfWork.Officer.GetAll().ToList();

            return View(objOfficerList);
        }
        public IActionResult Upsert(int? id)
        {


            if (id == null || id == 0)
            {
                //Create

                return View(new Officer());
            }
            else
            {
                //update

                Officer officerObj = _unitOfWork.Officer.Get(u => u.Id == id);
                return View(officerObj);
            }
        }
        [HttpPost]
        public IActionResult Upsert(Officer OfficerObj)
        {

            if (ModelState.IsValid)
            {
                if (OfficerObj.Id == 0)
                {
                    _unitOfWork.Officer.Add(OfficerObj);
                }
                else
                {
                    _unitOfWork.Officer.Update(OfficerObj);
                }

                _unitOfWork.Save();
                TempData["success"] = "Officer Created Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                return View(OfficerObj);
            }

        }


        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Officer> objOfficerList = _unitOfWork.Officer.GetAll().ToList();
            return Json(new { data = objOfficerList });
        }
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var officerToBeDeleted = _unitOfWork.Officer.Get(u => u.Id == id);
            if (officerToBeDeleted == null)
            {
                return Json(new { success = false, Message = "Error while deleting" });
            }

            _unitOfWork.Officer.Remove(officerToBeDeleted);
            _unitOfWork.Save();


            return Json(new { success = true, message = "Delete Successful" });
        }
        #endregion
    }
}
