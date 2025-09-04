using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSummer
{
    internal class BusTier
    {
        public static void SmallSort(Movie[] movies)
        {
            Console.WriteLine("Sorted List is:");
            Console.WriteLine();
            Array.Sort(movies);
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine($"{i + 1} {movies[i].Title}  {movies[i].Genre} {movies[i].Rate}");
            }

            //foreach (var item in movies)
            //{
            //    Console.WriteLine($"{item.Title}   {item.Genre}   {item.Rate}");
            //}
        }

        


    }
}
