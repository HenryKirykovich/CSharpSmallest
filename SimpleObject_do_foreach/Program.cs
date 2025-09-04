using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleObject_do_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            string fruitX;
            string colorY;
            string choice;

            Console.WriteLine("How many fruit would you like set?");
            number = Convert.ToInt32(Console.ReadLine());
            Fruit[] my_list = new Fruit[number];

            Console.WriteLine();
            do
            {
                for (int i = 0; i < my_list.Length; i++)
                {
                    Console.WriteLine("Please put your favorite fruit");
                    fruitX = Console.ReadLine().ToLower();
                    Console.WriteLine("Please put your favorite color");
                    colorY = Console.ReadLine().ToLower();
                    my_list[i] = new Fruit(fruitX, colorY);
                }

                Console.WriteLine();
                Console.WriteLine("Would you like show your list y/n");
                choice = Console.ReadLine().ToLower();

            } while (choice == "y");
            {

            }

            Console.WriteLine();
            Console.WriteLine("Your favorute fruits are:");
            Fruit.Print(my_list);
            


        }
    }
}
