using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTest
{     // declaring stack + constructor 
    public class Stack
    {
        private int[] numbers;
        private int top;

        public Stack(int size)
        {
            numbers = new int[size];
            top = -1;
        }

        public bool IsEmpty() 
        { 
            return top == -1;
        }

        public bool IsFull()
        {
            return top == numbers.Length - 1;
        }


        public void PushStack(int x)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full, I can not put your number onto");
                return;


            }
            else
            {
                numbers[++top] = x;
               
            }
            
            
        }


        public int PeekStack()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Your stack is empty");
                return -1;
            }
            
            
            return numbers[top];
        }


        public int PopStack()
        {
            if (IsEmpty())
            {
                Console.WriteLine("your stack is empty");
                return -1;

            }
            else
            {
                return numbers[top--];
            }


        }

        public void Display(Stack stack)
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return;


            }
            Console.WriteLine("Stack elements:");
            for (int i = stack.top; i >= 0; i--)
            {
                Console.Write(stack.numbers[i] + " "); // Displays each element in the stack
            }

            
        }
        


    }
}
