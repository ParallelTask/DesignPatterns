using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Prototype
{
    // This pattern should be followed, if the cost of creating a new object is expensive and resource intensive.
    // The concept is to copy an existing object rather than creating a new instance from scratch, 
    // something that may include costly operations.
    // Refer: https://www.geeksforgeeks.org/prototype-design-pattern/
    // Prototype pattern is useful in cases where we share the same object reference to save memory
    // for example, if two objects are using the same object as a member, 
    // then we can have both the objects pointing to the same reference object but only for read-only 
    // If once the object is writable by any of the other object then the clone of that object is created
    // this is how prototype pattern helps in saving memory also, 
    // this is what javascript actually implements prototypal inheritance for memory saving
    public class Program
    {
        public static void Run()
        {
            ICharacter character = new Character();

            // some complex operations to set properties of object
            character.HairColor = "blacks";
            character.ShirtColor = "red";

            ICharacter clonedCopy = character.Clone();

            if(clonedCopy != character)
            {
                Console.WriteLine("Character is cloned");
            }
        }
    }
}
