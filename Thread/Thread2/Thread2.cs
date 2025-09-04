using System;
using System.Threading;   // f

namespace Threads
{
    class Thread2
    {

       
        static void WriteSecond()
        {
            Thread mySecond = Thread.CurrentThread;
            mySecond.Name = "Second";
         
            for (int i = 0; i < 10; i++) {
               
                Console.WriteLine($"#{i}  {mySecond.Name}  {mySecond.GetHashCode()}   ");
                Thread.Sleep(1000);
            }
        }

        static void Main()
        {
            

            Thread myFirst = Thread.CurrentThread;

            for (int i = 0; i < 10; i++)
            {
                            
                    
                    Console.WriteLine($"#{i}  Task running... {myFirst.GetHashCode()}");
                    Thread.Sleep( 1000 );
               
            }

            ThreadStart writeSecond = new ThreadStart(WriteSecond);
            System.Threading.Thread thread = new System.Threading.Thread(writeSecond);
            thread.Start();

        }

    }
}


