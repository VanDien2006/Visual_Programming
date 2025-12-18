using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int cx = this.ClientSize.Width / 2;
            int cy = this.ClientSize.Height / 2;
            int radius = 180;

            Pen whitePen = new Pen(Color.White, 2);

            // Vẽ vòng tròn đồng hồ
            g.DrawEllipse(whitePen, cx - radius, cy - radius, radius * 2, radius * 2);

            // Vẽ các chấm giờ
            for (int i = 0; i < 60; i++)
            {
                double angle = Math.PI * i / 30;
                int r1 = (i % 5 == 0) ? radius - 10 : radius - 5;
                int r2 = radius;

                int x1 = cx + (int)(r1 * Math.Sin(angle));
                int y1 = cy - (int)(r1 * Math.Cos(angle));
                int x2 = cx + (int)(r2 * Math.Sin(angle));
                int y2 = cy - (int)(r2 * Math.Cos(angle));

                g.DrawLine(Pens.White, x1, y1, x2, y2);
            }

            DateTime now = DateTime.Now;

            // Kim giờ
            DrawHand(g, cx, cy, radius - 90,
                (now.Hour % 12 + now.Minute / 60.0) * 30, 6);

            // Kim phút
            DrawHand(g, cx, cy, radius - 60,
                now.Minute * 6, 4);

            // Kim giây
            DrawHand(g, cx, cy, radius - 40,
                now.Second * 6, 2);

        }

        private void DrawHand(Graphics g, int cx, int cy, int length, double angle, int thickness)
        {
            double rad = Math.PI * angle / 180;
            int x = cx + (int)(length * Math.Sin(rad));
            int y = cy - (int)(length * Math.Cos(rad));

            Pen pen = new Pen(Color.White, thickness);
            g.DrawLine(pen, cx, cy, x, y);
        }
    }
}
