using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.SelectedObservable
{
    public class ObserverTwo : IObserver
    {
        public string Name { get; set; }

        public void Onnotify(string message)
        {
            Console.WriteLine($"ObserverTwo got the message: {message}");
        }
    }
}
