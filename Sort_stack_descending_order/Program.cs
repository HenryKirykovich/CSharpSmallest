using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_stack_descending_order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initialize a stack:");
            Stack stack = new Stack(10); // Creating a stack with a size of 10
            Console.WriteLine("\nInput some elements onto the stack:");
            stack.Push(1);
            stack.Push(3);
            stack.Push(3);
            stack.Push(9);
            stack.Push(5);
            Stack.Display(stack); // Displaying the elements in the stack
            Stack.SortDescending(stack); // Sorting stack elements in descending order
            Console.WriteLine("\nStack elements in descending order:");
            Stack.Display(stack); // Displaying the sorted elements
            Console.WriteLine("\nInput two more elements onto the stack:");
            stack.Push(0);
            stack.Push(10);
            Stack.Display(stack);
            Console.WriteLine("\nStack elements in descending order:");
            Stack.SortDescending(stack); // Sorting stack elements again in descending order
            Stack.Display(stack); // Displaying the sorted elements
        }
    }
}
