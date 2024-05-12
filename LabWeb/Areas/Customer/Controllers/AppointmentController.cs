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

namespace LabWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize(Roles = SD.Role_Admin)]

    public class AppointmentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public AppointmentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
            List<Appointment> objAppointmentList = _unitOfWork.Appointment.GetAll().ToList();

            return View(objAppointmentList);
        }
        public IActionResult Upsert(int? id)
        {
            if (id == null || id == 0)
            {
                //Create

                return View(new Appointment());
            }
            else
            {
                //update

                Appointment appointmenObj = _unitOfWork.Appointment.Get(u => u.Id == id);
                return View(appointmenObj);
            }
        }
        [HttpPost]
        public IActionResult Upsert(Appointment AppointmentObj)
        {

            if (ModelState.IsValid)
            {

                if (AppointmentObj.Id == 0)
                {
                    _unitOfWork.Appointment.Add(AppointmentObj);
                }
                else
                {
                    _unitOfWork.Appointment.Update(AppointmentObj);
                }

                _unitOfWork.Save();
                TempData["success"] = "Appointment Created Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                return View(AppointmentObj);
            }
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Appointment? appointmentFromDb = _unitOfWork.Appointment.Get(u => u.Id == id);
            if (appointmentFromDb == null)
            {
                return NotFound();
            }

            return View(appointmentFromDb);

        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {

            var appointmentToBeDeleted = _unitOfWork.Appointment.Get(u => u.Id == id);
            if (appointmentToBeDeleted == null)
            {
                return Json(new { success = false, Message = "Error while deleting" });
            }

            _unitOfWork.Appointment.Remove(appointmentToBeDeleted);
            _unitOfWork.Save();

            TempData["success"] = "Appointment Deleted Successfully";

            return RedirectToAction("Index");

        }


        //#region API CALLS

        //[HttpGet]
        //public IActionResult GetAll()
        //{
        //    List<Appointment> objAppointmentList = _unitOfWork.Appointment.GetAll(includeProperties: "Officer").ToList();
        //    return Json(new { data = objAppointmentList });
        //}
        //[HttpDelete]
        //public IActionResult Delete(int? id)
        //{
        //    var appointmentToBeDeleted = _unitOfWork.Appointment.Get(u => u.Id == id);
        //    if (appointmentToBeDeleted == null)
        //    {
        //        return Json(new { success = false, Message = "Error while deleting" });
        //    }
        //    var oldImagePath =
        //                    Path.Combine(_webHostEnvironment.WebRootPath,
        //                    appointmentToBeDeleted.ImageUrl.TrimStart('\\'));


        //    if (System.IO.File.Exists(oldImagePath))
        //    {
        //        System.IO.File.Delete(oldImagePath);
        //    }

        //    _unitOfWork.Appointment.Remove(appointmentToBeDeleted);
        //    _unitOfWork.Save();


        //    return Json(new { success = true, message = "Delete Successful" });
        //}
        //#endregion
    }
}
