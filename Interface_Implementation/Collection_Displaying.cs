using Interface_Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Implementation
{
   public class Collection_Displaying : ICarModel<Car>  // You must implement three methods from Interface
   {
        private List<Car> cars = new List<Car>    // internally add my collection and then we will be able to add by AddCar method
        {
            new Car { CarId = 1, MyCar = "Tesla Model S", CarDescription = "Electrical Car" },

            new Car { CarId = 2, MyCar = "Honda SRV", CarDescription = "hybrid Car"}

        };

        public void AddCar(Car MyCar)
        {
            cars.Add(MyCar);
        }

        public void RemoveCar(Car MyCar)
        {
            cars.Remove(MyCar);
        }

        public IEnumerable<Car> GetAll()
        { 
            return cars;
        }






    }
}





