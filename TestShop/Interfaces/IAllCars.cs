using TestShop.Models;

namespace TestShop.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get;}
        IEnumerable<Car> getFavCars { get; set; }
        Car getObjectCar(int carId);
        
        

        



    }
}
