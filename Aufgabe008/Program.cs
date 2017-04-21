using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe008
{
    class Program
    {
        static bool isPrime(int num)
        {
            if (num == 1) return false;
            if (num == 2) return true;
            for (int a = 2; a <= num / 2; a++)
            {
                if (num % a == 0)
                {
                    return false;
                }

            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("IsPrime(7):" + isPrime(7));
            Console.WriteLine("IsPrime(9):" + isPrime(9));
            Console.WriteLine("IsPrime(213):" + isPrime(213));
            System.Threading.Thread.Sleep(10000);
        }
    }
}
