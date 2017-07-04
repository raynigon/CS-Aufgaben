using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Aufgabe040
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xdoc = XDocument.Load("../../simple.xml");
            FindAllWaffles(xdoc);

            FindAllExpesives(xdoc);

            System.Threading.Thread.Sleep(10000);
        }

        private static double convertPriceToDouble(string s)
        {
            return double.Parse(s.Substring(1).Replace(".", ","));
        }

        private static void FindAllExpesives(XDocument xdoc)
        {
            Console.WriteLine("Expensive Products:");
            var result1 = from food in xdoc.Descendants("food")
                          where convertPriceToDouble(food.Element("price").Value) > 7.0
                          select new { Name = food.Element("name").Value, Price = food.Element("price").Value};

            foreach (var line in result1)
            {
                Console.WriteLine("Name: {0}, Price: {1}", line.Name, line.Price);
            }
        }

        private static void FindAllWaffles(XDocument xdoc)
        {
            Console.WriteLine("Waffles:");
            var result0 = from food in xdoc.Descendants("food")
                          where food.Element("name").Value.Contains("Waffles")
                          select new { Name = food.Element("name").Value, Price = food.Element("price").Value };

            foreach (var line in result0)
            {
                Console.WriteLine("Name: {0}, Price: {1}", line.Name, line.Price);
            }
        }
    }
}
