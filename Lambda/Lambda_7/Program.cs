using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_7
{
    internal class Program
    {

        //Task: display numbers, multiplication of numbers with frequency and the frequency of a number in an array.
        static void Main(string[] args)
        {
            Console.WriteLine("Input 5 numbers");
            int[] list = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter your number"); // Task the same like previous example - calculating of each character in a given string
                int my_num = Convert.ToInt32(Console.ReadLine());
                list[i] = my_num;
            }



            var sqr = list
                .GroupBy(num => num) // sort by group 
                .Select(group => new { Number = group.Key, Count = group.Count(), Amount = group.Key * group.Count() }); //sort group by number and count times
                                                                                                                         //derived result from mult two previous var




            //===================================================================
            //using query syntax


            //var sqr = from x in list
            //          group x by x into y
            //          select y;


            //foreach (var i in sqr)
            //{
            //    Console.WriteLine($"Number {i.Key}  appears {i.Count()} times = multiplication {i.Sum()}");

            //}

            // ===================================================================



            foreach (var i in sqr)
            {
                Console.WriteLine($"Number {i.Number} appears {i.Count} times = multiplication of {i.Amount} ");

            }

            Console.ReadLine();
        }
    }
}
