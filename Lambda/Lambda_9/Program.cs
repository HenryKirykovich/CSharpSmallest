using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_9
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

                    throw new Exception("PLease put correct format and Try again");
                }
            }

            var new_list = list.Where(n => n > 80); // create a list of numbers and display numbers greater than 80
            Console.WriteLine();
            Console.WriteLine("Result:");
            
            if(!new_list.Any())
            {
                Console.WriteLine("the list is empty");
            }

            foreach (int i in new_list)
            {
                count += i;
                Console.WriteLine($"The {count} number greater than 80 {i}");

            }

            Console.ReadLine();
            

        }
    }
}
