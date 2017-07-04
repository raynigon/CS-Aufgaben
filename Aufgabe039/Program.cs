using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe039
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            ISet<int> numbers = new HashSet<int>();
            while (numbers.Count<10)
            {
                numbers.Add(r.Next()%100);
            }
            var result = from number in numbers
                         group number by number%3 into g
                         orderby g.Key ascending
                         select new { Rest = g.Key, Numbers = g};
            foreach (var g in result)
            {
                Console.WriteLine("Nummern mit Rest {0}:", g.Rest);
                foreach (var n in g.Numbers.OrderBy(v=>v))
                {
                    Console.WriteLine(n);
                }
            }
            System.Threading.Thread.Sleep(10000);
        }
    }
}
