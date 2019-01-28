using System;
using Microsoft.ServiceBus.Messaging;

namespace DataGenerator.Sinks
{
    public class EventHubMessage
    {
        public DateTime Timestamp { get; set; }

        public string Message { get; set; }
    }

    public class EventHubSink : ISink<EventHubMessage>
    {
        public IDisposable Subscribe(IObservable<EventHubMessage> observable)
        {
            return null;   
        }
    }
}
