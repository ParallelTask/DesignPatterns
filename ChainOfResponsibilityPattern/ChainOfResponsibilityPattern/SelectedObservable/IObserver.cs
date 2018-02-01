using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.SelectedObservable
{
    public interface IObserver
    {
        string Name { set; get; }
        void Onnotify(string message);
    }
}
