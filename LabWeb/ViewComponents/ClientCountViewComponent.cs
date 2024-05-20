using Lab.DataAcess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace LabWeb.ViewComponents
{
    public class ClientCountViewComponent : ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;
        public ClientCountViewComponent(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
