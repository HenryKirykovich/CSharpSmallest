using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesUpperCase
{
    class Program
    {
        //  http://www.dotnetperls.com/delegate

        // define the delegate
        delegate string CaseDelegate(string input);
        // note this is a VERY generic delegate, as it just says any method
        // that takes in a string and returns a string is ok

        // define 3 methods that conform to that delegate definition
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

        
        // we have this method, to demostrate passing a method (a delegate) into another method
        static void WriteOutput(string input, CaseDelegate PassedInMethod)
        {
            Console.WriteLine("Your string before: {0}", input);
            Console.WriteLine("Your string after: {0}", PassedInMethod(input));
        }


        // finally, our program
        static void Main(string[] args)
        {
            string myString = "food";

            // create delegate variables
            // assigning a method to a delegate variable by instantiating the delegate, and specifying a method that matches the return type and sig
            CaseDelegate firstMethod = UppercaseFirst;
            CaseDelegate lastMethod = UppercaseLast;
            // and then use the variables as method calls
            Console.WriteLine("Your string before: {0}", myString);
            Console.WriteLine("Your string after: {0}", firstMethod(myString)); 
            Console.WriteLine("Your string after: {0}", lastMethod(myString)); 
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
           

            // You can pass a lambda expression as the implementation of the delegate method. 
            // You can construct the UppercaseDelegate by specifying a lambda expression inside the constructor itself
            // As The syntax for delegate functions can be complex. 
            // Lambda expressions provide a simple and terse way of specifying functions. 
            // They use the => syntax to separate formal parameters and the method body.
            // http://www.dotnetperls.com/lambda
        

           
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("now using lamda expressions");
            WriteOutput(myString, UppercaseAll);
            WriteOutput(myString, x => x.ToUpper());
            Console.WriteLine();
            WriteOutput(myString, UppercaseFirst);
            WriteOutput(myString, x => { char[] buffer = x.ToCharArray(); buffer[0] = char.ToUpper(buffer[0]); return new string(buffer); });

            // arrays have a built in Sum method, but it looks at the type of array, and if its not
            // an array of, for example ints, which it knows how to do, then it expects you to
            // pass in a delegate telling it how to do the sum operation.
            // int computerHandScore = _computerHand.Sum(item => (int)item.cardsRank);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("array.sum");
            int[] intArray = new int[5] { 1, 3, 2, 5, 4 };
            Rank[] rankArray = new Rank[5] { Rank.Ace, Rank.King, Rank.Jack, Rank.Five, Rank.Ten };

            // this is ok, C# knows how to add array values of type int
            int intTotal = intArray.Sum();
            Console.WriteLine( "int total is  " + intTotal);

            // this won't work, C# does not want to guess how to add "Rank" things
            //int rankTotal = rankArray.Sum();
            
            //int rankTotal = rankArray.Sum(item => (int)item);
            //Console.WriteLine("int total is  " + rankTotal);

            Console.ReadLine();
           
        }

        public enum Rank
        {
            Deuce = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13,
            Ace = 14
        }
    }
}
