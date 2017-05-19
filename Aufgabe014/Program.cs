using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe014
{
    class Program
    {
        static bool IsPalindrom(string text)
        {
            if (text.Length % 2 != 0)
                return false;
            string p1 = text.Substring(0, text.Length / 2);
            string p2 = text.Substring(text.Length / 2, text.Length / 2);
            for (int i = 0; i < p1.Length; i++)
            {
                if (p1[i] != p2[p2.Length - i - 1])
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bitte Text eingeben:");
            string text = Console.ReadLine();
            text = text.Replace(" ", "").Replace("\t", "").ToLower();
            Console.WriteLine("Input Text: {0}", text);
            if (IsPalindrom(text))
                Console.WriteLine("Der Text war ein Palindrom");
            else
                Console.WriteLine("Der Text ist kein Palindrom");
            System.Threading.Thread.Sleep(10000);
        }
    }
}
