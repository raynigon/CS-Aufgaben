using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe025
{
    class Program
    {
        public class Queue<T>
        {
            private int start = 0;
            private int size = 0;
            private T[] array;

            public Queue()
            {
                array = new T[10];
            }

            public void push(T element)
            {
                if (size + 1 >= array.Length)
                {
                    var tmp = new T[2 * size];
                    Array.Copy(array, tmp, size);
                    array = tmp;
                }
                else if (start + size + 1 >= array.Length)
                {
                    Array.Copy(array, start, array, 0, size);
                    start = 0;
                }
                array[start + size] = element;
                size++;
            }

            public T pop()
            {
                T tmp = array[start];
                start++;
                return tmp;
            }

            public override string ToString()
            {
                string res = "";
                for (int i = start; i < start + size; i++)
                {
                    res += "," + array[i].ToString();
                }
                return "[" + res.Substring(1) + "]";
            }
        }

        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.push(1);
            q.push(2);
            q.push(3);
            q.push(4);
            q.push(5);
            q.push(6);
            q.push(7);
            q.push(8);
            q.push(9);
            q.push(10);
            q.push(11);
            q.push(12);
            Console.WriteLine(q);
            Console.WriteLine("Pop: {0}", q.pop());
            Console.WriteLine("Pop: {0}", q.pop());
            Console.WriteLine("Pop: {0}", q.pop());
            Console.WriteLine("Pop: {0}", q.pop());
            Console.WriteLine("Pop: {0}", q.pop());
            Console.WriteLine("Pop: {0}", q.pop());
            Console.WriteLine("Pop: {0}", q.pop());
            Console.WriteLine("Pop: {0}", q.pop());
            System.Threading.Thread.Sleep(10000);
        }
    }
}
