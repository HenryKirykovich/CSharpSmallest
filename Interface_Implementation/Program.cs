using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Interface_Implementation
{
   public class Program
    {
        static void Main(string[] args)   // invoke Collection Displaying class for add/ remove / display from class CarModel
        {


            Console.WriteLine("Declare collection from Colletion_Displaying and Push any button");
            Console.ReadLine();
            Console.WriteLine();
            
            Collection_Displaying myCollection = new Collection_Displaying();

            foreach (var item in myCollection.GetAll())
            {
                if(item.CarAvailability == null)
                {
                    Console.WriteLine($"{item.CarId}: {item.MyCar}: {item.CarDescription}: call");
                }else
                {
                    Console.WriteLine($"{item.CarId}: {item.MyCar}: {item.CarDescription}: {item.CarAvailability}");
                }
               
            }


            Console.WriteLine();
            Console.WriteLine("We have added new car into collection 'CarId = 3, MyCar = 'Mitsubishi', CarDescription = 'Fuel' Car'");
            Console.ReadLine();

            myCollection.AddCar(new Car { CarId = 3, MyCar = "Mitsubishi ", CarDescription = "Gas Car" });  // trial of adding new Car into collection

            Console.WriteLine("Both result Push any button");
            Console.ReadLine();
            Console.WriteLine();


            foreach (var item in myCollection.GetAll())
            {
                if (item.CarAvailability == null)
                {
                    Console.WriteLine($"{item.CarId}: {item.MyCar}: {item.CarDescription}: please call for knowing");
                }
                else
                {
                    Console.WriteLine($"{item.CarId}: {item.MyCar}: {item.CarDescription}: {item.CarAvailability}");
                }
            }


            


        }
    }
}
