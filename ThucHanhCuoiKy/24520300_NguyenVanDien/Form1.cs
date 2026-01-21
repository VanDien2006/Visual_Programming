using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24520300_NguyenVanDien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool KiemTraDuLieu()
        {
            if (txtMaTB.Text == "") return false;
            if(txtTenTB.Text == "") return false;
            if(cboLoaiTB.SelectedIndex == -1) return false;
            if(cboPhong.SelectedIndex == -1) return false;
            if(txtSL.Text == "") return false;
            if(txtDonGia.Text == "") return false;
            if(cboTinhTrang.SelectedIndex == -1) return false;

            return true;
        }
        private void CapNhatSoThuTu()
        {
            for (int i = 0; i < dgvQuanLy.Rows.Count; i++)
            {
                dgvQuanLy.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void CapNhatThanhTien()
        {
            decimal TongTien = 0;
            for (int i = 0; i < dgvQuanLy.Rows.Count; i++)
            {
                DataGridViewRow row = dgvQuanLy.Rows[i];
                if (row.IsNewRow) continue;

                if (row.Cells["clnSL"].Value == null ||
                    row.Cells["clnDonGia"].Value == null)
                    continue;

                int soLuong;
                decimal donGia;

                if (!int.TryParse(row.Cells["clnSL"].Value.ToString(), out soLuong))
                    continue;

                if (!decimal.TryParse(row.Cells["clnDonGia"].Value.ToString(), out donGia))
                    continue;

                TongTien += soLuong * donGia;
            }
            txtThanhTien.Text = TongTien.ToString();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
            {
                MessageBox.Show("Dữ liệu không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool DaTonTai = false;
                foreach (DataGridViewRow item in dgvQuanLy.Rows)
                {
                    if (item.IsNewRow) continue;

                    if (item.Cells[1].Value.ToString() == txtMaTB.Text)
                    {
                        DaTonTai = true;

                        item.Cells["clnTenThietBi"].Value = txtTenTB.Text;
                        item.Cells["clnLoaiTB"].Value = cboLoaiTB.Text;
                        item.Cells["clnPhong"].Value = cboPhong.Text;
                        item.Cells["clnSL"].Value = txtSL.Text;
                        item.Cells["clnDonGia"].Value = txtDonGia.Text;
                        item.Cells["clnNgayNhap"].Value = dtpNgayNhap.Value.ToShortDateString();
                        item.Cells["clnTinhTrang"].Value = cboTinhTrang.Text;
                        item.Cells["clnThanhTien"].Value = (int.Parse(txtSL.Text) * decimal.Parse(txtDonGia.Text)).ToString();


                        MessageBox.Show("Đã cập nhật thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
                if (!DaTonTai)
                {
                    int index = dgvQuanLy.Rows.Add();
                    dgvQuanLy.Rows[index].Cells["clnMaTB"].Value = txtMaTB.Text;
                    dgvQuanLy.Rows[index].Cells["clnTenTB"].Value = txtTenTB.Text;
                    dgvQuanLy.Rows[index].Cells["clnLoaiTB"].Value = cboLoaiTB.Text;
                    dgvQuanLy.Rows[index].Cells["clnPhong"].Value = cboPhong.Text;
                    dgvQuanLy.Rows[index].Cells["clnSL"].Value = txtSL.Text;
                    dgvQuanLy.Rows[index].Cells["clnDonGia"].Value = txtDonGia.Text;
                    dgvQuanLy.Rows[index].Cells["clnNgayNhap"].Value = dtpNgayNhap.Value.ToShortDateString();
                    dgvQuanLy.Rows[index].Cells["clnTinhTrang"].Value = cboTinhTrang.Text;
                    dgvQuanLy.Rows[index].Cells["clnThanhTien"].Value = (int.Parse(txtSL.Text) * decimal.Parse(txtDonGia.Text)).ToString();

                    MessageBox.Show("Đã thêm thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                txtMaTB.Clear();
                txtTenTB.Clear();
                cboPhong.SelectedIndex = -1;
                txtSL.Clear();
                txtDonGia.Clear();
                dtpNgayNhap.Value = DateTime.Now;
                cboTinhTrang.SelectedIndex = -1;
            }
            CapNhatSoThuTu();
            CapNhatThanhTien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa thiết bị này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dlg != DialogResult.Yes) return;

            foreach (DataGridViewRow row in dgvQuanLy.SelectedRows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["clnMaTB"].Value?.ToString() == txtMaTB.Text)
                {
                    dgvQuanLy.Rows.Remove(row);
                }
            }

            CapNhatSoThuTu();
            CapNhatThanhTien();
        }


        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaTB.Clear();
            txtTenTB.Clear();
            cboPhong.SelectedIndex = -1;
            txtSL.Clear();
            txtDonGia.Clear();
            dtpNgayNhap.Value = DateTime.Now;
            cboTinhTrang.SelectedIndex = -1;

            txtThanhTien.Text = "0";
            txtMaTB.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvQuanLy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaTB.Text = dgvQuanLy.CurrentRow.Cells[1].Value.ToString();
            txtTenTB.Text = dgvQuanLy.CurrentRow.Cells[2].Value.ToString();
            cboLoaiTB.SelectedItem = dgvQuanLy.CurrentRow.Cells[2].Value.ToString();
            cboPhong.SelectedItem = dgvQuanLy.CurrentRow.Cells[3].Value.ToString();
            txtSL.Text = dgvQuanLy.CurrentRow.Cells[4].Value.ToString();
            txtDonGia.Text = dgvQuanLy.CurrentRow.Cells[5].Value.ToString();
            //dtpNgayNhap.Value = DateTime.Parse(dgvQuanLy.CurrentRow.Cells[6].Value.ToString());
            cboTinhTrang.SelectedItem = dgvQuanLy.CurrentRow.Cells[7].Value.ToString();
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            CapNhatThanhTien();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            CapNhatThanhTien();
        }
    }
}
