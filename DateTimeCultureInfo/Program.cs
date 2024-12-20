using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeCultureInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // current local date and time
            DateTime localDate = DateTime.Now;

            // UTC (Coordinated Universal Time) date and time
            DateTime utcDate = DateTime.UtcNow;

            // Array of culture names
            String[] cultureNames = { "lt-LT", "en-US" };

          
            foreach (var cultureName in cultureNames)
            {
                // Create a CultureInfo object for the current culture name
                var culture = new CultureInfo(cultureName);

                // Display the native name of the culture
                Console.WriteLine("{0}:", culture.NativeName);

                // Display the local date and time in the current culture format
                // property 'Kind' describes the specific area for time/date
                Console.WriteLine($"Local date and time: {localDate.ToString(culture)} // {localDate.Kind}");  //  2024-12-20 14:56:14  for LT or  US 12/20/2024 2:56:14 PM


                // Display the UTC date and time in the current culture format

                Console.WriteLine($"Local date and time: {utcDate.ToString(culture)} // UTC ");



                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
