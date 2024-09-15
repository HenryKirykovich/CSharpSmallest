using First_MVC_form.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace First_MVC_form.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("Index");
        }

        public IActionResult Index2()
        {
            
            return View();
        }


    }
}
