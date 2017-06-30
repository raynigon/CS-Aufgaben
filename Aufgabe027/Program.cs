using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe027
{
    delegate int Fct(int x, int y);
    class Program
    {
        public static int plus(int x, int y)
        {
            return x + y;
        }

        public static int mult(int x, int y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
            Fct fp = plus;
            Fct fm = mult;
            Fct fd = (x, y) => x / y;
            {
                int x = 6;
                int y = 2;
                Console.WriteLine("Plus:  {0} + {1} = {2}", x, y, fp(x, y));
                Console.WriteLine("Mult:  {0} * {1} = {2}", x, y, fm(x, y));
                Console.WriteLine("Lambd: {0} / {1} = {2}", x, y, fd(x, y));
            }
            System.Threading.Thread.Sleep(10000);
        }
    }
}
