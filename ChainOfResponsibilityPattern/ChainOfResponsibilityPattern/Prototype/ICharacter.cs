using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Prototype
{
    public interface ICharacter : IClonable<ICharacter>
    {
        bool HasShoes { get; set; }
        string HairColor { get; set; }
        string ShirtColor { get; set; }
        bool HasGun { get; set; }
        bool HasArrow { get; set; }
    }
}
