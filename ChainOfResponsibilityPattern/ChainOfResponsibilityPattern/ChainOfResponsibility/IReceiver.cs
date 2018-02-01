using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.ChainOfResponsibility
{
    // also treated as IHandler
    public interface IReceiver
    {
        void SetNext(IReceiver receiver);
        void InvokeNext(string request);
    }
}
