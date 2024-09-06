namespace RecursionFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding the Factorial of a given number using recursion");
            Console.WriteLine();

            Console.WriteLine("PLease enter you number");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input > 0)
            {
                Console.WriteLine(RecursionMethodFactorial(input));
            }
        }
        
        public static int RecursionMethodFactorial(int input)
        {
            
            if(input == 0)
            {
                return 1;
            }
            else
            {
                return input * RecursionMethodFactorial(input - 1);  // Important to know:
                                                                     // recursion accumulated resulted and
                                                                     // after input 0  multiplied all number in reverse order 1 * 2 * 3 *4 * 5
                
            }
        }
        

    }
}
