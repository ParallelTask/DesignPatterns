using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.PublishSubscribe
{
    public interface ISubscriber
    {
        void SetBroker(IBroker broker);

        void OnMessage(string message);

        void SetTopic(string topic);
    }
}
