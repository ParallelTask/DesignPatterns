using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.PublishSubscribe
{
    public class SubscriberOne : ISubscriber
    {
        private IBroker _broker;

        public void OnMessage(string message)
        {
            Console.WriteLine($"SubscriberOne recieved the message: {message}");
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
