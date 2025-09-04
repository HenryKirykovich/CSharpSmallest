using System.Xml.Linq;
using System;

namespace Example_Nested_Structure
{
    internal class Program
    {
        public enum CarType   // declaring 1st Derived class
        {
            none,
            F150,
            F250,
            F350
        }


        public class InventoryList   // inside parent main class accumulating data from derived BrandCar class and Enum class
        {
            public string brand { get; set; }
            public object type_brand { get; set; }
            public string ColorCar { get; set; }
            public int Years { get; set; }

            public InventoryList(BrandCar _brand,string _color, int _year)
            {
                brand = _brand.BrandFord;
                type_brand = _brand.Type;
                ColorCar = _color;
                Years = _year;
            }


        }

        public class BrandCar    // declaring 2nd (Derived class)
        { 
            public string BrandFord { get;set; }
            public CarType Type { get; }


            public BrandCar(string _name, CarType _type2)
            {
                BrandFord = _name;
                Type = _type2;
            }

        }



        static void Main(string[] args)
        {
            Console.WriteLine("========= Nested Structure =========");

            // Step 1: Choosing brand and pre - installed model of brand by 2nd (Derived class)
            Console.WriteLine("Would you like to choose any brand of car?");
            string brand = Console.ReadLine().ToUpper();
            CarType type = new CarType();
            if (brand == "FORD")
            {
                Console.WriteLine($"Would you like to choose any type of {brand} such as {CarType.F150} / {CarType.F250} / {CarType.F250} then push 1 / 2 / 3 ?");
                int typeValue = Convert.ToInt32(Console.ReadLine());
                type = (CarType)typeValue;
            }
            else
            {
                Console.WriteLine($"CAUTION: Of choice is {brand} model didn't FOUND");
                type = (CarType).0;
            }

            BrandCar choiceBrand = new BrandCar(brand, type);

            // Step 2: Populating data inside  parent main class 
            Console.WriteLine("Enter color what are you preferring?");
            string color = Console.ReadLine();
            Console.WriteLine("Enter year what are you preferring?");
            int years = Convert.ToInt32(Console.ReadLine());


            InventoryList myList = new InventoryList(choiceBrand, color, years);


            // Step 3: Displaying all data from parent main class 
            Console.WriteLine();
            Console.WriteLine($"Your choice is: {myList.brand} => {myList.type_brand} => {myList.ColorCar} => {myList.Years}");
        }
    }
}
