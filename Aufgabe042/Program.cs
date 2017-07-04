using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aufgabe042
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            object conditionalVar = new object();
            Thread t0 = new Thread(()=> {
                lock (conditionalVar) {
                    Monitor.Wait(conditionalVar, 2000);
                }
                Console.WriteLine("Finished Child");
            });
            t0.Start();
            lock (conditionalVar)
            {
                Monitor.Pulse(conditionalVar);
            }
            System.Threading.Thread.Sleep(1000);
            t0.Join();
            Console.WriteLine("Finished Main");
            System.Threading.Thread.Sleep(10000);
        }
    }
}
