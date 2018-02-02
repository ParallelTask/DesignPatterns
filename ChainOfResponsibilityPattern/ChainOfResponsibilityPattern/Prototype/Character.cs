using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Prototype
{
    public class Character : ICharacter
    {
        public bool HasShoes { get; set; }
        public string HairColor { get; set; }
        public string ShirtColor { get; set; }
        public bool HasGun { get; set; }
        public bool HasArrow { get; set; }

        public Character()
        {

        }

        // Must have a Constructor that have all properties injected to it
        public Character(bool hasShoes, string hairColor, string shirtColor, bool hasGun, bool hasArrow)
        {
            HasShoes = hasShoes;
            HairColor = hairColor;
            ShirtColor = shirtColor;
            HasGun = hasGun;
            HasArrow = hasArrow;
        }

        public ICharacter Clone()
        {
            return new Character(HasShoes, HairColor, ShirtColor, HasGun, HasArrow);
        }
    }
}
