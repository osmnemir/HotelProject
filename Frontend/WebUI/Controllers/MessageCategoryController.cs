﻿using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class MessageCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
