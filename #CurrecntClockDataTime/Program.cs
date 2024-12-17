using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _CurrecntClockDataTime
{
    public class Program
    {
        static void Main(string[] args)
        {

            DateTime dt1 = new DateTime(2016, 6, 8, 11, 49, 0);
            Console.WriteLine("Complete date: " + dt1.ToString()); // Display complete date and time


            DateTime dateOnly = dt1.Date;


            Console.WriteLine("Short Date: " + dateOnly.ToString("d"));


            Console.WriteLine("Display date using 24-hour clock format:");

            Console.WriteLine(dateOnly.ToString("g"));

            // format with 24-hour clock
            Console.WriteLine(dateOnly.ToString("MM/dd/yyyy HH:mm"));


            Console.WriteLine();
            Console.WriteLine(DateTime.UtcNow);
        }
    }
}
