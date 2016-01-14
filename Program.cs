using System;
using System.Configuration;
using System.Reactive.Linq;
using DataGenerator.Sinks;

namespace DataGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Fare.Xeger(ConfigurationSettings.AppSettings["pattern"]);

            var tick = TimeSpan.Parse(ConfigurationSettings.AppSettings["timespan"]);

            var observable = Observable
                .Timer(TimeSpan.Zero, tick)
                .Select(t => data.Generate());

            new ConsoleSink().Subscribe(observable);

            Console.ReadLine();
        }
    }
}
