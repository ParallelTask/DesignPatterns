using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Prototype
{
    // We can refer ICloneable as IPrototype, both are similar
    public interface IClonable<T>
    {
        T Clone();
    }
}
