using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lambda_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // members of list : ....   =>  How many records you want to display ? : 3  = > The top 3 records from the list are : ...

            Console.WriteLine("LIst you number ");
            Console.WriteLine("24,2,30,40,60");
            int[] list = new int[] {24,2,30,40,60 };
            Console.WriteLine("PLease set you Top number considering amount number");
            int my_top = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("After Sorting  are: ");
            Array.Sort(list);
            list.ToList().ForEach(x => { Console.WriteLine($"{x}"); });
            
            Console.WriteLine();
            
            var new_list = list.Reverse();
            Console.WriteLine("Using Reverce() reversed array");
            new_list.ToList().ForEach(x => Console.WriteLine($"{x}"));



            Console.WriteLine("Using IEnumerable object convert to liist and then Itteration use GetRange + lambda");
            Console.WriteLine();
            var top = new_list.ToList().GetRange(0, my_top);
            int count = new_list.ToArray().Length;
            top.ToList().ForEach(x => Console.WriteLine($"{count--}: {x}"));
        }
    }
}
