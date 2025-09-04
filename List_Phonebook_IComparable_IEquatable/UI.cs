using System;
using System.ComponentModel;
using System.Threading.Channels;

namespace List_Phonebook_IComparable_IEquatable
{
    internal class UI
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- Small PhoneBook -------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("How many names would you like enter?");
            int number_name = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            List<Phonebook> names = new List<Phonebook>();
            Console.WriteLine("#Item ------ Last name ------ First name -------- Number Phone ------");

            for (int i = 0; i < number_name; i++)
            {
                Console.WriteLine($"Please enter {i+1}th first name");
                string first = Console.ReadLine().ToUpper();
                Console.WriteLine($"Please enter {i + 1}th last name and number of phone");
                string last = Console.ReadLine().ToUpper();
                Console.WriteLine($"Please enter {i + 1}th phone");
                long number = Convert.ToInt64(Console.ReadLine());
                names.Add(new Phonebook(first, last, number));

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("#Item ------ Last name ------ First name -------- Number Phone ------");
            int count = 1;
            foreach (var item in names)
            {
                Console.WriteLine($"#{count++} --- {item.MyLast} --- {item.MyFirst} --- {item.Myphone} ---");
            }

            Console.WriteLine();
            Console.WriteLine("Would you like sort your list? y/n");
            string answer = Console.ReadLine().ToLower();

            if (answer == "y")
            {
                names.Sort(); // it is relating with IComparable<Phonebook> and Sort() 
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("#Item ----- Last name ------ First name -------- Number Phone ------");
                int count2 = 1;
                foreach (var item in names)
                {
                    Console.WriteLine($"#{count2++} --- {item.MyLast} --- {item.MyFirst} --- {item.Myphone} ---");
                }
            }
            else
            {
                Console.WriteLine("Thank you, bye!");
            }
            Console.WriteLine();
            Console.WriteLine("Would you like sort your list in descending order? y/n");
            string answer_desc = Console.ReadLine().ToLower();
            if (answer_desc == "y")
            {
                names.Reverse();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("#Item ----- Last name ------ First name -------- Number Phone ------");
                int count2 = 1;
                foreach (var item in names)
                {
                    Console.WriteLine($"#{count2++} --- {item.MyLast} --- {item.MyFirst} --- {item.Myphone} ---");
                }
            }
            else
            {
                Console.WriteLine("Thank you, bye!");
            }




        }
    }
}
