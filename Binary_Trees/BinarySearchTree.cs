using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Binary_Trees
{
    public class BinarySearchTree
    {
        Node root;                                  // this is 'start' point for tree

        public void Insert(Node node)
        {
            root = InsertHelper(root, node);
        }

        private Node InsertHelper(Node root, Node node)
        {
            int data = node.Data;  // temporarily save value of inpute data for comparison 

            if (root == null)
            {
                root = node;
                return root;
            }
            else if (data < root.Data)
            {
                root.Left = InsertHelper(root.Left, node);
            }
            else
            {
                root.Right = InsertHelper(root.Right, node);
            }

            return root;
        }

        public void Display()
        {
            DisplayHelper(root);
        }

        private void DisplayHelper(Node root)
        {
            if (root != null)
            {
                DisplayHelper(root.Left);
                Console.WriteLine(root.Data);
                DisplayHelper(root.Right);
            }
        }

        public bool Search(int data)
        {
            return SearchHelper(root, data);
        }

        private bool SearchHelper(Node root, int data)
        {
            if (root == null)
            {
                return false;
            }
            else if (root.Data == data)
            {
                return true;
            }
            else if (root.Data > data)
            {
                return SearchHelper(root.Left, data);
            }
            else
            {
                return SearchHelper(root.Right, data);
            }
        }

        public void Remove(int data)
        {
            if (Search(data))
            {
                root = RemoveHelper(root, data);
            }
            else
            {
                Console.WriteLine($"{data} could not be found");
            }
        }

        private Node RemoveHelper(Node root, int data)
        {
            if (root == null)
            {
                return root;
            }
            else if (data < root.Data)
            {
                root.Left = RemoveHelper(root.Left, data);
            }
            else if (data > root.Data)
            {
                root.Right = RemoveHelper(root.Right, data);
            }
            else // node found
            {
                if (root.Left == null && root.Right == null)
                {
                    root = null;
                }
                else if (root.Right != null) // find a successor to replace this node
                {
                    root.Data = Successor(root);
                    root.Right = RemoveHelper(root.Right, root.Data);
                }
                else // find a predecessor to replace this node
                {
                    root.Data = Predecessor(root);
                    root.Left = RemoveHelper(root.Left, root.Data);
                }
            }
            return root;
        }

        private int Successor(Node root) // find least value below the right child of this root node
        {
            root = root.Right;
            while (root.Left != null)
            {
                root = root.Left;
            }
            return root.Data;
        }

        private int Predecessor(Node root) // find greatest value below the left child of this root node
        {
            root = root.Left;
            while (root.Right != null)
            {
                root = root.Right;
            }
            return root.Data;
        }
    }

}

