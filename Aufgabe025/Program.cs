using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe025
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.push(1);
            q.push(2);
            q.push(3);
            q.push(4);
            q.push(5);
            q.push(6);
            q.push(7);
            q.push(8);
            q.push(9);
            q.push(10);
            q.push(11);
            q.push(12);
            Console.WriteLine(q);
            Console.WriteLine("Pop: {0}", q.pop());
            Console.WriteLine("Pop: {0}", q.pop());
            Console.WriteLine("Pop: {0}", q.pop());
            Console.WriteLine("Pop: {0}", q.pop());
            Console.WriteLine("Pop: {0}", q.pop());
            Console.WriteLine("Pop: {0}", q.pop());
            Console.WriteLine("Pop: {0}", q.pop());
            Console.WriteLine("Pop: {0}", q.pop());
            System.Threading.Thread.Sleep(10000);
        }
    }
}
