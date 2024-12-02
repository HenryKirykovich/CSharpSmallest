using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Stack_push_pop_find
{
    public class Stack
    {
        private int[] items;
        private int top; // index of the top of the stack

        public Stack(int size)  // initialization of stack
        {
            items = new int[size];
            top = -1;
        }

        public bool Empty()
        {

            return top == -1;

        }

        public bool Full()
        {
            return top == items.Length - 1;// Returns true if top is at the last index of the array (full stack)
        }

        public void Push(int item)
        {
            if (Full())
            {
                Console.WriteLine("Your Stack is Full");
                return;
            }

            items[++top] = item; // Inserts the item at the incremented top index

        }

        public int Pop()
        {
            if (Empty())
            {
                Console.WriteLine("Stack underflow");
                return -1;
            }
            return items[top--];// Removes and returns the top element by decrementing top




        }

        public int Peek() // Method to peek at the top element of the stack without removing it
        {
            if (Empty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            return items[top];
        }


        public static void Display(Stack stack)
        {
            if (stack.Empty())
            {
                Console.WriteLine("Stack is emplty");
                return;

            }
            Console.WriteLine("\nStack elements:");
            for (int i = stack.top; i >= 0; i--)
            {
                Console.WriteLine(stack.items[i] + " ");// Displays each element in the stack
            }

        }
    }
}
