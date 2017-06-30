using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe021
{
    class Komplex
    {
        private double real;
        private double img;

        public Komplex()
        {
            real = 0.0;
            img = 0.0;
        }
        public Komplex(double real, double img)
        {
            this.real = real;
            this.img = img;
        }

        public double Real => real;
        public double Img => img;

        public double this[int key]
        {
            get
            {
                return key % 2 == 0 ? real : img;
            }
            set
            {
                if (key % 2 == 0)
                    real = value;
                else
                    img = value;
            }
        }

        public static Komplex operator+ (Komplex k0, Komplex k1)
        {
            return new Komplex(k0.real + k1.real, k0.img + k1.img);
        }
    
        public static Komplex operator -(Komplex k0, Komplex k1)
        {
            return new Komplex(k0.real - k1.real, k0.img - k1.img);
        }

        public static Komplex operator *(Komplex k0, Komplex k1)
        {
            return new Komplex(k0.real * k1.real - k0.img * k1.img, k0.real*k1.img + k0.img*k1.real);
        }

        public static Komplex operator /(Komplex k0, Komplex k1)
        {
            Komplex k1k = ~k1; // k1 Konjungiert
            Komplex t0 = k0 * k1k;
            double t1 = k1.real * k1.real + k1.img * k1.img;
            return new Komplex(t0.real/t1, t0.img/t1);
        }

        public static Komplex operator ~(Komplex k)
        {
            return new Komplex(k.real, k.img*-1.0);
        }

        public static bool operator ==(Komplex k0, Komplex k1)
        {
            return k0.real == k1.real && k0.img == k1.img;
        }

        public static bool operator !=(Komplex k0, Komplex k1)
        {
            return !(k0 == k1);
        }

        public override bool Equals(object obj)
        {
            Komplex other = obj as Komplex;
            if (other!=null)
                return other == this;
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return String.Format("{0} + {1}i", real, img);
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
