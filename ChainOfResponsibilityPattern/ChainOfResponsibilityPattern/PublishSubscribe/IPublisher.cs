using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.PublishSubscribe
{
    public interface IPublisher
    {
        void Publish(string topic, string message);

        void SetBroker(IBroker broker);
    }
}
