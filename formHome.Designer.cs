
namespace CAP_MAN
{
    partial class formHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHome));
            this.lbGameTitle = new System.Windows.Forms.Label();
            this.pMenu = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnControls = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnLeaderboard = new System.Windows.Forms.Button();
            this.btnLocalMultiplayer = new System.Windows.Forms.Button();
            this.btnSingleplayer = new System.Windows.Forms.Button();
            this.pDesktop = new System.Windows.Forms.Panel();
            this.pbBanner = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pMenu.SuspendLayout();
            this.pDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbGameTitle
            // 
            this.lbGameTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(63)))), ((int)(((byte)(242)))));
            this.lbGameTitle.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbGameTitle.ForeColor = System.Drawing.Color.White;
            this.lbGameTitle.Location = new System.Drawing.Point(0, 0);
            this.lbGameTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbGameTitle.Name = "lbGameTitle";
            this.lbGameTitle.Size = new System.Drawing.Size(256, 64);
            this.lbGameTitle.TabIndex = 0;
            this.lbGameTitle.Text = "CAP - MAN";
            this.lbGameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.btnQuit);
            this.pMenu.Controls.Add(this.btnControls);
            this.pMenu.Controls.Add(this.btnOptions);
            this.pMenu.Controls.Add(this.btnLeaderboard);
            this.pMenu.Controls.Add(this.btnLocalMultiplayer);
            this.pMenu.Controls.Add(this.btnSingleplayer);
            this.pMenu.Controls.Add(this.lbGameTitle);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Padding = new System.Windows.Forms.Padding(2);
            this.pMenu.Size = new System.Drawing.Size(256, 688);
            this.pMenu.TabIndex = 1;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(63)))), ((int)(((byte)(112)))));
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(0, 526);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(256, 64);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnClick);
            // 
            // btnControls
            // 
            this.btnControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(242)))), ((int)(((byte)(193)))));
            this.btnControls.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnControls.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnControls.ForeColor = System.Drawing.Color.White;
            this.btnControls.Location = new System.Drawing.Point(0, 386);
            this.btnControls.Name = "btnControls";
            this.btnControls.Size = new System.Drawing.Size(256, 64);
            this.btnControls.TabIndex = 4;
            this.btnControls.Text = "Controls";
            this.btnControls.UseVisualStyleBackColor = false;
            this.btnControls.Click += new System.EventHandler(this.btnClick);
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(63)))), ((int)(((byte)(112)))));
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOptions.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOptions.ForeColor = System.Drawing.Color.White;
            this.btnOptions.Location = new System.Drawing.Point(0, 456);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(256, 64);
            this.btnOptions.TabIndex = 5;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnClick);
            // 
            // btnLeaderboard
            // 
            this.btnLeaderboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(242)))), ((int)(((byte)(193)))));
            this.btnLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeaderboard.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLeaderboard.ForeColor = System.Drawing.Color.White;
            this.btnLeaderboard.Location = new System.Drawing.Point(0, 316);
            this.btnLeaderboard.Name = "btnLeaderboard";
            this.btnLeaderboard.Size = new System.Drawing.Size(256, 64);
            this.btnLeaderboard.TabIndex = 3;
            this.btnLeaderboard.Text = "Leaderboard";
            this.btnLeaderboard.UseVisualStyleBackColor = false;
            this.btnLeaderboard.Click += new System.EventHandler(this.btnClick);
            // 
            // btnLocalMultiplayer
            // 
            this.btnLocalMultiplayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(242)))), ((int)(((byte)(63)))));
            this.btnLocalMultiplayer.FlatAppearance.BorderSize = 0;
            this.btnLocalMultiplayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLocalMultiplayer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLocalMultiplayer.ForeColor = System.Drawing.Color.White;
            this.btnLocalMultiplayer.Location = new System.Drawing.Point(0, 246);
            this.btnLocalMultiplayer.Name = "btnLocalMultiplayer";
            this.btnLocalMultiplayer.Size = new System.Drawing.Size(256, 64);
            this.btnLocalMultiplayer.TabIndex = 2;
            this.btnLocalMultiplayer.Text = "Local Multiplayer";
            this.btnLocalMultiplayer.UseVisualStyleBackColor = false;
            this.btnLocalMultiplayer.Click += new System.EventHandler(this.btnClick);
            // 
            // btnSingleplayer
            // 
            this.btnSingleplayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(242)))), ((int)(((byte)(63)))));
            this.btnSingleplayer.FlatAppearance.BorderSize = 0;
            this.btnSingleplayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSingleplayer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSingleplayer.ForeColor = System.Drawing.Color.White;
            this.btnSingleplayer.Location = new System.Drawing.Point(0, 176);
            this.btnSingleplayer.Name = "btnSingleplayer";
            this.btnSingleplayer.Size = new System.Drawing.Size(256, 64);
            this.btnSingleplayer.TabIndex = 1;
            this.btnSingleplayer.Text = "Singleplayer";
            this.btnSingleplayer.UseVisualStyleBackColor = false;
            this.btnSingleplayer.Click += new System.EventHandler(this.btnClick);
            // 
            // pDesktop
            // 
            this.pDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pDesktop.Controls.Add(this.pbBanner);
            this.pDesktop.Controls.Add(this.pbLogo);
            this.pDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDesktop.Location = new System.Drawing.Point(256, 0);
            this.pDesktop.Name = "pDesktop";
            this.pDesktop.Size = new System.Drawing.Size(1024, 688);
            this.pDesktop.TabIndex = 2;
            // 
            // pbBanner
            // 
            this.pbBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(63)))), ((int)(((byte)(242)))));
            this.pbBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbBanner.Location = new System.Drawing.Point(0, 0);
            this.pbBanner.Margin = new System.Windows.Forms.Padding(0);
            this.pbBanner.Name = "pbBanner";
            this.pbBanner.Size = new System.Drawing.Size(1024, 64);
            this.pbBanner.TabIndex = 1;
            this.pbBanner.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(332, 164);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(360, 360);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1280, 688);
            this.Controls.Add(this.pDesktop);
            this.Controls.Add(this.pMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formHome";
            this.Text = "Home";
            this.pMenu.ResumeLayout(false);
            this.pDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbGameTitle;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnControls;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnLeaderboard;
        private System.Windows.Forms.Button btnLocalMultiplayer;
        private System.Windows.Forms.Button btnSingleplayer;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbBanner;
        public System.Windows.Forms.Panel pDesktop;
    }
}