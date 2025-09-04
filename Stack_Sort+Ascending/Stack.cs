using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Sort_Ascending
{
    public class Stack
    {
        private int[] items; // Array to hold stack elements
        private int top;     // Index representing the top of the stack

        // Constructor to initialize the stack with a specified size
        public Stack(int size)
        {
            items = new int[size]; // Initializing the array with the given size
            top = -1;              // Initializing top to -1, indicating an empty stack
        }

        // Method to check if the stack is empty
        public bool IsEmpty()
        {
            return top == -1; // Returns true if top is -1 (empty stack), otherwise false
        }

        // Method to check if the stack is full
        public bool IsFull()
        {
            return top == items.Length - 1; // Returns true if top is at the last index of the array (full stack)
        }

        // Method to push an element onto the stack
        public void Push(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack Full!"); // Displays a message if the stack is full
                return;
            }

            items[++top] = item; // Inserts the item at the incremented top index
        }

        // Method to pop an element from the stack
        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack underflow"); // Displays a message if the stack is empty
                return -1;
            }

            return items[top--]; // Removes and returns the top element by decrementing top
        }

        // Method to peek at the top element of the stack without removing it
        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty"); // Displays a message if the stack is empty
                return -1;
            }

            return items[top]; // Returns the element at the top index without removing it
        }

        // Method to get the current size of the stack
        public static int Size(Stack stack)
        {
            return stack.top + 1; // Returns the number of elements in the stack
        }

        // Method to sort the stack elements in ascending order
        public static void SortAscending(Stack stack)
        {
            // Create a temporary stack to hold sorted elements
            Stack temp = new Stack(stack.items.Length);

            while (!stack.IsEmpty())
            {
                // Pop an element from the original stack
                int curr = stack.Pop();

                // Pop elements from the temporary stack and push them back onto the original stack
                while (!temp.IsEmpty() && temp.Peek() > curr)
                {
                    stack.Push(temp.Pop());
                }

                // Push the current element onto the temporary stack
                temp.Push(curr);
            }

            // Copy the sorted elements back onto the original stack
            while (!temp.IsEmpty())
            {
                stack.Push(temp.Pop());
            }
        }

        // Method to display the stack elements
        public static void Display(Stack stack)
        {
            if (stack.IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return;
            }

            Console.WriteLine("Stack elements:");
            for (int i = stack.top; i >= 0; i--)
            {
                Console.Write(stack.items[i] + " "); // Displays each element in the stack
            }
        }
    }
}
