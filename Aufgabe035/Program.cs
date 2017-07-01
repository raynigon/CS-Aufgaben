using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe035
{
    class Splitter<T> : IEnumerable<List<T>>
    {
        private List<T> source;
        private int size;

        public Splitter(List<T> source, int size)
        {
            this.source = source;
            this.size = size;
        }

        public IEnumerator<List<T>> GetEnumerator()
        {
            int i;
            for (i=0; i + size < source.Count; i += size)
            {
                yield return source.Skip<T>(i).Take<T>(size).ToList<T>();
            }
            yield return source.Skip<T>(i).ToList<T>();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> lints = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29 };
            foreach (var sublist in (new Splitter<int>(lints, 4)))
            {
                Console.WriteLine(String.Join(",", sublist));
            }
            System.Threading.Thread.Sleep(10000);
        }
    }
}
