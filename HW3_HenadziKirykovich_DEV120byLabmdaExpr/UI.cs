using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace moviesCollection
{

    public class UI
    {
        static void Main()
        {
            Console.WriteLine(">>>>>>>>  Welcome to List Your Favorite Movies  <<<<<<");
           
            Console.WriteLine();
            Console.WriteLine("How many movies do you like?");
            byte quantityMovie = byte.Parse(Console.ReadLine());
            
            Movie[] listMovies = new Movie[quantityMovie];   // created new object Movie[array] for collecting 
                                     
                for (int i = 0; i < quantityMovie; i++)  // typicaly using itteration for filling array
                {
                try      // 
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"What is your favorite {i + 1}st movie ? ");
                    string movie = Console.ReadLine().ToUpper();
                    Console.WriteLine();
                    Console.WriteLine($"What the genre of {movie} movie is ? ");
                    string genre = Console.ReadLine().ToLower();
                    Console.WriteLine();
                    Console.WriteLine($"What the rating {movie} movie is ? (please use rate: 1 bad to 5 great)");
                    byte rating = byte.Parse(Console.ReadLine());
                    Console.WriteLine();
                    listMovies[i] = new Movie(movie, genre, rating);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);

                }
                finally
                {
                    Console.WriteLine($"The {i+1}st movie was successfully saved");
                }

                }
                
                // creating simple Menu for displaing result

            string check = "y";
            byte choice = 0;
            do
            {
                Console.WriteLine();
                Console.WriteLine("How Would you like sort your list push appropriated  number: by Genre - 1, by Rating - 2, Quit - 0");

                
                try
                {
                    choice = byte.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    
                }
                                
               
                switch (choice)
                {
                    case 1:
                        Sort.ByGenre(listMovies);
                        break;
                    case 2:
                        Sort.ByRating(listMovies);
                        break;
                    case 0:
                        check = "n";
                        Console.WriteLine("Thank you. Buy!");
                        break;
                    default:
                        Console.WriteLine("you chose invalid number, try once again?  y/n");
                        check = Convert.ToString(Console.ReadLine().ToLower());
                        break;

                }
            } while (check == "y");
                     
                 




        }
                  

    }
}
