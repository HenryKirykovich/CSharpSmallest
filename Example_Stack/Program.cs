using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Example_Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------- Implementation of work of Stack -------");   // Program to implement a stack with push and pop operations. Find the top element of the stack and check if the stack is empty or not.
            Stack<double> myStack = new Stack<double>();
            char choice = 'y';
            do
            {
                Console.WriteLine("how many elements do you want to implemented?");
                int num_el = int.Parse(Console.ReadLine());
                Console.WriteLine();


                for (int i = 0; i < num_el; i++)
                {
                    Console.WriteLine($"Enter you {i}th element to your Stack:");
                    double el = double.Parse(Console.ReadLine());
                    myStack.Push(el);
                }
                Console.WriteLine();
                


                checkStack(myStack);  // for fun, this check empty or not stack // if it is empty reload block of questions


                Console.WriteLine("Would you like to try it again? y / n ");
                choice = char.Parse(Console.ReadLine().ToLower());

            } while (choice == 'y');

                      
            

            Console.WriteLine();
            double number= myStack.Peek();
            Console.WriteLine($"Last-in and First - Out element is {number}");

            Console.WriteLine();
            double number_remove = myStack.Pop();
            Console.WriteLine($"{number_remove} was REMOVED from STack");
            
            Console.WriteLine();
            foreach (var item in myStack)
            {
                Console.WriteLine($"Rested elements of Stack {item}");
                
            }

            Console.WriteLine();
            Console.WriteLine("The Count the elements of Stack handles by myStack.Count");
            int count_element = myStack.Count;
            Console.WriteLine($"Finally, the numbers of elements are {count_element}");


            
            
        }


        static void checkStack(Stack<double> nameStack)
        {
            int number = nameStack.Count;
            if (number == 0)
            {
                Console.WriteLine("your stack is empty");
                Console.WriteLine("Try upload once again");
            }
            else
            {
                Console.WriteLine("List of Element inside is");
                int count = 0;
                foreach (var item in nameStack)
                {
                    Console.WriteLine($"{count} element {item}");
                    count++;
                }
            }
        }
    }

    
}
