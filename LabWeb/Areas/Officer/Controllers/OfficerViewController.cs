using Microsoft.AspNetCore.Mvc;

namespace LabWeb.Areas.Officer.Controllers
{
    public class OfficerViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
