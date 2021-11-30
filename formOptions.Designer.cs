
namespace CAP_MAN
{
    partial class formOptions
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
            this.lbLeaderboard = new System.Windows.Forms.Label();
            this.pMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbLeaderboard
            // 
            this.lbLeaderboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(63)))), ((int)(((byte)(112)))));
            this.lbLeaderboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbLeaderboard.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLeaderboard.ForeColor = System.Drawing.Color.White;
            this.lbLeaderboard.Location = new System.Drawing.Point(0, 0);
            this.lbLeaderboard.Margin = new System.Windows.Forms.Padding(0);
            this.lbLeaderboard.Name = "lbLeaderboard";
            this.lbLeaderboard.Size = new System.Drawing.Size(1024, 64);
            this.lbLeaderboard.TabIndex = 1;
            this.lbLeaderboard.Text = "Options";
            this.lbLeaderboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pMain.Location = new System.Drawing.Point(12, 76);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(1000, 600);
            this.pMain.TabIndex = 2;
            // 
            // formOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1024, 688);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.lbLeaderboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formOptions";
            this.Text = "formOptions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbLeaderboard;
        private System.Windows.Forms.Panel pMain;
    }
}