using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Decorator
{
    public abstract class PizzaDecorator: IPizzaProvider
    {
        protected IPizzaProvider _pizzaProvider;

        public PizzaDecorator(IPizzaProvider pizzaProvider)
        {
            _pizzaProvider = pizzaProvider;
        }

        public abstract string GetPizza();
        public abstract int GetPrice();
        public abstract void SetPizza(string pizza);
        public abstract void SetPrice(int price);
    }
}
