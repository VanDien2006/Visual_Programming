using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            double result = double.Parse(textBoxNumber1.Text) + double.Parse(textBoxNumber2.Text);
            textBoxAnswer.Text = result.ToString("F2");
        }

        private void textBoxNumber1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxNumber1_Leave(object sender, EventArgs e)
        {
            double n;
            if (!double.TryParse(textBoxNumber1.Text, out n))
            {
                MessageBox.Show("Số thứ nhất không hợp lệ!", "Cảnh báo");
                textBoxNumber1.Clear();
                textBoxNumber1.Focus();
            }
        }

        private void textBoxNumber2_Leave(object sender, EventArgs e)
        {
            double n;
            if(!double.TryParse(textBoxNumber2.Text, out n))
            {
                MessageBox.Show("Số thứ hai không hợp lệ!", "Cảnh báo");
                textBoxNumber2.Clear();
                textBoxNumber2.Focus();
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double result = double.Parse(textBoxNumber1.Text) - double.Parse(textBoxNumber2.Text);
            textBoxAnswer.Text = result.ToString("F2");
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            double result = double.Parse(textBoxNumber1.Text) * double.Parse(textBoxNumber2.Text);
            textBoxAnswer.Text = result.ToString("F2");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if(double.Parse(textBoxNumber2.Text) == 0)
            {
                MessageBox.Show("Không thể chia cho 0!", "Cảnh báo");
                textBoxNumber2.Focus();
                return;
            }
            double result = double.Parse(textBoxNumber1.Text) / double.Parse(textBoxNumber2.Text);
            textBoxAnswer.Text = result.ToString("F2");
        }
    }
}
