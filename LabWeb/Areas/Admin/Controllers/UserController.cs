using Lab.DataAcess.Data;
using Lab.DataAcess.Repository;
using Lab.DataAcess.Repository.IRepository;
using Lab.Models;
using Lab.Models.ViewModels;
using Lab.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Claims;

namespace LabWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    
    //[Authorize(Roles = SD.Role_Officer)]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db;
        public UserController(ApplicationDbContext db)
        {
            _db = db;
           
        }
        public IActionResult Index()
        {
            List<ApplicationUser> objUserList = _db.ApplicationUsers.Include(u => u.Officer).ToList();
            
            var userRoles = _db.UserRoles.ToList();
            var roles = _db.Roles.ToList();
            
            foreach (var user in objUserList)
            {
                var roleId = userRoles.FirstOrDefault(u => u.UserId == user.Id).RoleId;
                //user.Role = roles.FirstOrDefault(u => u.Id == roleId).Name;
            }
            return View(objUserList);
        }
        public IActionResult Delete(string? id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return NotFound();
            }
            ApplicationUser? userFromDb = _db.ApplicationUsers.Find(id);
            if (userFromDb == null)
            {
                return NotFound();
            }

            return View(userFromDb);

        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(string? id)
        {

            ApplicationUser? obj = _db.ApplicationUsers.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.ApplicationUsers.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}
