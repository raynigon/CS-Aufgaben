using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe051
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bands = { "ACDC", "Queen", "Aerosmith", "Iron Maiden", "Megadeth", "Metallica",
                "Cream", "Oasis", "Abba", "Blur", "Chic", "Eurythmics", "Genesis",
                "INXS", "Midnight Oil", "Kent", "Madness", "Manic Street Preachers",
                "Noir Desir", "The Offspring", "Pink Floyd", "Rammstein", "Red Hot Chili Peppers",
                "Tears for Fears", "Deep Purple", "KISS" };
            int[] stage = { 1, 2, 3 };

            var manager = new[] {
                new { mantel="+01/01795678", bandname="ACD" },
                new { mantel="+01/01552345", bandname="MAD" },
                new { mantel="+01/01620987", bandname="RAM" },
            };
            //a)
            var result_a = from band in bands
                where band.StartsWith("M")
                orderby band ascending
                select band;

            var result_b = from band in bands
                where band.StartsWith("M")
                orderby band ascending
                select new { shortName = band.Substring(0, 3), longName = band };

            var result_c = from band in bands
                where band.StartsWith("M")
                group band by (int)band[1] into g
                select new { Key = g.Key, Items = g.ToList() };

            var result_d = (from band in bands
                where band.StartsWith("M")
                select bands.Length).Average();

            var result_e = from band in bands
                join mgn in manager on band.ToUpper().Substring(0, 3) equals mgn.bandname
                select new { TelNr = mgn.mantel, Bandname = band };

            foreach (var item in result_a)
            {
                Console.WriteLine("a) {0}", item);
            }

            foreach (var item in result_b)
            {
                Console.WriteLine("b) {{ {0}, {1} }}", item.shortName, item.longName);
            }

            foreach (var item in result_c)
            {
                Console.WriteLine("c) {0}", (char)item.Key);
                foreach (var subitem in item.Items)
                {
                    Console.WriteLine("\t{0}", subitem);
                }
            }

            Console.WriteLine("d) Avg: {0}", result_d);

            foreach (var item in result_e)
            {
                Console.WriteLine("e) {{ {0}, {1} }}", item.Bandname, item.TelNr);
            }
            System.Threading.Thread.Sleep(10000);
        }
    }
}
