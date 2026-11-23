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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lblHuongDan = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.pnlHeader.Controls.Add(this.lblSubTitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(30, 28, 30, 28);
            this.pnlHeader.Size = new System.Drawing.Size(1176, 200);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Italic);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(178)))));
            this.lblSubTitle.Location = new System.Drawing.Point(30, 126);
            this.lblSubTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(1116, 46);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Hệ Thống Quản Lý Gác Xép Tháng Tư";
            this.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 28);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1116, 89);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "GÁC XÉP THÁNG TƯ XIN CHÀO!";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.pnlBody.Controls.Add(this.pnlCard);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 200);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1176, 663);
            this.pnlBody.TabIndex = 1;
            // 
            // pnlCard
            // 
            this.pnlCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.lblHuongDan);
            this.pnlCard.Controls.Add(this.btnThoat);
            this.pnlCard.Controls.Add(this.btnDangKy);
            this.pnlCard.Controls.Add(this.btnDangNhap);
            this.pnlCard.Location = new System.Drawing.Point(243, 52);
            this.pnlCard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Padding = new System.Windows.Forms.Padding(42, 43, 42, 43);
            this.pnlCard.Size = new System.Drawing.Size(690, 557);
            this.pnlCard.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(48, 372);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(594, 92);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnDangKy.FlatAppearance.BorderSize = 0;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Location = new System.Drawing.Point(48, 249);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(594, 98);
            this.btnDangKy.TabIndex = 2;
            this.btnDangKy.Text = "ĐĂNG KÝ";
            this.btnDangKy.UseVisualStyleBackColor = false;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(48, 120);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(594, 105);
            this.btnDangNhap.TabIndex = 1;
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            // 
            // lblHuongDan
            // 
            this.lblHuongDan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHuongDan.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblHuongDan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblHuongDan.Location = new System.Drawing.Point(42, 43);
            this.lblHuongDan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHuongDan.Name = "lblHuongDan";
            this.lblHuongDan.Size = new System.Drawing.Size(606, 52);
            this.lblHuongDan.TabIndex = 0;
            this.lblHuongDan.Text = "CHỌN THAO TÁC ĐỂ BẮT ĐẦU CA LÀM VIỆC";
            this.lblHuongDan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1176, 863);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gác Xép Tháng Tư";
            this.pnlHeader.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label lblHuongDan;
    }
}