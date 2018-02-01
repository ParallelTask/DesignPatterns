using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.ChainOfResponsibility
{
    public class Program
    {
        // Refer https://en.wikipedia.org/wiki/Chain-of-responsibility_pattern
        public static void Run()
        {
            var recieverOne = new ReceiverOne();
            var recieverTwo = new ReceiverTwo();
            var recieverThree = new ReceiverThree();

            recieverOne.SetNext(recieverTwo);
            recieverTwo.SetNext(recieverThree);

            recieverOne.InvokeNext("Request is being sent");
        }
    }
}
