using Aufgabe033;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe034
{
    class Program
    {
        public static PrimaryNumbers Primes() { return new PrimaryNumbers(); }

        static void Main(string[] args)
        {
            int i = 0;
            int last = 0;
            foreach (int prime in Primes())
            {
                int diff = prime - last;
                Console.WriteLine("Prime: {0}\tDiff to last: {1}", prime, diff);
                last = prime;
                if (i > 1000)
                    break;
                i++;
            }
            System.Threading.Thread.Sleep(10000);
        }
    }
}
