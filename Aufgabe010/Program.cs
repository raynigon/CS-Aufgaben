using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe010
{
    class Program
    {
        static void swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        static void Main(string[] args)
        {
            int x = 5;
            int y = 6;
            Console.WriteLine("X: {0,1} Y: {1,1}", x, y);
            swap(ref x,ref y);
            Console.WriteLine("X: {0,1} Y: {1,1}", x, y);
            System.Threading.Thread.Sleep(10000);
        }
    }
}
