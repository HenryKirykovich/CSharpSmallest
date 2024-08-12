namespace windows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Window calculator***");
            Console.WriteLine();
            double SubtotalYards = 0;
            double totalYards = 0;
            string answer;
            do
            {
                Console.WriteLine("How many unique window sizes do you have?");
                int uniqueCount = Convert.ToInt32(Console.ReadLine());
                for (int windowType = 0; windowType < uniqueCount; windowType++)
                {
                    Console.WriteLine($"how many windows of type {windowType + 1}  do you want?");
                    int howManyThisType = Convert.ToInt32(Console.ReadLine());
                    double oneWindowAmountInch = DoOneWindow();
                    double oneWindowAmountYard = InchToYards(oneWindowAmountInch);
                    SubtotalYards = SubtotalYards + (oneWindowAmountYard * howManyThisType);
                                                            
                }

                Console.WriteLine();
                Console.WriteLine($"SubTotal is: {SubtotalYards}");
                Console.WriteLine();
                Console.WriteLine("Would you like calculate additional material? Y/N");
                answer = Console.ReadLine().ToLower();
                Console.WriteLine();
            } while (answer == "y");

            totalYards = totalYards + SubtotalYards;
            Console.WriteLine();
            Console.WriteLine($"Total you will need {totalYards} yards");
            Console.WriteLine("Thanks for shopping, goodbye!");
        }

        public static double DoOneWindow()
        {
            Console.WriteLine("Please input width of windows");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input length of windows");
            double length = Convert.ToDouble(Console.ReadLine());
            double amount = (width * length)*1.1;
            return amount;
        }

        public static double InchToYards(double x)
        {
            double convertSqYard = x / 1296;
            return convertSqYard;
        }


        /* code this DoOneWindow method. It should 
            ask the user for the width and length of this style window, 
            and add 10% to each dimension. Then mutliply those 2 numbers 
            to calacuate the number of square inches needed for 1 window.  
            Next, make a call to a new method  InchToYards, and pass in 
            the number of SQUARE inches. 
            The method should return the number of SQUARE yards. 

           Here are 2 sample runs:

          How many unique window sizes do you have?
          1
          how many windows of type 1  do you want?
          1
          what is the width in inches of this window type?
          36
          what is the length in inches of this window type?
          72
          you need 2.42 yards.


          How many unique window sizes do you have?
          2
          how many windows of type 1  do you want?
          2
          what is the width in inches of this window type?
          36
          what is the length in inches of this window type?
          72
          how many windows of type 2  do you want?
          3
          what is the width in inches of this window type?
          18
          what is the length in inches of this window type?
          36
          you need 6.654999999999999 yards.


           */


    }
}
