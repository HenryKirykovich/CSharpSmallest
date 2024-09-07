using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassUsability
{
    internal class MyGeneric<First, Second, Third>
    {
        private First first;
        private Second second;
        private Third third;

       

        public First Property1
        {
            get { return first; }
            set { first = value; }
        }

        public Second Property2
        {
            get { return second; }
            set { second = value; }
        }

        public Third Property3
        {
            get { return third; }
            set { third = value; }
        }


        public MyGeneric(First _First, Second _Second, Third _third)
        {
            first = _First;
            second = _Second;
            third = _third;
        }


        

    }
}
