namespace Coffee_Shop_Management
{
    partial class DangKy
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
        private System.Windows.Forms.Label lblRePass;
        private System.Windows.Forms.TextBox nlmk;
        private System.Windows.Forms.Label lblQuyen;
        private System.Windows.Forms.ComboBox quyen;
        private System.Windows.Forms.CheckBox htmk;
        private System.Windows.Forms.Button dk;
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
            this.lblRePass = new System.Windows.Forms.Label();
            this.nlmk = new System.Windows.Forms.TextBox();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.quyen = new System.Windows.Forms.ComboBox();
            this.htmk = new System.Windows.Forms.CheckBox();
            this.dk = new System.Windows.Forms.Button();
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
            this.pnlHeader.Size = new System.Drawing.Size(567, 109);
            this.pnlHeader.TabIndex = 11;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(204)))), ((int)(((byte)(200)))));
            this.lblSubTitle.Location = new System.Drawing.Point(158, 63);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(248, 25);
            this.lblSubTitle.TabIndex = 0;
            this.lblSubTitle.Text = "Tạo tài khoản nhân viên mới";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(108, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(350, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblUser.Location = new System.Drawing.Point(116, 124);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(183, 28);
            this.lblUser.TabIndex = 10;
            this.lblUser.Text = "Tên tài khoản mới";
            // 
            // tentk
            // 
            this.tentk.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tentk.Location = new System.Drawing.Point(116, 150);
            this.tentk.Name = "tentk";
            this.tentk.Size = new System.Drawing.Size(345, 37);
            this.tentk.TabIndex = 9;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblPass.Location = new System.Drawing.Point(116, 190);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(102, 28);
            this.lblPass.TabIndex = 8;
            this.lblPass.Text = "Mật khẩu";
            // 
            // mk
            // 
            this.mk.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.mk.Location = new System.Drawing.Point(116, 216);
            this.mk.Name = "mk";
            this.mk.Size = new System.Drawing.Size(345, 37);
            this.mk.TabIndex = 7;
            this.mk.UseSystemPasswordChar = true;
            // 
            // lblRePass
            // 
            this.lblRePass.AutoSize = true;
            this.lblRePass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblRePass.Location = new System.Drawing.Point(116, 256);
            this.lblRePass.Name = "lblRePass";
            this.lblRePass.Size = new System.Drawing.Size(187, 28);
            this.lblRePass.TabIndex = 6;
            this.lblRePass.Text = "Nhập lại mật khẩu";
            // 
            // nlmk
            // 
            this.nlmk.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.nlmk.Location = new System.Drawing.Point(116, 282);
            this.nlmk.Name = "nlmk";
            this.nlmk.Size = new System.Drawing.Size(345, 37);
            this.nlmk.TabIndex = 5;
            this.nlmk.UseSystemPasswordChar = true;
            // 
            // lblQuyen
            // 
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblQuyen.Location = new System.Drawing.Point(116, 322);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(73, 28);
            this.lblQuyen.TabIndex = 4;
            this.lblQuyen.Text = "Quyền";
            // 
            // quyen
            // 
            this.quyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quyen.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.quyen.Items.AddRange(new object[] {
            "Nhân viên",
            "Admin"});
            this.quyen.Location = new System.Drawing.Point(116, 348);
            this.quyen.Name = "quyen";
            this.quyen.Size = new System.Drawing.Size(345, 38);
            this.quyen.TabIndex = 3;
            // 
            // htmk
            // 
            this.htmk.AutoSize = true;
            this.htmk.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.htmk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.htmk.Location = new System.Drawing.Point(116, 387);
            this.htmk.Name = "htmk";
            this.htmk.Size = new System.Drawing.Size(187, 29);
            this.htmk.TabIndex = 2;
            this.htmk.Text = "Hiển thị mật khẩu";
            // 
            // dk
            // 
            this.dk.Location = new System.Drawing.Point(116, 424);
            this.dk.Name = "dk";
            this.dk.Size = new System.Drawing.Size(165, 44);
            this.dk.TabIndex = 1;
            this.dk.Text = "ĐĂNG KÝ";
            // 
            // bt
            // 
            this.bt.Location = new System.Drawing.Point(296, 424);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(165, 44);
            this.bt.TabIndex = 0;
            this.bt.Text = "QUAY LẠI";
            // 
            // DangKy
            // 
            this.AcceptButton = this.dk;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(567, 494);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.dk);
            this.Controls.Add(this.htmk);
            this.Controls.Add(this.quyen);
            this.Controls.Add(this.lblQuyen);
            this.Controls.Add(this.nlmk);
            this.Controls.Add(this.lblRePass);
            this.Controls.Add(this.mk);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.tentk);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký tài khoản";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}