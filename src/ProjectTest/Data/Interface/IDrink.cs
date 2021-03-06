﻿using ProjectTest.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTest.Data.Interface
{
    public interface IDrink
    {
        IEnumerable<Drink> Drinks { get; }

        IEnumerable<Drink> PreferredDrinks { get; }

        Drink GetDrinkById(int drinkId);


    }
}
