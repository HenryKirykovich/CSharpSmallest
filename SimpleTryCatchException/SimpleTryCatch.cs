using System;
using System.Threading.Channels;

namespace SimpleTryCatchException
{
    internal class SimpleTryCatch
    {
        static void Main(string[] args)
        {
            
            
            
            Console.WriteLine("TryCatchException  Program");

            try
            {
                Console.WriteLine("Please set First number");
                string number1 = Console.ReadLine();
                double input1 = Convert.ToDouble(number1);
                Console.WriteLine();

                Console.WriteLine("Please set Second number");
                string number2 = Console.ReadLine();
                double input2 = Convert.ToDouble(number2);
                Console.WriteLine();


                if (input2 !=0)
                {

                    Console.WriteLine($"Your result is:  {input1 / input2}"  );
                }
                else
                {
                    Console.WriteLine("Incorrect input. error of divide by zero");
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Unexcpected error {ex.Message}");
                Console.WriteLine();
                Console.WriteLine($"!!! {ex.StackTrace} !!!");
            }
        }
    }
}
