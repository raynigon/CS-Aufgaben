using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe025
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
}
