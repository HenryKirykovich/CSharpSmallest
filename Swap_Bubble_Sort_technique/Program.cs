using System.Collections.Immutable;

namespace Swap_Bubble_Sort_technique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============== Bubble (Swap) Sort Array ==============");
            Console.WriteLine();

            Console.WriteLine("how many number you would like save?");
            int cell = Convert.ToInt32(Console.ReadLine());
            long[] myArray = new long[cell];
            Console.WriteLine();
            Console.WriteLine();
            for (int q = 0; q < cell; q++)
            {
                Console.WriteLine($"Please enter {q}th element array");
                myArray[q] = Convert.ToInt64(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine(" ============== Your order is: ==============");
            int number_order = 0;
            foreach (var item in myArray)
            {
                Console.WriteLine($"#{number_order}  {item}");
                number_order++;
            }
            Console.WriteLine();

            ////// sorting by Array.Sort(array) from simpler array
            long[] new_array = new long[cell];
            myArray.CopyTo(new_array, 0);
            Array.Sort(new_array);

            Console.WriteLine();
            Console.WriteLine(" ============== Your ascending order by Sort() method: ==============");
            int number_order2 = 0;
            foreach (var item in new_array)
            {
                Console.WriteLine($"#{number_order2}  {item}");
                number_order2++;
            }




            Console.WriteLine();
           
            long temp_q;
            for (int i = 1; i < myArray.Length; i++)
            {
                for (int q = 0; q < myArray.Length-1; q++)
                {
                    if (myArray[q] > myArray[i])
                    {
                        temp_q = myArray[q];
                        myArray[q] = myArray[i];
                        myArray[i] = temp_q;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine(" ============== Your ascending order by 'Bubble' sort: ==============");
            int number_order3 = 0;
            foreach (var item in myArray)
            {
                Console.WriteLine($"#{number_order3}  {item}");
                number_order3++;
            }
        }
    }
}
