using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLab
{
    public class DispensingDrink : ICoffeeMachineState
    {
        private CoffeeMachine _coffeeMachine;

        public DispensingDrink(CoffeeMachine coffeeMachine)
        {
            _coffeeMachine = coffeeMachine;
        }

        public void InsertCoin() => Console.WriteLine("Напиток уже готовится.");
        public void SelectDrink() => Console.WriteLine("Напиток уже готовится.");
        public void DispenseDrink()
        {
            Console.WriteLine("Напиток выдан.");
            _coffeeMachine.SetState(new WaitingForCoin(_coffeeMachine));
        }
    }
}
