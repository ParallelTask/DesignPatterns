using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Builder
{
    // builder pattern is just a way to build an object similar to what a constructor does
    // Reference https://stackoverflow.com/questions/328496/when-would-you-use-the-builder-pattern
    // Reference https://en.wikipedia.org/wiki/Builder_pattern
    // .NET StringBuilder class is a great example of builder pattern. It is mostly used to create a string 
    // in a series of steps. The final result you get on doing ToString() is always a string but 
    // the creation of that string varies according to what functions in the StringBuilder class were used.
    // 1. Builder pattern typically used to build object in steps
    // 2. create different representations of a complex object by configurating objects properties
    // 3. using the existing configurarion objects properties, it is easy to build new objects or just by few changes new objects can be built too.
    // 4. Provides control over steps of construction process

    // In short, builder pattern uses another object, a builder, that receives each initialization parameter step by step and 
    // then returns the resulting constructed object at once
    public class Program
    {
        public static void BuilderExample()
        {
            StringBuilder s = new StringBuilder();
            s.Append('a');
            var a = s.ToString();
            s.Append('b');
            var ab = s.ToString();
            Console.WriteLine(a);
            Console.WriteLine(ab);
        }

        public static void Run()
        {
            ICharacterBuilder characterBuilder = new CharacterBuilder();

            characterBuilder.AddArrow();
            characterBuilder.AddShoes();
            characterBuilder.ChangeHairColor("black");
            characterBuilder.ChangeShirt("red");

            ICharacter characterOne = characterBuilder.Build();

            characterBuilder.RemoveArrow();
            characterBuilder.AddGun();
            characterBuilder.ChangeShirt("yellow");

            ICharacter characterTwo = characterBuilder.Build();

            Console.WriteLine("===========CharacterOne=============");
            characterOne.Print();
            Console.WriteLine("===========CharacterTwo=============");
            characterTwo.Print();
        }
    }
}
