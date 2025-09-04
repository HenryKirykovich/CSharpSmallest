using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task:  to find a string that starts and ends with a specific character
            Console.WriteLine("find a string that starts and ends with a specific character");

            string[] city = new string[] { "MINSK", "PINSK", "MOLODECHNO", "VILNIUS", "GDANSK", "MOSCOW", "MOLO" };

            Console.WriteLine("Set first letter");
            string first = Console.ReadLine().ToUpper();
            Console.WriteLine("Set last letter");
            string last = Console.ReadLine().ToUpper();


            var order = city
                .Where(n => n.StartsWith(first) && n.EndsWith(last));




            foreach (var i in order)
            {
                Console.WriteLine($"The city started from  {first} finished {last} the word is {i} ");
                
            }

            if (!order.Any())
            {
                Console.WriteLine("No cities match the criteria.");
            }

            Console.ReadLine();

        }
    }
}
