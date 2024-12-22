using TestShop.Interfaces;
using TestShop.Models;

namespace TestShop.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarCategory _carCategory = new MockCategory(); // cteating object based on MockCategory and take specific Category 

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        Name = "Tesla Model S",
                        ShortDesc = "Speed Car",
                        FullDesc = "Red, speed car, 4 progressive drivers, quiet car, produced by Tesla Co",
                        Img = "https://www.npr.org/2023/02/02/1152586942/tesla-price-cuts-ford-mach-e-gm-electric-cars-tax-credit",
                        Price = 45000,
                        IsFavourite = true,
                        Available = true,
                        Category = _carCategory.AllCategories.First()

                    },
                    new Car
                    {
                        Name = "Ford Mustang Mach-E",
                        ShortDesc = "Electric SUV",
                        FullDesc = "Stylish electric SUV with advanced features and impressive range",
                        Img = "https://www.motortrend.com/uploads/2023/01/Ford-Mustang-Mach-E.jpg",
                        Price = 42000,
                        IsFavourite = true,
                        Available = true,
                        Category = _carCategory.AllCategories.First()
                    },
                    new Car
                    {
                        Name = "Chevrolet Bolt EV",
                        ShortDesc = "Affordable Electric",
                        FullDesc = "Compact and affordable electric car, ideal for city commutes",
                        Img = "https://www.chevrolet.com/images/2023-bolt-ev",
                        Price = 31000,
                        IsFavourite = false,
                        Available = true,
                        Category = _carCategory.AllCategories.Last()
                    },
                    new Car
                    {
                        Name = "BMW i4",
                        ShortDesc = "Luxury Electric Sedan",
                        FullDesc = "Elegant and high-performance electric sedan with cutting-edge features",
                        Img = "https://cdn.motor1.com/images/bmw-i4.jpg",
                        Price = 56000,
                        IsFavourite = true,
                        Available = true,
                        Category = _carCategory.AllCategories.First()
                    },
                    new Car
                    {
                        Name = "Toyota Prius Prime",
                        ShortDesc = "Hybrid Leader",
                        FullDesc = "Reliable plug-in hybrid with excellent fuel efficiency and spacious interior",
                        Img = "https://www.toyota.com/priusprime",
                        Price = 32000,
                        IsFavourite = false,
                        Available = true,
                        Category = _carCategory.AllCategories.Last()
                    },
                    new Car
                    {
                        Name = "Rivian R1T",
                        ShortDesc = "Electric Truck",
                        FullDesc = "Rugged electric truck with off-road capabilities and modern features",
                        Img = "https://assets.rivian.com/r1t.jpg",
                        Price = 67000,
                        IsFavourite = true,
                        Available = true,
                        Category = _carCategory.AllCategories.First()
                    }



                };
            }
        }



        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    
    }
}
