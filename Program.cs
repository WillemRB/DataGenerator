using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Fare.Xeger(ConfigurationSettings.AppSettings["pattern"]);

            var tick = TimeSpan.Parse(ConfigurationSettings.AppSettings["timespan"]);

            Observable
                .Timer(TimeSpan.Zero, tick)
                .Subscribe(
                    t => { Console.WriteLine(data.Generate()); }
                );

            Console.ReadLine();
        }
    }
}
