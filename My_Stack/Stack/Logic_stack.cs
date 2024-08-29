using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Stack.Stack
{
    class Logic_stack
    {
        // declaring mu stack like array
        Stack<Phone_list> my_list_stack = new Stack<Phone_list>();

        public void PushStack(Phone_list phone_List)
        {
            my_list_stack.Push(phone_List);   // populating stack 
        }


        public void Display()
        {
            // displaying stack
            Console.WriteLine("----------- yours Stack -----------");
            Console.WriteLine("First_Name ======== Last_Name ========== Number");
            foreach (var item in my_list_stack)
            {
                Console.WriteLine();
                Console.WriteLine($"{item.First_Name} ======== {item.Last_Name} ======== {item.Number}");
            }
        }

        public void Deleting()
        {
            //// deleting first element of stack by pop
            
            Phone_list pop = my_list_stack.Pop();
            Console.WriteLine($"you deleted {pop.First_Name} ======== {pop.Last_Name} ======== {pop.Number} ");
           
        }


        public void WatchTop()
        {
            // only watch top element of stack 
            Phone_list watch = my_list_stack.Peek();
            
        }
    }
}
