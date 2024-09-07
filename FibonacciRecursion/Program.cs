namespace FibonacciRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FibonacciRecursion");

            Console.WriteLine("Input your number");
            long number = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine();
            Console.Write($"{FibonacciMethod(number)}");


            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < number; i++)
            {
                Console.Write($"\t{FibonacciMethod2(i)}");
            }
            
        }

        public static long FibonacciMethod(long number)
        {
            if(number == 0)
            {
                return 0;
            }
            else if (number == 1)
            {
                return 1;
            }
            else
            {
                
                return FibonacciMethod(number - 1) + FibonacciMethod(number - 2); // recursion accumulated series of number if you entered 11
                                                                                                            // 0 1 1 2 3 5 8 13 21 34 55 next number 34+55 = 89;
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
