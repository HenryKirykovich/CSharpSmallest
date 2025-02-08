using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Example
{
    internal class Program
    {

        static Class1 myClass; // Don't initialize class; in fact is null
        

        static void Main(string[] args)
        {
            
            // check initialize class or not use ?? left side ? it is 'no null' or initialazed And right side means null
            // declare new object from class1 
            Class1 mc = myClass ?? new Class1() { my_string = "I am null and I put this sentence inside new instance" }; // initialization new

            
            Console.WriteLine(mc.my_string); // result from above because is null





            // example with Class2

            Class2 class2 = new Class2(); // initialaze class2 but not list

            
            // class2.my_list.Add(1); // be warning ! exception!

            // checking use if  or ??= for the version 8 C#  variable ?? = expression

            if (class2.my_list == null) { class2.my_list = new List<int>(); };

            class2.my_list.Add(1);
            class2.my_list.Add(2);
            class2.my_list.Add(3);

            foreach (int i in class2.my_list) { Console.WriteLine(i); }


            Console.ReadLine();





        }
    }
}
