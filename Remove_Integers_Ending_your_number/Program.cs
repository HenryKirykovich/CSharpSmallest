using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Integers_Ending_your_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Entering number and then creating a list from a given list of integers, removing all values ending in your number from 0 to 9."); // condition 
            Console.WriteLine();



            Console.WriteLine("PLease set your number from 0 to 9");
            int byInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("PLease let's starting set your numbers order for stopping push -1 ");
            int choice;

            int count = 0; // counter

            List<int> numberStore = new List<int>(); // declaration of list for gathering information 
            List<int> newList = new List<int>(); // declaration of NEW sorted list for gathering information
            do
            {
                count++;
                Console.WriteLine($"# {count}rd: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice != -1)
                {
                    numberStore.Add(choice);
                }

            } while (choice != -1);
            Console.WriteLine();
            Console.WriteLine("Your list was filled");
            foreach (int i in numberStore)
            {
                if (i % 10 != byInt)
                {
                    newList.Add(i);
                }

            }
            ShowResult.ShowMeResult(newList, byInt);
            Console.WriteLine();

        }
    }
}
