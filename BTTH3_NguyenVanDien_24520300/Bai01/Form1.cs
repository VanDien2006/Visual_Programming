using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Activated += Form1_Activated;
            this.Shown += Form1_Shown;
            this.Deactivate += Form1_Deactivate;
            this.Closing += Form1_Closing;
            this.Closed += Form1_Closed;
        }


        private void GhiSuKien(string TenSuKien)
        {
            string ThoiGian = DateTime.Now.ToString("HH:mm:ss");
            listBox1.Items.Add($"{ThoiGian} - {TenSuKien}");
        }
        private void Form1_Load(object sender, EventArgs e) => GhiSuKien("Form1_Load");
        private void Form1_Activated(object sender, EventArgs e) => GhiSuKien("Form1_Activated");
        private void Form1_Shown(object sender, EventArgs e) => GhiSuKien("Form1_Shown");
        private void Form1_Deactivate(object sender, EventArgs e) => GhiSuKien("Form1_Deactivate");
        private void Form1_Closing(object sender, CancelEventArgs e) => GhiSuKien("Form1_Closing");
        private void Form1_Closed(object sender, EventArgs e) => GhiSuKien("Form1_Closed");
        private void btnMoFormCon_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();
            DaMoFormCon();
        }
        private void DaMoFormCon()=> GhiSuKien("Đã mở Form con");

        private void btnDongForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
