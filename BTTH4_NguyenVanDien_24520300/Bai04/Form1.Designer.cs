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
            System.Windows.Forms.ToolStrip toolStrip1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TaoMoi = new System.Windows.Forms.ToolStripButton();
            this.Luu = new System.Windows.Forms.ToolStripButton();
            this.ComboBoxFont = new System.Windows.Forms.ToolStripComboBox();
            this.ComboBoxSize = new System.Windows.Forms.ToolStripComboBox();
            this.Bold = new System.Windows.Forms.ToolStripButton();
            this.Italic = new System.Windows.Forms.ToolStripButton();
            this.Underline = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TaoVanBanMoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoTapTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LuuNoiDungVanBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DinhDangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RichTextBoxVanBan = new System.Windows.Forms.RichTextBox();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TaoMoi,
            this.Luu,
            this.ComboBoxFont,
            this.ComboBoxSize,
            this.Bold,
            this.Italic,
            this.Underline});
            toolStrip1.Location = new System.Drawing.Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            toolStrip1.Size = new System.Drawing.Size(800, 28);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // TaoMoi
            // 
            this.TaoMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TaoMoi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TaoMoi.Image = ((System.Drawing.Image)(resources.GetObject("TaoMoi.Image")));
            this.TaoMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TaoMoi.Name = "TaoMoi";
            this.TaoMoi.Size = new System.Drawing.Size(29, 25);
            this.TaoMoi.Text = "Tạo mới";
            this.TaoMoi.Click += new System.EventHandler(this.TaoVanBanMoiToolStripMenuItem_Click);
            // 
            // Luu
            // 
            this.Luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Luu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Luu.Image = ((System.Drawing.Image)(resources.GetObject("Luu.Image")));
            this.Luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Luu.Name = "Luu";
            this.Luu.Size = new System.Drawing.Size(29, 25);
            this.Luu.Text = "Lưu";
            this.Luu.Click += new System.EventHandler(this.LuuNoiDungVanBanToolStripMenuItem_Click);
            // 
            // ComboBoxFont
            // 
            this.ComboBoxFont.Name = "ComboBoxFont";
            this.ComboBoxFont.Size = new System.Drawing.Size(121, 28);
            this.ComboBoxFont.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFont_Click);
            this.ComboBoxFont.Click += new System.EventHandler(this.ComboBoxFont_Click);
            // 
            // ComboBoxSize
            // 
            this.ComboBoxSize.Name = "ComboBoxSize";
            this.ComboBoxSize.Size = new System.Drawing.Size(121, 28);
            this.ComboBoxSize.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSize_Click);
            this.ComboBoxSize.Click += new System.EventHandler(this.ComboBoxSize_Click);
            // 
            // Bold
            // 
            this.Bold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Bold.Image = ((System.Drawing.Image)(resources.GetObject("Bold.Image")));
            this.Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(29, 25);
            this.Bold.Text = "Bold";
            this.Bold.Click += new System.EventHandler(this.Bold_Click);
            // 
            // Italic
            // 
            this.Italic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Italic.Image = ((System.Drawing.Image)(resources.GetObject("Italic.Image")));
            this.Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(29, 25);
            this.Italic.Text = "Italic";
            this.Italic.Click += new System.EventHandler(this.Italic_Click);
            // 
            // Underline
            // 
            this.Underline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Underline.Image = ((System.Drawing.Image)(resources.GetObject("Underline.Image")));
            this.Underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Underline.Name = "Underline";
            this.Underline.Size = new System.Drawing.Size(29, 25);
            this.Underline.Text = "Underline";
            this.Underline.Click += new System.EventHandler(this.Underline_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.DinhDangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TaoVanBanMoiToolStripMenuItem,
            this.MoTapTinToolStripMenuItem,
            this.LuuNoiDungVanBanToolStripMenuItem,
            this.ThoatToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // TaoVanBanMoiToolStripMenuItem
            // 
            this.TaoVanBanMoiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("TaoVanBanMoiToolStripMenuItem.Image")));
            this.TaoVanBanMoiToolStripMenuItem.Name = "TaoVanBanMoiToolStripMenuItem";
            this.TaoVanBanMoiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.TaoVanBanMoiToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.TaoVanBanMoiToolStripMenuItem.Text = "Tạo văn bản mới";
            this.TaoVanBanMoiToolStripMenuItem.Click += new System.EventHandler(this.TaoVanBanMoiToolStripMenuItem_Click);
            // 
            // MoTapTinToolStripMenuItem
            // 
            this.MoTapTinToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("MoTapTinToolStripMenuItem.Image")));
            this.MoTapTinToolStripMenuItem.Name = "MoTapTinToolStripMenuItem";
            this.MoTapTinToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MoTapTinToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.MoTapTinToolStripMenuItem.Text = "Mở tập tin";
            this.MoTapTinToolStripMenuItem.Click += new System.EventHandler(this.MoTapTinToolStripMenuItem_Click);
            // 
            // LuuNoiDungVanBanToolStripMenuItem
            // 
            this.LuuNoiDungVanBanToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("LuuNoiDungVanBanToolStripMenuItem.Image")));
            this.LuuNoiDungVanBanToolStripMenuItem.Name = "LuuNoiDungVanBanToolStripMenuItem";
            this.LuuNoiDungVanBanToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.LuuNoiDungVanBanToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.LuuNoiDungVanBanToolStripMenuItem.Text = "Lưu nội dung văn bản";
            this.LuuNoiDungVanBanToolStripMenuItem.Click += new System.EventHandler(this.LuuNoiDungVanBanToolStripMenuItem_Click);
            // 
            // ThoatToolStripMenuItem
            // 
            this.ThoatToolStripMenuItem.Name = "ThoatToolStripMenuItem";
            this.ThoatToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.ThoatToolStripMenuItem.Text = "Thoát";
            this.ThoatToolStripMenuItem.Click += new System.EventHandler(this.ThoatToolStripMenuItem_Click);
            // 
            // DinhDangToolStripMenuItem
            // 
            this.DinhDangToolStripMenuItem.Name = "DinhDangToolStripMenuItem";
            this.DinhDangToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.DinhDangToolStripMenuItem.Text = "Định dạng";
            this.DinhDangToolStripMenuItem.Click += new System.EventHandler(this.DinhDangToolStripMenuItem_Click);
            // 
            // RichTextBoxVanBan
            // 
            this.RichTextBoxVanBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextBoxVanBan.Location = new System.Drawing.Point(0, 59);
            this.RichTextBoxVanBan.Name = "RichTextBoxVanBan";
            this.RichTextBoxVanBan.Size = new System.Drawing.Size(800, 391);
            this.RichTextBoxVanBan.TabIndex = 2;
            this.RichTextBoxVanBan.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RichTextBoxVanBan);
            this.Controls.Add(toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Soạn thảo văn bản";
            this.Load += new System.EventHandler(this.Form1_Load);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TaoVanBanMoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MoTapTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LuuNoiDungVanBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DinhDangToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton TaoMoi;
        private System.Windows.Forms.ToolStripButton Luu;
        private System.Windows.Forms.ToolStripComboBox ComboBoxFont;
        private System.Windows.Forms.ToolStripComboBox ComboBoxSize;
        private System.Windows.Forms.ToolStripButton Bold;
        private System.Windows.Forms.ToolStripButton Italic;
        private System.Windows.Forms.ToolStripButton Underline;
        private System.Windows.Forms.RichTextBox RichTextBoxVanBan;
    }
}

