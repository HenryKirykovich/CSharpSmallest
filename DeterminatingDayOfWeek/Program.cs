using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeterminatingDayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dayofWeek = DateTime.Now;
            Console.WriteLine("Put your amount of day:");
            int daysWants = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"Current day of Week is {dayofWeek.DayOfWeek}");

            Console.WriteLine();

            Console.WriteLine($"{daysWants} days from today: {dayofWeek.AddDays(daysWants).DayOfWeek}");
        }
    }
}
