using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesUpperCase
{
    delegate string CaseDelegate(string input);

    // define the delegate

    class Program
    {
       
      

        // define 3 methods that match with delegate
        static string UppercaseFirst(string input)   // 1
        {
            char[] buffer = input.ToCharArray();
            buffer[0] = char.ToUpper(buffer[0]);
            return new string(buffer);
        }
        static string UppercaseLast(string input)    // 2
        {
            char[] buffer = input.ToCharArray();
            buffer[buffer.Length - 1] = char.ToUpper(buffer[buffer.Length - 1]);
            return new string(buffer);
        }
        static string UppercaseAll(string input)   // 3
        {
            return input.ToUpper();
        }

        
        // methos with signature and delegate pass via  other method
        static void WriteOutput(string input, CaseDelegate PassedInMethod)
        {
            Console.WriteLine("Your string before: {0}", input);
            Console.WriteLine("Your string after: {0}", PassedInMethod(input)); // implementation string to Delegate which then 
        }


        // finally, our program
        static void Main(string[] args)
        {
            string myString = "food";


            CaseDelegate firstMethod = UppercaseFirst;   // create delegate variables
            // assigning a method to a delegate variable by instantiating the delegate, and specifying a method that matches the return type and sig
            CaseDelegate lastMethod = UppercaseLast;
            CaseDelegate lastMethodAllUpper = UppercaseAll;

            // and then use the variables as method calls
            Console.WriteLine("Your string before: {0}", myString);
            Console.WriteLine("Your string after: {0}", firstMethod(myString));
            Console.WriteLine("Your string after: {0}", lastMethod(myString));
            Console.WriteLine("Your string after: {0}", lastMethodAllUpper(myString));
            Console.ReadLine();
            Console.WriteLine();


            //  Again, you can don't need to create a variable name to pass a method
            Console.WriteLine("now passing in 2 parameters, one a method, to another method, just using the actual method name.");
            WriteOutput(myString, UppercaseFirst);
            Console.WriteLine();
            WriteOutput(myString, UppercaseLast);
            Console.WriteLine();
            WriteOutput(myString, UppercaseAll);

            Console.ReadLine();




            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("now using lambda expressions");

            Console.WriteLine($"Your string before {myString}");

            CaseDelegate FirstUpper = delegate (string x) { char[] buffer = x.ToCharArray(); buffer[0] = char.ToUpper(buffer[0]); return new string(buffer); };  // only First Upper
            Console.WriteLine(FirstUpper(myString));

            CaseDelegate LastUpper = delegate (string x) { char[] buffer = x.ToCharArray(); buffer[buffer.Length - 1] = char.ToUpper(buffer[buffer.Length - 1]); return new string(buffer); };  // only First Upper
            Console.WriteLine(LastUpper(myString));

            CaseDelegate AllUpper = delegate (string x) { return x.ToUpper(); };  // for AllUpper
            Console.WriteLine(AllUpper(myString));

        }
    }
}
