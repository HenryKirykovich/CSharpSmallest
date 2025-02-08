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
            int[] list_num = { 200,1, 2, 333,452 };
            var new_list = list_num.Where(n=> n > 10);
            foreach (int i in new_list)
            {
                Console.WriteLine(i);
            }

            list_num.ToList().ForEach(n => Console.WriteLine(n));
            Console.WriteLine();
            Console.WriteLine();
            list_num.ToList().ForEach(n => { Array.Sort(list_num); Console.WriteLine($"The type of: {list_num.GetType()}"); });

            foreach (int i in list_num)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }




    }
}
