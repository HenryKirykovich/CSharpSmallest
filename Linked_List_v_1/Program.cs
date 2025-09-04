using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Linked_List_v_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------- Linked List v.1---------------");
            Console.WriteLine();

            AppendList newList = new AppendList();
            newList.AddList(10);
            newList.AddList(20);
            newList.AddList(25);
            

            Console.WriteLine();

            newList.DisplayList();
                      
;
        }

    }

    public class Node
    {
        public object Data { get; set; }
        public Node Next { get; set; }

        public Node(object date)
        {
            Data = date;
        }

        
    }

    public class AppendList
    {
        public Node head { get; set; } // initializing head null of list

        public void AddList(object data) // populating list 
        {
            if (head == null)
            {
                head = new Node(data);
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;

                }
                current.Next = new Node(data);
            }

        }


        public void DisplayList()
        {
            Node current = head;
            while (current!= null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;

            }
           
        }

      

    }




}
