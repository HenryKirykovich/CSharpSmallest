using System.Diagnostics.Metrics;

namespace C_HenadziKirykovichCountLettersHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Program  that finds the count of each leter used in a sentence");
            Console.WriteLine();
            char[] alphas = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int[] count = new int[26];
            Console.WriteLine("Please enter you sentence:");
            string sentence = Console.ReadLine().ToLower();
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.WriteLine(sentence[i]);
                
                
                for (int letter = 0; letter < alphas.Length; letter++)
                {
                    if (sentence[i] == alphas[letter])
                    {
                        count[letter] = count[letter] + 1;
                    }

                }
            }
            
            Console.WriteLine();
            Console.WriteLine("Here is the count of letters:");
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine(alphas[i] + " " + count[i]);
            }

        }
    }
}
