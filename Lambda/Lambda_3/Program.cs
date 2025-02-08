using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_3
{
    public class Program   // find the number of an array and the square of each number. ex. 8 => 64 9 => 81
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

                    throw new Exception("PLease check your input and Try again");
                }
            }

            var sqr = list.Select(n => n * n); // Creating a query expression that retrieves even numbers from the LIst
            Console.WriteLine($"Format your new var  {sqr.GetType()}");



            foreach (int i in sqr)
            {
                Console.WriteLine(i);


            }

            Console.ReadLine();

        }

    }
}
