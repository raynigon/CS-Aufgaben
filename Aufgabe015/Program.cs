using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aufgabe015
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("test.txt");
            lines = lines.Reverse().ToArray();
            File.WriteAllLines("test2.txt", lines);
            System.Threading.Thread.Sleep(10000);
        }
    }
}
