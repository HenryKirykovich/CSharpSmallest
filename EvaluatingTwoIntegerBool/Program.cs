using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EvaluatingTwoIntegerBool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char choice = 'y';
            int first;
            int second; 
            do
            {
                Console.WriteLine("PLease set the first number between 20 to 50 ");
                first = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("PLease set the second number between 20 to 50 ");
                second = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine($"Your numbers are your range 20-50 {test(first,second)}");
                Console.WriteLine();
                Console.WriteLine("Would you like proceed?   y/n ");
                choice = Convert.ToChar(Console.ReadLine());

            } while (choice == 'y');
            Console.WriteLine();
            Console.WriteLine("Thanks.Buy!");
        }

        public static bool test(int x, int y)
        {
            // Check if either x or y is within the range 20 to 50 inclusive
            return (x >= 20 && x <= 50) || (y >= 20 && y <= 50);
        }

        

    
    }
}
