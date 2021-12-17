using DrinksMarket.Models;
using DrinksMarket.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinksMarket.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDrinkRepository _drinkRepository;
        public HomeController(IDrinkRepository drinkRepository)
        {
            _drinkRepository = drinkRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                DrinksOfTheWeek = _drinkRepository.DrinksOfTheWeek
        };
            return View(homeViewModel);
        }
    }
}
