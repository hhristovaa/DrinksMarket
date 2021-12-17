using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinksMarket.Models
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> AllDrinks { get; }
        IEnumerable<Drink> DrinksOfTheWeek { get; }
        Drink GetDrinkById(int drinkId);
    }
}
