using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MyDraw(Graphics g, int N, int x, int y, int radius)
        {
            if (N == 0)
            {
                return;
            }
            else
            {
                g.DrawEllipse(new Pen(Brushes.Blue, 2), x - radius, y - radius, 2 * radius, 2 * radius);
                x += radius; // Смещение по диагонали
                y += radius; // Смещение по диагонали
                radius += 6; // Увеличение радиуса
                N--;
                MyDraw(g, N, x, y, radius);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            MyDraw(g, 7, 50, 50, 10);
        }
    }
}