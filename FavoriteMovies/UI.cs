using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestSummer
{
    public class UI
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello my mindless Summer!");
            Console.WriteLine();
            Console.WriteLine();
            bool choice = true;
            byte parsedValue;
            do
            {
                Console.WriteLine("How many movies do you know? (from 1 to 10)");
                string number = Console.ReadLine();
                parsedValue = ValidInput.Convert(number);
               
                if (parsedValue == 0)
                {
                    Console.WriteLine("Thank you buy!");
                    Environment.Exit(0);
                }
                else if (parsedValue > 10)
                {
                    Console.WriteLine("Number exceeds the maximum allowed value. Please enter a number between 1 and 10.");
                    choice = true;
                }
                else
                {
                    choice = false;
                    Console.WriteLine($"You entered {parsedValue} movies.");
                }

            } while (choice);
            
                    
            

            Movie[] movieCollection = new Movie[parsedValue];

            for (int i = 0; i <movieCollection.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"You {i+1} favorite movie is:");
                string movieMy = Console.ReadLine().ToUpper();
                Console.WriteLine();
                Console.WriteLine("The genre your movie is");
                string genreMy = Console.ReadLine().ToUpper();
                Console.WriteLine();
                Console.WriteLine("The rate your movie is");
                byte rateMy = Convert.ToByte(Console.ReadLine());
                movieCollection[i] = new Movie(movieMy, genreMy, rateMy);
                Console.WriteLine($"Your {i+1} movie was successfully saved");
                Console.WriteLine();

            }

            string yes = "y";
            do
            {
                Console.WriteLine("----------------------");
                Console.WriteLine();
                Console.WriteLine("Sort by Name - 1");
                Console.WriteLine("Sort by Genre - 2");
                Console.WriteLine("Sort by Rate - 3");
                Console.WriteLine();
                Console.WriteLine("Exit - 0");
                Console.WriteLine("----------------------");

                string number = Console.ReadLine();
                byte chose = ValidInput.Convert(number);
                Console.WriteLine();
                Console.WriteLine("----------------------");
                switch (chose)
                {
                    case 1:
                        MySort.USort(movieCollection, new MovieSortName());
                        break;
                    case 2:
                        MySort.UGenre(movieCollection, new MovieSortGenre());
                        break;
                    case 3:
                        MySort.UTitle(movieCollection, new MovieSortRate());
                        break;
                    case 0:
                        yes = "n";
                        Console.WriteLine("Thank you. Buy!");
                        break;

                   
                }
                Console.WriteLine();
                Console.WriteLine("----------------------");

            } while (yes == "y");




        }
    }
}
