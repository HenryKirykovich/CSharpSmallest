using My_Stack.Stack;
using System;
using System.IO.Pipes;
using System.Numerics;
using System.Threading.Channels;

namespace My_Stack
{
    internal class UI
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------- Collection by Stack -----------");

            Logic_stack my_stack = new Logic_stack();
            

            // ui question
            Console.WriteLine("How many Friends would you like store here?");
            int number = Convert.ToInt32(Console.ReadLine());

            // itteration  for populating stack by phone_list class 
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Please enter {i+1}th First name");
                string first_name = Console.ReadLine();
                Console.WriteLine($"Please enter {i + 1}th Last name");
                string last_name = Console.ReadLine();
                Console.WriteLine($"Please enter {i + 1}th person's number");
                string phone = Console.ReadLine();
                Phone_list person = new Phone_list(first_name, last_name, phone);
                my_stack.PushStack(person);   // populating stack by stack class
            }


            Console.WriteLine("Displaing your stack");
            Console.ReadLine();
            my_stack.Display();


            Console.WriteLine();
            Console.WriteLine("Do you want deleting top of Stack ?");
            Console.WriteLine();
            my_stack.Deleting();


            Console.WriteLine();
            Console.WriteLine("Displaing your stack");
            Console.ReadLine();
            my_stack.Display();


            Console.WriteLine();
            Console.WriteLine("Would you like watch a top of Stack ?");
            Console.WriteLine();
            my_stack.WatchTop();


            Console.WriteLine();
            Console.WriteLine("Displaing your stack");
            Console.ReadLine();
            my_stack.Display();


        }
    }
}
