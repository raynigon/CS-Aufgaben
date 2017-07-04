using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe043
{
    class Program
    {
        public delegate double Fct(double x);
        public static double Trapez(Fct f, double a, double b)
        {
            return (b - a) * 0.5 * (f(a) + f(b));
        }

        public static Task<double> integrate(Fct f, double a, double b, int slices)
        {
            var task = new Task<double>(() =>
            {
                double result = 0.0;
                double diff = b - a;
                for (int i = 0; i < slices - 1; i++)
                {
                    result += Trapez(f, a + i * diff, a + (i + 1) * diff);
                }
                result += Trapez(f, a + (slices - 1) * diff, b);
                return result;
            });
            task.Start();
            return task;
        }

        public static double integrateFast(Fct f, double a, double b, int slices)
        {
            double diff = (b - a) / 4.0;
            int rest = slices / 4 + slices - 4 * (slices / 4);
            var t0 = integrate(f, a             , a + diff      , slices / 4);
            var t1 = integrate(f, a + diff      , a + 2 * diff  , slices / 4);
            var t2 = integrate(f, a + 2 * diff  , a + 3 * diff  , slices / 4);
            var t3 = integrate(f, a + 3 * diff  , b             , rest);
            return t0.Result + t1.Result + t2.Result + t3.Result;
        }

        static void Main(string[] args)
        {
            Fct f = (double x) => 1;
            var result = integrateFast(f, 0.0, 100.0, 1000000000);
            Console.WriteLine("Result: {0}", result);
            System.Threading.Thread.Sleep(10000);
        }
    }
}
