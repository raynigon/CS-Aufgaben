using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe037
{
    class Program
    {
        static void Main(string[] args)
        {
            int deep = 10;
            int[][] array = new int[10][];
            if (deep >= 1)
                array[0] = new int[1] { 1 };
            for (int i = 1; i < array.Length; i++)
            {
                var prev = array[i-1];
                array[i] = new int[i+1];
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (j - 1 < 0 || i == j)
                        array[i][j] = 1;
                    else
                        array[i][j] = prev[j - 1] + prev[j];
                }
            }
            foreach (var line in array)
            {
                var values = from item in line select item.ToString();
                Console.WriteLine(string.Join(",", values.ToArray()));
            }
            

            System.Threading.Thread.Sleep(10000);
        }
    }
}
