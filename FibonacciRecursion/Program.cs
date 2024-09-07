namespace FibonacciRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FibonacciRecursion");

            Console.WriteLine("Input your number");
            long number = Convert.ToInt64(Console.ReadLine());  // to find the Fibonacci numbers for a series of N numbers 
            Console.WriteLine();
            Console.Write($"{FibonacciMethod(number)}");   // invoke a method that calculates Number Fibonacci and displays only this


            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < number; i++)
            {
                Console.Write($"\t{FibonacciMethod2(i)}");  // invoking method that calculates All sequences Number Fibonacci and display those 
            }
            
        }

        public static long FibonacciMethod(long number)
        {
            if(number == 0)
            {
                return 0;   // this is base case for 0 for any time
            }
            else if (number == 1)
            {
                return 1;   // this is base case for 1 for any time
            }
            else
            {
                
                return FibonacciMethod(number - 1) + FibonacciMethod(number - 2); // recursion accumulated series of number if you entered for ex. 11
                                                                                                            // 0 1 1 2 3 5 8 13 21 34 55 next number 34+55 = 89;
                                                                                                            // this is a principle of Fibonacci  
            }



        }

        public static long FibonacciMethod2(long number)
        {
            long first_number = 0; // by default start from 0 = 0
            long second_number = 1;// by default then 1 = 1

            // next should be 0 + 1 = 3 => 1 + 3 = > 4 and so on 

            for (long i = 0; i <= number; i++)
            {
                if (number == 0)
                {
                    return 0;
                }
                else if (number == 1)
                {
                    return 1;
                }
                long temp_number = first_number;
                first_number = second_number;
                second_number = temp_number + second_number;
            }
            return first_number;


        }
    }
}

// there is perfect flowchart how it is working for number 5th

// Fibonacci(5)
//|
//| --> Fibonacci(4)
//|    |
//|    | --> Fibonacci(3)
//|    |    |
//|    |    | --> Fibonacci(2)
//|    |    |    |
//|    |    |    | --> Fibonacci(1) = 1(Base case)
//|    |    |    | --> Fibonacci(0) = 0(Base case)
//|    |    |
//|    |    | --> Fibonacci(1) = 1(Base case)
//|    |
//|    | --> Fibonacci(2)
//|         |
//|         | --> Fibonacci(1) = 1(Base case)
//|         | --> Fibonacci(0) = 0(Base case)
//|
//| --> Fibonacci(3)
//     |
//     | --> Fibonacci(2)
//     |    |
//     |    | --> Fibonacci(1) = 1(Base case)
//     |    | --> Fibonacci(0) = 0(Base case)
//     |
//     | --> Fibonacci(1) = 1(Base case)