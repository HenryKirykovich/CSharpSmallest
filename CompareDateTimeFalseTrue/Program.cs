using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CompareDateTimeFalseTrue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {

                Console.WriteLine("PLease put first date in format like this m/d/y");
                DateTime firstDate = Convert.ToDateTime(Console.ReadLine());
                // DateTime first = new DateTime(firstDate);

                Console.WriteLine($"it is {firstDate}");

                Console.WriteLine("PLease put second date in format like this m/d/y");
                DateTime secondDate = Convert.ToDateTime(Console.ReadLine());
                // DateTime first = new DateTime(firstDate);

                Console.WriteLine($"it is {secondDate}");


                Console.WriteLine($"You are comparing DateTime object {firstDate} VS {secondDate} is equal / not:  {firstDate.Equals(secondDate)}");

                Console.WriteLine("Do you want to check it more?  y/n");
                choice = Console.ReadLine().ToLower();
                Console.WriteLine();
            }
            while (choice == "y");
        }
    }
}

