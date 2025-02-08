using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lambda_4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter your number");
            List<int> list = new List<int>();
            int num;
            int count = 0;
            bool amount = true;


            while (amount)
            {
                count++;
                Console.WriteLine($"{count}nd number");
                try
                {
                    num = int.Parse(Console.ReadLine());
                    list.Add(num);
                    if (list.Count == 5)
                    {
                        amount = false;
                    }
                }
                catch (Exception)
                {

                    throw new Exception("Please check your input and Try again");
                }
            }



            var sqr = list
                .GroupBy(number => number) // sort by group 
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
                Console.WriteLine($"Number {i.Number} appears {i.Count} times");

            }

            Console.ReadLine();
        }
    }
}
