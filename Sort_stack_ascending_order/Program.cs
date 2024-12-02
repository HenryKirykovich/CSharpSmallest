using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_stack_ascending_order
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initialize a stack:");
            System.Collections.Stack stack = new System.Collections.Stack(10); // Creating a stack with a size of 10

            Console.WriteLine("Input some elements onto the stack:");
            stack.Push(1);
            stack.Push(3);
            stack.Push(3);
            stack.Push(9);
            stack.Push(5);
            

            System.Collections.Stack.Display(stack); // Displaying the elements in the stack

            System.Collections.Stack.SortAscending(stack); // Sorting stack elements in ascending order
            Console.WriteLine("\nStack elements in ascending order:");
            System.Collections.Stack.Display(stack); // Displaying the sorted elements

            Console.WriteLine("\nInput two more elements onto the stack:");
            stack.Push(0);
            stack.Push(10);
            System.Collections.Stack.Display(stack);

            Console.WriteLine("\nStack elements in ascending order:");
            System.Collections.Stack.SortAscending(stack); // Sorting stack elements again in ascending order
            System.Collections.Stack.Display(stack); // Displaying the sorted elements
        }
    }
}
