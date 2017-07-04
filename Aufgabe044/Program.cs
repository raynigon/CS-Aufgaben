using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe044
{
    class Program
    {
        public static int findDivisor(int number)
        {
            int result = 0;
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                    result++;
            }
            return result;
        }

        public static Tuple<int, int> getMaxDivisors()
        {
            List<Task<Tuple<int, int>>> tasks = new List<Task<Tuple<int, int>>>();
            for (int i = 0; i < 100000; i += 100)
            {
                var task = new Task<Tuple<int, int>>(() =>
                {
                    int maxNum = 0;
                    int maxDiv = -1;
                    for (int j = i; j < i + 100; j++)
                    {
                        int res = findDivisor(j);
                        if (res > maxDiv)
                        {
                            maxNum = j;
                            maxDiv = res;
                        }
                    }
                    return new Tuple<int, int>(maxNum, maxDiv);
                });
                task.Start();
                tasks.Add(task);
            }

            Tuple<int, int> max = null;
            foreach (var task in tasks)
            {
                task.Wait();
                if (max == null)
                    max = task.Result;
                else if (max.Item2 < task.Result.Item2)
                    max = task.Result;
            }
            return max;
        }

        static void Main(string[] args)
        {
            var max = getMaxDivisors();
            Console.WriteLine("Max Divisors by: {0} Amount: {1}", max.Item1, max.Item2);
            System.Threading.Thread.Sleep(10000);
        }
    }
}
