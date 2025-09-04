
class SortingWithLINQ
{
    static void Main(string[] args)
    {
        // Array of cities
        string[] cities =
        {
            "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
        };

        // Displaying the instruction for the operation
        Console.Write("\nLINQ : Display the list according to the length then by name in ascending order : ");
        Console.Write("\n--------------------------------------------------------------------------------\n");
        Console.Write("\nThe cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS' \n");
        Console.Write("\nHere is the arranged list :\n");

        // Ordering the cities first by length and then by name in ascending order using LINQ
        IEnumerable<string> cityOrder =
            cities.OrderBy(str => str.Length) // Order the cities by their lengths
                  .ThenBy(str => str);         // Then order them alphabetically if lengths are equal

        // Displaying the sorted cities
        foreach (string city in cityOrder)
        {
            Console.WriteLine(city);
        }

        Console.ReadLine(); // Wait for user input before closing the console
    }
}