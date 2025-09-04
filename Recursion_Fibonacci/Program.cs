
using static System.Net.Mime.MediaTypeNames;
using System;

// to find the Fibonacci numbers for a series of n numbers using recursion.
// The Fibonacci series of 10 terms is : 0 1 1 2 3 5 8 13 21 34
namespace RecursionFibonacci
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please put your number seq: ");
            Console.WriteLine();
            Console.WriteLine();

            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            //for (int i = 0; i < input; i++)
            //{
            //    Console.WriteLine(Lambda.MyFibFun(i) + "");
            //}
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine(Lambda.GetFibonacci(i) + "");
            }


        }


        //static int MyFibFun(int i)
        //{
        //    if (i <= 1) return i;
        //    return MyFibFun(i - 1) + MyFibFun(i - 2);
        //}
             
           

    }         

 
}