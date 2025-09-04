using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lambda_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Accept list members through the keyboard and display them more than a specific value
            Console.WriteLine("!!! Example: \nInput the number of members on the List : 5\r\nMember 0 : 10\r\nMember 1 : 48\r\nMember 2 : 52\r\nMember 3 : 94\r\nMember 4 : 63\r\nInput the value above you want to display the members of the List : 59");
            Console.WriteLine();
            List<int>my_numbers = new List<int>();
            Console.WriteLine("your turn for now:");
            Console.WriteLine("PLease Input the number of members on the List:");
                
           
            int num = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            Console.WriteLine();
            for (int i = 0; i < num; i++)

            {
                Console.WriteLine($"Please insert {++count}");
                my_numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine();
            Console.WriteLine("Input the value above you want to display the members of the List :");
            int signal = Convert.ToInt32(Console.ReadLine());

            var new_list = my_numbers.Where(x => x > signal).ToList();  // lambda for sort data inside list
            
            Console.WriteLine();

            Console.WriteLine($"The numbers greater than {signal} are :"); // typical itteration over List / array 
            foreach (var item in new_list)
            {
                Console.WriteLine(item);
            }


        }
    }
}
