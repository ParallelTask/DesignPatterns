using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Decorator
{
    public interface IPizzaProvider
    {
        int GetPrice();
        void SetPrice(int price);
        string GetPizza();
        void SetPizza(string pizza);
    }
}
