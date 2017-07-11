using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe045
{
    public class SerialSieb : ISieb
    {
        public bool[] Sieb;

        public long Size { get; set; }

        public SerialSieb(long n)
        {
            Size = n;
            Sieb = new bool[Size];
        }

        public void Reset()
        {
            for (long i = 0; i < Size; ++i)
                Sieb[i] = false;
        }

        // ganz einfache Variante!
        public void CalcPrimes()
        {
            Sieb[0] = Sieb[1] = true;   // not prime
            for (long i = 2; i < Size; ++i)
            {
                if (Sieb[i])
                    continue;
                for (long k = i + i; k < Size; k += i)
                    Sieb[k] = true;
            }
        }
    }
}
