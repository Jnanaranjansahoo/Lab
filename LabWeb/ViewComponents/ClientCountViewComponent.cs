using Lab.DataAcess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace LabWeb.ViewComponents
{
    public class ClientCountViewComponent : ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;
        public ClientCountViewComponent(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
            var isAdmin = User.IsInRole("Admin");
            if (isAdmin)
            {
                objClientList = _unitOfWork.Client.GetAll(includeProperties: "Officer").ToList();
            }
            else
            {
                objClientList = _unitOfWork.Client.GetAll(x => x.ApplicationUserId == userId, includeProperties: "Officer").ToList();
            }
            ViewBag.ClientCount = objClientList.Count;
        }
    }
}
