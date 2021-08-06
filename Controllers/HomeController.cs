using System;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpGet("projects")]
        public IActionResult projects()
        {
            return View("projects");
        }

        [HttpGet("Contact")]
        public IActionResult contact()
        {
            return View("contact");
        }
    }
}