using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe106
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private Compass compass;

        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AdaptCompass();
            timer.Interval = 40;
            timer.Tick += OnTimerTick;
            timer.Start();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            AdaptCompass();
            Rectangle btnRect = btn.Bounds;
            switch (compass)
            {
                case Compass.North:
                    btnRect.Y--;
                    break;
                case Compass.East:
                    btnRect.X++;
                    break;
                case Compass.South:
                    btnRect.Y++;
                    break;
                case Compass.West:
                    btnRect.X--;
                    break;
            }
            if (btnRect.X + btnRect.Width > Bounds.Width)
                btnRect.X = 0;
            if (btnRect.Y +btnRect.Height > Bounds.Height)
                btnRect.Y = 0;
            btn.SetBounds(btnRect.X, btnRect.Y, btnRect.Width, btnRect.Height);
        }

        private void AdaptCompass()
        {
            int mx = MousePosition.X;
            int my = MousePosition.Y;

            int bx = Bounds.X + btn.Bounds.X + btn.Bounds.Width / 2;
            int by = Bounds.Y + btn.Bounds.Y + btn.Bounds.Height / 2;

            int ax = bx - mx;
            int ay = by - my;

            if(Math.Abs(ax) < Math.Abs(ay) && ay > 0)
                compass = Compass.North;
            else if(Math.Abs(ax) > Math.Abs(ay) && ax < 0)
                compass = Compass.East;
            else if (Math.Abs(ax) < Math.Abs(ay) && ay < 0)
                compass = Compass.South;
            else
                compass = Compass.West;
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            AdaptCompass();
        }
    }
}
