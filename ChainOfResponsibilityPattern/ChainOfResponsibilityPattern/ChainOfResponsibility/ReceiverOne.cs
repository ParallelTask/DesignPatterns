using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.ChainOfResponsibility
{
    public class ReceiverOne : IReceiver
    {
        private IReceiver _next;

        public void InvokeNext(string request)
        {
            Console.WriteLine($" ReceiverOne recieved the request: {request}");
            if (_next != null)
            {
                _next.InvokeNext(request);
            }
            else
            {
                Console.WriteLine($" No more Recievers...");
            }
        }

        public void SetNext(IReceiver receiver)
        {
            _next = receiver;
        }
    }
}
