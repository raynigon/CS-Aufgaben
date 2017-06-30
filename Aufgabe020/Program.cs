using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe020
{
    class Polynom : IComparable
    {
        private double[] values;

        public Polynom(params double[] values)
        {
            this.values = values;
        }

        public double eval(double x)
        {
            double result = 0.0;
            for (int i = 0; i < values.Length; i++)
            {
                result += values[i]*Math.Pow(x, i);
            }
            return result;
        }

        public int Degree { get { return values.Length; } }

        public bool isZero()
        {
            foreach (var value in values)
            {
                if (value != 0.0)
                    return false;
            }
            return true;
        }
        public bool isOne()
        {
            foreach (var value in values)
            {
                if (value != 1.0)
                    return false;
            }
            return true;
        }

        public int CompareTo(object obj)
        {
            var other = obj as Polynom;
            if (other==null)
                return -1;
            if (other.Degree != Degree)
                return Degree - other.Degree;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == other.values[i])
                    continue;
                return values[i] < other.values[i] ? -1 : 1;
            }
            return 0;
        }

        public static Polynom operator +(Polynom p0, Polynom p1)
        {
            var size = Math.Max(p0.values.Length, p1.values.Length);
            double[] result = new double[size];
            for (int i = 0; i < size; i++)
            {
                double d0 = p0.values.Length<i ? p0.values[i] : 0;
                double d1 = p1.values.Length < i ? p1.values[i] : 0;
                result[i] = d0 + d1;
            }
            return new Polynom(result);
        }
   
        public static Polynom operator *(Polynom p0, int skalar)
        {
            double[] result = (from value in p0.values select value * skalar).ToArray<double>();
            return new Polynom(result);
        }

        public double this[int key]
        {
            get
            {
                return values[key];
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.Sleep(10000);
        }
    }
}
