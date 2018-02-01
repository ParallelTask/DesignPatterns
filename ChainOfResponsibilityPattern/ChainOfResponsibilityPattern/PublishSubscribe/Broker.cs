using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.PublishSubscribe
{
    public class Broker : IBroker
    {
        // Maintain the list of subscribers to be invoked for a given topic
        private IDictionary<string, List<Action<string>>> _subscribers = new Dictionary<string, List<Action<string>>>();

        public void CreateTopic(string topic)
        {
            var key = _subscribers.Keys.Where(x => x == topic).Select(x => x).FirstOrDefault();

            if (key == null)
            {
                _subscribers[topic] = new List<Action<string>>();
            }
        }

        public void Publish(string topic, string message)
        {
            var key = _subscribers.Keys.Where(x => x == topic).Select(x => x).FirstOrDefault();

            if(key != null)
            {
                _subscribers[key].ForEach(x => x(message));
            }
        }

        public void Subscribe(string topic, Action<string> handler)
        {
            var key = _subscribers.Keys.Where(x => x == topic).Select(x => x).FirstOrDefault();

            if (key != null)
            {
                _subscribers[key].Add(handler);
            }
        }

        public void UnSubscribe(string topic, Action<string> handler)
        {
            throw new NotImplementedException();
        }
    }
}
