using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moviesCollection
{
    public static class Sort
    {
        public static void ByGenre(Movie[] inputArray)
        {
            Array.Sort(inputArray);
            
            Array.Sort(inputArray, (x, y) => String.Compare(x.Genre, y.Genre, StringComparison.Ordinal));
            foreach (var item in inputArray)
            {
                Console.WriteLine($"The movie is {item.Title} | The Genre is {item.Genre} | The Rating is {item.Rating}");
            }

            // Comparison<inputArray> comparison = Comparison<>();
        }

        public static void ByRating(Movie[] inputArray)
        {
            Array.Sort(inputArray, (x, y) => x.Rating.CompareTo(y.Rating));
            foreach (var item in inputArray)
            {
                Console.WriteLine($"The movie is {item.Title} | The Genre is {item.Genre} | The Rating is {item.Rating}");
            }
        }
    }
}
