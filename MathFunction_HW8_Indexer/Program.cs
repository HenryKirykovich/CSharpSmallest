using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunction_HW8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Square, Cube, Factorial Calculator");

            MathFunctions myMathObject = new MathFunctions();

            Console.WriteLine("enter an integer between 0 and 25");
            int inputValue = Convert.ToInt32(Console.ReadLine());
            if (inputValue < 26)  // greater than 26 will blow up in factorial
            {
                Console.WriteLine();
                Console.Write("the square is: ");
                Console.WriteLine(myMathObject[inputValue, "Square"]);

                Console.WriteLine();
                Console.Write("the cube is: ");
                Console.WriteLine(myMathObject[inputValue, "Cube"]);

                Console.WriteLine();
                Console.Write("the factorial is: ");
                Console.WriteLine(myMathObject[inputValue, "Factorial"]);
            }
            else
            {
                Console.WriteLine("too big");
            }


            Console.WriteLine();
            Console.WriteLine("end of program");
            Console.ReadLine();
        }


    }
}

