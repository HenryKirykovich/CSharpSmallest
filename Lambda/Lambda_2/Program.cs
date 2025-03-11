using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // list.Where(n => n % 2 == 0); // Creating a query expression that retrieves even numbers from the LIst
            Console.WriteLine("list.Where(n => n % 2 == 0); // Creating a query expression that retrieves even numbers from the LIst");
            Console.WriteLine("Enter your number");
            List<int> list = new List<int>();
            int num;
            int count=0;
            bool amount = true;
           

            while(amount) 
            {
                count++;
                Console.WriteLine($"{count}nd number");
                try
                {
                    num = int.Parse(Console.ReadLine());
                    list.Add(num);
                    if (list.Count == 5 )
                    {
                        amount = false;
                    }
                }
                catch (Exception)
                {

                    throw new Exception("PLease check your input and Try again");
                }
            }

            var sort = list.Where(n => n % 2 == 0); // Creating a query expression that retrieves even numbers from the LIst
            sort.ToList().ForEach(n => { Array.Sort(sort); Console.WriteLine(n); });
            Console.WriteLine($"Format your new var  {sort.GetType()} and your variable {Console.WriteLine()}");

            
            foreach (int i in sort)
            {
                Console.WriteLine(i);
               

            }

            Console.ReadLine();

        }
    }
}
