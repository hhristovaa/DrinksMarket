﻿using DrinksMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinksMarket.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Drink> DrinksOfTheWeek { get; set; }
    }
}
