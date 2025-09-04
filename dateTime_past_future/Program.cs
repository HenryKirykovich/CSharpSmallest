using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("PLease set your base date. Use format; Years, month, day ");

            var baseDate = new DateTime();

            baseDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine(baseDate);

            Console.WriteLine("My list date in the past");
            Console.WriteLine("PLease set desirable amount of years in the past and future with the same date");
            int? desireYears = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i >= -desireYears ; i--)
            {
                Console.WriteLine();
                Console.WriteLine($"{i} years ago was date is {baseDate.AddYears(i)}");
            }


            Console.WriteLine();
            Console.WriteLine("Push 'space' and you see future  ;) ");
            Console.ReadLine();
            // For the same function show you in the future date and day of week

            for (int i = 0; i <=desireYears; i++)
            {
                Console.WriteLine();
                if (i == 0)
                {
                    Console.WriteLine($"{i} years is the same current date  like your input {baseDate}");
                }
                else
                {
                    Console.WriteLine($"{i} years ago was date is {baseDate.AddYears(i)} it will be {baseDate.AddYears(i).DayOfWeek}");
                }
            }
        }
    }
}
