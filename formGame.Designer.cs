
namespace CAP_MAN
{
    partial class formGame
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
            this.lbBanner = new System.Windows.Forms.Label();
            this.pMain = new System.Windows.Forms.Panel();
            this.pbGame = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbPlayer2 = new System.Windows.Forms.Label();
            this.lbPlayer1 = new System.Windows.Forms.Label();
            this.tbPlayer2 = new System.Windows.Forms.TextBox();
            this.tbPlayer1 = new System.Windows.Forms.TextBox();
            this.timerTick = new System.Windows.Forms.Timer(this.components);
            this.lblP1Score = new System.Windows.Forms.Label();
            this.lblP2Score = new System.Windows.Forms.Label();
            this.pMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBanner
            // 
            this.lbBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(242)))), ((int)(((byte)(63)))));
            this.lbBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbBanner.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbBanner.ForeColor = System.Drawing.Color.White;
            this.lbBanner.Location = new System.Drawing.Point(0, 0);
            this.lbBanner.Margin = new System.Windows.Forms.Padding(0);
            this.lbBanner.Name = "lbBanner";
            this.lbBanner.Size = new System.Drawing.Size(1024, 64);
            this.lbBanner.TabIndex = 0;
            this.lbBanner.Text = "Singleplayer";
            this.lbBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pMain.Controls.Add(this.pbGame);
            this.pMain.Controls.Add(this.btnStart);
            this.pMain.Controls.Add(this.lbPlayer2);
            this.pMain.Controls.Add(this.lbPlayer1);
            this.pMain.Controls.Add(this.tbPlayer2);
            this.pMain.Controls.Add(this.tbPlayer1);
            this.pMain.Location = new System.Drawing.Point(12, 76);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(1000, 600);
            this.pMain.TabIndex = 1;
            // 
            // pbGame
            // 
            this.pbGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbGame.Location = new System.Drawing.Point(0, 0);
            this.pbGame.Name = "pbGame";
            this.pbGame.Size = new System.Drawing.Size(1000, 600);
            this.pbGame.TabIndex = 5;
            this.pbGame.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(242)))), ((int)(((byte)(63)))));
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(360, 302);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(256, 64);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbPlayer2
            // 
            this.lbPlayer2.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPlayer2.ForeColor = System.Drawing.Color.White;
            this.lbPlayer2.Location = new System.Drawing.Point(248, 232);
            this.lbPlayer2.Name = "lbPlayer2";
            this.lbPlayer2.Size = new System.Drawing.Size(256, 64);
            this.lbPlayer2.TabIndex = 3;
            this.lbPlayer2.Text = "Player 2:";
            this.lbPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPlayer2.Visible = false;
            // 
            // lbPlayer1
            // 
            this.lbPlayer1.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPlayer1.ForeColor = System.Drawing.Color.White;
            this.lbPlayer1.Location = new System.Drawing.Point(248, 162);
            this.lbPlayer1.Name = "lbPlayer1";
            this.lbPlayer1.Size = new System.Drawing.Size(256, 64);
            this.lbPlayer1.TabIndex = 2;
            this.lbPlayer1.Text = "Player 1:";
            this.lbPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPlayer2
            // 
            this.tbPlayer2.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbPlayer2.Location = new System.Drawing.Point(510, 232);
            this.tbPlayer2.MaxLength = 3;
            this.tbPlayer2.Name = "tbPlayer2";
            this.tbPlayer2.Size = new System.Drawing.Size(144, 64);
            this.tbPlayer2.TabIndex = 1;
            this.tbPlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPlayer2.Visible = false;
            // 
            // tbPlayer1
            // 
            this.tbPlayer1.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbPlayer1.Location = new System.Drawing.Point(510, 162);
            this.tbPlayer1.MaxLength = 3;
            this.tbPlayer1.Name = "tbPlayer1";
            this.tbPlayer1.Size = new System.Drawing.Size(144, 64);
            this.tbPlayer1.TabIndex = 0;
            this.tbPlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPlayer1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxKeyPress);
            // 
            // timerTick
            // 
            this.timerTick.Interval = 150;
            this.timerTick.Tick += new System.EventHandler(this.timerTick_Tick);
            // 
            // lblP1Score
            // 
            this.lblP1Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(242)))), ((int)(((byte)(63)))));
            this.lblP1Score.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblP1Score.ForeColor = System.Drawing.Color.White;
            this.lblP1Score.Location = new System.Drawing.Point(12, 33);
            this.lblP1Score.Name = "lblP1Score";
            this.lblP1Score.Size = new System.Drawing.Size(150, 24);
            this.lblP1Score.TabIndex = 2;
            this.lblP1Score.Text = "Score:";
            this.lblP1Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblP2Score
            // 
            this.lblP2Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(242)))), ((int)(((byte)(63)))));
            this.lblP2Score.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblP2Score.ForeColor = System.Drawing.Color.White;
            this.lblP2Score.Location = new System.Drawing.Point(862, 33);
            this.lblP2Score.Name = "lblP2Score";
            this.lblP2Score.Size = new System.Drawing.Size(150, 24);
            this.lblP2Score.TabIndex = 3;
            this.lblP2Score.Text = "Score:";
            this.lblP2Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1024, 688);
            this.Controls.Add(this.lblP2Score);
            this.Controls.Add(this.lblP1Score);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.lbBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formGame";
            this.Text = "formStartGame";
            this.Load += new System.EventHandler(this.formStartGame_Load);
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbBanner;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Label lbPlayer2;
        private System.Windows.Forms.Label lbPlayer1;
        private System.Windows.Forms.TextBox tbPlayer2;
        private System.Windows.Forms.TextBox tbPlayer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timerTick;
        private System.Windows.Forms.PictureBox pbGame;
        private System.Windows.Forms.Label lblP1Score;
        private System.Windows.Forms.Label lblP2Score;
    }
}