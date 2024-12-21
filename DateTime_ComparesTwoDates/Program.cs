using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_ComparesTwoDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current date is:");
            DateTime basedDate = DateTime.Now;


            Console.WriteLine(basedDate);
            Console.WriteLine();


            Console.WriteLine("Set your favorite date");
            

            DateTime outputDate = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine();
            Console.WriteLine("You sat date:");
            Console.WriteLine(outputDate);

            Console.WriteLine();
            int compaire = DateTime.Compare(basedDate, outputDate);
            if (compaire < 0)
            {
                Console.WriteLine($"{basedDate} is erliest than {outputDate}");
            }
            else if (compaire == 0)
            {
                Console.WriteLine($"{basedDate} is the same as {outputDate}");
            }
            else
            {
                Console.WriteLine($"{basedDate} is later than {outputDate}");
            }        
        }
    }
}
