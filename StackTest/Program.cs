using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack<int> my_stack = new Stack<int>(2);
            //my_stack.Push(10);
            //my_stack.Push(20);
            //my_stack.Push(30); 
            //my_stack.Push(40);

            //Console.WriteLine();
            //foreach (int i in my_stack)
            //{
            //    Console.WriteLine($"# : " + i);
            //}


            //// Pop function
            //Console.WriteLine();
            //int pop = my_stack.Pop();
            //foreach (int i in my_stack)
            //{
            //    Console.WriteLine($"# : " + i);
            //}
            //Console.WriteLine($"I kill this object  " + pop);

            //// Peek - only show top 
            //Console.WriteLine();
            //int peek = my_stack.Peek();
            //foreach (int i in my_stack)
            //{
            //    Console.WriteLine($"# : " + i);
            //}
            //Console.WriteLine($"I show you top-object and for now I have new top " + peek);


            //// countining elemnt
            //Console.WriteLine();
            //int count = my_stack.Count();
            //Console.WriteLine($"I show you countity of element " + count);

            
            //Console.WriteLine();
            //int min = my_stack.Min(x => x);
            //Console.WriteLine($"I show you minimum value your stack " + min);



            // creating my own stack by creating object

            Console.WriteLine();
            Stack new_stack = new Stack(3);
            new_stack.PushStack(66);
            new_stack.PushStack(67);
            new_stack.PushStack(68);
            new_stack.PushStack(69);
            Console.WriteLine($"your number 66, 67, 68, 69 send to Stack(3)");

            Console.WriteLine();
            new_stack.PopStack();



            Console.WriteLine();
            Console.WriteLine("Deleting Top element");
            new_stack.Display(new_stack);


            
            int peek_number = new_stack.PeekStack();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Showing Top Stack");
            Console.WriteLine(peek_number);
        }
    }
}
