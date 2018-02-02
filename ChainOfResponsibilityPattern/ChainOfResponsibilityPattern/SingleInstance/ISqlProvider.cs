using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.SingleInstance
{
    // Can be treated as Singleton class
    public interface ISqlProvider
    {
        // Some methods
        void Insert();
    }
}
