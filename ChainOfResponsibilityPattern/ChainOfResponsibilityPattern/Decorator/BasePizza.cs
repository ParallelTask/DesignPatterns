using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Decorator
{
    public class BasePizza : IPizzaProvider
    {
        int price = 100;
        string pizza = "_Base_Pizza";

        public string GetPizza()
        {
            return this.pizza;
        }

        public void SetPizza(string pizza)
        {
            this.pizza += pizza;
        }

        public int GetPrice()
        {
            return this.price;
        }

        public void SetPrice(int price)
        {
            this.price += price;
        }
    }
}
