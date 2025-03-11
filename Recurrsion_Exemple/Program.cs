using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Recursion_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My First Recursion Program");
            Console.WriteLine();
            Console.WriteLine("Please set your natural number");
            Console.WriteLine("________________________________");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            Console.WriteLine(SortNumber.sortPrintNatural(1, number));



            Console.WriteLine("Would yoiu like calculate factorial?");
            Console.ReadLine();
            Console.WriteLine("Set you number: ");
            long factorial = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"Your factorial will be {Factorial.Fact(factorial)}");
            string result = Factorial.Fact(factorial).ToString("N2");
            Console.WriteLine(result);

            Console.WriteLine();
        }
    }


    class SortNumber
    {
        public static int sortPrintNatural(int number1, int number) // input dates included 1 as first natural number 
        {

            if (number <= 1)     // sort number if less 1 show only 1 
            {
                return number1;
            }
            number--;   // decreasing input dates every iteration 
            Console.WriteLine("{0}", number1);     
            return sortPrintNatural(number1+1, number); // must important part // you must use function for itself but changing input data every iteration 
        }
    }

    class Factorial
    {
        public static long Fact(long number)
        {
            if (number <=1)
            {
                return 1;
            }
            return number * Fact(number - 1);

        }
    }
}
