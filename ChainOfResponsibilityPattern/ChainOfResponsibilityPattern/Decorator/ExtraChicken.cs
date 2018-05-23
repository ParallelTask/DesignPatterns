using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Decorator
{
    public class ExtraChicken : PizzaDecorator
    {
        public ExtraChicken(IPizzaProvider pizzaProvider) : base(pizzaProvider)
        {
            this.SetPrice(30);
            this.SetPizza("_Chicken_Pizza");
        }

        public override string GetPizza()
        {
            return _pizzaProvider.GetPizza();
        }

        public override int GetPrice()
        {
            return _pizzaProvider.GetPrice();
        }

        public override void SetPizza(string pizza)
        {
            _pizzaProvider.SetPizza(pizza);
        }

        public override void SetPrice(int price)
        {
            _pizzaProvider.SetPrice(price);
        }
    }
}
