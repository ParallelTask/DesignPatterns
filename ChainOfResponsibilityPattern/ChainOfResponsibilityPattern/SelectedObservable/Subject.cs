using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.SelectedObservable
{
    public class Subject : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void Notify(string[] observerNames, string message)
        {
            // Invoke only the specified observers
            _observers
                .Where(x => observerNames.Any(y => y == x.Name))
                .ToList()
                .ForEach(x => x.Onnotify(message));
        }

        public void Register(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            // Unregister the observer
            throw new NotImplementedException();
        }
    }
}
