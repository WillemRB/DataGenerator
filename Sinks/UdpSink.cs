using System;
using System.Net.Sockets;
using System.Text;

namespace DataGenerator.Sinks
{
    public class UdpSink : ISink
    {
        private readonly UdpClient _client;

        public UdpSink(string host = "127.0.0.1", int port = 514)
        {
            _client = new UdpClient(host, port);
        }

        public IDisposable Subscribe(IObservable<string> observable)
        {
            return observable.Subscribe(d =>
            {
                var bytes = Encoding.ASCII.GetBytes(d);

                _client.Send(bytes, bytes.Length);
            });
        }
    }
}
