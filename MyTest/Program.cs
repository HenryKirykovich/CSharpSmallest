using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            FullName movie = new FullName("Henry", "Bob", 1988);
            FullName movie2 = new FullName("John", "Leysy", 1968);
            List<FullName> myList = new List<FullName> { movie, movie2 };

            foreach (FullName item in myList)
            {
                Console.WriteLine($"{item.first} {item.last} {item.year}");
            }
            Console.WriteLine();
            Console.WriteLine();

            myList.Sort();
            foreach (FullName item in myList)
            {
                Console.WriteLine($"{item.first} {item.last} {item.year}");
            }
          

            myList.Sort();
            foreach (FullName item in myList)
            {
                Console.WriteLine($"{item.first} {item.last} {item.year}");
            }
            myList.Sort();

        }


        
    }

    public class FullName : IComparable<FullName>       
    {
        private string _First;

        public string first
        {
            get { return _First; }
            set { _First = value; }
        }


        private string _Last;

        public string last
        {
            get { return _Last; }
            set { _Last = value; }
        }

        private int _Years;

        public int year
        {
            get { return _Years; }
            set { _Years = value; }
        }

        public FullName()
        {
            
        }

        public FullName(string pFirst, string pLast, int pYears )
        {
            first = pFirst;
            last = pLast;
            year = pYears;
        }

        //public int CompareTo(FullName other)
        //{
        //    if (other == null) return 1; 
            
        //    if (this.year > other.year)
        //    {

        //        return 1;
        //    }
        //    else if (this.year < other.year)
        //    {
        //        return -1;
        //    }
        //    return 0;
            
        //}

        public int CompareTo(FullName other)
        {
            if (other == null) return 1;

            return string.Compare(this.first, other.first, StringComparison.CurrentCulture);
        }
    }





}
