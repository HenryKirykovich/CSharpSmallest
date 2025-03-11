using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // How working Lambda 
            Console.WriteLine("How working Lambda ");

            Console.WriteLine("please put desirable number");
            int input = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            
            int[] list_num = { 200,1, 2, 333,452 };
            Console.WriteLine("haiving simple array  200,1, 2, 333,452");
            Console.WriteLine();
            var new_list = list_num.Where(n=> n > input);
            foreach (int i in new_list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("Lambda use for itteration  list_num.ToList().ForEach(n => Console.WriteLine(n));");
            list_num.ToList().ForEach(n => Console.WriteLine(n));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Lambda uses for itteration + Sorting");
            list_num.ToList().ForEach(n => { Array.Sort(list_num); Console.WriteLine($"The type object: {list_num.GetType()};  number of array {n}"); });

            Console.ReadLine();
        }




    }
}
