using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe030
{
    delegate double Fct(double x);

    class Program
    {
        public static double eval(Fct f, double x)
        {
            return f(x);
        }
        static void Main(string[] args)
        {
            double x = 2.5;
            Console.WriteLine("f({0}) = {1}", x, eval((t)=>t*t,x));
            System.Threading.Thread.Sleep(10000);
        }
    }
}
