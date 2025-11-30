namespace Bai05
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThemMoi = new System.Windows.Forms.ToolStripButton();
            this.lblThemMoi = new System.Windows.Forms.ToolStripLabel();
            this.lblTimKiemTheoTen = new System.Windows.Forms.ToolStripLabel();
            this.dgvThongTinSinhVien = new System.Windows.Forms.DataGridView();
            this.txtTimKiemTheoTen = new System.Windows.Forms.ToolStripTextBox();
            this.clnSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmMớiToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // thêmMớiToolStripMenuItem
            // 
            this.thêmMớiToolStripMenuItem.Name = "thêmMớiToolStripMenuItem";
            this.thêmMớiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.thêmMớiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thêmMớiToolStripMenuItem.Text = "Thêm mới";
            this.thêmMớiToolStripMenuItem.Click += new System.EventHandler(this.thêmMớiToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemMoi,
            this.lblThemMoi,
            this.lblTimKiemTheoTen,
            this.txtTimKiemTheoTen});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(760, 37);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.Image")));
            this.btnThemMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(29, 34);
            this.btnThemMoi.Text = "toolStripButton1";
            this.btnThemMoi.Click += new System.EventHandler(this.thêmMớiToolStripMenuItem_Click);
            // 
            // lblThemMoi
            // 
            this.lblThemMoi.BackColor = System.Drawing.Color.White;
            this.lblThemMoi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblThemMoi.Name = "lblThemMoi";
            this.lblThemMoi.Size = new System.Drawing.Size(87, 34);
            this.lblThemMoi.Text = "Thêm Mới";
            this.lblThemMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblThemMoi.Click += new System.EventHandler(this.thêmMớiToolStripMenuItem_Click);
            // 
            // lblTimKiemTheoTen
            // 
            this.lblTimKiemTheoTen.Name = "lblTimKiemTheoTen";
            this.lblTimKiemTheoTen.Size = new System.Drawing.Size(155, 34);
            this.lblTimKiemTheoTen.Text = "Tìm Kiếm Theo Tên";
            // 
            // dgvThongTinSinhVien
            // 
            this.dgvThongTinSinhVien.AllowUserToAddRows = false;
            this.dgvThongTinSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongTinSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnSTT,
            this.clnMSSV,
            this.clnHoTen,
            this.clnKhoa,
            this.clnDTB});
            this.dgvThongTinSinhVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvThongTinSinhVien.Location = new System.Drawing.Point(0, 68);
            this.dgvThongTinSinhVien.Name = "dgvThongTinSinhVien";
            this.dgvThongTinSinhVien.ReadOnly = true;
            this.dgvThongTinSinhVien.RowHeadersWidth = 51;
            this.dgvThongTinSinhVien.RowTemplate.Height = 24;
            this.dgvThongTinSinhVien.Size = new System.Drawing.Size(760, 400);
            this.dgvThongTinSinhVien.TabIndex = 2;
            // 
            // txtTimKiemTheoTen
            // 
            this.txtTimKiemTheoTen.Name = "txtTimKiemTheoTen";
            this.txtTimKiemTheoTen.Size = new System.Drawing.Size(300, 37);
            this.txtTimKiemTheoTen.TextChanged += new System.EventHandler(this.txtTimKiemTheoTen_TextChanged);
            // 
            // clnSTT
            // 
            this.clnSTT.HeaderText = "STT";
            this.clnSTT.MinimumWidth = 6;
            this.clnSTT.Name = "clnSTT";
            this.clnSTT.ReadOnly = true;
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
            // clnKhoa
            // 
            this.clnKhoa.HeaderText = "Khoa";
            this.clnKhoa.MinimumWidth = 6;
            this.clnKhoa.Name = "clnKhoa";
            this.clnKhoa.ReadOnly = true;
            // 
            // clnDTB
            // 
            this.clnDTB.HeaderText = "DTB";
            this.clnDTB.MinimumWidth = 6;
            this.clnDTB.Name = "clnDTB";
            this.clnDTB.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 468);
            this.Controls.Add(this.dgvThongTinSinhVien);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Quản Lý Sinh Viên";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThemMoi;
        private System.Windows.Forms.ToolStripLabel lblThemMoi;
        private System.Windows.Forms.ToolStripLabel lblTimKiemTheoTen;
        private System.Windows.Forms.ToolStripTextBox txtTimKiemTheoTen;
        public System.Windows.Forms.DataGridView dgvThongTinSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDTB;
    }
}

