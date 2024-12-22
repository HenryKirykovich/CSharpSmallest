using TestShop.Models;

namespace TestShop.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> AllCars { get; set; }

        public string curreCategory { get; set; }
    }
}
