using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisplay_HW_HenadziKirykovich
{
    public class Document : IDisplay
    {
        string IDisplay.title { get; set; }


        
        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        private int pageCount;

        public int PageCount
        {
            get { return pageCount; }
            set { pageCount = value; }
        }

        

        public virtual void Display()
        {
            Console.WriteLine("Display from Document");
        }

        int CompareTo(IDisplay other)
        {
            return string.Compare(((IDisplay)this).title, other.title);
        }

        

        
    }
}
