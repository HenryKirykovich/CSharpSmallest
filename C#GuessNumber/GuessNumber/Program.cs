using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please guess number from 1 to 3");
                Random myRandom = new Random();
                int dice = myRandom.Next(1, 4);
                int input = int.Parse(Console.ReadLine());

                if ((input > 3) || (input < 1))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                    continue;
                }

                Console.WriteLine("You chose number {0} but computer's number was {1} ", input, dice);

                if (dice == input)
                {
                    Console.WriteLine("You Winning, guessing number. Do you want to check your destiny again? Y / N ");
                    string retryInput = Console.ReadLine().ToUpper();
                    if (retryInput == "Y")
                    {
                        continue;
                    }
                    else if (retryInput == "N")
                    {
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("Today You didn't guess, please try again. Enter Y / N");
                    string retryInput = Console.ReadLine().ToUpper();
                    if (retryInput == "Y")
                    {
                        continue;
                    }
                    else if (retryInput == "N")
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
