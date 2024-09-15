using MCVProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.IO;
using MCVProject.DAL;

namespace MCVProject.Controllers
{
    public class HomeController : Controller

    {   private readonly IConfiguration _config;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _config = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Page2(PhoneBook x)
        {
            Book phoneBook = new Book(_config);
            string id_from_DB = phoneBook.InsertDataBook(x); //1. send object from module PhoneBook and 2. then send data to DB 3. retrieving id from DAL from DB query

            //storing the returned ID in my session temporarily space (!!!hold this data only during this session!!!)
            HttpContext.Session.SetString("ID", id_from_DB);
                             
            
            return View(x); //send object to viewer Page2
        }


        public IActionResult Page3()
        {
            string? str = HttpContext.Session.GetString("ID");
            Book phoneBook = new Book(_config);
            PhoneBook x = new PhoneBook();
            x = phoneBook.RetrieveDataBook(str);

            return View(x);
        }

    }
}
