using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe019
{
    class Buch
    {
        private string isbn;
        private string title;
        private string author;

        Buch(string isbn, string title, string author)
        {
            this.isbn = isbn;
            this.title = title;
            this.author = author;
        }

        public string Isbn => isbn;
        public string Title => title;
        public string Author => author;

        public override string ToString()
        {
            return String.Format("ISBN={0} Title={1} Author={2}", isbn, title, author);
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
