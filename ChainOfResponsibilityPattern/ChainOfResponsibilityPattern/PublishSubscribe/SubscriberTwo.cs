using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.PublishSubscribe
{
    public class SubscriberTwo : ISubscriber
    {
        private IBroker _broker;

        public void OnMessage(string message)
        {
            Console.WriteLine($"SubscriberTwo recieved the message: {message}");
        }

        public void SetBroker(IBroker broker)
        {
            _broker = broker;
        }

        public void SetTopic(string topic)
        {
            _broker.Subscribe(topic, OnMessage);
        }
    }
}
