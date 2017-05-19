using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe012
{
    class Program
    {
        static int[] FindAll(string input, string muster)
        {
            int[] positions = new int[input.Length];
            string rest = input;
            int i = 0;
            int shift = 0;
            while (rest.Contains(muster))
            {
                positions[i] = rest.IndexOf(muster);
                int size = positions[i] + muster.Length;
                positions[i] += shift;
                shift += size;
                rest = rest.Substring(size);
                i++;
            }
            return positions;
        }

        static void Main(string[] args)
        {
            foreach (int pos in FindAll("TestTestTestTest", "Test"))
            {
                Console.WriteLine("Pos: {0,1}", pos);
            }
            System.Threading.Thread.Sleep(10000);
        }
    }
}
