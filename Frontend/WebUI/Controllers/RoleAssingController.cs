using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Role;

namespace WebUI.Controllers
{
    public class RoleAssingController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public RoleAssingController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> AssingRole(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            TempData["userİd"] = user.Id;
            var roles = _roleManager.Roles.ToList();
            var userRoles = await _userManager.GetRolesAsync(user);
            List<RoleAssingViewModel> roleAssingViewModels = new List<RoleAssingViewModel>();
            foreach (var item in roles)
            {
                RoleAssingViewModel model = new RoleAssingViewModel();
                model.RoleID = item.Id;
                model.RoleName = item.Name;
                model.RoleExist = userRoles.Contains(item.Name);
                roleAssingViewModels.Add(model);

            }
            return View(roleAssingViewModels);

        }


        [HttpPost]
        public async Task<IActionResult> AssingRole(List<RoleAssingViewModel> roleAssingViewModel)
        {
            var userid = (int)TempData["userİd"];
            var user= _userManager.Users.FirstOrDefault(x=>x.Id == userid);

            foreach(var item in roleAssingViewModel)
            {
                if(item.RoleExist) {
                    
                        await _userManager.AddToRoleAsync(user, item.RoleName);
                    
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.RoleName);
                }

            }
            return RedirectToAction("Index");
           
        }
        
    }
}