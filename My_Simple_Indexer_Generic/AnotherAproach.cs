using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Simple_Indexer_Generic
{
    class AnotherAproach
    {
        private string[] myCollection;
        public AnotherAproach(int size)
        {
            myCollection = new string[size];
            for (int i = 0; i < size; i++)
            {
                myCollection[i] = "blank";
            }

        }


        public string this[int number]
        {
            get
            {
                return myCollection[number];
            }
            set
            {
                myCollection[number] = value;
            }
        }
    }
}
