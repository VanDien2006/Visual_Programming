using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVelai_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void btnVelai_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Random rand = new Random();

            int x = rand.Next(this.ClientSize.Width);
            int y = rand.Next(this.ClientSize.Height);

            Brush myBrush=new SolidBrush(Color.FromArgb(rand.Next(256),rand.Next(256),rand.Next(256)));
            e.Graphics.DrawString("Paint Event", new Font("Arial", 16), myBrush, x, y);
        }
    }
}
