namespace Bai06
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaoChep = new System.Windows.Forms.Button();
            this.btnChonNguon = new System.Windows.Forms.Button();
            this.btnChonDich = new System.Windows.Forms.Button();
            this.txtDuongDanDich = new System.Windows.Forms.TextBox();
            this.txtDuongDanNguon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PBarTienTrinhSaoChep = new System.Windows.Forms.ProgressBar();
            this.statusStripDangSaoChep = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelDangSaoChep = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStripDangSaoChep.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaoChep);
            this.groupBox1.Controls.Add(this.btnChonNguon);
            this.groupBox1.Controls.Add(this.btnChonDich);
            this.groupBox1.Controls.Add(this.txtDuongDanDich);
            this.groupBox1.Controls.Add(this.txtDuongDanNguon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sao chép tập tin";
            // 
            // btnSaoChep
            // 
            this.btnSaoChep.BackColor = System.Drawing.Color.Silver;
            this.btnSaoChep.ForeColor = System.Drawing.Color.Black;
            this.btnSaoChep.Location = new System.Drawing.Point(265, 119);
            this.btnSaoChep.Name = "btnSaoChep";
            this.btnSaoChep.Size = new System.Drawing.Size(129, 34);
            this.btnSaoChep.TabIndex = 2;
            this.btnSaoChep.Text = "Sao Chép";
            this.btnSaoChep.UseVisualStyleBackColor = false;
            this.btnSaoChep.Click += new System.EventHandler(this.btnSaoChep_Click);
            // 
            // btnChonNguon
            // 
            this.btnChonNguon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonNguon.ForeColor = System.Drawing.Color.Blue;
            this.btnChonNguon.Location = new System.Drawing.Point(580, 39);
            this.btnChonNguon.Name = "btnChonNguon";
            this.btnChonNguon.Size = new System.Drawing.Size(48, 23);
            this.btnChonNguon.TabIndex = 0;
            this.btnChonNguon.Text = "...";
            this.btnChonNguon.UseVisualStyleBackColor = true;
            this.btnChonNguon.Click += new System.EventHandler(this.btnChonNguon_Click);
            // 
            // btnChonDich
            // 
            this.btnChonDich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonDich.ForeColor = System.Drawing.Color.Blue;
            this.btnChonDich.Location = new System.Drawing.Point(580, 84);
            this.btnChonDich.Name = "btnChonDich";
            this.btnChonDich.Size = new System.Drawing.Size(48, 23);
            this.btnChonDich.TabIndex = 1;
            this.btnChonDich.Text = "...";
            this.btnChonDich.UseVisualStyleBackColor = true;
            this.btnChonDich.Click += new System.EventHandler(this.btnChonDich_Click);
            // 
            // txtDuongDanDich
            // 
            this.txtDuongDanDich.ForeColor = System.Drawing.Color.Black;
            this.txtDuongDanDich.Location = new System.Drawing.Point(213, 85);
            this.txtDuongDanDich.Name = "txtDuongDanDich";
            this.txtDuongDanDich.ReadOnly = true;
            this.txtDuongDanDich.Size = new System.Drawing.Size(351, 22);
            this.txtDuongDanDich.TabIndex = 1;
            // 
            // txtDuongDanNguon
            // 
            this.txtDuongDanNguon.ForeColor = System.Drawing.Color.Black;
            this.txtDuongDanNguon.Location = new System.Drawing.Point(213, 40);
            this.txtDuongDanNguon.Name = "txtDuongDanNguon";
            this.txtDuongDanNguon.ReadOnly = true;
            this.txtDuongDanNguon.Size = new System.Drawing.Size(351, 22);
            this.txtDuongDanNguon.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đường Dẫn Thư Mục Đích";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đường Dẫn Thư Mục Nguồn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PBarTienTrinhSaoChep);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(14, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(632, 79);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiến trình sao chép";
            // 
            // PBarTienTrinhSaoChep
            // 
            this.PBarTienTrinhSaoChep.Location = new System.Drawing.Point(50, 33);
            this.PBarTienTrinhSaoChep.Name = "PBarTienTrinhSaoChep";
            this.PBarTienTrinhSaoChep.Size = new System.Drawing.Size(545, 23);
            this.PBarTienTrinhSaoChep.TabIndex = 0;
            // 
            // statusStripDangSaoChep
            // 
            this.statusStripDangSaoChep.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripDangSaoChep.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelDangSaoChep});
            this.statusStripDangSaoChep.Location = new System.Drawing.Point(0, 273);
            this.statusStripDangSaoChep.Name = "statusStripDangSaoChep";
            this.statusStripDangSaoChep.Size = new System.Drawing.Size(659, 26);
            this.statusStripDangSaoChep.TabIndex = 1;
            this.statusStripDangSaoChep.Text = "statusStrip1";
            // 
            // toolStripStatusLabelDangSaoChep
            // 
            this.toolStripStatusLabelDangSaoChep.Name = "toolStripStatusLabelDangSaoChep";
            this.toolStripStatusLabelDangSaoChep.Size = new System.Drawing.Size(119, 20);
            this.toolStripStatusLabelDangSaoChep.Text = "Đang Sao Chép: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 299);
            this.Controls.Add(this.statusStripDangSaoChep);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sao chép tập tin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.statusStripDangSaoChep.ResumeLayout(false);
            this.statusStripDangSaoChep.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar PBarTienTrinhSaoChep;
        private System.Windows.Forms.StatusStrip statusStripDangSaoChep;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDangSaoChep;
        private System.Windows.Forms.Button btnChonNguon;
        private System.Windows.Forms.Button btnChonDich;
        private System.Windows.Forms.TextBox txtDuongDanDich;
        private System.Windows.Forms.TextBox txtDuongDanNguon;
        private System.Windows.Forms.Button btnSaoChep;
    }
}

