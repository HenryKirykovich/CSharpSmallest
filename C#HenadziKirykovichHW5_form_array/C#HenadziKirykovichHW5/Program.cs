using System.Xml.Serialization;

namespace C_HenadziKirykovichHW5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            byte input;
            do
            {
                Console.WriteLine("How many word would you like to input? or 0 if you want Exit");
                input = Convert.ToByte(Console.ReadLine());
                Console.WriteLine();

                string[] userInput = new string[input];
                for (int i = 0; i < userInput.Length; i++)
                {
                    Console.WriteLine("Please type your word here: ");
                    userInput[i] = Console.ReadLine();
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("Your words are:");

                for (int i = 0; i < userInput.Length; i++)
                {
                    Console.WriteLine(userInput[i]);

                }

                Console.WriteLine();
                Console.WriteLine();

                string[] allCaps = new string[userInput.Length];
                for (int i = 0; i < userInput.Length; i++)
                {
                    allCaps[i] = userInput[i].ToUpper();

                }

                Console.WriteLine("AllCaps result:");
                for (int i = 0; i < allCaps.Length; i++)
                {
                    Console.WriteLine(allCaps[i]);
                }
                Console.WriteLine();
                Console.WriteLine();

            } while (input!= 0);
            

        }
    }
}
