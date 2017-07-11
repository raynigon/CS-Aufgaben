using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aufgabe045
{
    class ParallelSieb : ISieb
    {
        public bool[] Sieb;

        public long Size { get; }
        public ParallelSieb(int n)
        {
            Size = n;
            Sieb = new bool[Size];
        }
        public void Reset()
        {
            for (long i = 0; i < Size; ++i)
                Sieb[i] = false;
        }

        public void CalcPrimes()
        {
            Sieb[0] = Sieb[1] = true;   // not prime
            Task t0 = Task.Factory.StartNew(() => CalcPrimesFrom(2));
            Task t1 = Task.Factory.StartNew(() => CalcPrimesFrom(3));
            Task t2 = Task.Factory.StartNew(() => CalcPrimesFrom(5));
            Task t3 = Task.Factory.StartNew(() => CalcPrimesFrom(7));
            t0.Wait();
            t1.Wait();
            t2.Wait();
            t3.Wait();
        }

        private void CalcPrimesFrom(int start)
        {
            for (long i = start; i < Size; ++i)
            {
                if (Sieb[i])
                    continue;
                for (long k = i + i; k < Size; k += i)
                {
                    if (!Sieb[k])
                    {
                        lock (Sieb)
                        {
                            Sieb[k] = true;
                        }
                    }
                }
                    
            }
        }
    }
}
