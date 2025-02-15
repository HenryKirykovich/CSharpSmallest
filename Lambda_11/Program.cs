using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda11
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //  Explanation TASK:    Write a program in C# Sharp to display the top n-th records.  Input: 5 7 13 24  How many records you want to display ? : 3  => 24 13 7
            List<int> my_numbers = new List<int>();
            
            Console.WriteLine("how many the number of members do you want to put in the List:");


            int num = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            Console.WriteLine();
            for (int i = 0; i < num; i++)

            {
                Console.WriteLine($"Please insert {++count}");
                my_numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine();
            Console.WriteLine("How many records you want to display ? :");


            // process validation input // repeat many times 
            int signal;
           
            while (!int.TryParse(Console.ReadLine(), out signal) || signal <= 0 || signal > my_numbers.Count)
            {
                Console.Write("Invalid input. Enter a number between 1 and " + my_numbers.Count + ": ");
            }





            // solve 1  using primitive itteration

            my_numbers.Sort(); // sorting list 
            int number_in_array = my_numbers.Count; // get length of array 
            int[] my_new_array = my_numbers.OrderByDescending(x => x).ToArray(); // Descending order 

            Console.WriteLine();
            Console.WriteLine($"he top {signal} records from the list are:");
            for (int i = 0; i < signal; i++)
            {
                Console.WriteLine(my_new_array[i]);
            }


            // solve 2  using lambda expression

            //var topRecords = my_numbers.OrderByDescending(x => x).Take(signal);
            //Console.WriteLine();
            //Console.WriteLine($"he top {signal} records from the list are:");
            //foreach (var item in topRecords)
            //{
            //    Console.WriteLine(item);
            //}




        }
    }
}
