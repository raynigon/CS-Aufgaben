using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe023
{
    public interface IMonatsReport
    {
        void monatsReport();
    }
    class Kontakt : IMonatsReport
    {
        private string anschrift;
        private List<string> emails;

        public Kontakt(string anschrift)
        {
            this.anschrift = anschrift;
            emails = new List<string>();
        }

        public string Anschrift => anschrift;
        public IList<string> EMailAdresses { get => emails.AsReadOnly(); set => emails.AddRange(value); }
        public virtual void monatsReport()
        {
            Console.WriteLine("Report: Kunde, Anschrift {0}", anschrift);
        }
    }

    class Lieferant : Kontakt
    {
        private string bankAccount;

        public Lieferant(string anschrift, string bankAccount) : base(anschrift)
        {
            this.bankAccount = bankAccount;
        }

        public override void monatsReport()
        {
            Console.WriteLine("Report: Lieferant, Account {0}", bankAccount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Kontakt> contacts = new List<Kontakt>();
            contacts.Add(new Kontakt("Hallo Weg 32") { EMailAdresses = new List<string>{ "Test@Test.de", "Abc.Test@Test.de", "Test.Abc@Test.de" }});
            contacts.Add(new Kontakt("Hallo Weg 33") { EMailAdresses = new List<string> { "Test@Test1.de", "Abc.Test@Test1.de", "Test.Abc@Test1.de" } });
            contacts.Add(new Lieferant("Hallo Weg 34", "DE12 3456 7890, Bank DE") { EMailAdresses = new List<string> { "Test@Test2.de", "Abc.Test@Test2.de", "Test.Abc@Test2.de" } });
            contacts.Add(new Kontakt("Hallo Weg 35") { EMailAdresses = new List<string> { "Test@Test3.de", "Abc.Test@Test3.de", "Test.Abc@Test3.de" } });
            contacts.ForEach(a => a.monatsReport());
            System.Threading.Thread.Sleep(10000);
        }
    }
}
