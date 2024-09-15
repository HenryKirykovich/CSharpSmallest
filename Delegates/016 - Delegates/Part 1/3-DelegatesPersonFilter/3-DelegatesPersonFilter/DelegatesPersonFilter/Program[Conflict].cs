using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DelegateApp
{
    // http://stackoverflow.com/questions/2019402/when-why-to-use-delegates
    /// <summary>
    /// A class to define a person, just a name and an age
    /// </summary>
    public class Person 
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }

    
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
            //Create 4 Person objects
            Person p1 = new Person() { Name = "John", Age = 41 }; 
            Person p2 = new Person() { Name = "Jane", Age = 69 };
            Person p3 = new Person() { Name = "Jake", Age = 12 };
            Person p4 = new Person() { Name = "Jessie", Age = 25 };
            Person p5 = new Person() { Name = "Jeff", Age = 2 };
            Person p6 = new Person() { Name = "Jackie", Age = 75 };

            //Create a list of Person objects and fill it
            List<Person> people = new List<Person>() { p1, p2, p3, p4, p5, p6 }; // note the shorthand way of adding 4 objects

            //people.Sort(); // sort the list

            // Call a method, 3 times, each time passing in a method (delegate)
            DisplayPeople("Children:", people, IsChild);
            DisplayPeople("Adults:", people, IsAdult);
            DisplayPeople("Seniors:", people, IsSenior);
            Console.Read();
        }

        // A method to write out a subset of people, based on a filter delegate method
        // method requires a string for a title (window dressing!)
        // the List of people objects it is going to operate on
        // a method passed in  (a delegate)
       static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title); // write title (window dressing!)
            foreach (Person p in people) // use normal List foreach
            {
                if (filter(p))  // what we filter on depends on what which METHOD we passed in!
                {
                    Console.WriteLine("{0}, {1} years old", p.Name, p.Age);
                }
            }
            Console.Write("\n\n");
        }
       
    }
}














  //: IComparable<Person>
        //public int CompareTo(Person other)
        //{
        //    if (other.Age < Age)
        //    {
        //        return 1;
        //    }
        //    else if (other.Age == Age)
        //    {
        //        return 0;
        //    }
        //    return -1;
        //}
