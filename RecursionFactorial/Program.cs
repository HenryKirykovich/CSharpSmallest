namespace RecursionFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding the Factorial of a given number using recursion");
            Console.WriteLine();

            Console.WriteLine("PLease enter your number: ");
            int input = Convert.ToInt32(Console.ReadLine());  //simple input inpit's number


            if (input > 0)
            {
                for (int i = 0; i < input; i++)
                {
                    Console.WriteLine($"\t{i} itteration: {RecursionMethodFactorial(i)}");  // for displaying results from any itteration 
                }
                Console.WriteLine();
                Console.WriteLine("\tYour final result  " + RecursionMethodFactorial(input));  // Factorial
            }
            else
            {
                Console.WriteLine("Invalid number for Factorial.Only real number."); 
            }


            Console.ReadLine();
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
