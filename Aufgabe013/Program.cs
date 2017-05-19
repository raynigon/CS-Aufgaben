using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe013
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seitenlänge:");
            string site = Console.ReadLine();
            Console.WriteLine("Höhe:");
            string height = Console.ReadLine();
            int l = int.Parse(site);
            int h = int.Parse(height);
            int vol = l * l * h / 3;
            Console.WriteLine("Volume: {0}", vol);
            System.Threading.Thread.Sleep(10000);
        }
    }
}
