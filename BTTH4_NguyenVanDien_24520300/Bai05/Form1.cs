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
        public void CapNhatSTT()
        {
            int stt = 1;
            foreach(DataGridViewRow row in dgvThongTinSinhVien.Rows)
            {
                if (row.IsNewRow) continue;
                row.Cells[0].Value = stt.ToString();
                stt++;
            }
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(this);
            frm2.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtTimKiemTheoTen_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemTheoTen.Text.ToLower();
            foreach(DataGridViewRow row in dgvThongTinSinhVien.Rows)
            {
                if(row.IsNewRow) continue;
                string name = row.Cells["clnHoTen"].Value.ToString().ToLower();
                row.Visible = name.Contains(keyword);
            }
        }
    }
}
