using TestShop.Models;

namespace TestShop.Interfaces
{
    public interface ICarCategory
    {
        IEnumerable<Category> AllCategories { get; }


    }
}
