using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace FinalStarter
{
    // Program Class  ************************************************
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("List of Movies");
            Console.WriteLine();
            Comedy movie1 = new Comedy("Airplane!", 1980);
            Horror movie2 = new Horror("The Shining", 1980);
            Comedy movie3 = new Comedy("Blazing Saddles", 1974);
            Comedy movie4 = new Comedy("Caddyshack", 1980);
            Horror movie5 = new Horror("The Others", 2001);
            Horror movie6 = new Horror("The Exorcist", 1973);

            List<Movie> myList = new List<Movie> { movie1, movie2, movie3, movie4, movie5, movie6 };   // create List Movie and put all movies to the list. I used shortest method add OR we could be use any long method add any object 6 lines

            Console.WriteLine();
            foreach (Movie item in myList)
            {
                Console.WriteLine(item.GetDescriptionString());
            }
            
            Console.WriteLine();
            Console.WriteLine();

            myList.Sort();
            foreach (Movie item in myList)
            {
                Console.WriteLine(item.GetDescriptionString());
            }
            Console.WriteLine();
            Console.WriteLine();

            Magic magic = new Magic(); // declare object for called my method that handler string by method AllCaps 

            OurDelegateDefintion myDelegate = AllCaps;   // connection Delegate  -object  and method that handling string from List
            foreach (Movie item in myList)
            {

                
                
                magic.Transform(item.GetDescriptionString(), myDelegate); // passing String and method to another Method
                
                
            }
           

            static string AllCaps(string someString)   // the method handle any string to Upper string 
            {
                return someString.ToUpper();
            }



        }
    }

    // Movie Class ************************************************
    class Movie : IComparable<Movie>
    {
        private string _Title;

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        private int _Years;

        public int Years
        {
            get { return _Years; }
            set { _Years = value; }
        }
        
        public virtual string GetDescriptionString() => "There is a bug in this program";    // I have used short form for one-line expression. I saw it in youtube.        

        
        public int CompareTo(Movie other)
        {
            if (other == null) return 1;

            if (this.Years > other.Years)
            {
                return 1;
            }
            else if (this.Years < other.Years)
            {
                return -1;
            }
            return 0; 

        }


    }

    // Comedy Class  ************************************************

    class Comedy : Movie
    {
        public Comedy(string pTitle, int pYears) : base()
        {
            Title = pTitle;
            Years = pYears;

        }

        public override string GetDescriptionString() => $"Title: {Title}   Years: {Years}";


    }


    // Horror Class  ************************************************
    class Horror : Movie
    {
            public Horror(string pTitle, int pYears) : base()
            {
                Title = pTitle;
                Years = pYears;

            }

            public override string GetDescriptionString() => $"Title: {Title}   Years: {Years}";


    }

    // Magic Class  ************************************************
    public delegate string OurDelegateDefintion(string someString);

    class Magic
    {
        public void Transform(string inputString, OurDelegateDefintion PassedInMethod)
        {
            Console.WriteLine(PassedInMethod(inputString));
        }
    }

}
