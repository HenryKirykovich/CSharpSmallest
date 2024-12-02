using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Stack_push_pop_find
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initialazing a stack");
            Stack stack = new Stack(5); // Creating a stack with a size of 5
            Console.WriteLine("Checking if stack is empty : "  + stack.Empty());
            Console.WriteLine("\nInput some elements the stack");
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);
            stack.Push(60);
            Stack.Display(stack);
            Console.WriteLine("\nTop element of the stack: " + stack.Peek());
            Console.WriteLine("\nChecking if stack is full: " + stack.Full());
            Console.WriteLine("\nnPopping three elements from the stack:");
            Console.WriteLine(stack.Pop()); // Removing and displaying the popped elements
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Stack.Display(stack);
            Console.WriteLine("\nTop element of the stack: " + stack.Peek()); // Displaying the top element without removing it

        }
    }
}
