﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLab
{
    // Паттерн State
    public interface ICoffeeMachineState
    {
        void InsertCoin();
        void SelectDrink();
        void DispenseDrink();
    }
}
