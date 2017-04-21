using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe009
{
    class Program
    {
        static int fib(int n)
        {
            //Little Speedup for large Numbers ;)
            if (n > 10)
            {
                double sqrt5 = Math.Sqrt(5);
                double p1 = (1 + sqrt5) / 2;
                double p2 = -1 * (p1 - 1);


                double n1 = Math.Pow(p1, n + 1);
                double n2 = Math.Pow(p2, n + 1);
                return (int)((n1 - n2) / sqrt5);
            }
            else
            {
                if (n == 0)
                    return 0;
                else if (n == 1)
                    return 1;
                else
                    return fib(n - 2) + fib(n - 1);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Fib(5):" + fib(5));
            Console.WriteLine("Fib(3):" + fib(3));
            Console.WriteLine("Fib(12):" + fib(12));
            Console.WriteLine("Fib(35):" + fib(35));
            System.Threading.Thread.Sleep(10000);
        }
    }
}
