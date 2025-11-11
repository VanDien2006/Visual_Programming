using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CapNhatTongTien()
        {
            double TongTienKhachHang = 0;
            foreach (ListViewItem item in lvQuanLyThongTinTaiKhoan.Items)
            {
                TongTienKhachHang += Convert.ToDouble(item.SubItems[4].Text);
            }
            txtTongTien.Text = Convert.ToString(TongTienKhachHang);

        }
        private void CapNhatSTT()
        {
            int stt = 1;
            foreach (ListViewItem it in lvQuanLyThongTinTaiKhoan.Items)
            {
                it.Text = stt.ToString();
                stt++;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtDiaChiKhachHang.Text == "" || txtSoTaiKhoan.Text == "" || txtSoTienTrongTaiKhoan.Text == "" || txtTenKhachHang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Cập nhật thông tin khách hàng vào danh sách nếu số tài khoản đã tồn tại
                bool DaTonTai = false;
                foreach(ListViewItem item in lvQuanLyThongTinTaiKhoan.Items)
                {
                    if(item.SubItems[1].Text == txtSoTaiKhoan.Text)
                    {
                        DaTonTai = true;
                        // Cập nhật thông tin nếu số tài khoản đã tồn tại
                        item.SubItems[2].Text = txtTenKhachHang.Text;
                        item.SubItems[3].Text = txtDiaChiKhachHang.Text;
                        item.SubItems[4].Text = txtSoTienTrongTaiKhoan.Text;
                        MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                // Thêm mới thông tin khách hàng vào danh sách
                if (!DaTonTai)
                {
                    ListViewItem item1 = new ListViewItem();
                    item1.Text = (lvQuanLyThongTinTaiKhoan.Items.Count + 1).ToString();
                    item1.SubItems.Add(txtSoTaiKhoan.Text);
                    item1.SubItems.Add(txtTenKhachHang.Text);
                    item1.SubItems.Add(txtDiaChiKhachHang.Text);
                    item1.SubItems.Add(txtSoTienTrongTaiKhoan.Text);
                    lvQuanLyThongTinTaiKhoan.Items.Add(item1);
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoTienTrongTaiKhoan.Clear(); 
                    txtDiaChiKhachHang.Clear();
                    txtTenKhachHang.Clear();
                    txtSoTaiKhoan.Clear();
                }
            }
            CapNhatTongTien();
            CapNhatSTT();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool DaTimThay = false;
            foreach(ListViewItem item in lvQuanLyThongTinTaiKhoan.Items)
            {
                if(txtSoTaiKhoan.Text == item.SubItems[1].Text)
                {
                    DaTimThay = true;
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(result == DialogResult.Yes)
                    {
                        lvQuanLyThongTinTaiKhoan.Items.Remove(item);
                        MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSoTaiKhoan.Clear();
                        txtTenKhachHang.Clear();
                        txtDiaChiKhachHang.Clear();
                        txtSoTienTrongTaiKhoan.Clear();
                    }
                    break;
                }
            }
            if(!DaTimThay)
            {
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CapNhatTongTien();
            CapNhatSTT();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lvQuanLyThongTinTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvQuanLyThongTinTaiKhoan.SelectedItems.Count > 0)
            {
                ListViewItem item = lvQuanLyThongTinTaiKhoan.SelectedItems[0];
                txtSoTaiKhoan.Text = item.SubItems[1].Text;
                txtTenKhachHang.Text = item.SubItems[2].Text;
                txtDiaChiKhachHang.Text = item.SubItems[3].Text;
                txtSoTienTrongTaiKhoan.Text = item.SubItems[4].Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResizeColumns();
        }
        private void ResizeColumns()
        {
            int DonViChieuRong = lvQuanLyThongTinTaiKhoan.Width / (lvQuanLyThongTinTaiKhoan.Columns.Count * 2);
            lvQuanLyThongTinTaiKhoan.Columns[0].Width = DonViChieuRong; // STT
            lvQuanLyThongTinTaiKhoan.Columns[1].Width = DonViChieuRong * 2; // Số tài khoản
            lvQuanLyThongTinTaiKhoan.Columns[2].Width = DonViChieuRong * 2; // Tên khách hàng
            lvQuanLyThongTinTaiKhoan.Columns[3].Width = DonViChieuRong * 2; // Địa chỉ
            lvQuanLyThongTinTaiKhoan.Columns[4].Width = DonViChieuRong * 3; // Số tiền
        }
    }
}
