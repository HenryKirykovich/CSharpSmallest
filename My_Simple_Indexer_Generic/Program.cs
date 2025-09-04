namespace My_Simple_Indexer_Generic
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- Example implementation Indexer ----------"); // sometime it is useless thing because I can build object and than assemble any collection what I want
            Console.WriteLine();
            Console.WriteLine("How many collection would you like assemble?");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Approach #1 by Generic Class");

            CollectionName<string> collection = new CollectionName<string>(size);
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Please enter you First, Last name, number your phone by using format: ");
                collection[i] = Console.ReadLine();
            }
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(collection[i]);
            }


            Console.WriteLine();
            Console.WriteLine("Approach #2 by This-Get-Set Method Class");

            Console.WriteLine();
            AnotherAproach anothers = new AnotherAproach(size);


            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Please enter you First, Last name, number your phone by using format: ");
                anothers[i] = Console.ReadLine();
            }
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(anothers[i]);
            }

        }
    }
}
