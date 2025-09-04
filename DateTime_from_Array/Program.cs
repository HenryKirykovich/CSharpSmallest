using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_from_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // use array for collect dates and then display their
            DateTime my_time = DateTime.Now;
            Console.WriteLine(my_time);

            Console.WriteLine();
            DateTime[] dates = {DateTime.Now, new DateTime(2016, 8, 16, 9, 28, 0), new DateTime(2024, 5, 28, 10, 35, 0), new DateTime(1984, 02, 21, 00, 30, 0)};


            foreach (DateTime dt in dates)
            {
                Console.WriteLine($"Date: {dt.Date}  Time: {dt.Hour}:{dt.Minute}");
            }



            // retrieving the current date

            DateTime dates2 = DateTime.Now;
            Console.WriteLine("Display the date in a variety of formats:");
            Console.WriteLine(dates2.Date); // 12 / 19 / 2024 12:00:00 AM
            Console.WriteLine(dates2.ToString("d")); // 19:50:03.5503210
            Console.WriteLine(dates2.TimeOfDay);

            // OR using ToString for changing format
            Console.WriteLine();

            Console.WriteLine(dates2.ToString("d")); // Short date format
            Console.WriteLine(dates2.ToString("D")); // Long date format
            Console.WriteLine(dates2.ToString("g")); // General date and time format
        }
    }
}
