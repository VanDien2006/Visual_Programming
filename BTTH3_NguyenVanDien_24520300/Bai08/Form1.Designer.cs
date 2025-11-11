namespace Bai08
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblSoTaiKhoan = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.lblDiaChiKhachHang = new System.Windows.Forms.Label();
            this.lblSoTienTrongTaiKhoan = new System.Windows.Forms.Label();
            this.txtSoTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtDiaChiKhachHang = new System.Windows.Forms.TextBox();
            this.txtSoTienTrongTaiKhoan = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lvQuanLyThongTinTaiKhoan = new System.Windows.Forms.ListView();
            this.clnSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnMaTK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTenKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnSoTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(774, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoTaiKhoan
            // 
            this.lblSoTaiKhoan.AutoSize = true;
            this.lblSoTaiKhoan.Location = new System.Drawing.Point(89, 69);
            this.lblSoTaiKhoan.Name = "lblSoTaiKhoan";
            this.lblSoTaiKhoan.Size = new System.Drawing.Size(81, 16);
            this.lblSoTaiKhoan.TabIndex = 0;
            this.lblSoTaiKhoan.Text = "Số tài khoản";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Location = new System.Drawing.Point(67, 97);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(103, 16);
            this.lblTenKhachHang.TabIndex = 0;
            this.lblTenKhachHang.Text = "Tên khách hàng";
            // 
            // lblDiaChiKhachHang
            // 
            this.lblDiaChiKhachHang.AutoSize = true;
            this.lblDiaChiKhachHang.Location = new System.Drawing.Point(51, 125);
            this.lblDiaChiKhachHang.Name = "lblDiaChiKhachHang";
            this.lblDiaChiKhachHang.Size = new System.Drawing.Size(119, 16);
            this.lblDiaChiKhachHang.TabIndex = 0;
            this.lblDiaChiKhachHang.Text = "Địa chỉ khách hàng";
            // 
            // lblSoTienTrongTaiKhoan
            // 
            this.lblSoTienTrongTaiKhoan.AutoSize = true;
            this.lblSoTienTrongTaiKhoan.Location = new System.Drawing.Point(32, 153);
            this.lblSoTienTrongTaiKhoan.Name = "lblSoTienTrongTaiKhoan";
            this.lblSoTienTrongTaiKhoan.Size = new System.Drawing.Size(138, 16);
            this.lblSoTienTrongTaiKhoan.TabIndex = 0;
            this.lblSoTienTrongTaiKhoan.Text = "Số tiền trong tài khoản";
            // 
            // txtSoTaiKhoan
            // 
            this.txtSoTaiKhoan.Location = new System.Drawing.Point(218, 69);
            this.txtSoTaiKhoan.Name = "txtSoTaiKhoan";
            this.txtSoTaiKhoan.Size = new System.Drawing.Size(463, 22);
            this.txtSoTaiKhoan.TabIndex = 0;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(218, 97);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(463, 22);
            this.txtTenKhachHang.TabIndex = 1;
            // 
            // txtDiaChiKhachHang
            // 
            this.txtDiaChiKhachHang.Location = new System.Drawing.Point(218, 125);
            this.txtDiaChiKhachHang.Name = "txtDiaChiKhachHang";
            this.txtDiaChiKhachHang.Size = new System.Drawing.Size(463, 22);
            this.txtDiaChiKhachHang.TabIndex = 2;
            // 
            // txtSoTienTrongTaiKhoan
            // 
            this.txtSoTienTrongTaiKhoan.Location = new System.Drawing.Point(218, 153);
            this.txtSoTienTrongTaiKhoan.Name = "txtSoTienTrongTaiKhoan";
            this.txtSoTienTrongTaiKhoan.Size = new System.Drawing.Size(463, 22);
            this.txtSoTienTrongTaiKhoan.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Silver;
            this.btnThem.Location = new System.Drawing.Point(392, 181);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(127, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm/Cập Nhật";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Silver;
            this.btnXoa.Location = new System.Drawing.Point(525, 181);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Silver;
            this.btnThoat.Location = new System.Drawing.Point(606, 181);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.White;
            this.txtTongTien.Location = new System.Drawing.Point(530, 476);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(232, 22);
            this.txtTongTien.TabIndex = 7;
            // 
            // lvQuanLyThongTinTaiKhoan
            // 
            this.lvQuanLyThongTinTaiKhoan.CausesValidation = false;
            this.lvQuanLyThongTinTaiKhoan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnSTT,
            this.clnMaTK,
            this.clnTenKH,
            this.clnDiaChi,
            this.clnSoTien});
            this.lvQuanLyThongTinTaiKhoan.FullRowSelect = true;
            this.lvQuanLyThongTinTaiKhoan.GridLines = true;
            this.lvQuanLyThongTinTaiKhoan.HideSelection = false;
            this.lvQuanLyThongTinTaiKhoan.Location = new System.Drawing.Point(12, 213);
            this.lvQuanLyThongTinTaiKhoan.Name = "lvQuanLyThongTinTaiKhoan";
            this.lvQuanLyThongTinTaiKhoan.Size = new System.Drawing.Size(750, 257);
            this.lvQuanLyThongTinTaiKhoan.TabIndex = 4;
            this.lvQuanLyThongTinTaiKhoan.UseCompatibleStateImageBehavior = false;
            this.lvQuanLyThongTinTaiKhoan.View = System.Windows.Forms.View.Details;
            this.lvQuanLyThongTinTaiKhoan.SelectedIndexChanged += new System.EventHandler(this.lvQuanLyThongTinTaiKhoan_SelectedIndexChanged);
            // 
            // clnSTT
            // 
            this.clnSTT.Text = "STT";
            this.clnSTT.Width = 40;
            // 
            // clnMaTK
            // 
            this.clnMaTK.Text = "Mã tài khoản";
            this.clnMaTK.Width = 100;
            // 
            // clnTenKH
            // 
            this.clnTenKH.Text = "Tên khách hàng";
            this.clnTenKH.Width = 200;
            // 
            // clnDiaChi
            // 
            this.clnDiaChi.Text = "Địa chỉ";
            this.clnDiaChi.Width = 200;
            // 
            // clnSoTien
            // 
            this.clnSoTien.Text = "Số tiền";
            this.clnSoTien.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 510);
            this.Controls.Add(this.lvQuanLyThongTinTaiKhoan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSoTienTrongTaiKhoan);
            this.Controls.Add(this.txtDiaChiKhachHang);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtSoTaiKhoan);
            this.Controls.Add(this.lblSoTienTrongTaiKhoan);
            this.Controls.Add(this.lblDiaChiKhachHang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTenKhachHang);
            this.Controls.Add(this.lblSoTaiKhoan);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSoTaiKhoan;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.Label lblDiaChiKhachHang;
        private System.Windows.Forms.Label lblSoTienTrongTaiKhoan;
        private System.Windows.Forms.TextBox txtSoTaiKhoan;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtDiaChiKhachHang;
        private System.Windows.Forms.TextBox txtSoTienTrongTaiKhoan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.ListView lvQuanLyThongTinTaiKhoan;
        private System.Windows.Forms.ColumnHeader clnSTT;
        private System.Windows.Forms.ColumnHeader clnMaTK;
        private System.Windows.Forms.ColumnHeader clnTenKH;
        private System.Windows.Forms.ColumnHeader clnDiaChi;
        private System.Windows.Forms.ColumnHeader clnSoTien;
    }
}

