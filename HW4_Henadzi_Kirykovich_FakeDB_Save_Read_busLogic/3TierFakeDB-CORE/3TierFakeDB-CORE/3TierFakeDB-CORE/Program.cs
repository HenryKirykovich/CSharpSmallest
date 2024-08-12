using System;

namespace _3TierFakeDB_CORE
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface appUserInterface = new UserInterface();
            appUserInterface.Start();
            Console.ReadLine();
        }
    }
}
