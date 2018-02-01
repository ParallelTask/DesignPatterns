using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.SelectedObservable
{
    public static class ObserversConstant
    {
        public static string[] observerOne = new string[] { "observer_one" };
        public static string[] observerTwo = new string[] { "observer_two" };
        public static string[] observerThree = new string[] { "observer_three" };
        public static string[] observerOne_observerTwo = new string[] { "observer_one", "observer_two" };
        public static string[] observerOne_observerThree = new string[] { "observer_one", "observer_three" };
        public static string[] observerTwo_observerThree = new string[] { "observer_two", "observer_three" };
        public static string[] observerOne_observerTwo_observerThree = new string[] { "observer_one", "observer_two", "observer_three" };
    }
}
