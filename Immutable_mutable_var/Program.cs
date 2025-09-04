using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutable_mutable_var
{
    public delegate bool Filter(int value);

    internal class Program
    {

        static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            // Use Func<int, bool> instead of a custom delegate
            Func<int, bool> isEven = value => value % 2 == 0;

            // Filter the list
            List<int> evenNumbers = Filter(numbers, isEven);

            Console.WriteLine("Even Numbers:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
        }

        static List<int> Filter(List<int> list, Func<int, bool> filter)
        {
            List<int> result = new List<int>();
            foreach (var item in list)
            {
                if (filter(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
