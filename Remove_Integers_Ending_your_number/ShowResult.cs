using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Integers_Ending_your_number
{
    public class ShowResult
    {
        public static void ShowMeResult(List<int> list, int byInt)
        {
            Console.WriteLine();
            Console.WriteLine($"Your new list without number ending by {byInt}");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }

    }
}
