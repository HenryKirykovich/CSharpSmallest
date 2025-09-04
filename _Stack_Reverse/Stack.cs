using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Stack_Reverse
{
    public class Stack
    {
        private int[] items;
        private int top;


        public Stack(int size)
        {
            items = new int[size];
            top = -1; // last elements to stack, stack is empty
        }

        public bool IsFull()
        {
            return top == items.Length - 1;
        }

        public bool IsEmpty()
        {
            return top == -1;

        }


      

        public void Push(int item)
        {

            if (IsFull())
            {
                Console.WriteLine("Stack is Full!"); // Dispalays if a stack is full
                return;

            }
            else
            {
                items[++top]=item;
            }
        }

        public int Pop()
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is Full!"); // Dispalays if a stack is full
                return -1;

            }
            else
            {
                return items[top--];
            }
        }

        public int Peek()
        {
            if (IsEmpty() == true )
                {
                Console.WriteLine("Stack is empty");
                return -1;

                }

            return items[top]; // return top element without removing
        }


        public static int Size(Stack stack)
        {
            return stack.items.Length;
        }

        public static Stack Reverse(Stack stack)
        {
            Stack temp = new Stack(stack.items.Length);

            while (!stack.IsEmpty())
            {
                temp.Push(stack.Pop());
            }
            return temp;


        }

        public static void Display(Stack stack)
        {
            if (stack.IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return;
            }

            Console.WriteLine("Stack element");
            for (int i = 0; i < stack.items.Length; i++)
            {
                Console.WriteLine("Element # " + stack.items[i]);
            }

        }

    }

}
