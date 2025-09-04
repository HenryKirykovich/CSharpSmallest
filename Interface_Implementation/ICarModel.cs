using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Implementation
{
    public interface ICarModel<T> // versatile way to deploying any Class and object, collecting object, sort and so on via Interface
    {
        void AddCar(T MyCar);
        void RemoveCar (T MyCar);
        IEnumerable<T> GetAll();

    }

    public interface ICarAvailability
    {
        void SetAvailability(Car car, bool? availability);
        bool? GetAvailability(Car car);
    }
}
