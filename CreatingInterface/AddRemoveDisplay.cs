using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingInterfaceIEnumerable // implementing interface + implementing IEnumerable class
{
    public class AddRemoveDisplay : IAddRemoveDisplay<Grocery>
    {
        private  List<Grocery> _groceryList = new List<Grocery>();

        public void Add(Grocery grocery)
        {
            _groceryList.Add(grocery);
        }

        public void Remove(Grocery grocery)
        {
            _groceryList.Remove(grocery);
        }

        public IEnumerable<Grocery> GetAll()
        {
            return _groceryList;
        }


        public static void PrintCollection(IEnumerable<Grocery> groceryList) // using whatever collection you want 
        {
            foreach (var item in groceryList)
            {
                Console.WriteLine($"#{item.number}: {item.name} = {item.total} kg.");
            }
        }
    }
}
