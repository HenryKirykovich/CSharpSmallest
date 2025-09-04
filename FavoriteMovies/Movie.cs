using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSummer
{
    public class Movie
    {
		private string title;

		public string  Title
		{
			get { return title; }
			set { title = value; }
		}

		private string genre;

		public string Genre
		{
			get { return genre; }
			set { genre = value; }
		}

		private byte rate;

		public byte Rate
		{
			get { return rate; }
			set { rate = value; }
		}

		public Movie()
		{
			title = "empty";
			genre = "empty";
			rate = 0;
		}

		public Movie(string pTitle, string pGenre, byte pRate)
		{
			Title = pTitle;
			Genre = pGenre;
			Rate = pRate;
			
		}
	}


	public class MovieSortName: IComparer<Movie>
	{
		public int Compare(Movie x, Movie y)
		{
			return string.Compare(x.Title, y.Title, StringComparison.Ordinal);
		}
		       
    }

    public class MovieSortGenre : IComparer<Movie>
    {
        public int Compare(Movie x, Movie y)
        {
            return string.Compare(x.Genre, y.Genre, StringComparison.Ordinal);
        }

    }

	public class MovieSortRate : IComparer<Movie>
	{
		public int Compare(Movie x, Movie y)
		{
			return x.Rate.CompareTo(y.Rate);
		}
	}

    
    public class MySort
	{
		

		public static void USort(Movie[] movies, IComparer<Movie> comparer)
		{
			Array.Sort(movies, comparer);
			for (int i = 0; i<movies.Length; i++)
					
			{
                Console.WriteLine($"{i+1}  {movies[i].Title}  {movies[i].Genre} {movies[i].Rate}");
            }
		}

        public static void UGenre(Movie[] movies, IComparer<Movie> comparer)
        {
            Array.Sort(movies, comparer);
            for (int i = 0; i < movies.Length; i++)

            {
                Console.WriteLine($"{i + 1}  {movies[i].Title}  {movies[i].Genre} {movies[i].Rate}");
            }
        }

        public static void UTitle(Movie[] movies, IComparer<Movie> comparer)
        {
            Array.Sort(movies, comparer);
            for (int i = 0; i < movies.Length; i++)

            {
                Console.WriteLine($"{i + 1}  {movies[i].Title}  {movies[i].Genre} {movies[i].Rate}");
            }
        }


    }

}
