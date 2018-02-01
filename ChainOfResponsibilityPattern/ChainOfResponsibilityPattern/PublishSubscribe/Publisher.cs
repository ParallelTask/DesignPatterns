using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.PublishSubscribe
{
    public class Publisher : IPublisher
    {
        private IBroker _broker;

        public void Publish(string topic, string message)
        {
            _broker.Publish(topic, message);
        }

        public void SetBroker(IBroker broker)
        {
            _broker = broker;
        }
    }
}
