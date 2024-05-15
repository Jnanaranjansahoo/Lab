using Lab.DataAcess.Repository.IRepository;
using Lab.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabWeb.Areas.OfficerView.Controllers
{
    public class OfficerViewController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public OfficerViewController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<Client> objClientList = _unitOfWork.Client.GetAll(includeProperties:"Officer");
            return View(objClientList);
        }
    }
}
