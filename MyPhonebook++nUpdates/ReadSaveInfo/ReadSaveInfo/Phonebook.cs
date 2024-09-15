using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadSaveInfo
{
    public class Phonebook : Interface
    {
        private string first;

		public string First
		{
			get { return first; }
			set { first = value; }
		}

		private string last;

		public string Last
		{
			get { return last; }
			set { last = value; }
		}

		private string number;

		public string Number
		{
			get { return number; }
			set { number = value; }
		}

        public int Speed { get; set; }


        public Phonebook()
		{
			this.first = "Empty";
			this.last = "Emplty";
			this.number = "Emplty";
		}

        public Phonebook(string pFirst, string pLast, string pNumber)
        {
            this.first = pFirst;
            this.last = pLast;
            this.number = pNumber;
        }



    }
}
