using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayingSpecifiedDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime myDate = DateTime.Now;
            Console.WriteLine($"The day of the week {myDate} is {myDate.DayOfWeek} "); //  use fiel DayofWeek for DateTime object  


        }
    }
}
