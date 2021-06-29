using System;
using System.Diagnostics;
using System.Text;

namespace Stress
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder s = new StringBuilder();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            for(int i = 0; i < 100000; i++)
            {
                s.Append(i.ToString());
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }
    }
}
