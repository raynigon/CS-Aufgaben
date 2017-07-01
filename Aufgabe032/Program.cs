using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe032
{
    class Splitter : IEnumerable<char>
    {
        private string s;

        public Splitter(string inString)
        {
            s = inString;
        }

        public IEnumerator<char> GetEnumerator()
        {
            var e = s.Reverse<char>();
            var l = e.ToList<char>();
            foreach (char c in l)
            {
                yield return c;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

    class Program
    {
        static IEnumerable<char> SplitString(string s)
        {
            return new Splitter(s);
        }

        static void Main(string[] args)
        {
            foreach (char c in SplitString("Hallo"))
            {
                Console.WriteLine("c = {0}",c);
            }
            System.Threading.Thread.Sleep(10000);
        }
    }
}
