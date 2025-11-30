using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form2 : Form
    {
        private Form1 parentForm;
        public Form2(Form1 frm)
        {
            InitializeComponent();
            parentForm = frm;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (txtMSSV.Text == "" || txtHoTen.Text == "" || cmbKhoa.SelectedIndex == -1 || txtDTB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            bool DaTonTai = false;
            if(parentForm.dgvThongTinSinhVien.Rows.Count > 0)
            {
                foreach(DataGridViewRow Row in parentForm.dgvThongTinSinhVien.Rows)
                {
                    if (Row.IsNewRow)
                    {
                        continue;
                    }
                    if(txtMSSV.Text == Row.Cells["clnMSSV"].Value.ToString())
                    {
                        DialogResult a = MessageBox.Show("Sinh viên đã tồn tại! Bạn có muốn cập nhật thông tin sinh viên không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (a == DialogResult.No)
                        {
                            return;
                        }

                        DaTonTai = true;
                        Row.Cells["clnHoTen"].Value = txtHoTen.Text;
                        Row.Cells["clnKhoa"].Value = cmbKhoa.SelectedItem.ToString();
                        Row.Cells["clnDTB"].Value = txtDTB.Text;

                        MessageBox.Show("Cập Nhật Thông Tin Sinh Viên Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
            }
            if (!DaTonTai)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(parentForm.dgvThongTinSinhVien);
                row.Cells[1].Value = txtMSSV.Text;
                row.Cells[2].Value = txtHoTen.Text;
                row.Cells[3].Value = cmbKhoa.SelectedItem.ToString();
                row.Cells[4].Value = txtDTB.Text;

                parentForm.dgvThongTinSinhVien.Rows.Add(row);

                MessageBox.Show("Lưu Thông Tin Sinh Viên Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtMSSV.Clear();
            txtHoTen.Clear();
            cmbKhoa.SelectedIndex = -1;
            txtDTB.Clear();

            parentForm.CapNhatSTT();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
