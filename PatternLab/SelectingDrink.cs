using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLab
{
    public class SelectingDrink : ICoffeeMachineState
    {
        private CoffeeMachine _coffeeMachine;

        public SelectingDrink(CoffeeMachine coffeeMachine)
        {
            _coffeeMachine = coffeeMachine;
        }

        public void InsertCoin() => Console.WriteLine("Монета уже внесена.");
        public void SelectDrink()
        {
            Console.WriteLine("Напиток выбран.");
            _coffeeMachine.SetState(new DispensingDrink(_coffeeMachine));
        }

        public void DispenseDrink() => Console.WriteLine("Сначала выберите напиток.");
    }
}
