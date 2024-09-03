using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlTypes;

namespace Collection_of_Problems_on_Recursion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Input your number");
            //int number = Convert.ToInt32(Console.ReadLine());  // Task 1: to count the number of digits in a number using recursion
            //int count = 0;
            //CountDigit(number, count);


            //Console.WriteLine("Input your number");
            //int number = Convert.ToInt32(Console.ReadLine());  // Task 2: to print even or odd numbers in a given range using recursion.
            //int first = 1;
            //OddDigit(number, first);

            Console.WriteLine("Please enter you Palindrom");
            string palindrom = Console.ReadLine().ToUpper();  // Task 3: to check whether a given string is a palindrome or not 
                        
            
            bool choice;
            choice = PalindromMethod(palindrom);
            if (choice == true)
            {
                Console.WriteLine(" The string is a Palindrome.\n");
            }
            else
            {
                Console.WriteLine(" The string is not a Palindrome.\n");
            }
        }



        //static void CountDigit(int number, int count)   // Task 1: to count the number of digits in a number using recursion
        //{

        //    if(number > 0)
        //    {
        //        count++;
        //        CountDigit(number / 10, count);
        //    }
        //    else
        //    {
        //        Console.WriteLine(count);
        //    }

        //}


        //static void OddDigit(int number,int first)    // Task 2: to print even or odd numbers in a given range using recursion.
        //{

        //    if(number >=first)
        //    {
        //        if (number % 2 == 0)
        //        {

        //            Console.WriteLine($"Even {number}");
        //            OddDigit(number - 1, first);
        //        }
        //        else if (number % 2 != 0)
        //        {

        //            Console.WriteLine($"Odd {number}");
        //            OddDigit(number - 1, first);
        //        }

        //    }
        //}

        public static bool PalindromMethod(string palindrom)   // Task 3: to check whether a given string is a palindrome or not 
        {

            if (palindrom.Length <= 1) 
            {
                return true;
            }
            else
            {
                if (palindrom[0] != palindrom[palindrom.Length - 1]) // Check if the first and last characters are equal
                {

                    return false;// If not equal, it's not a palindrome

                }
                else
                {
                    return PalindromMethod(palindrom.Substring(1, palindrom.Length - 2)); // Check the substring without the first and last characters
                }
            }
                                 

        }

    }
}
