using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe029
{
    delegate double AddThree(double x, double y, double z);
    delegate bool IsInIntervall(int x, int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            AddThree addthree = (double x, double y, double z) => x + y + z;
            IsInIntervall check = (int x, int a, int b) => (a <= x && x <= b);

            Console.WriteLine("{0} + {1} + {2} = {3}", 1.1, 1.2, 1.3, addthree(1.1, 1.2, 1.3));
            Console.WriteLine("{0} e [{1},{2}] <=> {3}", 2, 1,3, check(2,1,3));

            System.Threading.Thread.Sleep(10000);
        }
    }
}
