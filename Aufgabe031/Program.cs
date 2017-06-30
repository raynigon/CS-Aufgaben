using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe031
{
    delegate double Fct(double x);
    class Program
    {
        public static double newton(Fct fx, Fct fsx, double x)
        {
            for(int i = 0; i < 100; i++) {
                x = x - fx(x)/fsx(x);
            }
            return x;
        }

        static void Main(string[] args)
        {
            Fct f = (x) => Math.Sin(2.1 + x);
            Fct fs = (x) => Math.Cos(2.1 + x);
            double x0 = newton(f, fs, 1.2);
            Console.WriteLine("f({0}) = 0", x0);
            System.Threading.Thread.Sleep(10000);
        }
    }
}
