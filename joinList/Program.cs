using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joinList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Item_mast> itemlist = new List<Item_mast>
        {
            new Item_mast { ItemId = 1, ItemDes = "Juce  " },
            new Item_mast { ItemId = 2, ItemDes = "Chocolate" },
            new Item_mast { ItemId = 3, ItemDes = "milk   " },
            new Item_mast { ItemId = 4, ItemDes = "meat    " },
            new Item_mast { ItemId = 5, ItemDes = "beef    " }
        };

            // Creating a list of Purchase objects with InvNo, ItemId, and PurQty properties
            List<Purchase> purchlist = new List<Purchase>
        {
            new Purchase { InvNo=00, ItemId = 3,  PurQty = 800 },
            new Purchase { InvNo=01, ItemId = 2,  PurQty = 650 },
            new Purchase { InvNo=02, ItemId = 3,  PurQty = 900 },
            new Purchase { InvNo=03, ItemId = 4,  PurQty = 700 },
            new Purchase { InvNo=04, ItemId = 3,  PurQty = 900 },
            new Purchase { InvNo=05, ItemId = 4,  PurQty = 650 },
            new Purchase { InvNo=06, ItemId = 1,  PurQty = 458 }
        };

            // Printing a prompt for the inner join operation
            Console.Write("\nLINQ : Generate an Inner Join between two data sets : ");
            Console.Write("\n--------------------------------------------------\n");
            Console.Write("Here is the Item_mast List : ");
            Console.Write("\n-------------------------\n");

            // Displaying the content of the itemlist
            foreach (var item in itemlist)
            {
                Console.WriteLine(
                    "Item Id: {0}, Description: {1}",
                    item.ItemId,
                    item.ItemDes);
            }

            Console.Write("\nHere is the Purchase List : ");
            Console.Write("\n--------------------------\n");

            // Displaying the content of the purchlist
            foreach (var item in purchlist)
            {
                Console.WriteLine(
                    "Invoice No: {0}, Item Id : {1},  Quantity : {2}",
                    item.InvNo,
                    item.ItemId,
                    item.PurQty);
            }

            Console.Write("\nHere is the list after joining  : \n\n");

            // Performing an inner join between itemlist and purchlist based on matching ItemId
            var innerJoin = from e in itemlist
                            join d in purchlist on e.ItemId equals d.ItemId
                            select new
                            {
                                itid = e.ItemId,
                                itdes = e.ItemDes,
                                prqty = d.PurQty,
                                cost = d.PurQty * 44.50
                            };

            // Displaying the result of the inner join
            Console.WriteLine("Item ID\t\tItem Name\tQuantity\t\tCost");
            Console.WriteLine("-------------------------------------------------------");
            foreach (var data in innerJoin)
            {
                Console.WriteLine(data.itid + "\t\t" + data.itdes + "\t\t" + data.prqty + "\t\t" + data.cost);
            }

            Console.ReadLine();

        }
    }

   
}
