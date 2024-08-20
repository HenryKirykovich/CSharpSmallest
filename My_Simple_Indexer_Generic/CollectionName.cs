using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Simple_Indexer_Generic
{
    public class CollectionName<T>
    {
        private T[] myCollection;
        public CollectionName(int size)
        {
            myCollection = new T[size];
        }

        public T this[int index]
                  
        {
            get { return myCollection[index]; }
            set { myCollection[index] = value; }
        }


    }
}
