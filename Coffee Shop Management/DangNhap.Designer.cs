namespace Coffee_Shop_Management
{
    partial class DangNhap
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

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox tentk;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox mk;
        private System.Windows.Forms.CheckBox htmk;
        private System.Windows.Forms.Button dn;
        private System.Windows.Forms.Button bt;

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.tentk = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.mk = new System.Windows.Forms.TextBox();
            this.htmk = new System.Windows.Forms.CheckBox();
            this.dn = new System.Windows.Forms.Button();
            this.bt = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.pnlHeader.Controls.Add(this.lblSubTitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(498, 117);
            this.pnlHeader.TabIndex = 7;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(204)))), ((int)(((byte)(200)))));
            this.lblSubTitle.Location = new System.Drawing.Point(77, 73);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(341, 25);
            this.lblSubTitle.TabIndex = 0;
            this.lblSubTitle.Text = "Hệ thống quản lý của Gác Xép Tháng Tư";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(135, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(217, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "ĐĂNG NHẬP";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblUser.Location = new System.Drawing.Point(63, 147);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(145, 28);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "Tên tài khoản:";
            // 
            // tentk
            // 
            this.tentk.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tentk.Location = new System.Drawing.Point(63, 175);
            this.tentk.Name = "tentk";
            this.tentk.Size = new System.Drawing.Size(345, 37);
            this.tentk.TabIndex = 5;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblPass.Location = new System.Drawing.Point(63, 219);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(107, 28);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Mật khẩu:";
            // 
            // mk
            // 
            this.mk.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.mk.Location = new System.Drawing.Point(63, 247);
            this.mk.Name = "mk";
            this.mk.Size = new System.Drawing.Size(345, 37);
            this.mk.TabIndex = 3;
            this.mk.UseSystemPasswordChar = true;
            // 
            // htmk
            // 
            this.htmk.AutoSize = true;
            this.htmk.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.htmk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.htmk.Location = new System.Drawing.Point(63, 285);
            this.htmk.Name = "htmk";
            this.htmk.Size = new System.Drawing.Size(187, 29);
            this.htmk.TabIndex = 2;
            this.htmk.Text = "Hiển thị mật khẩu";
            // 
            // dn
            // 
            this.dn.Location = new System.Drawing.Point(63, 327);
            this.dn.Name = "dn";
            this.dn.Size = new System.Drawing.Size(165, 44);
            this.dn.TabIndex = 1;
            this.dn.Text = "ĐĂNG NHẬP";
            // 
            // bt
            // 
            this.bt.Location = new System.Drawing.Point(243, 327);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(165, 44);
            this.bt.TabIndex = 0;
            this.bt.Text = "QUAY LẠI";
            // 
            // DangNhap
            // 
            this.AcceptButton = this.dn;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(498, 411);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.dn);
            this.Controls.Add(this.htmk);
            this.Controls.Add(this.mk);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.tentk);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}