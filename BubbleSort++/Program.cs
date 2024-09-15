namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 40,88,9999, 8, 10, 2,1 };

            Console.WriteLine(myArray.Sum());

            int temp;
            char l = 'a';
            foreach (var item in myArray)
            {
                Console.Write($"{item}  ");
            }

            for (int i = 0; i < myArray.Length; i++)   // start from first number
            {
                for (int j =i+1; j < myArray.Length; j++)  // start from second number
                {
                    if (myArray[i] > myArray[j])    // adjuster for set descending or ascending order
                    {
                        temp = myArray[j];
                        myArray[j] = myArray[i];
                        myArray[i] = temp;

                    }
                }
            }

            Console.WriteLine();

            foreach (var item in myArray)
            {
                Console.Write($"{item}  ");
            }

            Console.ReadLine();
        }
    }
}
