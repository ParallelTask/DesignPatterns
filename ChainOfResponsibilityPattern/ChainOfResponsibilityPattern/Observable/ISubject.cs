using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Observable
{
    // Also treated as "IObservable", Subject and Obervable both mean the same.
    public interface ISubject
    {
        void Notify(string message);
        void Register(IObserver observer);
        void Unregister(IObserver observer);
    }
}
