namespace GeneratingRandomNumber_simple_task_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 10; i++)
            {

                Console.WriteLine();
                Random random = new Random();
                object x = random.Next(1, 999);
                Thread.Sleep(1000);
                Console.WriteLine(x);
            }
            Console.WriteLine();
            Console.WriteLine("Next block Generation");
            Console.WriteLine();


            Console.WriteLine("Enumerable sequences");
            var collection = Enumerable.Range(1, 10); // generating Enumerable sequences

            foreach (var item in collection)
            {
                Console.WriteLine(item);
                Thread.Sleep(1000);
            }

            Console.WriteLine();
            Console.WriteLine("converting and then displaying Enumerable sequences to list");
            var collection_array = collection.ToList();  // converting and then displaying Enumerable sequences to list;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(collection_array[i]);
            }


            Console.WriteLine();
            Console.WriteLine("IEnumerable sequences");
            IEnumerable<int> random_number = Enumerable.Range(1, 10); // generating Enumerable sequences


           
            Console.WriteLine();
            foreach (var item in random_number)
            {
                Console.WriteLine(item);
            }
           

        }
    }
}
