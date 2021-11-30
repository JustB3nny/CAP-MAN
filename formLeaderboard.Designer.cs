
namespace CAP_MAN
{
    partial class formLeaderboard
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
            this.lstbLeaderboard = new System.Windows.Forms.ListBox();
            this.lbLeaderboard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbLeaderboard
            // 
            this.lstbLeaderboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lstbLeaderboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstbLeaderboard.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstbLeaderboard.ForeColor = System.Drawing.Color.White;
            this.lstbLeaderboard.FormattingEnabled = true;
            this.lstbLeaderboard.ItemHeight = 30;
            this.lstbLeaderboard.Location = new System.Drawing.Point(12, 76);
            this.lstbLeaderboard.Name = "lstbLeaderboard";
            this.lstbLeaderboard.Size = new System.Drawing.Size(1000, 600);
            this.lstbLeaderboard.TabIndex = 1;
            // 
            // lbLeaderboard
            // 
            this.lbLeaderboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(242)))), ((int)(((byte)(193)))));
            this.lbLeaderboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbLeaderboard.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLeaderboard.ForeColor = System.Drawing.Color.White;
            this.lbLeaderboard.Location = new System.Drawing.Point(0, 0);
            this.lbLeaderboard.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lbLeaderboard.Name = "lbLeaderboard";
            this.lbLeaderboard.Size = new System.Drawing.Size(1024, 64);
            this.lbLeaderboard.TabIndex = 0;
            this.lbLeaderboard.Text = "Leaderboard";
            this.lbLeaderboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formLeaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1024, 688);
            this.Controls.Add(this.lstbLeaderboard);
            this.Controls.Add(this.lbLeaderboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLeaderboard";
            this.Text = "formLeaderboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbLeaderboard;
        private System.Windows.Forms.Label lbLeaderboard;
    }
}