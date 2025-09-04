using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LCM_GCD_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter the second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine($" GCD for {firstNumber} and {secondNumber} is " + GCD(firstNumber, secondNumber));
            System.Console.WriteLine($" LCM for {firstNumber} and {secondNumber} is " + LCM(firstNumber, secondNumber));
        }

        public static int GCD(int a, int b)  // methos to calculate GCD using Euclidean algorithm
        {
            if (b == 0) // if one number is zero, return the other number
                return a;
            Console.WriteLine(a % b);

            return GCD(b, a % b); // recursive call to find GCD   
        }

        public static int LCM(int a, int b) // method to calculate LCM using the relationship between GCD and LCM
        {
            return (a * b) / GCD(a, b);
        }
    }
}
