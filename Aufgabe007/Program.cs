using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aufgabe007
{
    class Program
    {
        static uint Pot(uint b, uint n)
        {
            uint res = 1;
            for (int i = 0; i < n; i++)
                res *= b;
            return res;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("2^10 = " + Pot(2, 10));
            Console.WriteLine("4^6 = " + Pot(4, 6));
            Console.WriteLine("3^2 = " + Pot(3, 2));
            Thread.Sleep(10000); 
        }
    }
}
