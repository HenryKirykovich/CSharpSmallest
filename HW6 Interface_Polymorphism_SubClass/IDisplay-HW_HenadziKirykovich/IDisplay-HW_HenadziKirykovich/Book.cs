using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisplay_HW_HenadziKirykovich
{
    public class Book : Document
    {
        public Book()
        {
            Title = "";
            Author = "";
            PageCount = 0;
        }

        public Book(string pTitle, string pAuthor, int pPageCount )
        {
            Title =pTitle;
            Author = pAuthor;
            PageCount = pPageCount;
        }

        public override void Display()
        {
            Console.WriteLine($"The {Title} by {Author} has {PageCount} pages.");
        }

    }
}
