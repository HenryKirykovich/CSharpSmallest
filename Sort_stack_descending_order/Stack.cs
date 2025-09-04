using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_stack_descending_order
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
            // Method to sort the stack elements in descending order
            public static void SortDescending(Stack stack)
            {
                if (stack.IsEmpty())
                {
                    Console.WriteLine("Stack is empty");
                    return;
                }
                // Creating a temporary stack to hold sorted elements
                Stack tempStack = new Stack(stack.items.Length);
                // Sorting elements in descending order
                while (!stack.IsEmpty())
                {
                    int currentItem = stack.Pop();
                    while (!tempStack.IsEmpty() && currentItem > tempStack.Peek())
                    {
                        stack.Push(tempStack.Pop());
                    }
                    tempStack.Push(currentItem);
                }
                while (!tempStack.IsEmpty())
                {
                    stack.Push(tempStack.Pop());
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
