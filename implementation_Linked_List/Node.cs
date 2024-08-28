using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementation_Linked_List
{
    public class Node<T>    // initializing chain of node (core single linked list) 
    {

        
            public T Data { get; }    // field or object or single instance list
            public Node(T data)
            {
                Data = data;                  // constructor that set data to nodes
            }

            public Node<T> Next { get; set; }     // initializing next node of list 
        
            

    }
}
