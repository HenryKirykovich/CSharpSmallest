using System.Runtime.CompilerServices;
using TestShop.Interfaces;
using TestShop.Models;


namespace TestShop.Mocks
{
    public class MockCategory : ICarCategory   // the Class release Category of car AND release Mocks for implementing Interface  
    {
        public IEnumerable<Category> AllCategories {


            get {
                return new List<Category>() {
                    new Category { CategoryName = "Electrical car", Description = "Modern Car"},
                    new Category { CategoryName = "Classical car", Description = "Oil' car"}




                };
            }

        }
        
        // this is the same approach of implementing interface (work the same): gather category and than collect them inside IEnumerable 

    //{
    ////  gather Category object via list
    //private List<Category> categories = new List<Category>
    //{
    //    new Category { CategoryName = "Electrical car", Description = "Modern Car" },
    //    new Category { CategoryName = "Classical car", Description = "Oil' car" }
    //};

    //    // Property returning the backing field from list 
    //    public IEnumerable<Category> AllCategories
    //    {
    //        get { return categories; }
    //    }
    //}


    }
}
