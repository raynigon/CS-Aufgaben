using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe024
{
    public class Tier : IDisposable
    {
        public int Hoehe;
        public bool Gesund;

        public Tier(int hoehe)
        {
            Hoehe = hoehe;
            Console.WriteLine("Ein neues Tier ist geboren, es ist {0}cm groß", Hoehe);
        }

        public void Dispose()
        {
            Console.WriteLine("Ein {0} Tier, was {1}cm groß war ist gestorben.", Gesund ? "gesundes" : "krankes", Hoehe);
        }
    }

    public class Vogel : Tier
    {
        public bool Gestutzt;

        public Vogel(int hoehe) : base(hoehe)
        {
        }
    }

    public class Fleischfresser : Tier
    {
        
        public string Nahrungsmittel;

        public Fleischfresser(int hoehe) : base(hoehe)
        {
        }
    }

    public class Pferd : Tier
    {
        public string Name;

        public Pferd(int hoehe, string name) : base(hoehe)
        {
            Name = name;
        }
    }

    public class Zoo
    {
        public List<Tier> tiere;

        public Zoo()
        {
            tiere = new List<Tier>();
        }

        public void adoptieren(Tier t) { tiere.Add(t); }
        public void toete(int i) { tiere.RemoveAt(i); }

    }

    public class Trigger
    {
        public Trigger(Zoo zoo)
        {
            zoo.adoptieren(new Fleischfresser(120));
            zoo.adoptieren(new Pferd(180, "Lili"));
            zoo.adoptieren(new Vogel(30) { Gesund = false });
            zoo.adoptieren(new Vogel(21));
            zoo.adoptieren(new Fleischfresser(90));
            zoo.adoptieren(new Pferd(186, "Manni"));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            new Trigger(zoo);
            zoo.toete(2);
            zoo.toete(4);
            List<byte[]> data = new List<byte[]>();
            Random r = new Random();
            for (int i = 0; i < 1000000; i++) { byte[] b = new byte[i*i]; r.NextBytes(b);  data.Add(b); }
            GC.Collect(0, GCCollectionMode.Forced, true);
            System.Threading.Thread.Sleep(100000);
        }
    }
}
