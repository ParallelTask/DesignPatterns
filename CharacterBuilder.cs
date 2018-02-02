using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Builder
{
    public class CharacterBuilder : ICharacterBuilder
    {
        private bool _hasShoes { get; set; }
        private string _hairColor { get; set; }
        private string _shirtColor { get; set; }
        private bool _hasGun { get; set; }
        private bool _hasArrow { get; set; }

        public void AddArrow()
        {
            _hasArrow = true;
        }

        public void RemoveArrow()
        {
            _hasArrow = false;
        }

        public void AddGun()
        {
            _hasGun = true;
        }

        public void RemoveGun()
        {
            _hasGun = false;
        }

        public void AddShoes()
        {
            _hasShoes = true;
        }

        public void RemoveShoes()
        {
            _hasShoes = false;
        }

        public void ChangeHairColor(string color)
        {
            _hairColor = color;
        }

        public void ChangeShirt(string color)
        {
            _shirtColor = color;
        }

        public ICharacter Build()
        {
            return new Character() { HairColor = _hairColor, HasArrow = _hasArrow, HasGun = _hasGun, HasShoes = _hasShoes, ShirtColor = _shirtColor };
        }
    }
}
