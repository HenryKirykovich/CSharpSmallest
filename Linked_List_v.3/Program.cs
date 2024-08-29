using Linked_List_v._3.Linked_List;


namespace Linked_List_v._3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List ");
            Console.WriteLine();

            Linked nw_list = new Linked();
            nw_list.AddList(10);
            nw_list.AddList(20);
            nw_list.AddList(30);
            

            Console.WriteLine();
            Console.WriteLine("Your list after added all element is:");
            nw_list.Display();   // displaying


            nw_list.DeleteFirst(); // deleting 
            Console.WriteLine();
            Console.WriteLine("Your list after deleting is:");
            nw_list.Display();


            nw_list.InsertLastElement(666); // adding last any element 
            Console.WriteLine();
            Console.WriteLine("Your list insert last element is:");
            nw_list.Display();
            


        }
    }
}
