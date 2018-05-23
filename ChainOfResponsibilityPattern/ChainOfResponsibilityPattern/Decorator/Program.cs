using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Decorator
{
    public class Program
    {
        static IPizzaProvider CreatePizza()
        { 
            return new BasePizza();
        }

        static IPizzaProvider CreateCheezePizza()
        {
            return new ExtraCheese(new BasePizza());
        }

        static IPizzaProvider CreateChickenCheezePizza()
        {
            return new ExtraChicken(new ExtraCheese(new BasePizza()));
        }

        public static void Run()
        {
            var basePizza = CreatePizza();
            var cheesePizza = CreateCheezePizza();
            var chickenCheesePizza = CreateChickenCheezePizza();

            Console.WriteLine(basePizza.GetPrice());
            Console.WriteLine(basePizza.GetPizza());
            Console.WriteLine();
            Console.WriteLine(cheesePizza.GetPrice());
            Console.WriteLine(cheesePizza.GetPizza());
            Console.WriteLine();
            Console.WriteLine(chickenCheesePizza.GetPrice());
            Console.WriteLine(chickenCheesePizza.GetPizza());
        }
    }
}
