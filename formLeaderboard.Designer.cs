
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
            this.lstbName = new System.Windows.Forms.ListBox();
            this.lbLeaderboard = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl10th = new System.Windows.Forms.Label();
            this.lbl9th = new System.Windows.Forms.Label();
            this.lbl8th = new System.Windows.Forms.Label();
            this.lbl7th = new System.Windows.Forms.Label();
            this.lbl6th = new System.Windows.Forms.Label();
            this.lbl5th = new System.Windows.Forms.Label();
            this.lbl4th = new System.Windows.Forms.Label();
            this.lbl3rd = new System.Windows.Forms.Label();
            this.lbl2nd = new System.Windows.Forms.Label();
            this.lbl1st = new System.Windows.Forms.Label();
            this.lstbScore = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbName
            // 
            this.lstbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lstbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstbName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstbName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstbName.ForeColor = System.Drawing.Color.White;
            this.lstbName.FormattingEnabled = true;
            this.lstbName.ItemHeight = 54;
            this.lstbName.Location = new System.Drawing.Point(666, 60);
            this.lstbName.Name = "lstbName";
            this.lstbName.Size = new System.Drawing.Size(333, 540);
            this.lstbName.TabIndex = 15;
            this.lstbName.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listTypes_DrawItem);
            // 
            // lbLeaderboard
            // 
            this.lbLeaderboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(242)))), ((int)(((byte)(193)))));
            this.lbLeaderboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbLeaderboard.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLeaderboard.ForeColor = System.Drawing.Color.White;
            this.lbLeaderboard.Location = new System.Drawing.Point(0, 0);
            this.lbLeaderboard.Margin = new System.Windows.Forms.Padding(0);
            this.lbLeaderboard.Name = "lbLeaderboard";
            this.lbLeaderboard.Size = new System.Drawing.Size(1024, 64);
            this.lbLeaderboard.TabIndex = 0;
            this.lbLeaderboard.Text = "Leaderboard";
            this.lbLeaderboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.lbl10th);
            this.panel1.Controls.Add(this.lbl9th);
            this.panel1.Controls.Add(this.lbl8th);
            this.panel1.Controls.Add(this.lbl7th);
            this.panel1.Controls.Add(this.lbl6th);
            this.panel1.Controls.Add(this.lbl5th);
            this.panel1.Controls.Add(this.lbl4th);
            this.panel1.Controls.Add(this.lbl3rd);
            this.panel1.Controls.Add(this.lbl2nd);
            this.panel1.Controls.Add(this.lbl1st);
            this.panel1.Controls.Add(this.lstbScore);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblScore);
            this.panel1.Controls.Add(this.lblRank);
            this.panel1.Controls.Add(this.lstbName);
            this.panel1.Location = new System.Drawing.Point(12, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 600);
            this.panel1.TabIndex = 2;
            // 
            // lbl10th
            // 
            this.lbl10th.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl10th.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl10th.ForeColor = System.Drawing.Color.White;
            this.lbl10th.Location = new System.Drawing.Point(0, 546);
            this.lbl10th.Name = "lbl10th";
            this.lbl10th.Size = new System.Drawing.Size(333, 54);
            this.lbl10th.TabIndex = 13;
            this.lbl10th.Text = "10th";
            this.lbl10th.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl9th
            // 
            this.lbl9th.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl9th.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl9th.ForeColor = System.Drawing.Color.White;
            this.lbl9th.Location = new System.Drawing.Point(0, 492);
            this.lbl9th.Name = "lbl9th";
            this.lbl9th.Size = new System.Drawing.Size(333, 54);
            this.lbl9th.TabIndex = 12;
            this.lbl9th.Text = "9th";
            this.lbl9th.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl8th
            // 
            this.lbl8th.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl8th.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl8th.ForeColor = System.Drawing.Color.White;
            this.lbl8th.Location = new System.Drawing.Point(0, 438);
            this.lbl8th.Name = "lbl8th";
            this.lbl8th.Size = new System.Drawing.Size(333, 54);
            this.lbl8th.TabIndex = 11;
            this.lbl8th.Text = "8th";
            this.lbl8th.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl7th
            // 
            this.lbl7th.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl7th.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl7th.ForeColor = System.Drawing.Color.White;
            this.lbl7th.Location = new System.Drawing.Point(0, 384);
            this.lbl7th.Name = "lbl7th";
            this.lbl7th.Size = new System.Drawing.Size(333, 54);
            this.lbl7th.TabIndex = 10;
            this.lbl7th.Text = "7th";
            this.lbl7th.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl6th
            // 
            this.lbl6th.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl6th.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl6th.ForeColor = System.Drawing.Color.White;
            this.lbl6th.Location = new System.Drawing.Point(0, 330);
            this.lbl6th.Name = "lbl6th";
            this.lbl6th.Size = new System.Drawing.Size(333, 54);
            this.lbl6th.TabIndex = 9;
            this.lbl6th.Text = "6th";
            this.lbl6th.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5th
            // 
            this.lbl5th.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl5th.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl5th.ForeColor = System.Drawing.Color.White;
            this.lbl5th.Location = new System.Drawing.Point(0, 276);
            this.lbl5th.Name = "lbl5th";
            this.lbl5th.Size = new System.Drawing.Size(333, 54);
            this.lbl5th.TabIndex = 8;
            this.lbl5th.Text = "5th";
            this.lbl5th.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4th
            // 
            this.lbl4th.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl4th.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl4th.ForeColor = System.Drawing.Color.White;
            this.lbl4th.Location = new System.Drawing.Point(0, 222);
            this.lbl4th.Name = "lbl4th";
            this.lbl4th.Size = new System.Drawing.Size(333, 54);
            this.lbl4th.TabIndex = 7;
            this.lbl4th.Text = "4th";
            this.lbl4th.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3rd
            // 
            this.lbl3rd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl3rd.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl3rd.ForeColor = System.Drawing.Color.White;
            this.lbl3rd.Location = new System.Drawing.Point(0, 168);
            this.lbl3rd.Name = "lbl3rd";
            this.lbl3rd.Size = new System.Drawing.Size(333, 54);
            this.lbl3rd.TabIndex = 6;
            this.lbl3rd.Text = "3rd";
            this.lbl3rd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2nd
            // 
            this.lbl2nd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl2nd.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl2nd.ForeColor = System.Drawing.Color.White;
            this.lbl2nd.Location = new System.Drawing.Point(0, 114);
            this.lbl2nd.Name = "lbl2nd";
            this.lbl2nd.Size = new System.Drawing.Size(333, 54);
            this.lbl2nd.TabIndex = 5;
            this.lbl2nd.Text = "2nd";
            this.lbl2nd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1st
            // 
            this.lbl1st.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl1st.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl1st.ForeColor = System.Drawing.Color.White;
            this.lbl1st.Location = new System.Drawing.Point(0, 60);
            this.lbl1st.Name = "lbl1st";
            this.lbl1st.Size = new System.Drawing.Size(333, 54);
            this.lbl1st.TabIndex = 4;
            this.lbl1st.Text = "1st";
            this.lbl1st.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstbScore
            // 
            this.lstbScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lstbScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstbScore.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstbScore.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstbScore.ForeColor = System.Drawing.Color.White;
            this.lstbScore.FormattingEnabled = true;
            this.lstbScore.ItemHeight = 54;
            this.lstbScore.Location = new System.Drawing.Point(333, 60);
            this.lstbScore.Name = "lstbScore";
            this.lstbScore.Size = new System.Drawing.Size(333, 540);
            this.lstbScore.TabIndex = 14;
            this.lstbScore.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listTypes_DrawItem);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(242)))), ((int)(((byte)(193)))));
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(666, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(333, 60);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(242)))), ((int)(((byte)(193)))));
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(333, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(333, 60);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRank
            // 
            this.lblRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(242)))), ((int)(((byte)(193)))));
            this.lblRank.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRank.ForeColor = System.Drawing.Color.White;
            this.lblRank.Location = new System.Drawing.Point(0, 0);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(333, 60);
            this.lblRank.TabIndex = 1;
            this.lblRank.Text = "Rank";
            this.lblRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formLeaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1024, 688);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbLeaderboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLeaderboard";
            this.Text = "formLeaderboard";
            this.Load += new System.EventHandler(this.formLeaderboard_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbName;
        private System.Windows.Forms.Label lbLeaderboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstbScore;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label lbl10th;
        private System.Windows.Forms.Label lbl9th;
        private System.Windows.Forms.Label lbl8th;
        private System.Windows.Forms.Label lbl7th;
        private System.Windows.Forms.Label lbl6th;
        private System.Windows.Forms.Label lbl5th;
        private System.Windows.Forms.Label lbl4th;
        private System.Windows.Forms.Label lbl3rd;
        private System.Windows.Forms.Label lbl2nd;
        private System.Windows.Forms.Label lbl1st;
    }
}