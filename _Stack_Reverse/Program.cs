using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Stack_Reverse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("Initialize a stack:");
            Stack stack = new Stack(10); // Creating a stack with a size of 10
            Stack result = new Stack(10); // Creating a stack to store the reversed elements


            Console.WriteLine("***************************************");
            Console.WriteLine("Input to the stack:");
            stack.Push(1);
            stack.Push(3);
            stack.Push(3);
            stack.Push(9);
            stack.Push(5);
            stack.Push(55);
            Stack.Display(stack); // Displaying the elements in the original stack

            result = Stack.Reverse(stack); // Reversing the elements in the stack
            Console.WriteLine("\nReverse the elements:  ");
            Console.WriteLine("***************************************");
            Stack.Display(result); // Displaying the reversed elements in the result stack


            Console.WriteLine("***************************************");
            Stack.Display(stack);
        }
    }
}
