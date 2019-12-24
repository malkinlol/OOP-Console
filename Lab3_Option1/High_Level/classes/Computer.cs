using System;

namespace High_Level.classes
{
    public class Computer : IDisposable
    {
        public OS OS { get; set; }

        public void Dispose()
        {
            Console.WriteLine("Dispose");
        }

        public void Launch(string osName)
        {
            OS = OS.GetOS(osName);
        }
    }
}
