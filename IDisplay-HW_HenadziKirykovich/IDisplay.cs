using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisplay_HW_HenadziKirykovich
{
    interface IDisplay : IComparable<IDisplay>
    {

      
        void Display();

        string title { get; set; }




        int CompareTo(IDisplay other)
        {
            // If other is not a valid object reference, this instance is greater. 
            if (other == null) return 1;

            return string.Compare(this.title, other.title);
        }
    }
}
