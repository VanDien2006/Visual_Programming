namespace Bai02
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
            this.btnVelai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVelai
            // 
            this.btnVelai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVelai.Location = new System.Drawing.Point(12, 12);
            this.btnVelai.Name = "btnVelai";
            this.btnVelai.Size = new System.Drawing.Size(143, 34);
            this.btnVelai.TabIndex = 0;
            this.btnVelai.Text = "Vẽ lại";
            this.btnVelai.UseVisualStyleBackColor = true;
            this.btnVelai.Click += new System.EventHandler(this.btnVelai_Click);
            this.btnVelai.Paint += new System.Windows.Forms.PaintEventHandler(this.btnVelai_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(411, 301);
            this.Controls.Add(this.btnVelai);
            this.Name = "Form1";
            this.Text = "Form";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVelai;
    }
}

