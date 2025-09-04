using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DelegatesPersonFilter;


namespace DelegateApp
{
    // http://stackoverflow.com/questions/2019402/when-why-to-use-delegates
    

    
    class Program
    {
        //Define our delegate
        public delegate bool FilterDelegate(Person p);
        // to comply, a method must accept objects of type Person, and return a true or false


        // Define 3 methods that have that delegate signature
        //==========FILTERS===================
        static bool IsChild(Person p)
        {
            return p.Age <= 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }

        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }

        static void Main(string[] args)
        {
            //Create 6 Person objects
            Person p1 = new Person() { Name = "John", Age = 41 };
            Person p2 = new Person() { Name = "Jane", Age = 69 };
            Person p3 = new Person() { Name = "Jake", Age = 12 };
            Person p4 = new Person() { Name = "Jessie", Age = 25 };
            Person p5 = new Person() { Name = "Jeff", Age = 2 };
            Person p6 = new Person() { Name = "Jackie", Age = 75 };

            //Create a list of Person objects and fill it
            List<Person> people = new List<Person>() { p1, p2, p3, p4, p5, p6 }; // note the shorthand way of adding 4 objects

            //people.Sort(); // sort the list  will this work??

            // call the Display method 3 times, and pass in the "rules" by giving it a method
            // using a variable for the method name
           

            FilterDelegate myDelegateVariable = IsChild;
            Console.WriteLine(myDelegateVariable(p1));
            Console.WriteLine("--------------------------------------------------------------");


            DisplayPeople("Children:", people, myDelegateVariable);
            Console.WriteLine();

            myDelegateVariable = IsAdult;
            DisplayPeople("Adults:", people, myDelegateVariable);
            Console.WriteLine();

            myDelegateVariable = IsSenior;
            DisplayPeople("Seniors:", people, myDelegateVariable);
            Console.WriteLine();

            // Notice that when we pass in the method defintion, even though the method needs a parameter,
            // we just pass in the name.  When the code that is going to execute this method is actaull called,
            // THEN it needs to append on the needed parameter.
 

            // Call a method, 3 times again, each time passing in an actual method, but the method must comply with the
            // delegate defintion that Display people has declared.

            //DisplayPeople("Children:", people, IsChild); // IsChild is a method

            //DisplayPeople("Adults:", people, IsAdult); // IsAdult is a method

            //DisplayPeople("Seniors:", people, IsSenior); // IsSenior is a method

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("what do you want to see, children, adults, oldfolks?");
            string userChoice = Console.ReadLine();
            Console.WriteLine();

            switch (userChoice)
            {
                case "children":
                    myDelegateVariable = IsChild;
                    break;
                case "adults":
                    myDelegateVariable = IsAdult;
                    break;
                case "oldfolks":
                    myDelegateVariable = IsSenior;
                    break;
                default:
                    break;
            }

            DisplayPeople(userChoice, people, myDelegateVariable);
            Console.Read();

        }

        // A method to write out a subset of people, based on a filter delegate method
        // method requires a string for a title (window dressing!)
        // the List of people objects it is going to operate on
        // a method passed in  (a delegate)
       static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title); // write title (window dressing!)
            foreach (Person anotherPerson in people) // use normal List foreach
            {
                if (filter(anotherPerson))  // what we filter on depends on what which METHOD we passed in!
                    // notice that we call the passed in method (filter), AND we give it its needed parameter
                    // we call back to the program where the "filter" method is actaully defined, and run the code there
                    // and then return back here.
                {
                    Console.WriteLine("{0}, {1} years old", anotherPerson.Name, anotherPerson.Age);
                }
            }
            Console.Write("\n\n");
        }
       
    }
}