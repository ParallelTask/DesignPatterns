using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.SelectedObservable
{
    public class Program
    {
        public static void Run()
        {
            var subject = new Subject();
            var observerOne = new ObserverOne() { Name = "observer_one" };
            var observerTwo = new ObserverTwo() { Name = "observer_two" };
            var observerThree = new ObserverThree() { Name = "observer_three" };

            subject.Register(observerOne);
            subject.Register(observerTwo);
            subject.Register(observerThree);

            subject.Notify(ObserversConstant.observerOne_observerThree, "First Notification is on the way");
            subject.Notify(ObserversConstant.observerTwo, "Second Notification is on the way");
            subject.Notify(ObserversConstant.observerOne_observerTwo_observerThree, "Third Notification is on the way");
            subject.Notify(ObserversConstant.observerTwo_observerThree, "Fourth Notification is on the way");
        }
    }
}
