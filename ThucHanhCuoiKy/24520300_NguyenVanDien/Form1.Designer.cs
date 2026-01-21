namespace _24520300_NguyenVanDien
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
            this.label2 = new System.Windows.Forms.Label();
            this.cboMaTB = new System.Windows.Forms.ComboBox();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvQuanLy = new System.Windows.Forms.DataGridView();
            this.cboLoaiTB = new System.Windows.Forms.ComboBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.clnSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMaTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTenTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnLoaiTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHienThiTatCa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1111, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ THIẾT BỊ PHÒNG MÁY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm theo";
            // 
            // cboMaTB
            // 
            this.cboMaTB.FormattingEnabled = true;
            this.cboMaTB.Items.AddRange(new object[] {
            "Mã thiết bị",
            "Phòng máy"});
            this.cboMaTB.Location = new System.Drawing.Point(111, 76);
            this.cboMaTB.Name = "cboMaTB";
            this.cboMaTB.Size = new System.Drawing.Size(121, 24);
            this.cboMaTB.TabIndex = 2;
            this.cboMaTB.Text = "Mã thiết bị";
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(238, 77);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(165, 22);
            this.txtPhong.TabIndex = 3;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(409, 77);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã thiết bị";
            // 
            // txtMaTB
            // 
            this.txtMaTB.Location = new System.Drawing.Point(120, 123);
            this.txtMaTB.Name = "txtMaTB";
            this.txtMaTB.Size = new System.Drawing.Size(364, 22);
            this.txtMaTB.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Loại thiết bị";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số lượng";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(120, 200);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(364, 22);
            this.txtSL.TabIndex = 4;
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày nhập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Thành tiền";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(120, 280);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(364, 22);
            this.txtThanhTien.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(531, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tên thiết bị";
            // 
            // txtTenTB
            // 
            this.txtTenTB.Location = new System.Drawing.Point(639, 123);
            this.txtTenTB.Name = "txtTenTB";
            this.txtTenTB.Size = new System.Drawing.Size(364, 22);
            this.txtTenTB.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(531, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Phòng máy";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(531, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(639, 200);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(364, 22);
            this.txtDonGia.TabIndex = 5;
            this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(531, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tình trạng";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(639, 307);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(151, 32);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm / Cập nhật";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(796, 307);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 32);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(877, 307);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 32);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(958, 307);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 32);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvQuanLy
            // 
            this.dgvQuanLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnSTT,
            this.clnMaTB,
            this.clnTenTB,
            this.clnLoaiTB,
            this.clnPhong,
            this.clnSL,
            this.clnDonGia,
            this.clnNgayNhap,
            this.clnTinhTrang,
            this.clnThanhTien});
            this.dgvQuanLy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvQuanLy.Location = new System.Drawing.Point(0, 345);
            this.dgvQuanLy.Name = "dgvQuanLy";
            this.dgvQuanLy.ReadOnly = true;
            this.dgvQuanLy.RowHeadersWidth = 51;
            this.dgvQuanLy.RowTemplate.Height = 24;
            this.dgvQuanLy.Size = new System.Drawing.Size(1111, 242);
            this.dgvQuanLy.TabIndex = 6;
            this.dgvQuanLy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLy_CellClick);
            // 
            // cboLoaiTB
            // 
            this.cboLoaiTB.FormattingEnabled = true;
            this.cboLoaiTB.Items.AddRange(new object[] {
            "PC",
            "Monitor",
            "Keyboard",
            "Mouse",
            "Headset",
            "Projector",
            "Router"});
            this.cboLoaiTB.Location = new System.Drawing.Point(120, 163);
            this.cboLoaiTB.Name = "cboLoaiTB";
            this.cboLoaiTB.Size = new System.Drawing.Size(364, 24);
            this.cboLoaiTB.TabIndex = 2;
            this.cboLoaiTB.Text = "Monitor";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Location = new System.Drawing.Point(120, 237);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(364, 22);
            this.dtpNgayNhap.TabIndex = 6;
            // 
            // cboPhong
            // 
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Items.AddRange(new object[] {
            "PM01",
            "PM02",
            "PM03"});
            this.cboPhong.Location = new System.Drawing.Point(639, 163);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(364, 24);
            this.cboPhong.TabIndex = 3;
            this.cboPhong.Text = "PM02";
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Items.AddRange(new object[] {
            "Tốt",
            "Hỏng",
            "Đang sửa"});
            this.cboTinhTrang.Location = new System.Drawing.Point(639, 237);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(364, 24);
            this.cboTinhTrang.TabIndex = 7;
            this.cboTinhTrang.Text = "Đang sửa";
            // 
            // clnSTT
            // 
            this.clnSTT.HeaderText = "STT";
            this.clnSTT.MinimumWidth = 6;
            this.clnSTT.Name = "clnSTT";
            this.clnSTT.Width = 125;
            // 
            // clnMaTB
            // 
            this.clnMaTB.HeaderText = "Mã thiết bị";
            this.clnMaTB.MinimumWidth = 6;
            this.clnMaTB.Name = "clnMaTB";
            this.clnMaTB.Width = 125;
            // 
            // clnTenTB
            // 
            this.clnTenTB.HeaderText = "Tên thiết bị";
            this.clnTenTB.MinimumWidth = 6;
            this.clnTenTB.Name = "clnTenTB";
            this.clnTenTB.Width = 125;
            // 
            // clnLoaiTB
            // 
            this.clnLoaiTB.HeaderText = "Loại thiết bị";
            this.clnLoaiTB.MinimumWidth = 6;
            this.clnLoaiTB.Name = "clnLoaiTB";
            this.clnLoaiTB.Width = 125;
            // 
            // clnPhong
            // 
            this.clnPhong.HeaderText = "Phòng máy";
            this.clnPhong.MinimumWidth = 6;
            this.clnPhong.Name = "clnPhong";
            this.clnPhong.Width = 125;
            // 
            // clnSL
            // 
            this.clnSL.HeaderText = "SL";
            this.clnSL.MinimumWidth = 6;
            this.clnSL.Name = "clnSL";
            this.clnSL.Width = 125;
            // 
            // clnDonGia
            // 
            this.clnDonGia.HeaderText = "Đơn giá";
            this.clnDonGia.MinimumWidth = 6;
            this.clnDonGia.Name = "clnDonGia";
            this.clnDonGia.Width = 125;
            // 
            // clnNgayNhap
            // 
            this.clnNgayNhap.HeaderText = "Ngày nhập";
            this.clnNgayNhap.MinimumWidth = 6;
            this.clnNgayNhap.Name = "clnNgayNhap";
            this.clnNgayNhap.Width = 125;
            // 
            // clnTinhTrang
            // 
            this.clnTinhTrang.HeaderText = "Tình trạng";
            this.clnTinhTrang.MinimumWidth = 6;
            this.clnTinhTrang.Name = "clnTinhTrang";
            this.clnTinhTrang.Width = 125;
            // 
            // clnThanhTien
            // 
            this.clnThanhTien.HeaderText = "Thành tiền";
            this.clnThanhTien.MinimumWidth = 6;
            this.clnThanhTien.Name = "clnThanhTien";
            this.clnThanhTien.Width = 125;
            // 
            // btnHienThiTatCa
            // 
            this.btnHienThiTatCa.Location = new System.Drawing.Point(490, 77);
            this.btnHienThiTatCa.Name = "btnHienThiTatCa";
            this.btnHienThiTatCa.Size = new System.Drawing.Size(150, 23);
            this.btnHienThiTatCa.TabIndex = 4;
            this.btnHienThiTatCa.Text = "Hiển thị tất cả";
            this.btnHienThiTatCa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 587);
            this.Controls.Add(this.dtpNgayNhap);
            this.Controls.Add(this.dgvQuanLy);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHienThiTatCa);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTenTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboTinhTrang);
            this.Controls.Add(this.cboPhong);
            this.Controls.Add(this.cboLoaiTB);
            this.Controls.Add(this.cboMaTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "QUẢN LÝ THIẾT BỊ PHÒNG MÁY";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMaTB;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvQuanLy;
        private System.Windows.Forms.ComboBox cboLoaiTB;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMaTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTenTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnLoaiTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnThanhTien;
        private System.Windows.Forms.Button btnHienThiTatCa;
    }
}

