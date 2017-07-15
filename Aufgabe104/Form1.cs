using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe104
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            throw new Exception("This should not happen");
        }

        private void OnMouseEnterButton(object sender, EventArgs e)
        {
            Random r = new Random();
            button.Dock = DockStyle.None;

            int mx = MousePosition.X - Bounds.X;
            int my = MousePosition.Y - Bounds.Y;
            int nx = r.Next(5, Width - 100 - 5);
            int ny = r.Next(5, Height - 30 - 5 - 50);

            //Check that the next position is not near the Button
            while ((nx-40 < mx && mx < nx+140) || (ny - 40 < my && my < ny + 80))
            {
                nx = r.Next(5, Width - 100 - 5);
                ny = r.Next(5, Height - 30 - 5 - 50);
            }

            button.SetBounds(nx, ny, 100, 30);
        }
    }
}
