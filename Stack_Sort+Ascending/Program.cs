using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Sort_Ascending
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Initialize a stack:");
            Stack stack = new Stack(10); // Creating a stack with a size of 10

            Console.WriteLine("Input some elements onto the stack:");
            stack.Push(1);
            stack.Push(3);
            stack.Push(3);
            stack.Push(9);
            stack.Push(5);
            Stack.Display(stack); // Displaying the elements in the stack

            Stack.SortAscending(stack); // Sorting stack elements in ascending order
            Console.WriteLine("\nStack elements in ascending order:");
            Stack.Display(stack); // Displaying the sorted elements

            Console.WriteLine("\nInput two more elements onto the stack:");
            stack.Push(0);
            stack.Push(10);
            Stack.Display(stack);

            Console.WriteLine("\nStack elements in ascending order:");
            Stack.SortAscending(stack); // Sorting stack elements again in ascending order
            Stack.Display(stack); // Displaying the sorted elements
        }
    }
}
