using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelDraw.Paint += panelDraw_Paint;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDashStyle.DataSource = Enum.GetValues(typeof(DashStyle));
            cmbLineJoin.DataSource = Enum.GetValues(typeof(LineJoin));
            cmbDashCap.DataSource = Enum.GetValues(typeof(DashCap));
            cmbStartCap.DataSource = Enum.GetValues(typeof(LineCap));
            cmbEndCap.DataSource = Enum.GetValues(typeof(LineCap));

            for (int i = 1; i <= 20; i++)
                cmbWidth.Items.Add(i);

            cmbDashStyle.SelectedItem = DashStyle.DashDot;
            cmbLineJoin.SelectedItem = LineJoin.Round;
            cmbDashCap.SelectedItem = DashCap.Triangle;
            cmbStartCap.SelectedItem = LineCap.Triangle;
            cmbEndCap.SelectedItem = LineCap.RoundAnchor;
            cmbWidth.SelectedItem = 8;
        }
        private void panelDraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Pen pen = new Pen(Color.Red, Convert.ToInt32(cmbWidth.SelectedItem));

            pen.DashStyle = (DashStyle)cmbDashStyle.SelectedItem;
            pen.LineJoin = (LineJoin)cmbLineJoin.SelectedItem;
            pen.DashCap = (DashCap)cmbDashCap.SelectedItem;
            pen.StartCap = (LineCap)cmbStartCap.SelectedItem;
            pen.EndCap = (LineCap)cmbEndCap.SelectedItem;

            if (pen.DashStyle == DashStyle.Custom)
                pen.DashPattern = new float[] { 3, 2 };

            Point[] pts =
            {
                new Point(50, 50),
                new Point(200, 120),
                new Point(100, 220),
            };

            g.DrawLines(pen, pts);
        }
        private void cmbDashStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelDraw.Invalidate();
        }

        private void cmbWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelDraw.Invalidate();
        }

        private void cmbLineJoin_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelDraw.Invalidate();
        }

        private void cmbDashCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelDraw.Invalidate();
        }

        private void cmbStartCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelDraw.Invalidate();
        }

        private void cmbEndCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelDraw.Invalidate();
        }

    }
}
