using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var gen = new Fare.Xeger(ConfigurationSettings.AppSettings["pattern"]);

            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(gen.Generate());
            }

            Console.ReadLine();
        }
    }
}
