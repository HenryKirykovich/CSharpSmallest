namespace StringCompare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- Comparison String ---------");
            Console.WriteLine();
            Console.WriteLine("Enter first word");
            string x = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter second word");
            string y = Console.ReadLine();

            int result;

            result = string.CompareOrdinal(x, y);
            if (result > 0)
            {
                Console.WriteLine($"The word {x} more than {y}");
            }
            else if (result < 0)
            {
                Console.WriteLine($"The word {x} less than {y}");
            }
            else
            {
                Console.WriteLine($"The both words are the same");
            }


            Console.WriteLine();
            Console.WriteLine("Do you want compare specific character?");
            Console.ReadLine();
            Console.WriteLine("Enter first word");
            string x2 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter second word");
            string y2 = Console.ReadLine();

            int result2 = string.Compare(x2, 3, y2, 3, 2);
            if (result2 < 0)
            {
                Console.WriteLine($"The word {x2} is more than {y2}");
            }
            else if (result2 > 0)
            {
                Console.WriteLine($"The word {x2} is less than {y2}");
            }
            else
            {
                Console.WriteLine($"The both words are the same");
            }
        }
    }
}
