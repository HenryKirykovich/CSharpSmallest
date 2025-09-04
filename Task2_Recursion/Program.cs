using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

namespace Task1_3_Recursion
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task # 1-3 Recursion");

            Console.WriteLine("Enter  your simple number");
            int input_number = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("Enter  your simple number");    // Task 3 to display the individual digits of a given number like here The digits in the number 1234 are : 1 2 3 4
            //string number = Console.ReadLine();




            //Console.WriteLine("===================================================================");   

            DisplNumber(input_number);     // Task 1 to print numbers from n to 1 using recursion.


            //int sum = 0;
            //SumNumber(input_number, sum);  // Task 2 to find the sum of the first n natural numbers 

            //int count = 0;
            //IndDigit(number, count);     // Task 3 to display the individual digits of a given number like here The digits in the number 1234 are : 1 2 3 4

        }

        static void DisplNumber(int input)       //   Task 1 to print numbers from n to 1 using recursion.
        {
            if (input >= 1)
            {
                Console.WriteLine(input);
                DisplNumber(input - 1);
            }
        }


        //static void SumNumber(int input, int sum)   // Task 2 to find the sum of the first n natural numbers 
        //{


        //    sum += input;
        //    if (input>0)
        //    {
        //        SumNumber(input - 1, sum);
        //    }
        //    else if (input<=0)
        //    {
        //        Console.WriteLine(sum);
        //    }

        //}


        //static void IndDigit(string input, int count)    // Task 3 to display the individual digits of a given number like here The digits in the number 1234 are : 1 2 3 4
        //{
        //    string myString;

        //    if (input.Length > 0 && count < input.Length)
        //    {
        //        Console.WriteLine($"{input[count]} ====");
        //        count++;
        //        IndDigit(input, count);
        //    }

        //}



    }



}
