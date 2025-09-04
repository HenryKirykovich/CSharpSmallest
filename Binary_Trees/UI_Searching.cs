namespace Binary_Trees
{
    internal class UI_Searching
    {
        static void Main(string[] args)
        {
            //Binary Search Tree = A tree data structure, where each node is greater than it's left child,
            //		                         but less than it's right.

            //					   benefit: easy to locate a node when they are in this order						

            //					   time complexity: best case  O(log n)
            //									 worst case O(n)

            //					   space complexity: O(n)

            BinarySearchTree tree = new BinarySearchTree();

            tree.Insert(new Node(5));
            tree.Insert(new Node(1));
            tree.Insert(new Node(9));
            tree.Insert(new Node(2));
            tree.Insert(new Node(7));
            tree.Insert(new Node(3));
            tree.Insert(new Node(6));
            tree.Insert(new Node(4));
            tree.Insert(new Node(8));

            tree.Display();
        }
    }
}
    

