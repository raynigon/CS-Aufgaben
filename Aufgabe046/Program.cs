using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe046
{
    class Program
    {
        static void ParallelMergeSort(int[] data, int index, int size)
        {
            if (size < 4)
            {
                SerialMergeSort(data, index, size);
            }
            else
            {
                int s0 = size / 2;
                int s1 = size - s0;
                var t0 = Task.Factory.StartNew(() => SerialMergeSort(data, index, s0));
                var t1 = Task.Factory.StartNew(() => SerialMergeSort(data, index + s0, s1));
                t0.Wait();
                t1.Wait();
                SerialMergeAlgo(data, index, s0, s1);
            }
        }

        static void SerialMergeSort(int[] data, int index, int size)
        {
            if (size > 1)
            {
                int s0 = size / 2;
                int s1 = size - s0;

                SerialMergeSort(data, index, s0);
                SerialMergeSort(data, index + s0, s1);

                SerialMergeAlgo(data, index, s0, s1);
            }
        }

        private static void SerialMergeAlgo(int[] data, int index, int s0, int s1)
        {
            int[] neueArray = new int[s0+s1];
            int indexLinks = index;
            int indexRechts = index+s0;
            int indexErgebnis = 0;

            while (indexLinks < index+s0 && indexRechts < index + s0 + s1)
            {
                if (data[indexLinks] < data[indexRechts])
                {
                    neueArray[indexErgebnis] = data[indexLinks];
                    indexLinks += 1;
                }
                else
                {
                    neueArray[indexErgebnis] = data[indexRechts];
                    indexRechts += 1;
                }
                indexErgebnis += 1;
            }

            while (indexLinks < index + s0)
            {
                neueArray[indexErgebnis] = data[indexLinks];
                indexLinks += 1;
                indexErgebnis += 1;
            }

            while (indexRechts < index + s0+s1)
            {
                neueArray[indexErgebnis] = data[indexRechts];
                indexRechts += 1;
                indexErgebnis += 1;
            }

            Array.Copy(neueArray, 0, data, index, neueArray.Length);
        }

        static void Main(string[] args)
        {
            Random randNum = new Random();
            int[] randomArray = new int[100000];
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = randNum.Next(0, 99999);
            }

            int[] data = new int[randomArray.Length];
            Array.Copy(randomArray, data, data.Length);
            var r = new Random();
            Stopwatch watch = Stopwatch.StartNew();
            SerialMergeSort(data, 0, data.Length);
            watch.Stop();
            Console.WriteLine("Serial: {0}", watch.ElapsedMilliseconds);

            int[] result0 = new int[data.Length];
            Array.Copy(data, result0, data.Length);
            Array.Copy(randomArray, data, data.Length);

            watch = Stopwatch.StartNew();
            ParallelMergeSort(data, 0, data.Length);
            watch.Stop();
            Console.WriteLine("Parallel: {0}", watch.ElapsedMilliseconds);

            int[] result1 = new int[data.Length];
            Array.Copy(data, result1, data.Length);

            for (int i = 0; i < result0.Length; i++)
            {
                //Console.WriteLine("{0}\t{1:D5}\t{2:D5}",i, result0[i], result1[i]);
                if(result0[i]!=result1[i])
                    Console.WriteLine("Differ at {0}", i);
            }

            System.Threading.Thread.Sleep(10000);
        }
    }
}
