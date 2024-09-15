using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesCompareNames
{
    // This is our big fancy class that does wonderful things for us,
    // It stores EmployeeNames as objects in an array
    // It will print all the employees for us
    // It will sort the list for us, with its "powerful" bubble sort algorithm
    // (as long as we tell it how to decide what "bigger" means by passing in a delegate method!
    public class NamesStorage
    {
        EmployeeName[] names = new EmployeeName[5];  // array that can hold 5 EmployeeName objects

        public NamesStorage()  // constuctor nicely loads the array for us
        {
            names[0] = new EmployeeName("Joe", "May");
            names[1] = new EmployeeName("John", "Hancock");
            names[2] = new EmployeeName("Jane", "Doe");
            names[3] = new EmployeeName("Jennifer", "Aniston");
            names[4] = new EmployeeName("Jacoby", "Ellsbury");
        }

        // this class provides a Sort method, 
        // BUT - it requires you to pass in a delegate to tell it how to sort
        public void OurBubbleSort(OurComparer compareMethod)
        {
            EmployeeName temp; // to do the sort, we need to flip the order sometimes, so we need a place to put one aside

            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < names.Length-1; j++)
                {
                    // using delegate "compare" just like a normal method
                    if (compareMethod(names[j], names[j+1]) < 0) // the results of "compare" will depend on what we pass in
                    {
                        temp = names[j]; // pull this one out of the list
                        names[j] = names[j+1];  // move the one below it up to that spot
                        names[j+1] = temp;  // now put the one we set aside under the one we moved up
                    }
                }
            }
        }

        public void PrintNames()  // simple method to display the array values
        {
            foreach (EmployeeName name in names)
            {
                Console.WriteLine(name.ToString());  // makes use of our overide of the ToString method
            }
        }

    }
}
