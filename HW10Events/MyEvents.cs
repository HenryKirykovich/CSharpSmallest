using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10Events
{
    public delegate void OurEventDelegate(object Name, MyEventArgs e);

    public class MyEventArgs : EventArgs
    {
        public int number { get; set; }

        public MyEventArgs(int pNumber)
        {
            number = pNumber;
        }
    }


    public class MyEvents
    {
        public event OurEventDelegate myEvent;

        public void Start()
        {
           
            for (int i = 1; i <= 77; i++)
            {
                if (i % 7 == 0)
                {
                    
                    System.Threading.Thread.Sleep(2000);

                    object someObject = new object();

                    MyEventArgs numberFromFire = new MyEventArgs(i);


                    myEvent(someObject, numberFromFire);

                }
               
            }
           

        }
    }


    public class Listener
    {
        public void MyListenerShowSomething1(object Name, MyEventArgs e)
        {
            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("I am your Listener#1 and Executor#1: I changed Color and made Beep sound for you");
            Console.WriteLine($"The number is evenly divisible by 7: {e.number}");
            Console.Beep(440, 200);
           
            
        }


        public void MyListenerShowSomething2(object Name, MyEventArgs e)
        {
            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("I am your Listener#2.I changed Color to Yellow");
            Console.WriteLine($"The number is evenly divisible by 7: {e.number}");
            


        }

        public void MyListenerShowSomething3(object Name, MyEventArgs e)
        {
            if (e.number != 77)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("I am your Listener#3. I changed Color to Cyan ");
                Console.WriteLine($"The number is evenly divisible by 7: {e.number}");
            }
            else
            {
                Console.WriteLine();

                Console.WriteLine("this is Last itteration");
            }
        }

    }

      
}
