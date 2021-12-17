using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinksMarket.Models
{
    public class MockDrinkRepository: IDrinkRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

            public IEnumerable<Drink> AllDrinks =>
                new List<Drink>
                {
                    new Drink {DrinkId=1, Name="Espresso", Price=2.5M, ShortDescription="Locally-roasted organic blend", LongDescription="We can serve it with one or two shots of espresso.", Category= _categoryRepository.AllCategories.ToList()[0], ImageUrl="", IsDrinkOfTheWeek=true},
                    new Drink {DrinkId=2, Name="Raspberry Lemonade", Price=4.9M, ShortDescription="Homemade cold drink", LongDescription="Sweet and refreshing fizzy drink. Served with ice and fruit pieces.",  Category= _categoryRepository.AllCategories.ToList()[2], ImageUrl=""},
                    new Drink {DrinkId=3, Name="Latte Macchiato", Price=4.5M, ShortDescription="Served with fluffy milk", LongDescription="Foamed whole milk marked with shots of espresso.",  Category= _categoryRepository.AllCategories.ToList()[0], ImageUrl="", IsDrinkOfTheWeek=true},
                    new Drink {DrinkId=4, Name="Green tea", Price=4M, ShortDescription="Green tea - classic or blend", LongDescription="Green tea gives you the uplift you need to stay focused and embrace whatever comes your way.",  Category= _categoryRepository.AllCategories.ToList()[1], ImageUrl="", IsDrinkOfTheWeek=true},
                    new Drink {DrinkId=5, Name="Fruit tea", Price=3.5M, ShortDescription="Fruit tea by choice - served hot", LongDescription="Fruit tea is an infusion made from cut pieces of fruit and plants, which can either be fresh or dried.",  Category= _categoryRepository.AllCategories.ToList()[1], ImageUrl="", IsDrinkOfTheWeek=false}
                };
        
        public IEnumerable<Drink> DrinksOfTheWeek { get; }
        public Drink GetDrinkById(int drinkId)
        {
            return AllDrinks.FirstOrDefault(d => d.DrinkId == drinkId);
        }
    }
}
