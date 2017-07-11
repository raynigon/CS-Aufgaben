using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aufgabe045
{
    class Program
    {
        static void Main(string[] args)
        {
            ISieb s0 = new SerialSieb(1000000);
            ISieb s1 = new ParallelSieb(1000000);
            s0.Reset();
            s1.Reset();
            Stopwatch watch = Stopwatch.StartNew();
            s0.CalcPrimes();
            watch.Stop();
            Console.WriteLine("Serial: {0}", watch.ElapsedMilliseconds);
            watch = Stopwatch.StartNew();
            s1.CalcPrimes();
            watch.Stop();
            Console.WriteLine("Parallel: {0}", watch.ElapsedMilliseconds);
        }
    }
}
