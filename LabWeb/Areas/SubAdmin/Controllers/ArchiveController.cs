using Lab.DataAcess.Repository.IRepository;
using Lab.Models;
using Lab.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;

namespace LabWeb.Areas.SubAdmin.Controllers
{
    [Area("SubAdmin")]
    public class ArchiveController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ArchiveController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            List<Archive> objArchiveList = _unitOfWork.Archive.GetAll(includeProperties: "Officer").ToList();

            return View(objArchiveList);
        }
        public IActionResult Upsert(int? id)
        {

            ArchiveVM archiveVM = new()
            {
                OfficerList = _unitOfWork.Officer.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                Archive = new Archive()
            };
            if (id == null || id == 0)
            {
                //Create

                return View(archiveVM);
            }
            else
            {
                //update

                archiveVM.Archive = _unitOfWork.Archive.Get(u => u.Id == id);
                return View(archiveVM);
            }
        }
        [HttpPost]
        public IActionResult Upsert(ArchiveVM archiveVM, IFormFile? file)
        {

            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string archivePath = Path.Combine(wwwRootPath, @"images\client");

                    if (!string.IsNullOrEmpty(archiveVM.Archive.ImageUrl))
                    {
                        // Delete the old images

                        var oldImagePath =
                            Path.Combine(wwwRootPath, archiveVM.Archive.ImageUrl.TrimStart('\\'));


                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                    using (var fileStream = new FileStream(Path.Combine(archivePath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    archiveVM.Archive.ImageUrl = @"\images\client\" + fileName;
                }

                if (archiveVM.Archive.Id == 0)
                {
                    _unitOfWork.Archive.Add(archiveVM.Archive);
                }
                else
                {
                    _unitOfWork.Archive.Update(archiveVM.Archive);
                }

                _unitOfWork.Save();
                TempData["success"] = "Archive Created Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                archiveVM.OfficerList = _unitOfWork.Officer.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                });
                return View(archiveVM);
            }
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Archive? archiveFromDb = _unitOfWork.Archive.Get(u => u.Id == id);
            if (archiveFromDb == null)
            {
                return NotFound();
            }

            return View(archiveFromDb);

        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {

            var archiveToBeDeleted = _unitOfWork.Archive.Get(u => u.Id == id);
            if (archiveToBeDeleted == null)
            {
                return Json(new { success = false, Message = "Error while deleting" });
            }
            var oldImagePath =
                            Path.Combine(_webHostEnvironment.WebRootPath,
                            archiveToBeDeleted.ImageUrl.TrimStart('\\'));


            if (System.IO.File.Exists(oldImagePath))
            {
                System.IO.File.Delete(oldImagePath);
            }

            _unitOfWork.Archive.Remove(archiveToBeDeleted);
            _unitOfWork.Save();

            TempData["success"] = "Client Deleted Successfully";

            return RedirectToAction("Index");

        }

    }
}
