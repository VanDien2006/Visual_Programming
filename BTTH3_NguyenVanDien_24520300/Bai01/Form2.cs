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
    public partial class Form2 : Form
    {
        private Form1 formCha;
        public Form2(Form1 parent)
        {
            InitializeComponent();
            formCha = parent;

            this.Activated += Form2_Activated;  
            this.Shown += Form2_Shown;
            this.Deactivate += Form2_Deactivate;
            this.Closing+= Form2_Closing;
            this.FormClosed += Form2_Closed;
        }
        private void GhiSuKien(string TenSuKien)
        {
            string ThoiGian = DateTime.Now.ToString("HH:mm:ss");
            formCha.listBox1.Items.Add($"{ThoiGian} - {TenSuKien}");
        }
        private void Form2_Load(object sender, EventArgs e) => GhiSuKien("FormCon_Load");
        private void Form2_Activated(object sender, EventArgs e) => GhiSuKien("FormCon_Activated");
        private void Form2_Shown(object sender, EventArgs e) => GhiSuKien("FormCon_Shown");
        private void Form2_Deactivate(object sender, EventArgs e) => GhiSuKien("FormCon_Deactivate");
        private void Form2_Closing(object sender, CancelEventArgs e) => GhiSuKien("FormCon_Closing");
        private void Form2_Closed(object sender, EventArgs e) => GhiSuKien("FormCon_Closed");

    }
}
