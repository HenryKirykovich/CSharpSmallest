using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://www.csharp-station.com/Tutorials/Lesson14.aspx


namespace DelegatesCompareNames
{
    public static class program
    {
   // our program!

        static void Main(string[] args)
        {
            NamesStorage ourEmployees = new NamesStorage();  // call constructor and instantiate ourNames object

            // this is the delegate instantiation
            //OurComparer delegateVarOne = new OurComparer(EmployeeName.CompareFirstNames);  // point variable name to one of the compare methods
            OurComparer delegateVarOne = EmployeeName.CompareFirstNames;
            OurComparer delegateVarTwo;
            OurComparer delegateVarThree;
            //delegateVarOne = EmployeeName.CompareFirstNames;  // point variable name to one of the compare methods
            
            delegateVarTwo = EmployeeName.CompareLengthNames;  // add 2nd method with two parameters 

            delegateVarThree = EmployeeName.CompareVowels;      // add 3nd method with two parameters 

            // notice how I had to qualify the method .compareFirstNames with EmployeeName.CompareFirstNames since
            // that method is not in this class, it is a static method over in the EmployeeName class.

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            //after you write the 2nd and 3rd third new compliant methods, as I did above.
            // assing delegateVarTwo and delegateVarThree to point to their methods.
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            Console.WriteLine("\nBefore Sort: \n");

            ourEmployees.PrintNames();  // our method, in our object ourEmployees,  which with the help of our overriden ToString method, will write out our names.

            // here we use our delegate, delegateVarOne, as a delegate argument being passed into our Sort method in OurArrayOfNames
            // we are giving our Sort method the method we want it to use when it sorts
            ourEmployees.OurBubbleSort(delegateVarOne);

           

            Console.WriteLine("\nAfter 1st Sort: \n");
            ourEmployees.PrintNames();  // write out the names after the 1st sort

            Console.WriteLine();

            // now use your 2nd delegate, delegateVarTwo, as a delegate argument 
            // and again call our Sort method in ourEmployees, again passing in the method
            // call the 2nd sort method here  <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            ourEmployees.OurBubbleSort(delegateVarTwo);

            Console.WriteLine("\nAfter 2nd Sort: \n");
            ourEmployees.PrintNames();  // write out the names after the 2nd sort


            Console.WriteLine();

            // now use your 3rd delegate, delegateVarThree, as a delegate argument
            // and again call our Sort method in ourEmployees, again passing in the method
            // call the 3rd sort method here  <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

            ourEmployees.OurBubbleSort(delegateVarThree);
            Console.WriteLine("\nAfter 3rd Sort: \n");
            ourEmployees.PrintNames();  // write out the names after the 2nd sort


            Console.ReadLine();
        }

    }
}