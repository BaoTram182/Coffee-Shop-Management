namespace Coffee_Shop_Management
{
    partial class BanHang
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTraCuuHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mainGrid = new System.Windows.Forms.TableLayoutPanel();
            this.pnlColBan = new System.Windows.Forms.Panel();
            this.sdb = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHeaderBan = new System.Windows.Forms.Label();
            this.pnlColMenu = new System.Windows.Forms.Panel();
            this.flpThucDonPOS = new System.Windows.Forms.FlowLayoutPanel();
            this.flpDanhMucPOS = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHeaderMenu = new System.Windows.Forms.Label();
            this.pnlColBill = new System.Windows.Forms.Panel();
            this.lsvhd = new System.Windows.Forms.ListView();
            this.colTenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlBottomBill = new System.Windows.Forms.Panel();
            this.tblAction = new System.Windows.Forms.TableLayoutPanel();
            this.btnThemTouch = new Coffee_Shop_Management.RoundedButton();
            this.btnSuaTouch = new Coffee_Shop_Management.RoundedButton();
            this.btnXoaTouch = new Coffee_Shop_Management.RoundedButton();
            this.txtTongTienPOS = new System.Windows.Forms.TextBox();
            this.btnThanhToanTouch = new Coffee_Shop_Management.RoundedButton();
            this.lblTieuDeBanPOS = new System.Windows.Forms.Label();
            this.lblHeaderBill = new System.Windows.Forms.Label();
            this.grpban = new System.Windows.Forms.GroupBox();
            this.gcthd = new System.Windows.Forms.GroupBox();
            this.grpChonMon = new System.Windows.Forms.GroupBox();
            this.gtt = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.mainGrid.SuspendLayout();
            this.pnlColBan.SuspendLayout();
            this.pnlColMenu.SuspendLayout();
            this.pnlColBill.SuspendLayout();
            this.pnlBottomBill.SuspendLayout();
            this.tblAction.SuspendLayout();
            this.SuspendLayout();

            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTraCuuHD,
            this.mnuDangXuat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.menuStrip1.Size = new System.Drawing.Size(1366, 45);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            this.mnuTraCuuHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(130)))));
            this.mnuTraCuuHD.Name = "mnuTraCuuHD";
            this.mnuTraCuuHD.Size = new System.Drawing.Size(156, 25);
            this.mnuTraCuuHD.Text = "Tra cứu hóa đơn";

            this.mnuDangXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(145)))));
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(102, 25);
            this.mnuDangXuat.Text = "Đăng xuất";

            this.mainGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.mainGrid.ColumnCount = 3;
            this.mainGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.mainGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41F));
            this.mainGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainGrid.Controls.Add(this.pnlColBan, 0, 0);
            this.mainGrid.Controls.Add(this.pnlColMenu, 1, 0);
            this.mainGrid.Controls.Add(this.pnlColBill, 2, 0);
            this.mainGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGrid.Location = new System.Drawing.Point(0, 45);
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.Padding = new System.Windows.Forms.Padding(10);
            this.mainGrid.RowCount = 1;
            this.mainGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainGrid.Size = new System.Drawing.Size(1366, 723);
            this.mainGrid.TabIndex = 1;

            this.pnlColBan.BackColor = System.Drawing.Color.White;
            this.pnlColBan.Controls.Add(this.sdb);
            this.pnlColBan.Controls.Add(this.lblHeaderBan);
            this.pnlColBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlColBan.Location = new System.Drawing.Point(16, 16);
            this.pnlColBan.Margin = new System.Windows.Forms.Padding(6);
            this.pnlColBan.Name = "pnlColBan";
            this.pnlColBan.Padding = new System.Windows.Forms.Padding(1);
            this.pnlColBan.Size = new System.Drawing.Size(378, 691);
            this.pnlColBan.TabIndex = 0;

            this.sdb.AutoScroll = true;
            this.sdb.BackColor = System.Drawing.Color.White;
            this.sdb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sdb.Location = new System.Drawing.Point(1, 39);
            this.sdb.Name = "sdb";
            this.sdb.Padding = new System.Windows.Forms.Padding(6, 10, 6, 6);
            this.sdb.Size = new System.Drawing.Size(376, 651);
            this.sdb.TabIndex = 1;

            this.lblHeaderBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblHeaderBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeaderBan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeaderBan.ForeColor = System.Drawing.Color.White;
            this.lblHeaderBan.Location = new System.Drawing.Point(1, 1);
            this.lblHeaderBan.Name = "lblHeaderBan";
            this.lblHeaderBan.Size = new System.Drawing.Size(376, 38);
            this.lblHeaderBan.TabIndex = 0;
            this.lblHeaderBan.Text = "  SƠ ĐỒ BÀN  ";
            this.lblHeaderBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.pnlColMenu.BackColor = System.Drawing.Color.White;
            this.pnlColMenu.Controls.Add(this.flpThucDonPOS);
            this.pnlColMenu.Controls.Add(this.flpDanhMucPOS);
            this.pnlColMenu.Controls.Add(this.lblHeaderMenu);
            this.pnlColMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlColMenu.Location = new System.Drawing.Point(406, 16);
            this.pnlColMenu.Margin = new System.Windows.Forms.Padding(6);
            this.pnlColMenu.Name = "pnlColMenu";
            this.pnlColMenu.Padding = new System.Windows.Forms.Padding(1);
            this.pnlColMenu.Size = new System.Drawing.Size(540, 691);
            this.pnlColMenu.TabIndex = 1;

            this.flpThucDonPOS.AutoScroll = true;
            this.flpThucDonPOS.BackColor = System.Drawing.Color.White;
            this.flpThucDonPOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpThucDonPOS.Location = new System.Drawing.Point(1, 101);
            this.flpThucDonPOS.Name = "flpThucDonPOS";
            this.flpThucDonPOS.Padding = new System.Windows.Forms.Padding(8);
            this.flpThucDonPOS.Size = new System.Drawing.Size(538, 589);
            this.flpThucDonPOS.TabIndex = 2;

            this.flpDanhMucPOS.AutoScroll = true;
            this.flpDanhMucPOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.flpDanhMucPOS.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpDanhMucPOS.Location = new System.Drawing.Point(1, 39);
            this.flpDanhMucPOS.Name = "flpDanhMucPOS";
            this.flpDanhMucPOS.Padding = new System.Windows.Forms.Padding(6, 8, 6, 6);
            this.flpDanhMucPOS.Size = new System.Drawing.Size(538, 62);
            this.flpDanhMucPOS.TabIndex = 1;
            this.flpDanhMucPOS.WrapContents = false;

            this.lblHeaderMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblHeaderMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeaderMenu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeaderMenu.ForeColor = System.Drawing.Color.White;
            this.lblHeaderMenu.Location = new System.Drawing.Point(1, 1);
            this.lblHeaderMenu.Name = "lblHeaderMenu";
            this.lblHeaderMenu.Size = new System.Drawing.Size(538, 38);
            this.lblHeaderMenu.TabIndex = 0;
            this.lblHeaderMenu.Text = "  THỰC ĐƠN  ";
            this.lblHeaderMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.pnlColBill.BackColor = System.Drawing.Color.White;
            this.pnlColBill.Controls.Add(this.lsvhd);
            this.pnlColBill.Controls.Add(this.pnlBottomBill);
            this.pnlColBill.Controls.Add(this.lblTieuDeBanPOS);
            this.pnlColBill.Controls.Add(this.lblHeaderBill);
            this.pnlColBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlColBill.Location = new System.Drawing.Point(958, 16);
            this.pnlColBill.Margin = new System.Windows.Forms.Padding(6);
            this.pnlColBill.Name = "pnlColBill";
            this.pnlColBill.Padding = new System.Windows.Forms.Padding(1);
            this.pnlColBill.Size = new System.Drawing.Size(392, 691);
            this.pnlColBill.TabIndex = 2;

            this.lsvhd.BackColor = System.Drawing.Color.White;
            this.lsvhd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvhd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTenMon,
            this.colSoLuong,
            this.colDonGia,
            this.colThanhTien});
            this.lsvhd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvhd.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lsvhd.FullRowSelect = true;
            this.lsvhd.GridLines = true;
            this.lsvhd.HideSelection = false;
            this.lsvhd.Location = new System.Drawing.Point(1, 81);
            this.lsvhd.Name = "lsvhd";
            this.lsvhd.Size = new System.Drawing.Size(390, 414);
            this.lsvhd.TabIndex = 2;
            this.lsvhd.UseCompatibleStateImageBehavior = false;
            this.lsvhd.View = System.Windows.Forms.View.Details;

            this.colTenMon.Text = "Tên món";
            this.colTenMon.Width = 155;
            this.colSoLuong.Text = "SL";
            this.colSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSoLuong.Width = 50;
            this.colDonGia.Text = "Đơn giá";
            this.colDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colDonGia.Width = 85;
            this.colThanhTien.Text = "Thành tiền";
            this.colThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colThanhTien.Width = 96;

            this.pnlBottomBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.pnlBottomBill.Controls.Add(this.btnThanhToanTouch);
            this.pnlBottomBill.Controls.Add(this.txtTongTienPOS);
            this.pnlBottomBill.Controls.Add(this.tblAction);
            this.pnlBottomBill.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomBill.Location = new System.Drawing.Point(1, 495);
            this.pnlBottomBill.Name = "pnlBottomBill";
            this.pnlBottomBill.Padding = new System.Windows.Forms.Padding(8);
            this.pnlBottomBill.Size = new System.Drawing.Size(390, 195);
            this.pnlBottomBill.TabIndex = 3;

            this.tblAction.ColumnCount = 3;
            this.tblAction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblAction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblAction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tblAction.Controls.Add(this.btnThemTouch, 0, 0);
            this.tblAction.Controls.Add(this.btnSuaTouch, 1, 0);
            this.tblAction.Controls.Add(this.btnXoaTouch, 2, 0);
            this.tblAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblAction.Location = new System.Drawing.Point(8, 8);
            this.tblAction.Name = "tblAction";
            this.tblAction.RowCount = 1;
            this.tblAction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblAction.Size = new System.Drawing.Size(374, 56);
            this.tblAction.TabIndex = 0;

            this.btnThemTouch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnThemTouch.BorderColor = System.Drawing.Color.Transparent;
            this.btnThemTouch.BorderRadius = 12;
            this.btnThemTouch.BorderSize = 0;
            this.btnThemTouch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThemTouch.FlatAppearance.BorderSize = 0;
            this.btnThemTouch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTouch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnThemTouch.ForeColor = System.Drawing.Color.White;
            this.btnThemTouch.Location = new System.Drawing.Point(4, 4);
            this.btnThemTouch.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemTouch.Name = "btnThemTouch";
            this.btnThemTouch.Size = new System.Drawing.Size(116, 48);
            this.btnThemTouch.TabIndex = 0;
            this.btnThemTouch.Text = "THÊM";
            this.btnThemTouch.UseVisualStyleBackColor = false;

            this.btnSuaTouch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.btnSuaTouch.BorderColor = System.Drawing.Color.Transparent;
            this.btnSuaTouch.BorderRadius = 12;
            this.btnSuaTouch.BorderSize = 0;
            this.btnSuaTouch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSuaTouch.FlatAppearance.BorderSize = 0;
            this.btnSuaTouch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaTouch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSuaTouch.ForeColor = System.Drawing.Color.White;
            this.btnSuaTouch.Location = new System.Drawing.Point(128, 4);
            this.btnSuaTouch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaTouch.Name = "btnSuaTouch";
            this.btnSuaTouch.Size = new System.Drawing.Size(116, 48);
            this.btnSuaTouch.TabIndex = 1;
            this.btnSuaTouch.Text = "SỬA";
            this.btnSuaTouch.UseVisualStyleBackColor = false;

            this.btnXoaTouch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnXoaTouch.BorderColor = System.Drawing.Color.Transparent;
            this.btnXoaTouch.BorderRadius = 12;
            this.btnXoaTouch.BorderSize = 0;
            this.btnXoaTouch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoaTouch.FlatAppearance.BorderSize = 0;
            this.btnXoaTouch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTouch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnXoaTouch.ForeColor = System.Drawing.Color.White;
            this.btnXoaTouch.Location = new System.Drawing.Point(252, 4);
            this.btnXoaTouch.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaTouch.Name = "btnXoaTouch";
            this.btnXoaTouch.Size = new System.Drawing.Size(118, 48);
            this.btnXoaTouch.TabIndex = 2;
            this.btnXoaTouch.Text = "XÓA";
            this.btnXoaTouch.UseVisualStyleBackColor = false;

            this.txtTongTienPOS.BackColor = System.Drawing.Color.White;
            this.txtTongTienPOS.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTongTienPOS.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.txtTongTienPOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtTongTienPOS.Location = new System.Drawing.Point(8, 64);
            this.txtTongTienPOS.Name = "txtTongTienPOS";
            this.txtTongTienPOS.ReadOnly = true;
            this.txtTongTienPOS.Size = new System.Drawing.Size(374, 36);
            this.txtTongTienPOS.TabIndex = 1;
            this.txtTongTienPOS.Text = "0 VNĐ";
            this.txtTongTienPOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            this.btnThanhToanTouch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnThanhToanTouch.BorderColor = System.Drawing.Color.Transparent;
            this.btnThanhToanTouch.BorderRadius = 12;
            this.btnThanhToanTouch.BorderSize = 0;
            this.btnThanhToanTouch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThanhToanTouch.FlatAppearance.BorderSize = 0;
            this.btnThanhToanTouch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToanTouch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnThanhToanTouch.ForeColor = System.Drawing.Color.White;
            this.btnThanhToanTouch.Location = new System.Drawing.Point(8, 123);
            this.btnThanhToanTouch.Name = "btnThanhToanTouch";
            this.btnThanhToanTouch.Size = new System.Drawing.Size(374, 64);
            this.btnThanhToanTouch.TabIndex = 2;
            this.btnThanhToanTouch.Text = "THANH TOÁN";
            this.btnThanhToanTouch.UseVisualStyleBackColor = false;

            this.lblTieuDeBanPOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.lblTieuDeBanPOS.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDeBanPOS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTieuDeBanPOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(67)))), ((int)(((byte)(21)))));
            this.lblTieuDeBanPOS.Location = new System.Drawing.Point(1, 39);
            this.lblTieuDeBanPOS.Name = "lblTieuDeBanPOS";
            this.lblTieuDeBanPOS.Size = new System.Drawing.Size(390, 42);
            this.lblTieuDeBanPOS.TabIndex = 1;
            this.lblTieuDeBanPOS.Text = "Chưa chọn bàn";
            this.lblTieuDeBanPOS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblHeaderBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblHeaderBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeaderBill.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeaderBill.ForeColor = System.Drawing.Color.White;
            this.lblHeaderBill.Location = new System.Drawing.Point(1, 1);
            this.lblHeaderBill.Name = "lblHeaderBill";
            this.lblHeaderBill.Size = new System.Drawing.Size(390, 38);
            this.lblHeaderBill.TabIndex = 0;
            this.lblHeaderBill.Text = "  CHI TIẾT HÓA ĐƠN";
            this.lblHeaderBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.grpban.Visible = false;
            this.gcthd.Visible = false;
            this.grpChonMon.Visible = false;
            this.gtt.Visible = false;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.mainGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gác Xép Tháng Tư - Touch POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainGrid.ResumeLayout(false);
            this.pnlColBan.ResumeLayout(false);
            this.pnlColMenu.ResumeLayout(false);
            this.pnlColBill.ResumeLayout(false);
            this.pnlBottomBill.ResumeLayout(false);
            this.pnlBottomBill.PerformLayout();
            this.tblAction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTraCuuHD;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.TableLayoutPanel mainGrid;
        private System.Windows.Forms.Panel pnlColBan;
        private System.Windows.Forms.FlowLayoutPanel sdb;
        private System.Windows.Forms.Label lblHeaderBan;
        private System.Windows.Forms.Panel pnlColMenu;
        private System.Windows.Forms.FlowLayoutPanel flpThucDonPOS;
        private System.Windows.Forms.FlowLayoutPanel flpDanhMucPOS;
        private System.Windows.Forms.Label lblHeaderMenu;
        private System.Windows.Forms.Panel pnlColBill;
        private System.Windows.Forms.ListView lsvhd;
        private System.Windows.Forms.ColumnHeader colTenMon;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.ColumnHeader colDonGia;
        private System.Windows.Forms.ColumnHeader colThanhTien;
        private System.Windows.Forms.Panel pnlBottomBill;
        private System.Windows.Forms.TableLayoutPanel tblAction;
        private Coffee_Shop_Management.RoundedButton btnThemTouch;
        private Coffee_Shop_Management.RoundedButton btnSuaTouch;
        private Coffee_Shop_Management.RoundedButton btnXoaTouch;
        private System.Windows.Forms.TextBox txtTongTienPOS;
        private Coffee_Shop_Management.RoundedButton btnThanhToanTouch;
        private System.Windows.Forms.Label lblTieuDeBanPOS;
        private System.Windows.Forms.Label lblHeaderBill;
        private System.Windows.Forms.GroupBox grpban;
        private System.Windows.Forms.GroupBox gcthd;
        private System.Windows.Forms.GroupBox grpChonMon;
        private System.Windows.Forms.GroupBox gtt;
    }
}