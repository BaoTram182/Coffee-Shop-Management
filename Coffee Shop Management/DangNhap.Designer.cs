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

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label ltk;
        private System.Windows.Forms.TextBox tk;
        private System.Windows.Forms.Label lmk;
        private System.Windows.Forms.TextBox mk;
        private System.Windows.Forms.CheckBox htmk;
        private System.Windows.Forms.Button dn;
        private System.Windows.Forms.Button bt;

        private void InitializeComponent()
        {
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.bt = new System.Windows.Forms.Button();
            this.dn = new System.Windows.Forms.Button();
            this.htmk = new System.Windows.Forms.CheckBox();
            this.mk = new System.Windows.Forms.TextBox();
            this.lmk = new System.Windows.Forms.Label();
            this.tk = new System.Windows.Forms.TextBox();
            this.ltk = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.pnlLeft.Controls.Add(this.lblBrand);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(426, 568);
            this.pnlLeft.TabIndex = 0;
            // 
            // lblBrand
            // 
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(12, 193);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(389, 117);
            this.lblBrand.TabIndex = 1;
            this.lblBrand.Text = "GÁC XÉP THÁNG TƯ COFFEE\nMANAGEMENT";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.bt);
            this.pnlRight.Controls.Add(this.dn);
            this.pnlRight.Controls.Add(this.htmk);
            this.pnlRight.Controls.Add(this.mk);
            this.pnlRight.Controls.Add(this.lmk);
            this.pnlRight.Controls.Add(this.tk);
            this.pnlRight.Controls.Add(this.ltk);
            this.pnlRight.Controls.Add(this.lblTitle);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(426, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(627, 568);
            this.pnlRight.TabIndex = 1;
            // 
            // bt
            // 
            this.bt.BackColor = System.Drawing.Color.Gainsboro;
            this.bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt.FlatAppearance.BorderSize = 0;
            this.bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bt.ForeColor = System.Drawing.Color.Black;
            this.bt.Location = new System.Drawing.Point(442, 290);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(115, 42);
            this.bt.TabIndex = 4;
            this.bt.Text = "Thoát";
            this.bt.UseVisualStyleBackColor = false;
            // 
            // dn
            // 
            this.dn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dn.FlatAppearance.BorderSize = 0;
            this.dn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dn.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.dn.ForeColor = System.Drawing.Color.White;
            this.dn.Location = new System.Drawing.Point(132, 290);
            this.dn.Name = "dn";
            this.dn.Size = new System.Drawing.Size(205, 42);
            this.dn.TabIndex = 3;
            this.dn.Text = "ĐĂNG NHẬP";
            this.dn.UseVisualStyleBackColor = false;
            this.dn.Click += new System.EventHandler(this.dn_Click);
            // 
            // htmk
            // 
            this.htmk.AutoSize = true;
            this.htmk.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.htmk.Location = new System.Drawing.Point(50, 245);
            this.htmk.Name = "htmk";
            this.htmk.Size = new System.Drawing.Size(187, 29);
            this.htmk.TabIndex = 2;
            this.htmk.Text = "Hiển thị mật khẩu";
            // 
            // mk
            // 
            this.mk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mk.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.mk.Location = new System.Drawing.Point(50, 205);
            this.mk.Name = "mk";
            this.mk.Size = new System.Drawing.Size(330, 37);
            this.mk.TabIndex = 1;
            this.mk.UseSystemPasswordChar = true;
            // 
            // lmk
            // 
            this.lmk.AutoSize = true;
            this.lmk.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lmk.Location = new System.Drawing.Point(50, 178);
            this.lmk.Name = "lmk";
            this.lmk.Size = new System.Drawing.Size(107, 28);
            this.lmk.TabIndex = 5;
            this.lmk.Text = "Mật khẩu:";
            // 
            // tk
            // 
            this.tk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tk.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tk.Location = new System.Drawing.Point(50, 132);
            this.tk.Name = "tk";
            this.tk.Size = new System.Drawing.Size(330, 37);
            this.tk.TabIndex = 0;
            // 
            // ltk
            // 
            this.ltk.AutoSize = true;
            this.ltk.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ltk.Location = new System.Drawing.Point(50, 105);
            this.ltk.Name = "ltk";
            this.ltk.Size = new System.Drawing.Size(157, 28);
            this.ltk.TabIndex = 6;
            this.ltk.Text = "Tên đăng nhập:";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblTitle.Location = new System.Drawing.Point(40, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(612, 45);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DangNhap
            // 
            this.AcceptButton = this.dn;
            this.ClientSize = new System.Drawing.Size(1053, 568);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập - Gác Xép Tháng Tư";
            this.pnlLeft.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}