using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // collecting information from input: 
            My_Dictionary_List home = new My_Dictionary_List();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Set number phone");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Set Last Name");
                string Lname = Console.ReadLine();
                Console.WriteLine("Set First Name");
                string Fname = Console.ReadLine();

                // Create a new dictionary for each entry in the 'home' dictionary
                var Lfname = new Dictionary<string, string>
            {
                { "FirstName", Fname },
                { "LastName", Lname }
            };

                // Add to the 'home' dictionary with 'number' as the key and Lfname as the nested dictionary
                home.home.Add(number, Lfname); 
            }

            // Display the contents to verify
            foreach (var entry in home.home)
            {
                Console.WriteLine($"Phone Number: {entry.Key}");
                foreach (var nameEntry in entry.Value)
                {
                    Console.WriteLine($"{nameEntry.Key}: {nameEntry.Value}");
                }
            }


        }
    }
}
