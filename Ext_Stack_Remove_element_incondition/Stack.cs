using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ext_Stack_Remove_element_uncondition
{
    public class Stack
    {
        private int[] items; // Array to hold stack elements
        private int top; // Index of the top element in the stack

        // Constructor to initialize the stack with a specified size
        public Stack(int size)
        {
            items = new int[size]; // Create an array of integers with the given size
            top = -1; // Initialize top index to -1, indicating an empty stack
        }

        // Check if the stack is empty
        public bool IsEmpty()
        {
            return top == -1; // Returns true if the stack is empty
        }

        // Check if the stack is full
        public bool IsFull()
        {
            return top == items.Length - 1; // Returns true if the stack is full
        }

        // Push an element onto the stack
        public void Push(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack Full!"); // Display a message indicating stack overflow if the stack is full
                return;
            }

            items[++top] = item; // Increment top and add the item to the stack
        }

        // Pop an element from the stack
        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack underflow"); // Display a message indicating stack underflow if the stack is empty
                return -1;
            }

            return items[top--]; // Return and decrement top to remove the element from the stack
        }

        // Peek at the top element of the stack without removing it
        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty"); // Display a message indicating the stack is empty
                return -1;
            }

            return items[top]; // Return the top element of the stack
        }

        // Static method to get the size of a stack
        public static int Size(Stack stack)
        {
            return stack.top + 1; // Return the size of the stack based on the current top index
        }

        // Method to count all the elements in a stack
        public static int Count(Stack stack)
        {
            int count = 0;
            Stack temp = new Stack(Size(stack));

            // Move elements from the original stack to a temporary stack and count them
            while (!stack.IsEmpty())
            {
                temp.Push(stack.Pop()); // Move elements from the original stack to the temporary stack
                count++; // Increment count for each element moved
            }

            // Restore the original stack by moving elements back from the temporary stack
            while (!temp.IsEmpty())
            {
                stack.Push(temp.Pop()); // Move elements back to the original stack
            }

            return count; // Return the total count of elements in the stack
        }

        // Method to remove elements from a stack that do not meet a given condition
        public static void RemoveIfNot(Stack stack, Func<int, bool> condition)
        {
            Stack temp = new Stack(Size(stack));

            while (!stack.IsEmpty())
            {
                int item = stack.Pop();
                if (condition(item)) // Check if the condition is met for the element
                {
                    temp.Push(item); // Push the element to the temporary stack if it meets the condition
                }
            }

            while (!temp.IsEmpty())
            {
                stack.Push(temp.Pop()); // Restore the original stack by moving elements back
            }
        }

        // Method to display the elements of the stack
        public static void Display(Stack stack)
        {
            if (stack.IsEmpty())
            {
                Console.WriteLine("Stack is empty"); // Display a message if the stack is empty
                return;
            }

            Console.WriteLine("Stack elements:");
            for (int i = stack.top; i >= 0; i--)
            {
                Console.Write(stack.items[i] + " "); // Display elements of the stack
            }
        }
    }
}
