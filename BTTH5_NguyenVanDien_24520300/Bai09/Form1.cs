using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Paint += Form1_Paint;
            comboBox1.SelectedIndexChanged  += comboBox1_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[]
            {
                "Circle",
                "Square",
                "Ellipse",
                "Pie",
                "Filled Circle",
                "Filled Square",
                "Filled Ellipse",
                "Filled Pie"
            });

            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                return;

            Graphics g = e.Graphics;

            Pen pen = new Pen(Color.DarkRed, 3);
            Brush brush = new SolidBrush(Color.DarkRed);

            // Vị trí và kích thước hình
            Rectangle rect = new Rectangle(120, 80, 200, 120);

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Circle":
                    g.DrawEllipse(pen, rect);
                    break;

                case "Square":
                    g.DrawRectangle(pen, 120, 80, 150, 150);
                    break;

                case "Ellipse":
                    g.DrawEllipse(pen, rect);
                    break;

                case "Pie":
                    g.DrawPie(pen, rect, 0, 270);
                    break;

                case "Filled Circle":
                    g.FillEllipse(brush, rect);
                    break;

                case "Filled Square":
                    g.FillRectangle(brush, 120, 80, 150, 150);
                    break;

                case "Filled Ellipse":
                    g.FillEllipse(brush, rect);
                    break;

                case "Filled Pie":
                    g.FillPie(brush, rect, 0, 270);
                    break;
            }
        }
    }
}
