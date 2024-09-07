using System.Collections.Generic;

namespace Generater_all_possible_permutations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Generator all possible permutations of an array using recursion");
            int n, i;
            
            int[] arr1 = new int[5];

            Console.WriteLine("\n\n Recursion : Generate all possible permutations of an array :");
            Console.WriteLine("------------------------------------------------------------------");

            // Accept user input for the number of elements in the array
            Console.Write(" Input the number of elements to store in the array [maximum 5 digits]: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Input {0} number of elements in the array:\n", n);

            // Accept user input for array elements
            for (i = 0; i < n; i++)
            {
                Console.Write(" element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Display generated permutations of the array elements
            Console.Write("\n The Permutations with a combination of {0} digits are: \n", n);
            prnPermut(arr1, 0, n - 1);
            Console.Write("\n\n");


        }


        public static void swapTwoNumber(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // Method to generate permutations of elements in the array
        public static void prnPermut(int[] list, int start, int end)
        {
            int i;
            // If start equals end, it signifies a complete permutation
            if (start == end)
            {
                for (i = 0; i <= end; i++)
                    Console.Write("{0}", list[i]); // Print the permutation
                Console.Write(" "); // Space after each permutation
            }
            else
            {
                // Loop to generate permutations
                for (i = start; i <= end; i++)
                {
                    swapTwoNumber(ref list[start], ref list[i]); // Swap elements at positions start and i
                    prnPermut(list, start + 1, end); // Recursively generate permutations for the remaining elements
                    swapTwoNumber(ref list[start], ref list[i]); // Restore the original order for backtracking
                }
            }
        }
    }
}
