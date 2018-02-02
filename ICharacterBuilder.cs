using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Builder
{
    public interface ICharacterBuilder
    {
        void AddShoes();
        void RemoveShoes();
        void ChangeShirt(string color);
        void AddGun();
        void RemoveGun();
        void AddArrow();
        void RemoveArrow();
        void ChangeHairColor(string color);
        ICharacter Build();
    }
}
