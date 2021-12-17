using DrinksMarket.Models;
using DrinksMarket.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinksMarket.Controllers
{
    public class DrinkController : Controller
    {
        private readonly IDrinkRepository _drinkRepository;
        private readonly ICategoryRepository _categoryRepository;

        public DrinkController(IDrinkRepository drinkRepository, ICategoryRepository categoryRepository)
        {
            _drinkRepository = drinkRepository;
            _categoryRepository = categoryRepository;
        }

        //public ViewResult List()
        //{
        //    DrinksListViewModel drinksListViewModel = new DrinksListViewModel();
        //    drinksListViewModel.Drinks = _drinkRepository.AllDrinks;
        //    drinksListViewModel.CurrentCategory = "Homemade Lemonades";
        //    return View(drinksListViewModel);
        //}

        public IActionResult Details(int id)
        {
            var drink = _drinkRepository.GetDrinkById(id);
            if(drink == null)
            
                return NotFound();
            return View(drink);
            
        }

        public ViewResult List(string category)
        {
            IEnumerable<Drink> drinks;
            string currentCategory;
            if (string.IsNullOrEmpty(category))
            {
                drinks = _drinkRepository.AllDrinks.OrderBy(d => d.DrinkId);
                currentCategory = "All Drinks";
            }
            else
            {
                drinks = _drinkRepository.AllDrinks.Where(d => d.Category.CategoryName == category)
                    .OrderBy(d => d.DrinkId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new DrinksListViewModel
            {
                Drinks = drinks,
                CurrentCategory = currentCategory

            });
        }
    }
}
