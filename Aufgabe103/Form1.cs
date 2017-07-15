using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe103
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void randomNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            output.Text = String.Format("{0}",randomNumbers.SelectedItem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            int size = rand.Next(10, 50);
            int[] nums = new int[size];

            for (int i = 0; i < size; i++)
            {
                randomNumbers.Items.Add(rand.Next(1000, 9999));
            }
        }
    }
}
