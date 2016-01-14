using System;

namespace DataGenerator.Sinks
{
    public class ConsoleSink : ISink
    {
        public IDisposable Subscribe(IObservable<string> observable)
        {
            return observable.Subscribe(Console.WriteLine);
        }
    }
}
