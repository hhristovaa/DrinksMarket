using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinksMarket.Models
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Coffee Drinks", Description="Coffee drins for every taste"},
                new Category{CategoryId=2, CategoryName="Tea drinks", Description="Fruit and herbal teas for every taste"},
                new Category{CategoryId=3, CategoryName="Homemade Lemonades", Description="Refreshing homemade lemonades"}
            };
    }
}
