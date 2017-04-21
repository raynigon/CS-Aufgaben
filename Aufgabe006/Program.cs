using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aufgabe006
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 10000;
            Console.WriteLine("Double:");
            Console.WriteLine("Left->Right:" + calcDouble(max, 0));
            Console.WriteLine("Right->Left:" + calcDouble(max, 1));
            Console.WriteLine("Part Sums:" + calcDouble(max, 2));

            Console.WriteLine("Decimal:");
            Console.WriteLine("Left->Right:" + calcDecimal(max, 0));
            Console.WriteLine("Right->Left:" + calcDecimal(max, 1));
            Console.WriteLine("Part Sums:" + calcDecimal(max, 2));
            Thread.Sleep(10000);
        }

        static double calcDouble(int max, int mode)
        {
            double result = 1.0;
            if (mode == 0)
            {
                for (int i = 2; i < max; i++)
                {
                    if (i % 2 == 0)
                        result -= 1.0 / i;
                    else
                        result += 1.0 / i;
                }
            }
            else if (mode == 1)
            {
                for (int i = max; i > 1; i--)
                {
                    if (i % 2 == 0)
                        result -= 1.0 / i;
                    else
                        result += 1.0 / i;
                }
            }
            else if (mode == 2)
            {
                double partSum0 = 0.0;
                double partSum1 = 0.0;
                for (int i = 2; i < max; i+=2)
                {
                    partSum0 -= 1.0 / i;
                }
                for (int i = 3; i < max; i += 2)
                {
                    partSum1 += 1.0 / i;
                }
                result = partSum0 + partSum1;
            }
            return result;
        }

        static decimal calcDecimal(int max, int mode)
        {
            decimal result = 1.0M;
            if (mode == 0)
            {
                for (int i = 2; i < max; i++)
                {
                    if (i % 2 == 0)
                        result -= 1.0M / i;
                    else
                        result += 1.0M / i;
                }
            }
            else if (mode == 1)
            {
                for (int i = max; i > 1; i--)
                {
                    if (i % 2 == 0)
                        result -= 1.0M / i;
                    else
                        result += 1.0M / i;
                }
            }
            else if (mode == 2)
            {
                decimal partSum0 = 0.0M;
                decimal partSum1 = 0.0M;
                for (int i = 2; i < max; i += 2)
                {
                    partSum0 -= 1.0M / i;
                }
                for (int i = 3; i < max; i += 2)
                {
                    partSum1 += 1.0M / i;
                }
                result = partSum0 + partSum1;
            }
            return result;
        }
    }
}
