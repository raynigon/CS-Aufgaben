using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aufgabe005
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int size = rand.Next(10, 50);
            int[] nums = new int[size];

            for (int i = 0; i < size; i++)
            {
                nums[i] = rand.Next(1, 10);
            }
            Console.WriteLine("Random Numbers:");
            foreach (int num in nums)
            {
                Console.WriteLine("Number:"+num);
            }
            Thread.Sleep(10000);
        }
    }
}
