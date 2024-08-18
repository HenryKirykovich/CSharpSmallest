using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Phonebook_IComparable_IEquatable
{
    public class Phonebook : IEquatable<Phonebook>, IComparable<Phonebook>
    {
		private string myFirst;

		public string MyFirst
		{
			get { return myFirst; }
			set { myFirst = value; }
		}

		private string myLast;

		public string MyLast
        {
			get { return myLast; }
			set { myLast = value; }
		}

		private long phone;

		public long Myphone
		{
			get { return phone; }
			set { phone = value; }
		}


		public Phonebook(string First, string Last, long Phone)
        {
			MyFirst = First;
			MyLast = Last;
			Myphone = Phone;
        }


		public bool Equals(Phonebook other)   // it is not necessarily block for my task
		{
			if (this.MyLast == other.MyLast)
			{
				return true;

			}
			else
			{
				return false;
			}

		}

		public int CompareTo(Phonebook other) // it is relating with IComparable<Phonebook> and Sort() // sorting ascending order
        {

			if (other == null) return 1; // what is the other object is null? 
			return this.myLast.CompareTo(other.myLast);
                      

        }

      

    }
}
