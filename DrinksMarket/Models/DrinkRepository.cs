using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinksMarket.Models
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly AppDbContext _appDbContext;
        public DrinkRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Drink> AllDrinks
        {
            get
            {
                return _appDbContext.Drinks.Include(c => c.Category);
            }
        }

        public IEnumerable<Drink> DrinksOfTheWeek
        {
            get
            {
                return _appDbContext.Drinks.Include(c => c.Category).Where(d => d.IsDrinkOfTheWeek);
            }
        }

        public Drink GetDrinkById(int drinkId)
        {
            return _appDbContext.Drinks.FirstOrDefault(d => d.DrinkId == drinkId);
        }
    }
}
