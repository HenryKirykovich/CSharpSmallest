using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_v._3.Linked_List
{
    public class Node
    {
        public object? Data { get; set;}
        public Node? Next { get; set; }
        
        public Node(object myData)
        {
            Data = myData;
            Next = null;
            
            
        }

        public Node(Node myData)
        {
            Data = myData.Data;
            Next = myData.Next;
           
        }

    }
}
