using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestShop.Interfaces;
using TestShop.Models;
using TestShop.ViewModels;

namespace TestShop.Controllers
{

    public class HomeController : Controller
    //public class HomeController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarCategory _carCategory;

        public HomeController(IAllCars iA, ICarCategory iCarsCat)
        {
            _allCars = iA;
            _carCategory = iCarsCat;
        }

        public ViewResult Index() // send data to Views.Home.Index
        {
            

            ViewBag.Title = "This is yours Title from Controller";

            CarsListViewModel obj = new CarsListViewModel();
            obj.AllCars = _allCars.Cars;
            obj.curreCategory = "Cars:";
            return View(obj);
        }



    }

    //public class HomeController : Controller
    //{
    //    private readonly ILogger<HomeController> _logger;

    //    public HomeController(ILogger<HomeController> logger)
    //    {
    //        _logger = logger;
    //    }

    //    public IActionResult Index()
    //    {
    //        return View();
    //    }

    //    public IActionResult Privacy()
    //    {
    //        return View();
    //    }

    //    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    //    public IActionResult Error()
    //    {
    //        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    //    }
    //}
}
