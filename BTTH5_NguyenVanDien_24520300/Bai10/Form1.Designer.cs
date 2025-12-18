namespace Bai10
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
            this.lblDashStyle = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblLineJoin = new System.Windows.Forms.Label();
            this.lblDashCap = new System.Windows.Forms.Label();
            this.lblStartCap = new System.Windows.Forms.Label();
            this.lblEndCap = new System.Windows.Forms.Label();
            this.cmbDashStyle = new System.Windows.Forms.ComboBox();
            this.cmbWidth = new System.Windows.Forms.ComboBox();
            this.cmbLineJoin = new System.Windows.Forms.ComboBox();
            this.cmbDashCap = new System.Windows.Forms.ComboBox();
            this.cmbStartCap = new System.Windows.Forms.ComboBox();
            this.cmbEndCap = new System.Windows.Forms.ComboBox();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblDashStyle
            // 
            this.lblDashStyle.AutoSize = true;
            this.lblDashStyle.Location = new System.Drawing.Point(23, 26);
            this.lblDashStyle.Name = "lblDashStyle";
            this.lblDashStyle.Size = new System.Drawing.Size(58, 13);
            this.lblDashStyle.TabIndex = 1;
            this.lblDashStyle.Text = "Dash Style";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(23, 66);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width";
            // 
            // lblLineJoin
            // 
            this.lblLineJoin.AutoSize = true;
            this.lblLineJoin.Location = new System.Drawing.Point(23, 109);
            this.lblLineJoin.Name = "lblLineJoin";
            this.lblLineJoin.Size = new System.Drawing.Size(49, 13);
            this.lblLineJoin.TabIndex = 1;
            this.lblLineJoin.Text = "Line Join";
            // 
            // lblDashCap
            // 
            this.lblDashCap.AutoSize = true;
            this.lblDashCap.Location = new System.Drawing.Point(23, 156);
            this.lblDashCap.Name = "lblDashCap";
            this.lblDashCap.Size = new System.Drawing.Size(54, 13);
            this.lblDashCap.TabIndex = 1;
            this.lblDashCap.Text = "Dash Cap";
            // 
            // lblStartCap
            // 
            this.lblStartCap.AutoSize = true;
            this.lblStartCap.Location = new System.Drawing.Point(23, 206);
            this.lblStartCap.Name = "lblStartCap";
            this.lblStartCap.Size = new System.Drawing.Size(51, 13);
            this.lblStartCap.TabIndex = 1;
            this.lblStartCap.Text = "Start Cap";
            // 
            // lblEndCap
            // 
            this.lblEndCap.AutoSize = true;
            this.lblEndCap.Location = new System.Drawing.Point(24, 257);
            this.lblEndCap.Name = "lblEndCap";
            this.lblEndCap.Size = new System.Drawing.Size(48, 13);
            this.lblEndCap.TabIndex = 1;
            this.lblEndCap.Text = "End Cap";
            // 
            // cmbDashStyle
            // 
            this.cmbDashStyle.FormattingEnabled = true;
            this.cmbDashStyle.Location = new System.Drawing.Point(88, 23);
            this.cmbDashStyle.Name = "cmbDashStyle";
            this.cmbDashStyle.Size = new System.Drawing.Size(121, 21);
            this.cmbDashStyle.TabIndex = 2;
            this.cmbDashStyle.SelectedIndexChanged += new System.EventHandler(this.cmbDashStyle_SelectedIndexChanged);
            // 
            // cmbWidth
            // 
            this.cmbWidth.FormattingEnabled = true;
            this.cmbWidth.Location = new System.Drawing.Point(88, 63);
            this.cmbWidth.Name = "cmbWidth";
            this.cmbWidth.Size = new System.Drawing.Size(121, 21);
            this.cmbWidth.TabIndex = 2;
            this.cmbWidth.SelectedIndexChanged += new System.EventHandler(this.cmbWidth_SelectedIndexChanged);
            // 
            // cmbLineJoin
            // 
            this.cmbLineJoin.FormattingEnabled = true;
            this.cmbLineJoin.Location = new System.Drawing.Point(88, 106);
            this.cmbLineJoin.Name = "cmbLineJoin";
            this.cmbLineJoin.Size = new System.Drawing.Size(121, 21);
            this.cmbLineJoin.TabIndex = 2;
            this.cmbLineJoin.SelectedIndexChanged += new System.EventHandler(this.cmbLineJoin_SelectedIndexChanged);
            // 
            // cmbDashCap
            // 
            this.cmbDashCap.FormattingEnabled = true;
            this.cmbDashCap.Location = new System.Drawing.Point(88, 153);
            this.cmbDashCap.Name = "cmbDashCap";
            this.cmbDashCap.Size = new System.Drawing.Size(121, 21);
            this.cmbDashCap.TabIndex = 2;
            this.cmbDashCap.SelectedIndexChanged += new System.EventHandler(this.cmbDashCap_SelectedIndexChanged);
            // 
            // cmbStartCap
            // 
            this.cmbStartCap.FormattingEnabled = true;
            this.cmbStartCap.Location = new System.Drawing.Point(88, 203);
            this.cmbStartCap.Name = "cmbStartCap";
            this.cmbStartCap.Size = new System.Drawing.Size(121, 21);
            this.cmbStartCap.TabIndex = 2;
            this.cmbStartCap.SelectedIndexChanged += new System.EventHandler(this.cmbStartCap_SelectedIndexChanged);
            // 
            // cmbEndCap
            // 
            this.cmbEndCap.FormattingEnabled = true;
            this.cmbEndCap.Location = new System.Drawing.Point(88, 254);
            this.cmbEndCap.Name = "cmbEndCap";
            this.cmbEndCap.Size = new System.Drawing.Size(121, 21);
            this.cmbEndCap.TabIndex = 2;
            this.cmbEndCap.SelectedIndexChanged += new System.EventHandler(this.cmbEndCap_SelectedIndexChanged);
            // 
            // panelDraw
            // 
            this.panelDraw.BackColor = System.Drawing.Color.White;
            this.panelDraw.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDraw.Location = new System.Drawing.Point(226, 0);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(298, 299);
            this.panelDraw.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(524, 299);
            this.Controls.Add(this.panelDraw);
            this.Controls.Add(this.cmbEndCap);
            this.Controls.Add(this.cmbStartCap);
            this.Controls.Add(this.cmbDashCap);
            this.Controls.Add(this.cmbLineJoin);
            this.Controls.Add(this.cmbWidth);
            this.Controls.Add(this.cmbDashStyle);
            this.Controls.Add(this.lblEndCap);
            this.Controls.Add(this.lblStartCap);
            this.Controls.Add(this.lblDashCap);
            this.Controls.Add(this.lblLineJoin);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblDashStyle);
            this.Name = "Form1";
            this.Text = "Pen Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDashStyle;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblLineJoin;
        private System.Windows.Forms.Label lblDashCap;
        private System.Windows.Forms.Label lblStartCap;
        private System.Windows.Forms.Label lblEndCap;
        private System.Windows.Forms.ComboBox cmbDashStyle;
        private System.Windows.Forms.ComboBox cmbWidth;
        private System.Windows.Forms.ComboBox cmbLineJoin;
        private System.Windows.Forms.ComboBox cmbDashCap;
        private System.Windows.Forms.ComboBox cmbStartCap;
        private System.Windows.Forms.ComboBox cmbEndCap;
        private System.Windows.Forms.Panel panelDraw;
    }
}

