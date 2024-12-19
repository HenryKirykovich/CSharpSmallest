using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;  // necessarily use it 

namespace CurrentLocalDate
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // getting the DateTime value that represents the current date and time on the local and show time of another culture centers  
            DateTime my_time_local = DateTime.Now;  // get my date
            DateTime my_UTC_time = DateTime.UtcNow;  // get my UTC date

            Console.WriteLine("My time + UTC");
            Console.WriteLine($" Local date and time:  {my_time_local} ");
            Console.WriteLine($" UTC date and time:  {my_UTC_time} ");   // UTC is a universal time standard used across all nations and continents. 
            Console.WriteLine();



            String[] cultureNames = { "en-IE", "en-ZA", "fr-CA", "de-CH", "ro-RO" };

            foreach (var cultureName in cultureNames)
            {
                // Create a CultureInfo object for the current culture name
                var culture = new CultureInfo(cultureName);

                // Display the native name of the culture
                Console.WriteLine("{0}:", culture.NativeName); // ex. output English (Ireland):
                Console.WriteLine("{0}:", culture.Name);   // en-IE:
                Console.WriteLine("{0}:", culture.DisplayName);
                Console.WriteLine("{0}:", culture.DateTimeFormat.DayNames);

                // Display the local date and time in the current culture format
                // and show the 'Kind' of the DateTime object (local or UTC)
                Console.WriteLine("   Local date and time: {0}, {1:G}",
                                  my_time_local.ToString(culture), my_time_local.Kind);

                // Display the UTC date and time in the current culture format
                // and show the 'Kind' of the DateTime object (always UTC)
                Console.WriteLine("   UTC date and time: {0}, {1:G}\n",
                                  my_UTC_time.ToString(culture), my_UTC_time.Kind);
            }

            Console.WriteLine();

            var my_current_culture = CultureInfo.CurrentCulture;
            Console.WriteLine(my_current_culture);

            Console.WriteLine();
            CultureInfo my_cultureName = new CultureInfo("en-US");
            Console.WriteLine(DateTime.Now);

        }


       
    }
}
