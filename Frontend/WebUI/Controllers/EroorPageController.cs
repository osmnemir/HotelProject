using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    [AllowAnonymous]
    public class EroorPageController : Controller
    {
       
        public IActionResult Error404()
        {
            return View();
        }
    }
}
