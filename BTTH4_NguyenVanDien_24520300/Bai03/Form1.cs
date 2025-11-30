using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Hôm nay là ngày " + DateTime.Now.ToString("dd/MM/yyyy") + " - Bây giờ là " + DateTime.Now.ToString("hh:mm:ss tt");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Hôm nay là ngày " + DateTime.Now.ToString("dd/MM/yyyy") + " - Bây giờ là " + DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                MessageBox.Show("Cảm ơn bạn đã dùng phần mềm", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "AVI File|*.avi|MPEG File|*.mpeg|" +
                         "WAV File|*.wav|MIDI File|*.midi|" +
                         "MP4 File|*.mp4|MP3 File|*.mp3";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                WMPlayer.URL = dlg.FileName;
            }
        }
    }
}
