using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Observable
{
    public class ObserverOne : IObserver
    {
        public void Onnotify(string message)
        {
            Console.WriteLine($"ObserverOne got the message: {message}");
        }
    }
}
