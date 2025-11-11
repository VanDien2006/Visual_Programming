namespace Bai01
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
            this.btnMoFormCon = new System.Windows.Forms.Button();
            this.btnDongForm = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnMoFormCon
            // 
            this.btnMoFormCon.Location = new System.Drawing.Point(326, 12);
            this.btnMoFormCon.Name = "btnMoFormCon";
            this.btnMoFormCon.Size = new System.Drawing.Size(122, 86);
            this.btnMoFormCon.TabIndex = 1;
            this.btnMoFormCon.Text = "Mở Form Con";
            this.btnMoFormCon.UseVisualStyleBackColor = true;
            this.btnMoFormCon.Click += new System.EventHandler(this.btnMoFormCon_Click);
            // 
            // btnDongForm
            // 
            this.btnDongForm.Location = new System.Drawing.Point(326, 104);
            this.btnDongForm.Name = "btnDongForm";
            this.btnDongForm.Size = new System.Drawing.Size(122, 86);
            this.btnDongForm.TabIndex = 1;
            this.btnDongForm.Text = "Đóng Form";
            this.btnDongForm.UseVisualStyleBackColor = true;
            this.btnDongForm.Click += new System.EventHandler(this.btnDongForm_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(308, 276);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 297);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDongForm);
            this.Controls.Add(this.btnMoFormCon);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai01";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMoFormCon;
        private System.Windows.Forms.Button btnDongForm;
        public System.Windows.Forms.ListBox listBox1;
    }
}

