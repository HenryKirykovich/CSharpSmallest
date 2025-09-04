using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10Events
{
    public class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine("The Example is simple Event");
            Console.WriteLine();


            Listener listener = new Listener();

            MyEvents myEvents = new MyEvents();

            myEvents.myEvent += new OurEventDelegate(listener.MyListenerShowSomething1);
            myEvents.myEvent += new OurEventDelegate(listener.MyListenerShowSomething2);
            myEvents.myEvent += new OurEventDelegate(listener.MyListenerShowSomething3);

            Console.WriteLine("PLease push 'Enter'");
            Console.ReadLine();
            
            myEvents.Start();


            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Job was done");
            Console.ReadLine();
        }

        
    }
}
