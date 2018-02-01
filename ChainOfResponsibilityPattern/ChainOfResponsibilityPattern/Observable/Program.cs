using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Observable
{
    public class Program
    {
        // Refer https://en.wikipedia.org/wiki/Observer_pattern
        public static void Run()
        {
            var subject = new Subject();
            var observerOne = new ObserverOne();
            var observerTwo = new ObserverTwo();

            subject.Register(observerOne);
            subject.Register(observerTwo);

            subject.Notify("Notification is on the way");

        }
    }
}
