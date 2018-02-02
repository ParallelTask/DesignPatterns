using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Builder
{
    public class Character : ICharacter
    {
        public bool HasShoes { get; set; }
        public string HairColor { get; set; }
        public string ShirtColor { get; set; }
        public bool HasGun { get; set; }
        public bool HasArrow { get; set; }

        // Must have a Constructor that have all properties injected to it
        public Character(bool hasShoes, string hairColor, string shirtColor, bool hasGun, bool hasArrow)
        {
            HasShoes = hasShoes;
            HairColor = hairColor;
            ShirtColor = shirtColor;
            HasGun = hasGun;
            HasArrow = hasArrow;
        }

        public void Print()
        {
            Console.WriteLine($"HasShoes: {HasShoes}, HairColor: {HairColor}, ShirtColor: {ShirtColor}, HasGun: {HasGun}, HasArrow: {HasArrow}");
        }
    }
}
