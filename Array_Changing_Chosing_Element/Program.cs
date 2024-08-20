namespace Inserting_Element_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++++++++++++++ Inserting Particular Element to Array +++++++++++++++");

            Console.WriteLine("How many element would you like?");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[num];
            Console.WriteLine();
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Set your {i}th element");
                myArray[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine();
            Console.WriteLine("Your array is:");
            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"you array included {num} elements");
            Console.WriteLine();
            Console.WriteLine("Enter any number Would you like to insert from 1 to 999 ");
            int new_num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Set number position of element what do you want implement from 0 to {num}");
            int new_pos = Convert.ToInt32(Console.ReadLine());

            int[] new_array = new int[num + 1];
            for (int i = 0; i < new_pos; i++)
            {
                new_array[i] = myArray[i];
            }
            new_array[new_pos] = new_num;


            Console.WriteLine("");

            for (int i = new_pos; i < myArray.Length; i++)
            {
                new_array[i + 1] = myArray[i];
            }
            Console.WriteLine();
            Console.WriteLine();
            int element = 0; 
            foreach (var item in new_array)
            {
                Console.WriteLine($"element # {element} {item}");
                element++;
            }

        }
    }
}
