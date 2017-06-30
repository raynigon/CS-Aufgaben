using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aufgabe025;

namespace Aufgabe026
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<double> q = new Queue<double>();
            q.push(1.0);
            Console.WriteLine(q.pop());
            System.Threading.Thread.Sleep(10000);
        }
    }
}
