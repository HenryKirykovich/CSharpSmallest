using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer("Joe", "Blow");
            Customer C2 = new Customer("Kurt", "Crow");
            Customer C3 = new Customer("Liu", "Snow");
            Customer C4 = new Customer("Mary", "Flow");

            //Stack<Customer> myStack = new Stack<Customer>();
            //myStack.Push(C1);
            //myStack.Push(C2);
            //myStack.Push(C3);
            //myStack.Push(C4);

            Queue<Customer> myQueue = new Queue<Customer>();
            myQueue.Enqueue(C1);
            myQueue.Enqueue(C2);
            myQueue.Enqueue(C3);
            myQueue.Enqueue(C4);

            for (int i = 0; i < 4; i++) // can't use property myQueue.Count
                                        // as the count will keep changing as my loop executes.
            {
                Customer temp = myQueue.Dequeue();
                //Customer temp = myStack.Pop();
                Console.WriteLine("{0} {1} {2}", i + 1, temp.FirstName, temp.LastName);
            }
            //ArrayList myList = new ArrayList();
            //Address Address1 = new Address(7, "Main", 98053);
            //myList.Add(Address1);
            //Dog Dog1 = new Dog(12, "Border Collie");
            //myList.Add(Dog1);
            //Dog Dog2 = new Dog(9, "Sheppard");
            //myList.Add(Dog2);
            //Address Address2 = new Address(21, "Lincoln", 98053);
            //myList.Add(Address2);
            //Dog Dog3 = new Dog(5, "Poodle");
            //myList.Add(Dog3);
            //Address Address3 = new Address(13, "Plesant", 98053);
            //myList.Add(Address3);

            // for (int i = 0; i < 3; i++)
            //{

            //    var x = myList[3];  // create an object from an item in the list
            //    myList.RemoveAt(3); // removee whatever it was from the list
            //    // now figure out what kind of object x is.
            //    try
            //    {
            //        Address pickedAddress = (Address)x;
            //        Console.WriteLine("Found address: {0} {1} {2}", pickedAddress.StreetNumber, pickedAddress.Street, pickedAddress.Zip);

            //    }
            //    catch (Exception)
            //    {
            //        // if it was not an address, must have been a dog, assuming those are the only
            //        // types of objets I put in there!

            //        Dog pickedDog = (Dog)x;
            //        Console.WriteLine("Found dog: {0} {1}", pickedDog.Breed, pickedDog.Age);
            //    }
            //}
            Console.ReadLine();
        }
    }

    public class Address
    {
        public int StreetNumber { get; set; }
        public string Street { get; set; }
        public int Zip { get; set; }
        public Address(int pNumber, string pStreet, int pZip)
        {
            StreetNumber = pNumber;
            Street = pStreet;
            Zip = pZip;
        }
    }


    public class Dog
    {
        public int Age { get; set; }
        public string Breed { get; set; }
        public Dog(int pAge, string pBreed)
        {
            Age = pAge;
            Breed = pBreed;
        }
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Customer(string pFname, string pLname)
        {
            FirstName = pFname;
            LastName = pLname;
        }
    }
}

