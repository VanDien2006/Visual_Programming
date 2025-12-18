namespace Bai04
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
            this.lblFont = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.cmbFont = new System.Windows.Forms.ComboBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkUnderline = new System.Windows.Forms.CheckBox();
            this.grbAlignText = new System.Windows.Forms.GroupBox();
            this.radRight = new System.Windows.Forms.RadioButton();
            this.radCenter = new System.Windows.Forms.RadioButton();
            this.radLeft = new System.Windows.Forms.RadioButton();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.rtbVanBan = new System.Windows.Forms.RichTextBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.grbAlignText.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFont.Location = new System.Drawing.Point(13, 31);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(42, 20);
            this.lblFont.TabIndex = 0;
            this.lblFont.Text = "Font";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(283, 31);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(42, 20);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(276, 74);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(49, 20);
            this.lblColor.TabIndex = 0;
            this.lblColor.Text = "Color";
            // 
            // cmbFont
            // 
            this.cmbFont.FormattingEnabled = true;
            this.cmbFont.Location = new System.Drawing.Point(72, 31);
            this.cmbFont.Name = "cmbFont";
            this.cmbFont.Size = new System.Drawing.Size(173, 24);
            this.cmbFont.TabIndex = 1;
            this.cmbFont.SelectedIndexChanged += new System.EventHandler(this.cmbFont_SelectedIndexChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBold.Location = new System.Drawing.Point(13, 80);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(44, 24);
            this.chkBold.TabIndex = 2;
            this.chkBold.Text = "B";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkItalic.Location = new System.Drawing.Point(71, 80);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(35, 24);
            this.chkItalic.TabIndex = 2;
            this.chkItalic.Text = "I";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // chkUnderline
            // 
            this.chkUnderline.AutoSize = true;
            this.chkUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUnderline.Location = new System.Drawing.Point(126, 80);
            this.chkUnderline.Name = "chkUnderline";
            this.chkUnderline.Size = new System.Drawing.Size(43, 24);
            this.chkUnderline.TabIndex = 2;
            this.chkUnderline.Text = "U";
            this.chkUnderline.UseVisualStyleBackColor = true;
            this.chkUnderline.CheckedChanged += new System.EventHandler(this.chkUnderline_CheckedChanged);
            // 
            // grbAlignText
            // 
            this.grbAlignText.Controls.Add(this.radRight);
            this.grbAlignText.Controls.Add(this.radCenter);
            this.grbAlignText.Controls.Add(this.radLeft);
            this.grbAlignText.Location = new System.Drawing.Point(16, 122);
            this.grbAlignText.Name = "grbAlignText";
            this.grbAlignText.Size = new System.Drawing.Size(177, 156);
            this.grbAlignText.TabIndex = 3;
            this.grbAlignText.TabStop = false;
            this.grbAlignText.Text = "Align Text";
            // 
            // radRight
            // 
            this.radRight.AutoSize = true;
            this.radRight.Location = new System.Drawing.Point(25, 113);
            this.radRight.Name = "radRight";
            this.radRight.Size = new System.Drawing.Size(59, 20);
            this.radRight.TabIndex = 0;
            this.radRight.TabStop = true;
            this.radRight.Text = "Right";
            this.radRight.UseVisualStyleBackColor = true;
            this.radRight.CheckedChanged += new System.EventHandler(this.radRight_CheckedChanged);
            // 
            // radCenter
            // 
            this.radCenter.AutoSize = true;
            this.radCenter.Location = new System.Drawing.Point(25, 76);
            this.radCenter.Name = "radCenter";
            this.radCenter.Size = new System.Drawing.Size(67, 20);
            this.radCenter.TabIndex = 0;
            this.radCenter.TabStop = true;
            this.radCenter.Text = "Center";
            this.radCenter.UseVisualStyleBackColor = true;
            this.radCenter.CheckedChanged += new System.EventHandler(this.radCenter_CheckedChanged);
            // 
            // radLeft
            // 
            this.radLeft.AutoSize = true;
            this.radLeft.Location = new System.Drawing.Point(25, 38);
            this.radLeft.Name = "radLeft";
            this.radLeft.Size = new System.Drawing.Size(49, 20);
            this.radLeft.TabIndex = 0;
            this.radLeft.TabStop = true;
            this.radLeft.Text = "Left";
            this.radLeft.UseVisualStyleBackColor = true;
            this.radLeft.CheckedChanged += new System.EventHandler(this.radLeft_CheckedChanged);
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Location = new System.Drawing.Point(332, 31);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(121, 24);
            this.cmbSize.TabIndex = 4;
            this.cmbSize.SelectedIndexChanged += new System.EventHandler(this.cmbSize_SelectedIndexChanged);
            // 
            // rtbVanBan
            // 
            this.rtbVanBan.Location = new System.Drawing.Point(218, 122);
            this.rtbVanBan.Name = "rtbVanBan";
            this.rtbVanBan.Size = new System.Drawing.Size(270, 156);
            this.rtbVanBan.TabIndex = 0;
            this.rtbVanBan.Text = "";
            this.rtbVanBan.TextChanged += new System.EventHandler(this.rtbVanBan_TextChanged);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(332, 73);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(32, 23);
            this.btnColor.TabIndex = 7;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 300);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.rtbVanBan);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.grbAlignText);
            this.Controls.Add(this.chkUnderline);
            this.Controls.Add(this.chkItalic);
            this.Controls.Add(this.chkBold);
            this.Controls.Add(this.cmbFont);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblFont);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbAlignText.ResumeLayout(false);
            this.grbAlignText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cmbFont;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkUnderline;
        private System.Windows.Forms.GroupBox grbAlignText;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.RichTextBox rtbVanBan;
        private System.Windows.Forms.RadioButton radRight;
        private System.Windows.Forms.RadioButton radCenter;
        private System.Windows.Forms.RadioButton radLeft;
        private System.Windows.Forms.Button btnColor;
    }
}

