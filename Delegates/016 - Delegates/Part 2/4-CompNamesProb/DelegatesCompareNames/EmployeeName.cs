using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesCompareNames
{
    // this is the delegate declaration.  any delegate method implimentation must match this signature
    public delegate int OurComparer(EmployeeName obj1, EmployeeName obj2);  // notice it is sitting outside of all classes, but in the namespace



    public class EmployeeName // this is a new class we provide that holds names
    {
        // fields
        private string FirstName = null;
        private string LastName = null;

        public EmployeeName(string first, string last)  // constructor
        {
            FirstName = first;
            LastName = last;
        }

        public override string ToString()  // overriding the normal ToString so we have an easy way of writing out the values, we'll use later below
        {
            return FirstName + " " + LastName;
        }

        // This method provides a delegate method that satisfies the Comparer definition
        public static int CompareFirstNames(EmployeeName name1, EmployeeName name2)
        // note it returns an int and takes in 2 objects, so it supports the delegate defintion
        // this one compares just using the built in String compare, so list will be sorted alphabetically  by  first name
        {
            string n1 = (name1).FirstName;
            string n2 = (name2).FirstName;

            if (String.Compare(n1, n2) < 0)
            {
                return 1;
            }
            else if (String.Compare(n1, n2) > 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }



        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // You need to write a 2nd method
        // This Method needs to provide a different delegate method 
        // note it must return an int and takes in 2 objects, so it supports the delegate defintion
        // this one should compare objects based on the length of the first and second name combined
        // so for example  Bob Smith is less than Bobby Smitty but equal to Jim Jones

        

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // You need to write a 3rd method that does a compare based on by the number of vowels in both 
        // the first and last name
        // vowels are  a  e  i  o  u
        // you MUST use a helper method to count the vowels
        // in the helper method, change the passed in theString To.Upper()  then you only have 5 values to test for, not 10

        
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public static int HowManyVowels5(string theString)
        {
            // write the required code here.
            
        }


    }

}
