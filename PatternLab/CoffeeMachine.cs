using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLab
{
    public class CoffeeMachine
    {
        private ICoffeeMachineState _state;

        public CoffeeMachine(ICoffeeMachineState initialState)
        {
            _state = initialState;
        }

        public void SetState(ICoffeeMachineState state)
        {
            _state = state;
        }

        public void InsertCoin() => _state.InsertCoin();
        public void SelectDrink() => _state.SelectDrink();
        public void DispenseDrink() => _state.DispenseDrink();
    }
}
