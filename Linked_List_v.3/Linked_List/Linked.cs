using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_v._3.Linked_List
{
    class Linked
    {
        public Node? first; 
        
        public int count = 0;
        
                     
        
        public void AddList(object myData)
        {    // straight order of the list and the one is preferring for most common task

            //if (first == null)
            //{
            //    first = new Node(myData);
            //    
            //}
            //else
            //{
            //    Node current_value = first;
            //    while (current_value.Next != null)
            //    {
            //        current_value = current_value.Next;

            //    }
            //    current_value.Next = new Node(myData);
            //    
            //}

            //reversed order of the list

            Node current_value = new Node(myData);
            //current_value.Data = myData; // using constructor in Node()
            current_value.Next = first;
            first = current_value;
            count++;

        }


        public void Display()  // just displaying whole list
        {
            
            Node current_display = new Node(first);
           
            while (current_display!=null)
            {
                 
                 Console.WriteLine(current_display.Data);
                 current_display = current_display.Next;
            }


            Console.WriteLine();
            Console.WriteLine("Happy End");
            Console.WriteLine($"Quantity of elements are {count}");
            
        }


        public Node DeleteFirst()   // deleting only first 
        {
            
            Node temporarly = new Node(first);
            first = first.Next;
            count--;
            return temporarly;
        }


        public void InsertLastElement(object myData)
        {
            Node newElement = new Node(myData); // create new element with myData and Next = null
            Node current = first;

            while (current.Next!=null)
            {

                current = current.Next;
                count++;
            }
            current.Next = newElement; // add new element 
        }

    }
}
