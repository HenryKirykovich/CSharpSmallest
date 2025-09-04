namespace BinaryTreeConcept
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree in Ordered Array");

            int[] myArray = new int[] { 2, 44, 10, 33, 55, 100, 101 };
            int search_number = 44;

            int index = BinaryMethod(myArray, search_number);

            if (index != -1)
            {
                Console.WriteLine($"The value  {search_number} is {index}");
            }
            else
            {
                Console.WriteLine("Value not found");
            }


            Console.ReadLine();

        }

        public static int BinaryMethod(int[] myArray, int search_number)
        {
            int left = 0;
            int right = myArray.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;



                if (myArray[middle] == search_number)
                {
                    return middle;
                }
                else if (myArray[middle] < search_number)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
               
            }
            return -1;
        }

    }
}
