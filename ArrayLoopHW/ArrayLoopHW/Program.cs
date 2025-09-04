namespace ArrayLoopHW

{
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For how many numbers would you like to calculate the average?");
            byte quantity = Convert.ToByte(Console.ReadLine());
            while (quantity != 0)
            {
                float[] number = new float[quantity];

                Console.WriteLine($"Please input any {quantity}th positive number");
                for (int i = 0; i < number.Length; i++)
                {
                    number[i] = Convert.ToSingle(Console.ReadLine());
                }
                float total = 0;
                float largest = 0;
                for (int i = 0; i < number.Length; i++)
                {
                    Console.WriteLine($"Your number was {number[i]}");
                    total = total + number[i];
                    largest = number.Max();
                }
                Console.WriteLine($"The average of the numbers was {Math.Round(total / number.Length, 2)} , and the largest was {largest}");

                Console.WriteLine();
                Console.WriteLine("How about calculate the average once again? or input 0 for Exit");
                quantity = Convert.ToByte(Console.ReadLine());
            }
        }

    }
}
