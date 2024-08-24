using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementation_Linked_List
{
   public class NodeList<T> : IEnumerable // using Generic<T> type for ability implementing int, string, or any specific data type : using IEnumerable for ability use foreich loop
    {
        
            private Node<T> Head { get; set; }   // initiazing  the start - point for my linked list

            public NodeList(T head)
            {
                Head = new Node<T>(head);
            }



            public void AddList(T data)   // method for add new data to linked list
            {


                Node<T> current = Head;                  // what is the start - point? here  
                while (current.Next != null)              // add every new data until then uncounted to null (final point)

                {
                    current = current.Next;    // linking every node to chain
                }
                current.Next = new Node<T>(data);


            }

            public void Loop(Action<T> action)      // first way display our list /*/ creating own loop
            {
                Node<T> current = Head;
                while (current != null)
                {
                    action(current.Data);
                    current = current.Next;

                }


            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                Node<T> current = Head;
                while (current != null)
                {
                    yield return current.Data;
                    current = current.Next;

                }
            }
        
    }
}
