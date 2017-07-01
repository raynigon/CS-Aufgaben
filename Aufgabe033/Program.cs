using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe033
{
    public class PrimaryNumbers : IEnumerable<int>
    {
        public static IEnumerator<int> Primes()
        {
            int n = 2;
            yield return 1;
            yield return 2;
            while (n++>0)
            {
                if (isPrime(n))
                    yield return n;
            }
        }

        private static bool isPrime(int n)
        {
            //even number are no prime => false
            if (n % 2 == 0) return false;
            //just check the odds
            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return Primes();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

    class Program
    {
        public static PrimaryNumbers Primes() { return new PrimaryNumbers(); }

        static void Main(string[] args)
        {
            int i = 0;
            int last = 0;
            foreach (int prime in Primes())
            {
                int diff = prime - last;
                Console.WriteLine("Prime: {0}\tDiff to last: {1}", prime, diff);
                last = prime;
                if (i > 1000)
                    break;
                i++;
            }
            System.Threading.Thread.Sleep(10000);
        }
    }
}
