using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLab
{
    public class WaitingForCoin : ICoffeeMachineState
    {
        private CoffeeMachine _coffeeMachine;

        public WaitingForCoin(CoffeeMachine coffeeMachine)
        {
            _coffeeMachine = coffeeMachine;
        }

        public void InsertCoin()
        {
            Console.WriteLine("Монета внесена.");
            _coffeeMachine.SetState(new SelectingDrink(_coffeeMachine));
        }

        public void SelectDrink() => Console.WriteLine("Сначала внесите монету.");
        public void DispenseDrink() => Console.WriteLine("Сначала внесите монету.");
    }
}
