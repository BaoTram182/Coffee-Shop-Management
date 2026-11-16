namespace Coffee_Shop_Management
{
    partial class TrangChu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button modn;
        private System.Windows.Forms.Button modk;
        private System.Windows.Forms.Button bt;

        private void InitializeComponent()
        {
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.modn = new System.Windows.Forms.Button();
            this.modk = new System.Windows.Forms.Button();
            this.bt = new System.Windows.Forms.Button();
            this.pnlBanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBanner
            // 
            this.pnlBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.pnlBanner.Controls.Add(this.lblTitle);
            this.pnlBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBanner.Location = new System.Drawing.Point(0, 0);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.Size = new System.Drawing.Size(707, 135);
            this.pnlBanner.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(687, 73);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Gác Xép Tháng Tư xin chào!";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modn
            // 
            this.modn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.modn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modn.FlatAppearance.BorderSize = 0;
            this.modn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.modn.ForeColor = System.Drawing.Color.White;
            this.modn.Location = new System.Drawing.Point(212, 166);
            this.modn.Name = "modn";
            this.modn.Size = new System.Drawing.Size(300, 52);
            this.modn.TabIndex = 0;
            this.modn.Text = "ĐĂNG NHẬP";
            this.modn.UseVisualStyleBackColor = false;
            // 
            // modk
            // 
            this.modk.BackColor = System.Drawing.Color.SeaGreen;
            this.modk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modk.FlatAppearance.BorderSize = 0;
            this.modk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.modk.ForeColor = System.Drawing.Color.White;
            this.modk.Location = new System.Drawing.Point(212, 243);
            this.modk.Name = "modk";
            this.modk.Size = new System.Drawing.Size(300, 52);
            this.modk.TabIndex = 1;
            this.modk.Text = "ĐĂNG KÝ";
            this.modk.UseVisualStyleBackColor = false;
            // 
            // bt
            // 
            this.bt.BackColor = System.Drawing.Color.Gainsboro;
            this.bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt.FlatAppearance.BorderSize = 0;
            this.bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bt.ForeColor = System.Drawing.Color.Black;
            this.bt.Location = new System.Drawing.Point(212, 318);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(300, 60);
            this.bt.TabIndex = 2;
            this.bt.Text = "THOÁT";
            this.bt.UseVisualStyleBackColor = false;
            // 
            // TrangChu
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(707, 405);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.modk);
            this.Controls.Add(this.modn);
            this.Controls.Add(this.pnlBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gác Xép Tháng Tư xin chào!";
            this.pnlBanner.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}