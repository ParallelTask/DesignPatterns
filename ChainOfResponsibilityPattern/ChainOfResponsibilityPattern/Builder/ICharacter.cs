using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Builder
{
    public interface ICharacter
    {
        bool HasShoes { get; set; }
        string HairColor { get; set; }
        string ShirtColor { get; set; }
        bool HasGun { get; set; }
        bool HasArrow { get; set; }
        void Print();
    }
}
