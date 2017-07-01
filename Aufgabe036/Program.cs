using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe036
{
    public static class StringExt
    {
        public static List<int> findAll2(this string self, string p)
        {
            return Program.findAll1(self, p);
        }
    }

    public class Matcher : IEnumerable<int>
    {
        private string source;
        private string pattern;

        public Matcher(string source, string pattern)
        {
            this.source = source;
            this.pattern = pattern;
        }

        public IEnumerator<int> GetEnumerator()
        {
            char[] array = source.ToCharArray();
            int i = 0;
            while (i + pattern.Length < array.Length)
            {
                int j = 0;
                while (j < pattern.Length)
                {
                    if (array[i + j] != pattern[j])
                    {
                        i++;
                        break;
                    }
                    else if (j + 1 == pattern.Length)
                    {
                        yield return i;
                        i+=2;
                        break;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

    public class Program
    {
        public static IEnumerable<int> findAll3(string s, string p)
        {
            return new Matcher(s, p);
        }

        public static List<int> findAll1(string s, string p)
        {
            return findAll3(s, p).ToList<int>();
        }

        

        static void Main(string[] args)
        {
            string s = "012mmmm7890mmm", p = "mm";
            foreach (int n in findAll1(s, p))
                Console.WriteLine(n);
            foreach (int n in s.findAll2(p))
            {
                Console.WriteLine(n);
            }

            foreach (int n in findAll3(s, p))
                Console.WriteLine(n);
            System.Threading.Thread.Sleep(10000);
        }
    }
}
