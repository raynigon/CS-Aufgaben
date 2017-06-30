using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe022
{
    class Bruch : IComparable
    {
        private double zaehler;
        private double nenner;

        public Bruch()
        {
            this.zaehler = 1.0;
            this.nenner = 1.0;
        }

        public Bruch(double zaehler, double nenner)
        {
            this.zaehler = zaehler;
            this.nenner = nenner != 0.0 ? nenner : throw new Exception();
        }

        public double Zaehler => zaehler;
        public double Nenner
        {
            get { return nenner; }
            set { nenner = value!=0.0 ? value : throw new Exception(); }
        }

        public double this[int key]
        {
            get { return key % 2 == 0 ? zaehler : nenner; }
            set { if (key % 2 == 0)
                    zaehler = value;
                  else
                    Nenner = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}/{1}", zaehler, nenner);
        }

        public int CompareTo(object obj)
        {
            Bruch other = obj as Bruch;
            if (other==null)
                return -1;
            double v0 = zaehler / nenner;
            double v1 = other.zaehler / other.nenner;
            if (v0 == v1)
                return 0;
            return v0 > v1 ? 1 : -1;
        }

        public static Bruch operator +(Bruch b0, Bruch b1)
        {
            if (b0.nenner != b1.nenner)
                throw new Exception();
            return new Bruch(b0.zaehler+b1.zaehler, b0.nenner);
        }
        public static Bruch operator -(Bruch b0, Bruch b1)
        {
            if (b0.nenner != b1.nenner)
                throw new Exception();
            return new Bruch(b0.zaehler - b1.zaehler, b0.nenner);
        }

        public static Bruch operator *(Bruch b0, Bruch b1)
        {
            return new Bruch(b0.zaehler * b1.zaehler, b0.nenner * b1.nenner);
        }

        public static Bruch operator /(Bruch b0, Bruch b1)
        {
            return new Bruch(b0.zaehler * b1.nenner, b0.nenner * b1.zaehler);
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
