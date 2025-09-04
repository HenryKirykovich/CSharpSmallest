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
                        Img = "IMG-20181126-WA0007.jpg",
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
                        Img = "IMG-20181126-WA0007.jpg",
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
                        Img = "IMG-20181126-WA0008.jpg",
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
                        Img = "IMG-20181126-WA0008.jpg",
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
                        Img = "fotor_2023-2-17_15_31_25.jpg",
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
                        Img = "IMG-20181126-WA0008.jpg",
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
