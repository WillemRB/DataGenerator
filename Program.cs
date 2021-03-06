﻿using System;
using System.Configuration;
using System.Reactive.Linq;
using DataGenerator.Sinks;

namespace DataGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Fare.Xeger(ConfigurationManager.AppSettings["pattern"]);

            var tick = TimeSpan.Parse(ConfigurationManager.AppSettings["timespan"]);

            var observable = Observable
                .Timer(TimeSpan.Zero, tick)
                .Select(t => data.Generate());

            new ConsoleSink().Subscribe(observable);
            new FileSink("data.txt").Subscribe(observable);

            Console.ReadLine();
        }
    }
}
