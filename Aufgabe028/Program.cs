using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe028
{
    delegate double Fct(double x);

    class Program
    {
        static void Main(string[] args)
        {
            
            Fct[] fcts = { Math.Sin, Math.Cos, Math.Tan };
            for (double d = 0.0; d < 2 * Math.PI; d += 0.1)
            {
                Console.WriteLine("{0,-5:0.###}\t{1,-5:0.###}\t{2,-5:0.###}\t{3,-5:0.###}", d, fcts[0](d), fcts[1](d), fcts[2](d));
            }

            System.Threading.Thread.Sleep(10000);
        }
    }
}
