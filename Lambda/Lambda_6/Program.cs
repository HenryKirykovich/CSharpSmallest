using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_6
{
    internal class Program
    {

        enum MyDays
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday

        }

        static void Main(string[] args) // displayimg the name of the days of the week
        {

            DateTime dateTime = DateTime.Now;
            Console.WriteLine("Today is " + dateTime.DayOfWeek + "  // using DateTime object");
            Console.WriteLine();

            string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

           
            var Days = dayWeek.Select(day =>day ); // using lambda

            Console.WriteLine("itteration by lambda");
            foreach (var i in Days)
            {
                Console.WriteLine(i);

            }

            Console.ReadLine();
        }
    }
}
