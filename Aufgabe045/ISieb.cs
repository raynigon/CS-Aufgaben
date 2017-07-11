using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe045
{
    interface ISieb
    {
        long Size { get; }

        void Reset();

        void CalcPrimes();
    }
}
