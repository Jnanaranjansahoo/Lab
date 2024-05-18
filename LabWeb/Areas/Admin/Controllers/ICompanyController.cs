using Microsoft.AspNetCore.Mvc;

namespace LabWeb.Areas.Admin.Controllers
{
    public interface ICompanyController
    {
        IActionResult Delete(int? id);
        IActionResult Delete(int? id);
        IActionResult GetAll();
        IActionResult GetAll();
        IActionResult Index();
        IActionResult Index();
        IActionResult Upsert(CompanyVM companyVM, IFormFile? file);
        IActionResult Upsert(CompanyVM companyVM, IFormFile? file);
        IActionResult Upsert(int? id);
        IActionResult Upsert(int? id);
    }
}