using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestMVC.Models;

namespace TestMVC.Controllers
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
            Product[] x = Product.GetProducts(); // called method from Model Product 

            return View(x);


            //string[] name = new string[3];
            //name[0] = "Henry";
            //name[1] = "Hanna";
            //name[2] = "John";
            //return View("Index", name);
        }


        public IActionResult Index2()
        {
            List<string> result = new List<string>(); // declaring list for populating data from Model class

            foreach (Product p in Product.GetProducts()) // use static Method from Modul 
            {
                string name = p?.Name ?? "<No Name>";   //  assigning data from the Model class to my list !!! if field will be NUll we see "No Name" !!!
                string category = p?.Category ?? "<undefined>";  // ?? sign ?? help to avoid the Exceptional Error during work
                decimal? price = p?.Price ?? 0;  //
                string relatedName = p?.Related?.Name ?? "No relation";  //
                
                

                result.Add(string.Format($"Name: {name}, Category: {category}, Price {price}, Related: {relatedName}")); // using String Interpolation string.Format


            }

            return View(result); // passing to Index2 page
        }

    }
}
