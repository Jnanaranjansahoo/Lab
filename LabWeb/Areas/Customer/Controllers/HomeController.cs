using Lab.DataAcess.Repository;
using Lab.DataAcess.Repository.IRepository;
using Lab.Models;
using Lab.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LabWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        public HomeController(ILogger<HomeController> logger , IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }
 
        public IActionResult Appointment()
        {
            List<Appointment> objAppointmentList = _unitOfWork.Appointment.GetAll().ToList();

            return View(objAppointmentList);
        }
        [Authorize]
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
                return RedirectToAction("Appointment");
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

            return RedirectToAction("Appointment");

        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult FAQs()
        {
            return View();
        }
        public IActionResult Partnership()
        {
            return View();
        }
        public IActionResult HelpSupport()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
