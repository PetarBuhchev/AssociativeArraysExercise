using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Text;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            StringBuilder text = new StringBuilder();
            for (BigInteger i = 0; i < 200000000; i++)
                text.Append(i);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}
