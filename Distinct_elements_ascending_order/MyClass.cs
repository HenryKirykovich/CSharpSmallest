
class MyClass
{
    static void Main(string[] args)
    {
        // Displaying the instruction for the operation
        Console.Write("\nLINQ : Arrange distinct elements in the list in ascending order : ");
        Console.Write("\n----------------------------------------------------------------\n");

        // Retrieving the item descriptions from the GetItemMast method and arranging distinct elements in ascending order
        var itemlist = (from c in Item_Mast.GetItemMast()
                        select c.ItemDes)
                        .Distinct() // Getting distinct item descriptions
                        .OrderBy(x => x); // Sorting the distinct item descriptions in ascending order

        // Displaying the arranged distinct elements
        foreach (var item in itemlist)
        {
            Console.WriteLine(item);
        }

        Console.ReadLine(); // Wait for user input before closing the console
    }
}

class Item_Mast
{
    public int ItemId { get; set; }
    public string ItemDes { get; set; }

    // Method to retrieve a list of Item_Mast objects
    public static List<Item_Mast> GetItemMast()
    {
        // Creating and returning a list of Item_Mast objects with sample data
        List<Item_Mast> itemlist = new List<Item_Mast>();
        itemlist.Add(new Item_Mast() { ItemId = 1, ItemDes = "Biscuit  " });
        itemlist.Add(new Item_Mast() { ItemId = 2, ItemDes = "Honey    " });
        itemlist.Add(new Item_Mast() { ItemId = 3, ItemDes = "Butter   " });
        itemlist.Add(new Item_Mast() { ItemId = 4, ItemDes = "Brade    " });
        itemlist.Add(new Item_Mast() { ItemId = 5, ItemDes = "Honey    " });
        itemlist.Add(new Item_Mast() { ItemId = 6, ItemDes = "Biscuit  " });

        return itemlist;
    }
}
