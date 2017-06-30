using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe018
{
    class Kontakt
    {
        private string name;
        private uint alter;

        public Kontakt()
        {
            name = "";
            alter = 0;
        }

        public Kontakt(string name, uint alter)
        {
            this.name = name;
            this.alter = alter;
        }

        public string Name => name;
        public uint Alter => alter;

        public override string ToString()
        {
            return String.Format("Name={0} Alter={1}", name, alter);
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
