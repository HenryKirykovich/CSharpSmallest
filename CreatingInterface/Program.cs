using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingInterfaceIEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddRemoveDisplay objectAdd = new AddRemoveDisplay();

            

            Console.WriteLine("This is small Grocery list");  // manually type all fruit and then pass those to collection
            Console.WriteLine();
            string name; 
            int amount; 
            int count = 0;
            char choice = 'y';
            Console.WriteLine("Would you like to add new item?");
            Console.WriteLine("push something");
            Console.ReadLine();
            do
            {     
                
                count++;
                Console.WriteLine($"#{count} Which one type of fruit would you like put?");
                name = Console.ReadLine().ToLower();
                Console.WriteLine("How many fruit would you like put (kg.)?");
                amount = Convert.ToInt32(Console.ReadLine());
                objectAdd.Add(new Grocery(count,name,amount));
                Console.WriteLine();
                Console.WriteLine("Would you like to continue? y/n");
                choice = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
            } while (choice == 'y');

            Console.WriteLine();
            Console.WriteLine("Your list:");
            var AllList = objectAdd.GetAll();
            foreach (var item in AllList)
            {
                Console.WriteLine($"#{item.number}:  {item.name}  {item.total}");
            }


            // Displaying ready collection
            Console.WriteLine("Showing the alternative way using array anf then throw to IEnumerable list ");
            Console.WriteLine();
            Grocery[] groceriesAlternativeList =  // deploying array
            {
                new Grocery(1,"banana",10),
                new Grocery(2,"orange",1231),
                new Grocery (3,"pineapple",2)
            };


            AddRemoveDisplay.PrintCollection(groceriesAlternativeList);


            Console.WriteLine();
            Console.WriteLine();
            // Displaying ready collection
            Console.WriteLine("Showing the alternative way using List based on Grocery object and then throw to IEnumerable list ");
            Console.WriteLine();
            List<Grocery> grocList = new List<Grocery> // in the same manner deploy List<>
            {
                new Grocery(1,"banana",10),
                new Grocery(2,"orange",1231),
                new Grocery (3,"pineapple",2)
            };


            AddRemoveDisplay.PrintCollection(grocList);
        }
    }
}
