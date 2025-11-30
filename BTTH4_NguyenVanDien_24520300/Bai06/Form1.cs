using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnChonNguon_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                txtDuongDanNguon.Text = dlg.SelectedPath;
            }
        }

        private void btnChonDich_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                txtDuongDanDich.Text = dlg.SelectedPath;
            }
        }

        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelDangSaoChep.Text = "Đang sao chép: ";
            string[] files = Directory.GetFiles(txtDuongDanNguon.Text);

            PBarTienTrinhSaoChep.Minimum = 0;
            PBarTienTrinhSaoChep.Maximum = files.Length;
            PBarTienTrinhSaoChep.Value = 0;

            toolStripStatusLabelDangSaoChep.Text = "Đang sao chép: " + txtDuongDanNguon.Text;

            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string destFile = Path.Combine(txtDuongDanDich.Text, fileName);

                File.Copy(file, destFile, true);

                PBarTienTrinhSaoChep.Value++;
                toolStripStatusLabelDangSaoChep.Text = "Đang sao chép: " + fileName;
            }

            if(PBarTienTrinhSaoChep.Value == PBarTienTrinhSaoChep.Maximum)
            {
                System.Threading.Thread.Sleep(1000);
                toolStripStatusLabelDangSaoChep.Text = "Hoàn tất!";
            }
        }
    }
}
