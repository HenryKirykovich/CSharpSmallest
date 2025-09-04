using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Linked_List_v._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------- Linked List v.2 ---------------");

            LinkedList nw_list = new LinkedList();
            nw_list.AddToList(2220);
            nw_list.AddToList(20);
            nw_list.AddToList(30);
            nw_list.AddToList(40);
            nw_list.AddToList(50);
            nw_list.AddToList(60);


            Console.WriteLine("Original list");
            nw_list.PrintList();

            Console.WriteLine();

            Console.WriteLine("Original list + 0 set in Header");
            nw_list.AddToHeader(0);
            nw_list.PrintList();

                             
            

        }
    }


    public class Node
    {
        public object? data;  // there is data of my Node
        public Node? Next;    // there is pointer of my Node


        public Node()
        {
            
        }

        public Node(object y)
        {
            data = y;
            Next = null;
        }

    }

    class LinkedList
    {
        public Node? head;
        public Node? newObject;

        public LinkedList()
        {
            head = null;
        }
              
        public void AddToList(object y)
        {
            Node new_object = new Node(y) ;
            

            if (head == null)
            {
                head = new_object;
            }
            else
            {
                Node current = new Node();
                current = head;

                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = new_object;
            }        
           
            

        }


        public void AddToHeader(object y)
        {
            Node newnode = new Node(y);
            newnode.Next = head;
            head = newnode;

        }


       


        public void PrintList()
        {
            Node display = head;
            while (display != null)
            {
                Console.WriteLine(display.data);
                display = display.Next;
            }
            
        }


    }



}

    

