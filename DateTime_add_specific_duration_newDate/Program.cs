using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Calculating what day of the week is 40 days from now.


namespace DateTime_add_specific_duration_newDate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime current = DateTime.Now;
            Console.WriteLine("Current date :");
            Console.WriteLine(current);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("How many days would you like to add? ");
            int days = int.Parse(Console.ReadLine());
            Console.WriteLine($"We will add {days} days");

            Console.WriteLine();
            Console.WriteLine();
            // representing a duration of 33 days
            TimeSpan my_extra_duration = new TimeSpan(days,0,0,0);

            // add duration to current date
            DateTime new_date = current.Add(my_extra_duration);
            Console.WriteLine($"Current date {days} days extra");
            Console.WriteLine(new_date);
        }
    }
}
