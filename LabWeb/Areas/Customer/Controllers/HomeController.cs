using Lab.DataAcess.Repository.IRepository;
using Lab.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;

namespace LabWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        //HomeController CHanges
        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
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

                Appointment appointmentObj = _unitOfWork.Appointment.Get(u => u.Id == id);
                return View(appointmentObj);
            }
        }
        [HttpPost]
        [Authorize]
        public IActionResult Upsert(Appointment AppointmentObj)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
          
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


        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Appointment> objAppointmentList = _unitOfWork.Appointment.GetAll().ToList();
            return Json(new { data = objAppointmentList });
        }
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var appointmentToBeDeleted = _unitOfWork.Appointment.Get(u => u.Id == id);
            if (appointmentToBeDeleted == null)
            {
                return Json(new { success = false, Message = "Error while deleting" });
            }

            _unitOfWork.Appointment.Remove(appointmentToBeDeleted);
            _unitOfWork.Save();


            return Json(new { success = true, message = "Delete Successful" });
        }
        #endregion
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
