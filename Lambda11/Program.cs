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
            //   display the top n-th records
            Console.WriteLine("Example: Test Data :\r\nThe members of the list are :\r\n5\r\n7\r\n13\r\n24\r\n6\r\n9\r\n8\r\n7\r\nHow many records you want to display ? : 3\r\nExpected Output :\r\nThe top 3 records from the list are :\r\n24\r\n13\r\n9");
            Console.WriteLine();



            List<int> my_numbers = new List<int>();
            Console.WriteLine("How many numbers would you like sort?");


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
            int signal = Convert.ToInt32(Console.ReadLine());

            my_numbers.Sort();
            my_numbers.Reverse();            
            
            
            //Console.WriteLine(lastNumber);
            var new_list = my_numbers.Take(signal);  // lambda for sort data inside list

            Console.WriteLine();

            Console.WriteLine($"The numbers greater than {signal} are :"); // typical itteration over List / array 
            foreach (var item in new_list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
