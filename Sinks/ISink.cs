using System;

namespace DataGenerator.Sinks
{
    interface ISink<T>
    {
        IDisposable Subscribe(IObservable<T> observable);
    }
}
