using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ext_Stack_Remove_element_not_condition
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Initialize three stacks
            Stack stack1 = new Stack(10);
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            Console.Write("Stack1: ");
            Stack.Display(stack1);

            Stack stack2 = new Stack(10);
            stack2.Push(2);
            stack2.Push(3);
            stack2.Push(4);
            stack2.Push(5);
            Console.Write("\nStack2: ");
            Stack.Display(stack2);

            Stack stack3 = new Stack(10);
            stack3.Push(3);
            stack3.Push(4);
            stack3.Push(5);
            Console.Write("\nStack3: ");
            Stack.Display(stack3);

            Console.WriteLine("\n\nRemove elements that are odd:");
            Console.Write("\nStack1 before:\n");
            Stack.Display(stack1);
            Stack.RemoveIfNot(stack1, x => x % 2 == 0);
            Console.Write("\nStack1 after:\n");
            Stack.Display(stack1);

            Console.Write("\n\nStack2 before:\n");
            Stack.Display(stack2);
            Stack.RemoveIfNot(stack2, x => x % 2 == 0);
            Console.Write("\nStack2 after:\n");
            Stack.Display(stack2);

            Console.Write("\n\nStack3 before:\n");
            Stack.Display(stack3);
            Stack.RemoveIfNot(stack3, x => x % 2 == 0);
            Console.Write("\nStack3 after:\n");
            Stack.Display(stack3);
        }
    }
}
