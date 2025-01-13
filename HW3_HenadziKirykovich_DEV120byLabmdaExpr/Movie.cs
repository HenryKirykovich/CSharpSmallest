using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moviesCollection
{
    public class Movie  
    {
        private string title;     // all field have protection private access

        public string Title       // accessor's these field's
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
        private byte rating;

        public byte Rating
        {
            get { return rating; }
            set 
            {
                if (value > 5)    // additional protection input within the scope of numbers inside accessor
                {
                    rating = 5;
                }
                else if (value < 1)
                {
                    rating = 1;
                }
            }
        }


        public  Movie()              // default constructor with no-Null field for excepting of errors
        {
            this.title = "Empty";   // this is useful feature for direction to original field
            this.genre = "Empty";
            this.rating = 0;
        }

        public Movie(string pTittle, string pGenre, byte pRating) // 3 components constructor
        {
            this.title = pTittle;
            this.genre = pGenre;

            if (pRating > 5)    // additional protection input within the scope of numbers inside method
            {
                pRating = 5;
            }
            else if (pRating < 1)
            {
                pRating = 1;
            }
            
            this.rating = pRating;
        }

        

    }
}
