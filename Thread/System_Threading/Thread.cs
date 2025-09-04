using System;
using System.Threading;   // f

namespace Threads
{
    class Thread
    {

        static void WriteThird()
        {
            while (true)
            {
                Console.WriteLine(new string(' ', 40) + "Third " + System.Threading.Thread.CurrentThread.GetHashCode());
            }
        }
        static void WriteSecond()
        {
               
            while (true)
            {
                Console.WriteLine(new string(' ', 20) + "Secondary Thread" + System.Threading.Thread.CurrentThread.GetHashCode());
            }
        }
        static void Main()
        {
            ThreadStart writeSecond = new ThreadStart(WriteSecond);

            System.Threading.Thread thread = new System.Threading.Thread(writeSecond);
            thread.Start();


            System.Threading.Thread thread3 = new System.Threading.Thread(WriteThird);
            thread3.Start();
            
            while (true)
            {


                Task.Run(() => // thread inside thread
                {
                    Console.WriteLine($"Task running... {System.Threading.Thread.CurrentThread.GetHashCode()}");
                });
            }

        }

    }
}


