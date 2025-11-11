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
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            foreach(var item in lstDanhSachCacMon.SelectedItems)
            {
                if (!lstCacMonDuocChon.Items.Contains(item))
                    lstCacMonDuocChon.Items.Add(item);
            }
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            for (int i = lstCacMonDuocChon.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int index = lstCacMonDuocChon.SelectedIndices[i];
                lstCacMonDuocChon.Items.RemoveAt(index);
            }
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            if(txtMaSinhVien.Text == ""||txtHoTen.Text==""|| cmbChuyenNganh.SelectedIndex == -1 || (!radNam.Checked && !radNu.Checked) || lstCacMonDuocChon.Items.Count == 0)
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin");
                return;
            }
            bool DaTonTai = false;
            if(dgvThongTinSinhVien.Rows.Count > 0)
            {
                foreach (DataGridViewRow Row in dgvThongTinSinhVien.Rows)
                {
                    if (Row.IsNewRow)
                    {
                        continue;
                    }
                    if (txtMaSinhVien.Text == Row.Cells["clnMSSV"].Value.ToString())
                    {
                        DaTonTai = true;
                        Row.Cells["clnHoTen"].Value = txtHoTen.Text;
                        Row.Cells["clnChuyenNganh"].Value = cmbChuyenNganh.SelectedItem.ToString();
                        Row.Cells["clnGioiTinh"].Value = radNam.Checked ? "Nam" : "Nữ";
                        Row.Cells["clnSoMonHoc"].Value = lstCacMonDuocChon.Items.Count.ToString();

                        MessageBox.Show("Cập Nhật Thông Tin Sinh Viên Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
            }
            if (!DaTonTai)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvThongTinSinhVien);
                row.Cells[0].Value = txtMaSinhVien.Text;
                row.Cells[1].Value = txtHoTen.Text;
                row.Cells[2].Value = cmbChuyenNganh.SelectedItem.ToString();
                row.Cells[3].Value = radNam.Checked ? "Nam" : "Nữ";
                row.Cells[4].Value = lstCacMonDuocChon.Items.Count.ToString();
                dgvThongTinSinhVien.Rows.Add(row);

                MessageBox.Show("Lưu Thông Tin Sinh Viên Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtMaSinhVien.Clear();
            txtHoTen.Clear();
            cmbChuyenNganh.SelectedIndex = -1;
            radNam.Checked = false;
            radNu.Checked = false;
            lstCacMonDuocChon.Items.Clear();

        }

        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            if (txtMaSinhVien.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Mã Sinh Viên Cần Xóa");
                return;
            }
            foreach(DataGridViewRow Row in dgvThongTinSinhVien.Rows)
            {
                if (txtMaSinhVien.Text == Row.Cells["clnMSSV"].Value.ToString())
                {
                    DialogResult result = MessageBox.Show("Bạn Có Chắc Chắn Muốn Xóa Thông Tin Sinh Viên Này?", "Xác Nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dgvThongTinSinhVien.Rows.Remove(Row);
                        MessageBox.Show("Xóa Thông Tin Sinh Viên Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
            }
            txtMaSinhVien.Clear();
            txtHoTen.Clear();
            cmbChuyenNganh.SelectedIndex = -1;
            radNam.Checked = false;
            radNu.Checked = false;
            lstCacMonDuocChon.Items.Clear();

        }
    }
}
