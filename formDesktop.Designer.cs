
namespace CAP_MAN
{
    partial class formDesktop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDesktop));
            this.pTitleBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbFormName = new System.Windows.Forms.Label();
            this.pbFormIcon = new System.Windows.Forms.PictureBox();
            this.pDesktop = new System.Windows.Forms.Panel();
            this.pTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pTitleBar
            // 
            this.pTitleBar.BackColor = System.Drawing.Color.Black;
            this.pTitleBar.Controls.Add(this.btnClose);
            this.pTitleBar.Controls.Add(this.lbFormName);
            this.pTitleBar.Controls.Add(this.pbFormIcon);
            this.pTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pTitleBar.Name = "pTitleBar";
            this.pTitleBar.Size = new System.Drawing.Size(1280, 32);
            this.pTitleBar.TabIndex = 0;
            this.pTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1248, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbFormName
            // 
            this.lbFormName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbFormName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFormName.ForeColor = System.Drawing.Color.White;
            this.lbFormName.Location = new System.Drawing.Point(32, 0);
            this.lbFormName.Margin = new System.Windows.Forms.Padding(0);
            this.lbFormName.Name = "lbFormName";
            this.lbFormName.Size = new System.Drawing.Size(64, 32);
            this.lbFormName.TabIndex = 0;
            this.lbFormName.Text = "CAP-MAN";
            this.lbFormName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbFormIcon
            // 
            this.pbFormIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbFormIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbFormIcon.Image")));
            this.pbFormIcon.Location = new System.Drawing.Point(0, 0);
            this.pbFormIcon.Margin = new System.Windows.Forms.Padding(0);
            this.pbFormIcon.Name = "pbFormIcon";
            this.pbFormIcon.Size = new System.Drawing.Size(32, 32);
            this.pbFormIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFormIcon.TabIndex = 0;
            this.pbFormIcon.TabStop = false;
            // 
            // pDesktop
            // 
            this.pDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDesktop.Location = new System.Drawing.Point(0, 32);
            this.pDesktop.Name = "pDesktop";
            this.pDesktop.Size = new System.Drawing.Size(1280, 688);
            this.pDesktop.TabIndex = 1;
            // 
            // formDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pDesktop);
            this.Controls.Add(this.pTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFormIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTitleBar;
        private System.Windows.Forms.Label lbFormName;
        private System.Windows.Forms.PictureBox pbFormIcon;
        private System.Windows.Forms.Panel pDesktop;
        private System.Windows.Forms.Button btnClose;
    }
}

