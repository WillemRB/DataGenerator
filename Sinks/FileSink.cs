using System;
using System.IO;

namespace DataGenerator.Sinks
{
    public class FileSink : ISink<string>
    {
        public string FilePath { get; private set; }

        public FileSink(string path)
        {
            FilePath = path;
        }

        public IDisposable Subscribe(IObservable<string> observable)
        {
            return observable.Subscribe(AppendToFile);
        }

        private void AppendToFile(string line)
        {
            using (var f =
                !File.Exists(FilePath)
                    ? File.CreateText(FilePath)
                    : File.AppendText(FilePath))
            {
                f.WriteLine(line);
            }
        }
    }
}
