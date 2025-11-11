namespace Bai09
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
            this.grbThongTinSinhVien = new System.Windows.Forms.GroupBox();
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.lstCacMonDuocChon = new System.Windows.Forms.ListBox();
            this.lstDanhSachCacMon = new System.Windows.Forms.ListBox();
            this.cmbChuyenNganh = new System.Windows.Forms.ComboBox();
            this.btnXoaChon = new System.Windows.Forms.Button();
            this.btnLuuThongTin = new System.Windows.Forms.Button();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.lblCacMonHocThamGia = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblChuyenNganh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaSinhVien = new System.Windows.Forms.Label();
            this.dgvThongTinSinhVien = new System.Windows.Forms.DataGridView();
            this.clnMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnChuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSoMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbThongTinSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTinSinhVien
            // 
            this.grbThongTinSinhVien.Controls.Add(this.btnXoaMon);
            this.grbThongTinSinhVien.Controls.Add(this.btnThemMon);
            this.grbThongTinSinhVien.Controls.Add(this.lstCacMonDuocChon);
            this.grbThongTinSinhVien.Controls.Add(this.lstDanhSachCacMon);
            this.grbThongTinSinhVien.Controls.Add(this.cmbChuyenNganh);
            this.grbThongTinSinhVien.Controls.Add(this.btnXoaChon);
            this.grbThongTinSinhVien.Controls.Add(this.btnLuuThongTin);
            this.grbThongTinSinhVien.Controls.Add(this.radNu);
            this.grbThongTinSinhVien.Controls.Add(this.radNam);
            this.grbThongTinSinhVien.Controls.Add(this.txtHoTen);
            this.grbThongTinSinhVien.Controls.Add(this.txtMaSinhVien);
            this.grbThongTinSinhVien.Controls.Add(this.lblCacMonHocThamGia);
            this.grbThongTinSinhVien.Controls.Add(this.lblGioiTinh);
            this.grbThongTinSinhVien.Controls.Add(this.lblChuyenNganh);
            this.grbThongTinSinhVien.Controls.Add(this.lblHoTen);
            this.grbThongTinSinhVien.Controls.Add(this.lblMaSinhVien);
            this.grbThongTinSinhVien.Location = new System.Drawing.Point(12, 12);
            this.grbThongTinSinhVien.Name = "grbThongTinSinhVien";
            this.grbThongTinSinhVien.Size = new System.Drawing.Size(776, 314);
            this.grbThongTinSinhVien.TabIndex = 0;
            this.grbThongTinSinhVien.TabStop = false;
            this.grbThongTinSinhVien.Text = "Thông Tin Sinh Viên";
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.Location = new System.Drawing.Point(362, 225);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(35, 35);
            this.btnXoaMon.TabIndex = 7;
            this.btnXoaMon.Text = "<";
            this.btnXoaMon.UseVisualStyleBackColor = true;
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(362, 184);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(35, 35);
            this.btnThemMon.TabIndex = 6;
            this.btnThemMon.Text = ">";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // lstCacMonDuocChon
            // 
            this.lstCacMonDuocChon.FormattingEnabled = true;
            this.lstCacMonDuocChon.ItemHeight = 16;
            this.lstCacMonDuocChon.Location = new System.Drawing.Point(403, 184);
            this.lstCacMonDuocChon.Name = "lstCacMonDuocChon";
            this.lstCacMonDuocChon.Size = new System.Drawing.Size(256, 84);
            this.lstCacMonDuocChon.TabIndex = 8;
            // 
            // lstDanhSachCacMon
            // 
            this.lstDanhSachCacMon.FormattingEnabled = true;
            this.lstDanhSachCacMon.ItemHeight = 16;
            this.lstDanhSachCacMon.Items.AddRange(new object[] {
            "Cơ Sở Dữ Liệu",
            "Cơ Sở Dữ Liệu Nâng Cao",
            "PTTK Hệ Thống Thông Tin"});
            this.lstDanhSachCacMon.Location = new System.Drawing.Point(100, 184);
            this.lstDanhSachCacMon.Name = "lstDanhSachCacMon";
            this.lstDanhSachCacMon.Size = new System.Drawing.Size(256, 84);
            this.lstDanhSachCacMon.TabIndex = 5;
            // 
            // cmbChuyenNganh
            // 
            this.cmbChuyenNganh.FormattingEnabled = true;
            this.cmbChuyenNganh.Items.AddRange(new object[] {
            "Công Nghệ Thông Tin",
            "Hệ Thống Thông Tin",
            "Khoa Học Máy Tính",
            "Kỹ Thuật Phần Mềm",
            "Kỹ Thuật Máy Tính",
            "Mạng Máy Tính & Truyền Thông Dữ Liệu ",
            "An Toàn Thông Tin",
            "Thương Mại Điện Tử",
            "Khoa Học Dữ Liệu",
            "Trí Tuệ Nhân Tạo",
            "Thiết Kế Vi Mạch",
            "Truyền Thông Đa Phương Tiện"});
            this.cmbChuyenNganh.Location = new System.Drawing.Point(310, 88);
            this.cmbChuyenNganh.Name = "cmbChuyenNganh";
            this.cmbChuyenNganh.Size = new System.Drawing.Size(246, 24);
            this.cmbChuyenNganh.TabIndex = 2;
            // 
            // btnXoaChon
            // 
            this.btnXoaChon.Location = new System.Drawing.Point(375, 274);
            this.btnXoaChon.Name = "btnXoaChon";
            this.btnXoaChon.Size = new System.Drawing.Size(133, 32);
            this.btnXoaChon.TabIndex = 10;
            this.btnXoaChon.Text = "Xóa Chọn";
            this.btnXoaChon.UseVisualStyleBackColor = true;
            this.btnXoaChon.Click += new System.EventHandler(this.btnXoaChon_Click);
            // 
            // btnLuuThongTin
            // 
            this.btnLuuThongTin.Location = new System.Drawing.Point(236, 274);
            this.btnLuuThongTin.Name = "btnLuuThongTin";
            this.btnLuuThongTin.Size = new System.Drawing.Size(133, 32);
            this.btnLuuThongTin.TabIndex = 9;
            this.btnLuuThongTin.Text = "Lưu Thông Tin";
            this.btnLuuThongTin.UseVisualStyleBackColor = true;
            this.btnLuuThongTin.Click += new System.EventHandler(this.btnLuuThongTin_Click);
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(419, 120);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(45, 20);
            this.radNu.TabIndex = 4;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(310, 118);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(57, 20);
            this.radNam.TabIndex = 3;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(310, 60);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(247, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Location = new System.Drawing.Point(310, 32);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(113, 22);
            this.txtMaSinhVien.TabIndex = 0;
            // 
            // lblCacMonHocThamGia
            // 
            this.lblCacMonHocThamGia.AutoSize = true;
            this.lblCacMonHocThamGia.Location = new System.Drawing.Point(96, 153);
            this.lblCacMonHocThamGia.Name = "lblCacMonHocThamGia";
            this.lblCacMonHocThamGia.Size = new System.Drawing.Size(150, 16);
            this.lblCacMonHocThamGia.TabIndex = 0;
            this.lblCacMonHocThamGia.Text = "Các Môn Học Tham Gia";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(96, 124);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(60, 16);
            this.lblGioiTinh.TabIndex = 0;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // lblChuyenNganh
            // 
            this.lblChuyenNganh.AutoSize = true;
            this.lblChuyenNganh.Location = new System.Drawing.Point(96, 97);
            this.lblChuyenNganh.Name = "lblChuyenNganh";
            this.lblChuyenNganh.Size = new System.Drawing.Size(95, 16);
            this.lblChuyenNganh.TabIndex = 0;
            this.lblChuyenNganh.Text = "Chuyên Ngành";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(97, 66);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(52, 16);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // lblMaSinhVien
            // 
            this.lblMaSinhVien.AutoSize = true;
            this.lblMaSinhVien.Location = new System.Drawing.Point(97, 35);
            this.lblMaSinhVien.Name = "lblMaSinhVien";
            this.lblMaSinhVien.Size = new System.Drawing.Size(85, 16);
            this.lblMaSinhVien.TabIndex = 0;
            this.lblMaSinhVien.Text = "Mã Sinh Viên";
            // 
            // dgvThongTinSinhVien
            // 
            this.dgvThongTinSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnMSSV,
            this.clnHoTen,
            this.clnChuyenNganh,
            this.clnGioiTinh,
            this.clnSoMon});
            this.dgvThongTinSinhVien.Location = new System.Drawing.Point(12, 332);
            this.dgvThongTinSinhVien.Name = "dgvThongTinSinhVien";
            this.dgvThongTinSinhVien.ReadOnly = true;
            this.dgvThongTinSinhVien.RowHeadersWidth = 51;
            this.dgvThongTinSinhVien.RowTemplate.Height = 24;
            this.dgvThongTinSinhVien.Size = new System.Drawing.Size(776, 206);
            this.dgvThongTinSinhVien.TabIndex = 1;
            // 
            // clnMSSV
            // 
            this.clnMSSV.HeaderText = "MSSV";
            this.clnMSSV.MinimumWidth = 6;
            this.clnMSSV.Name = "clnMSSV";
            this.clnMSSV.ReadOnly = true;
            // 
            // clnHoTen
            // 
            this.clnHoTen.HeaderText = "Họ Tên";
            this.clnHoTen.MinimumWidth = 6;
            this.clnHoTen.Name = "clnHoTen";
            this.clnHoTen.ReadOnly = true;
            // 
            // clnChuyenNganh
            // 
            this.clnChuyenNganh.HeaderText = "Chuyên Ngành";
            this.clnChuyenNganh.MinimumWidth = 6;
            this.clnChuyenNganh.Name = "clnChuyenNganh";
            this.clnChuyenNganh.ReadOnly = true;
            // 
            // clnGioiTinh
            // 
            this.clnGioiTinh.HeaderText = "Giới Tính";
            this.clnGioiTinh.MinimumWidth = 6;
            this.clnGioiTinh.Name = "clnGioiTinh";
            this.clnGioiTinh.ReadOnly = true;
            // 
            // clnSoMon
            // 
            this.clnSoMon.HeaderText = "Số Môn";
            this.clnSoMon.MinimumWidth = 6;
            this.clnSoMon.Name = "clnSoMon";
            this.clnSoMon.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.dgvThongTinSinhVien);
            this.Controls.Add(this.grbThongTinSinhVien);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Liệu Sinh Viên";
            this.grbThongTinSinhVien.ResumeLayout(false);
            this.grbThongTinSinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTinSinhVien;
        private System.Windows.Forms.DataGridView dgvThongTinSinhVien;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.Label lblCacMonHocThamGia;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblChuyenNganh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaSinhVien;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Button btnXoaChon;
        private System.Windows.Forms.Button btnLuuThongTin;
        private System.Windows.Forms.ComboBox cmbChuyenNganh;
        private System.Windows.Forms.ListBox lstCacMonDuocChon;
        private System.Windows.Forms.ListBox lstDanhSachCacMon;
        private System.Windows.Forms.Button btnXoaMon;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnChuyenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSoMon;
    }
}

