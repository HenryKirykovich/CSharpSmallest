using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTwoNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Program to check whether two given integer values are in the range 20..50 inclusive. Return true if one or other is in the range, otherwise false.");
            Console.WriteLine();
            Console.WriteLine();


            char choice = 'y';
            int first;
            int second;
            do
            {

                try
                {
                    Console.WriteLine("PLease set the first number between 20 to 50 ");
                    first = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("PLease set the second number between 20 to 50 ");
                    second = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    throw new Exception($"Use integer and the numbers must have range from 20-50 The error is '{e.Message}'");
                }



                Console.WriteLine("PLease set the first number between 20 to 50 ");
                first = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("PLease set the second number between 20 to 50 ");
                second = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine($"Your numbers are your range 20-50 {test(first, second)}");
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
