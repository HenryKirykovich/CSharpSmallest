using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_add_specified_months
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // I added 'number of months' (between zero and fifteen months) to the last day of December, 2024.

            DateTime myInitialDate = new DateTime(2024, 12, 31);
            Console.WriteLine(myInitialDate.ToShortDateString());

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Next date is :");
                Console.WriteLine(myInitialDate.AddMonths(i).ToShortDateString());
                
            }

        }
    }
}
