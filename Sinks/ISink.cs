using System;

namespace DataGenerator.Sinks
{
    interface ISink
    {
        IDisposable Subscribe(IObservable<string> observable);
    }
}
