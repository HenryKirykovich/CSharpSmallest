using System.Threading.Channels;
using System.Collections;

namespace HashTable_simple_example_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Table - Simple collection");
            Console.WriteLine();


            Hashtable my_hashtable = new Hashtable();   // declaring hash table. it is same like cortege 

            Console.WriteLine("Please value your collection");
            int number = Int32.Parse(Console.ReadLine());
           

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter your key for pair");
                object my_key = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Please enter value for recent key");
                object my_value = Console.ReadLine();
                my_hashtable.Add(my_key, my_value);
            }
            Console.WriteLine("Collection was done!");

            Console.ReadLine();
            Console.WriteLine("Find element collection by your key");
            
            


            bool result = false;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Please enter your key for pair");
                object my_key_search = Console.ReadLine();
                Console.WriteLine();
                result = my_hashtable.Contains(my_key_search);
                
                if (result == true)
                {
                    Console.WriteLine($"in your collection {my_key_search} related with {my_hashtable[my_key_search]}");
                }
                else
                {
                    Console.WriteLine("Sorry, try it again");
                }

            } while (result==false);
           
            
            
           


        }
    }
}
