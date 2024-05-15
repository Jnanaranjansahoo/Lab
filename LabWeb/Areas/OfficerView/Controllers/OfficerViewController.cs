using Microsoft.AspNetCore.Mvc;

namespace LabWeb.Areas.OfficerView.Controllers
{
    [Area("OfficerView")]
    public class OfficerViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
