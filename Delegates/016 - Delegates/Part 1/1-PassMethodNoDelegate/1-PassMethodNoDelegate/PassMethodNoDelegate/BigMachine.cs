using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassMethodNoDelegate
{
    class BigMachine
    {
        public delegate void Directions(int count);  // this defines a contract, and Directions is a new data type

        // here we specify that the method accepts one parameter, and the data type is Directions
        public void GiveMeDirections(Directions pMethod) 
        {
            Console.WriteLine("This is your big machine doing your job");
            Console.WriteLine("I have everything all set up,");
            Console.WriteLine("but now I need specific directions from you.");
            pMethod(3);
            Console.WriteLine("Ok, thanks, big machine is done.");
        }
    }
}
