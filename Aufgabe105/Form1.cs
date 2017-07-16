using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe105
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(tbInput.Text);
                stackList.Items.Insert(0, value);
            }
            catch (FormatException exception)
            {
                tbInput.Text = "ERROR: Unable to parse Input";
            }

        }

        private void OnMathAction(object sender, EventArgs e)
        {
            if (stackList.Items.Count < 2)
            {
                tbInput.Text = "ERROR: not enough Numbers in Stack";
                return;
            }

            int b = PopItemFromStack();
            int a = PopItemFromStack();
            int c = 0;
            if (sender == btnAdd)
            {
                c = a + b;
            }else if (sender == btnSubstract)
            {
                c = a - b;
            }
            else if (sender == btnMultiply)
            {
                c = a * b;
            }
            else if (sender == btnDivide)
            {
                c = a / b;
                tbInput.Text = "Rest: " + (a % b);
            }

            stackList.Items.Add(c);
        }

        private int PopItemFromStack()
        {
            if(stackList.Items.Count<1)
                throw new FormatException("Empty Stack");
            int x = ((int) stackList.Items[0]);
            stackList.Items.RemoveAt(0);
            return x;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (stackList.Items.Count > 0)
                PopItemFromStack();
            tbInput.Text = "";
        }
    }
}
