using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe107
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> contacts;

        public Form1()
        {
            contacts = new Dictionary<string, string>();
            InitializeComponent();
        }

        private void OnInsert(object sender, EventArgs e)
        {
            contacts.Add(tbName.Text, tbPhoneNumber.Text);
            tbName.Clear();
            tbPhoneNumber.Clear();
            OnSearch(sender, e);
        }

        private void OnSearch(object sender, EventArgs e)
        {
            if (contacts.ContainsKey(tbsName.Text))
            {
                tbsPhoneNumber.Text = contacts[tbsName.Text];
            }
            else if (sender == btnSearch)
            {
                tbsPhoneNumber.Text = " - Not Found - ";
            }
            else
            {
                tbsPhoneNumber.Text = " - ";
            }
        }

    }
}
