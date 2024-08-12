using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisplay_HW_HenadziKirykovich
{
    public class ShortStory : Document
    {
        public ShortStory()
        {
            title = "";
            Author = "";
            PageCount = 0;
        }

        public ShortStory(string pTitle, string pAuthor, int pPageCount)
        {
            title = pTitle;
            Author = pAuthor;
            PageCount = pPageCount;
        }

        public override void Display()
        {
            Console.WriteLine($"The Short Story {title} by {Author} has {PageCount} pages.");
        }



    }
}
