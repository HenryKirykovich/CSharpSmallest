using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace implementation_Linked_List
{
    public class Program
    {
        static void Main(string[] args)
        {

            NodeList<string> myList = new NodeList<string>("John");
            myList.AddList("Henry");
            myList.AddList("Bobby");
            myList.AddList("Lucy");
            myList.AddList("Ivan");
            myList.AddList("Adeliy");

            myList.Loop(x => Console.WriteLine(x));

            Console.WriteLine("------------------------------"); // displaying all list by own method 
            NodeList<int> myList2 = new NodeList<int>(1);
            myList2.AddList(2);
            myList2.AddList(3);
          

            myList2.Loop(x => Console.WriteLine(x));


            


            Console.WriteLine("------------------------------"); // displaying all list by using typical iteration 


            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }

    }
   
}
