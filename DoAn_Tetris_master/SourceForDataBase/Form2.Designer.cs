namespace SourceForDataBase
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gameBoardPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.pauseScreenPanel = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.nextPiecePanel = new System.Windows.Forms.Panel();
            this.lstScoreHistory = new System.Windows.Forms.ListBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameBoardPanel
            // 
            this.gameBoardPanel.AutoScroll = true;
            this.gameBoardPanel.AutoSize = true;
            this.gameBoardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameBoardPanel.Location = new System.Drawing.Point(243, 15);
            this.gameBoardPanel.Margin = new System.Windows.Forms.Padding(4);
            this.gameBoardPanel.Name = "gameBoardPanel";
            this.gameBoardPanel.Size = new System.Drawing.Size(266, 398);
            this.gameBoardPanel.TabIndex = 0;
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Red;
            this.lblScore.Location = new System.Drawing.Point(164, 63);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(65, 55);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(13, 63);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(65, 55);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(13, 63);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(65, 55);
            this.btnPause.TabIndex = 0;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // pauseScreenPanel
            // 
            this.pauseScreenPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pauseScreenPanel.Location = new System.Drawing.Point(243, 15);
            this.pauseScreenPanel.Margin = new System.Windows.Forms.Padding(4);
            this.pauseScreenPanel.Name = "pauseScreenPanel";
            this.pauseScreenPanel.Size = new System.Drawing.Size(265, 398);
            this.pauseScreenPanel.TabIndex = 4;
            this.pauseScreenPanel.Visible = false;
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(86, 63);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(65, 55);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // nextPiecePanel
            // 
            this.nextPiecePanel.ForeColor = System.Drawing.Color.White;
            this.nextPiecePanel.Location = new System.Drawing.Point(14, 125);
            this.nextPiecePanel.Name = "nextPiecePanel";
            this.nextPiecePanel.Size = new System.Drawing.Size(222, 133);
            this.nextPiecePanel.TabIndex = 5;
            // 
            // lstScoreHistory
            // 
            this.lstScoreHistory.FormattingEnabled = true;
            this.lstScoreHistory.ItemHeight = 16;
            this.lstScoreHistory.Location = new System.Drawing.Point(14, 265);
            this.lstScoreHistory.Name = "lstScoreHistory";
            this.lstScoreHistory.Size = new System.Drawing.Size(222, 148);
            this.lstScoreHistory.TabIndex = 6;
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(14, 15);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(215, 30);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "label1";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(526, 426);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lstScoreHistory);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.nextPiecePanel);
            this.Controls.Add(this.pauseScreenPanel);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gameBoardPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel gameBoardPanel;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Panel pauseScreenPanel;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Panel nextPiecePanel;
        private System.Windows.Forms.ListBox lstScoreHistory;
        private System.Windows.Forms.Label lblUserName;
    }
}