using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.PublishSubscribe
{
    public interface IBroker
    {
        void Publish(string topic, string message);

        void Subscribe(string topic, Action<string> handler);

        void UnSubscribe(string topic, Action<string> handler);

        void CreateTopic(string topic);
    }
}
