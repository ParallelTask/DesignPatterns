using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.PublishSubscribe
{
    // In ‘Publisher-Subscriber’ pattern, senders of messages, called publishers, do not program the messages to be sent directly to specific receivers, called subscribers.
    // This means that the publisher and subscriber don’t know about the existence of one another. There is a third component, called broker or message broker or event bus,
    // which is known by both the publisher and subscriber, which filters all incoming messages and distributes them accordingly
    // Refer https://hackernoon.com/observer-vs-pub-sub-pattern-50d3b27f838c
    public class Program
    {
        public static void Run()
        {
            var broker = new Broker();
            var publisher = new Publisher();
            var subscriberOne = new SubscriberOne();
            var subscriberTwo = new SubscriberTwo();

            // Create topics on broker
            broker.CreateTopic("info");
            broker.CreateTopic("warning");

            // Assign brokers
            publisher.SetBroker(broker);
            subscriberOne.SetBroker(broker);
            subscriberTwo.SetBroker(broker);

            // Assign topics
            subscriberOne.SetTopic("info");
            subscriberTwo.SetTopic("warning");
            subscriberTwo.SetTopic("info");

            // Publish the messages
            publisher.Publish("info", "info message sent!");
            publisher.Publish("warning", "warning message sent!");
        }
    }
}
