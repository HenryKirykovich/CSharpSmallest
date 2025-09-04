using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassMethodNoDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            BigMachine myBigMachine = new BigMachine();

            Console.WriteLine("about to have big machine change color");
            Console.ReadLine();
            myBigMachine.GiveMeDirections(FlashScreen);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("about to have big machine beep");
            Console.ReadLine();
            myBigMachine.GiveMeDirections(DingTwice);

            Console.WriteLine("all done");
            Console.ReadLine();
        }

      

        static void DingTwice(int howMany)
        {
            for (int i = 0; i < howMany; i++)
            {
                Console.Beep();
            }
        }

        static void FlashScreen(int howMany)
        {
            for (int i = 0; i < howMany; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("White");
                System.Threading.Thread.Sleep(2000);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Black");
            }
            
        }
    }
}
