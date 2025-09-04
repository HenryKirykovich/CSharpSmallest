using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisplay_HW_HenadziKirykovich
{
    public class YouTubeVid : IDisplay
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public YouTubeVid()
        {
            Title = "";
            Author = "";
            Category = "";       
        }

        public YouTubeVid(string pTitle, string pAuthor, string pCategory)
        {
            Title = pTitle;
            Author = pAuthor;
            Category = pCategory;
                        
        }

        public void Display()
        {
            Console.WriteLine($"The video {Title} by {Author} is in the {Category} category.");
        }


    }
}
