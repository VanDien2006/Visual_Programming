namespace SourceForDataBase
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnTaoTaiKhoanMoi = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lblDangNhapTaiKhoan = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(269, 117);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(197, 22);
            this.txtUser.TabIndex = 0;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.Location = new System.Drawing.Point(70, 112);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(145, 25);
            this.lblTenDangNhap.TabIndex = 1;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            this.lblTenDangNhap.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(70, 175);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(93, 25);
            this.lblMatKhau.TabIndex = 2;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(269, 180);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(197, 22);
            this.txtPass.TabIndex = 1;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // btnTaoTaiKhoanMoi
            // 
            this.btnTaoTaiKhoanMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoTaiKhoanMoi.Location = new System.Drawing.Point(261, 251);
            this.btnTaoTaiKhoanMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoTaiKhoanMoi.Name = "btnTaoTaiKhoanMoi";
            this.btnTaoTaiKhoanMoi.Size = new System.Drawing.Size(207, 39);
            this.btnTaoTaiKhoanMoi.TabIndex = 3;
            this.btnTaoTaiKhoanMoi.Text = "Tạo tài khoản mới";
            this.btnTaoTaiKhoanMoi.UseVisualStyleBackColor = true;
            this.btnTaoTaiKhoanMoi.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(75, 253);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(145, 39);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblDangNhapTaiKhoan
            // 
            this.lblDangNhapTaiKhoan.AutoSize = true;
            this.lblDangNhapTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangNhapTaiKhoan.Location = new System.Drawing.Point(67, 54);
            this.lblDangNhapTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDangNhapTaiKhoan.Name = "lblDangNhapTaiKhoan";
            this.lblDangNhapTaiKhoan.Size = new System.Drawing.Size(329, 36);
            this.lblDangNhapTaiKhoan.TabIndex = 4;
            this.lblDangNhapTaiKhoan.Text = "Đăng Nhập Tài Khoản";
            this.lblDangNhapTaiKhoan.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(175, 321);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(145, 39);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(526, 426);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblDangNhapTaiKhoan);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnTaoTaiKhoanMoi);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.txtUser);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnTaoTaiKhoanMoi;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label lblDangNhapTaiKhoan;
        private System.Windows.Forms.Button btnThoat;
    }
}

