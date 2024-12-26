using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingInterfaceIEnumerable
{
    public class Grocery
    {
        internal int number { get; set; }
        internal string name { get; set; }
        internal int total { get; set; }

        public Grocery()  // default constructor
        { 
            
        }

        public Grocery(int numFruit, string nameFruit, int totalFruit) // constructor
        {
            number = numFruit;
            name = nameFruit;
            total = totalFruit;
        }
    }
}
