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
        private System.Windows.Forms.Label lblTenTK;
        private System.Windows.Forms.TextBox tentk;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox mk;
        private System.Windows.Forms.Label lblXacNhanMK;
        private System.Windows.Forms.TextBox xnmk;
        private System.Windows.Forms.Label lblQuyen;
        private System.Windows.Forms.ComboBox q;
        private System.Windows.Forms.CheckBox htmk;
        private System.Windows.Forms.Button dk;
        private System.Windows.Forms.Button bh;

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTenTK = new System.Windows.Forms.Label();
            this.tentk = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.mk = new System.Windows.Forms.TextBox();
            this.lblXacNhanMK = new System.Windows.Forms.Label();
            this.xnmk = new System.Windows.Forms.TextBox();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.q = new System.Windows.Forms.ComboBox();
            this.htmk = new System.Windows.Forms.CheckBox();
            this.dk = new System.Windows.Forms.Button();
            this.bh = new System.Windows.Forms.Button();
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
            this.pnlHeader.Size = new System.Drawing.Size(440, 123);
            this.pnlHeader.TabIndex = 11;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblSubTitle.ForeColor = System.Drawing.Color.Bisque;
            this.lblSubTitle.Location = new System.Drawing.Point(15, 71);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(410, 42);
            this.lblSubTitle.TabIndex = 0;
            this.lblSubTitle.Text = "Cấp tài khoản nhân viên / phục vụ";
            this.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(410, 46);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "TẠO TÀI KHOẢN MỚI";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenTK
            // 
            this.lblTenTK.AutoSize = true;
            this.lblTenTK.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTenTK.Location = new System.Drawing.Point(46, 144);
            this.lblTenTK.Name = "lblTenTK";
            this.lblTenTK.Size = new System.Drawing.Size(157, 28);
            this.lblTenTK.TabIndex = 10;
            this.lblTenTK.Text = "Tên đăng nhập:";
            // 
            // tentk
            // 
            this.tentk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tentk.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tentk.Location = new System.Drawing.Point(46, 170);
            this.tentk.Name = "tentk";
            this.tentk.Size = new System.Drawing.Size(350, 37);
            this.tentk.TabIndex = 0;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMatKhau.Location = new System.Drawing.Point(46, 210);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(107, 28);
            this.lblMatKhau.TabIndex = 9;
            this.lblMatKhau.Text = "Mật khẩu:";
            // 
            // mk
            // 
            this.mk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mk.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.mk.Location = new System.Drawing.Point(46, 236);
            this.mk.Name = "mk";
            this.mk.Size = new System.Drawing.Size(350, 37);
            this.mk.TabIndex = 1;
            this.mk.UseSystemPasswordChar = true;
            // 
            // lblXacNhanMK
            // 
            this.lblXacNhanMK.AutoSize = true;
            this.lblXacNhanMK.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblXacNhanMK.Location = new System.Drawing.Point(46, 276);
            this.lblXacNhanMK.Name = "lblXacNhanMK";
            this.lblXacNhanMK.Size = new System.Drawing.Size(199, 28);
            this.lblXacNhanMK.TabIndex = 8;
            this.lblXacNhanMK.Text = "Xác nhận mật khẩu:";
            // 
            // xnmk
            // 
            this.xnmk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xnmk.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.xnmk.Location = new System.Drawing.Point(46, 302);
            this.xnmk.Name = "xnmk";
            this.xnmk.Size = new System.Drawing.Size(350, 37);
            this.xnmk.TabIndex = 2;
            this.xnmk.UseSystemPasswordChar = true;
            // 
            // lblQuyen
            // 
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuyen.Location = new System.Drawing.Point(46, 342);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(216, 28);
            this.lblQuyen.TabIndex = 7;
            this.lblQuyen.Text = "Chức vụ / Quyền hạn:";
            // 
            // q
            // 
            this.q.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.q.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.q.Items.AddRange(new object[] {
            "Nhân viên",
            "Phục vụ",
            "Admin"});
            this.q.Location = new System.Drawing.Point(46, 368);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(350, 38);
            this.q.TabIndex = 3;
            // 
            // htmk
            // 
            this.htmk.AutoSize = true;
            this.htmk.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.htmk.Location = new System.Drawing.Point(46, 409);
            this.htmk.Name = "htmk";
            this.htmk.Size = new System.Drawing.Size(187, 29);
            this.htmk.TabIndex = 4;
            this.htmk.Text = "Hiển thị mật khẩu";
            // 
            // dk
            // 
            this.dk.BackColor = System.Drawing.Color.SeaGreen;
            this.dk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dk.FlatAppearance.BorderSize = 0;
            this.dk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dk.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.dk.ForeColor = System.Drawing.Color.White;
            this.dk.Location = new System.Drawing.Point(46, 449);
            this.dk.Name = "dk";
            this.dk.Size = new System.Drawing.Size(220, 42);
            this.dk.TabIndex = 5;
            this.dk.Text = "ĐĂNG KÝ";
            this.dk.UseVisualStyleBackColor = false;
            // 
            // bh
            // 
            this.bh.BackColor = System.Drawing.Color.Gainsboro;
            this.bh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bh.FlatAppearance.BorderSize = 0;
            this.bh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bh.ForeColor = System.Drawing.Color.Black;
            this.bh.Location = new System.Drawing.Point(276, 449);
            this.bh.Name = "bh";
            this.bh.Size = new System.Drawing.Size(120, 42);
            this.bh.TabIndex = 6;
            this.bh.Text = "Hủy";
            this.bh.UseVisualStyleBackColor = false;
            // 
            // DangKy
            // 
            this.AcceptButton = this.dk;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 518);
            this.Controls.Add(this.bh);
            this.Controls.Add(this.dk);
            this.Controls.Add(this.htmk);
            this.Controls.Add(this.q);
            this.Controls.Add(this.lblQuyen);
            this.Controls.Add(this.xnmk);
            this.Controls.Add(this.lblXacNhanMK);
            this.Controls.Add(this.mk);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.tentk);
            this.Controls.Add(this.lblTenTK);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tạo tài khoản";
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}