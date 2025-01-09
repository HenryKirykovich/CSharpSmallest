using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your word");
            string my_word = Console.ReadLine().ToLower();
            Console.WriteLine($"you sat  {my_word }");
            Console.WriteLine();

            var sqr = my_word
                .GroupBy(charect => charect) // sort by group 
                .Select(group => new { Number = group.Key, Count = group.Count() }); //sort group by number and count times



            //===================================================================
            //using query syntax


            //var sqr = from x in list
            //          group x by x into y
            //          select y;                      ;

            //foreach (var i in sqr)
            //{
            //    Console.WriteLine($"Number {i.Key} appears {i.Count()} times");

            //}

            // ===================================================================



            foreach (var i in sqr)
            {
                Console.WriteLine($"Characters {i.Number} appears {i.Count} times");

            }

        }
    }
}
