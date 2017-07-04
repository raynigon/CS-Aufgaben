using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aufgabe041
{
    class Program
    {
        public static int value;

        public static void addNumbers(int diff, object @lock)
        {
            for(int i = 0; i < diff; i++) { 
                lock (@lock) {
                    value++;
                }
            }
        }

        static void Main(string[] args)
        {
            object locker = new object();
            value = 0;
            Thread t0 = new Thread(() => addNumbers(10000000, locker));
            Thread t1 = new Thread(() => addNumbers(10000000, locker));
            t0.Start();
            t1.Start();
            t0.Join();
            t1.Join();
            Console.WriteLine("Number: {0}", value);
            System.Threading.Thread.Sleep(10000);
        }
    }
}
