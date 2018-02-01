using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.SelectedObservable
{
    public interface ISubject
    {
        void Notify(string[] observerNames, string message);
        void Register(IObserver observer);
        void Unregister(IObserver observer);
    }
}
