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

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTraCuuHD;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.TableLayoutPanel qlbh;
        private System.Windows.Forms.GroupBox grpban;
        private System.Windows.Forms.FlowLayoutPanel sdb;
        private System.Windows.Forms.GroupBox gcthd;
        private System.Windows.Forms.ListView lsvhd;
        private System.Windows.Forms.ColumnHeader colTenMon;
        private System.Windows.Forms.ColumnHeader colSL;
        private System.Windows.Forms.ColumnHeader colDonGia;
        private System.Windows.Forms.ColumnHeader colThanhTien;
        private System.Windows.Forms.Panel pnlcm;
        private System.Windows.Forms.GroupBox grpChonMon;
        private System.Windows.Forms.TableLayoutPanel tblOrder;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.ComboBox dm;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.ComboBox tm;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown sl;
        private System.Windows.Forms.TableLayoutPanel pnlNutOrder;
        private System.Windows.Forms.Button btm;
        private System.Windows.Forms.Button bs;
        private System.Windows.Forms.Button bx;
        private System.Windows.Forms.GroupBox gtt;
        private System.Windows.Forms.Label lbdc;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.TextBox tt;
        private System.Windows.Forms.Button btt;

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTraCuuHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.qlbh = new System.Windows.Forms.TableLayoutPanel();
            this.grpban = new System.Windows.Forms.GroupBox();
            this.sdb = new System.Windows.Forms.FlowLayoutPanel();
            this.gcthd = new System.Windows.Forms.GroupBox();
            this.lsvhd = new System.Windows.Forms.ListView();
            this.colTenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlcm = new System.Windows.Forms.Panel();
            this.grpChonMon = new System.Windows.Forms.GroupBox();
            this.tblOrder = new System.Windows.Forms.TableLayoutPanel();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.dm = new System.Windows.Forms.ComboBox();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.tm = new System.Windows.Forms.ComboBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.sl = new System.Windows.Forms.NumericUpDown();
            this.pnlNutOrder = new System.Windows.Forms.TableLayoutPanel();
            this.btm = new System.Windows.Forms.Button();
            this.bs = new System.Windows.Forms.Button();
            this.bx = new System.Windows.Forms.Button();
            this.gtt = new System.Windows.Forms.GroupBox();
            this.btt = new System.Windows.Forms.Button();
            this.tt = new System.Windows.Forms.TextBox();
            this.lblTong = new System.Windows.Forms.Label();
            this.lbdc = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.qlbh.SuspendLayout();
            this.grpban.SuspendLayout();
            this.gcthd.SuspendLayout();
            this.pnlcm.SuspendLayout();
            this.grpChonMon.SuspendLayout();
            this.tblOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sl)).BeginInit();
            this.pnlNutOrder.SuspendLayout();
            this.gtt.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTraCuuHD,
            this.mnuDangXuat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1355, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuTraCuuHD
            // 
            this.mnuTraCuuHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.mnuTraCuuHD.Name = "mnuTraCuuHD";
            this.mnuTraCuuHD.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuTraCuuHD.Size = new System.Drawing.Size(217, 32);
            this.mnuTraCuuHD.Text = "🔍 Tra cứu hóa đơn";
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.ForeColor = System.Drawing.Color.Firebrick;
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(126, 32);
            this.mnuDangXuat.Text = "Đăng xuất";
            // 
            // qlbh
            // 
            this.qlbh.ColumnCount = 3;
            this.qlbh.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.qlbh.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.qlbh.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.qlbh.Controls.Add(this.grpban, 0, 0);
            this.qlbh.Controls.Add(this.gcthd, 1, 0);
            this.qlbh.Controls.Add(this.pnlcm, 2, 0);
            this.qlbh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qlbh.Location = new System.Drawing.Point(0, 38);
            this.qlbh.Name = "qlbh";
            this.qlbh.Padding = new System.Windows.Forms.Padding(10);
            this.qlbh.RowCount = 1;
            this.qlbh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.qlbh.Size = new System.Drawing.Size(1355, 663);
            this.qlbh.TabIndex = 0;
            // 
            // grpban
            // 
            this.grpban.Controls.Add(this.sdb);
            this.grpban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpban.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpban.Location = new System.Drawing.Point(13, 13);
            this.grpban.Name = "grpban";
            this.grpban.Padding = new System.Windows.Forms.Padding(8);
            this.grpban.Size = new System.Drawing.Size(501, 637);
            this.grpban.TabIndex = 0;
            this.grpban.TabStop = false;
            this.grpban.Text = "SƠ ĐỒ BÀN";
            // 
            // sdb
            // 
            this.sdb.AutoScroll = true;
            this.sdb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sdb.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.sdb.Location = new System.Drawing.Point(8, 35);
            this.sdb.Name = "sdb";
            this.sdb.Size = new System.Drawing.Size(485, 594);
            this.sdb.TabIndex = 0;
            // 
            // gcthd
            // 
            this.gcthd.Controls.Add(this.lsvhd);
            this.gcthd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcthd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gcthd.Location = new System.Drawing.Point(520, 13);
            this.gcthd.Name = "gcthd";
            this.gcthd.Padding = new System.Windows.Forms.Padding(8);
            this.gcthd.Size = new System.Drawing.Size(447, 637);
            this.gcthd.TabIndex = 1;
            this.gcthd.TabStop = false;
            this.gcthd.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // lsvhd
            // 
            this.lsvhd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTenMon,
            this.colSL,
            this.colDonGia,
            this.colThanhTien});
            this.lsvhd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvhd.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lsvhd.FullRowSelect = true;
            this.lsvhd.GridLines = true;
            this.lsvhd.HideSelection = false;
            this.lsvhd.Location = new System.Drawing.Point(8, 35);
            this.lsvhd.Name = "lsvhd";
            this.lsvhd.Size = new System.Drawing.Size(431, 594);
            this.lsvhd.TabIndex = 0;
            this.lsvhd.UseCompatibleStateImageBehavior = false;
            this.lsvhd.View = System.Windows.Forms.View.Details;
            // 
            // colTenMon
            // 
            this.colTenMon.Text = "Tên món";
            this.colTenMon.Width = 140;
            // 
            // colSL
            // 
            this.colSL.Text = "SL";
            this.colSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSL.Width = 80;
            // 
            // colDonGia
            // 
            this.colDonGia.Text = "Đơn giá";
            this.colDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colDonGia.Width = 97;
            // 
            // colThanhTien
            // 
            this.colThanhTien.Text = "Thành tiền";
            this.colThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colThanhTien.Width = 107;
            // 
            // pnlcm
            // 
            this.pnlcm.Controls.Add(this.grpChonMon);
            this.pnlcm.Controls.Add(this.gtt);
            this.pnlcm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcm.Location = new System.Drawing.Point(973, 13);
            this.pnlcm.Name = "pnlcm";
            this.pnlcm.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pnlcm.Size = new System.Drawing.Size(369, 637);
            this.pnlcm.TabIndex = 2;
            // 
            // grpChonMon
            // 
            this.grpChonMon.Controls.Add(this.tblOrder);
            this.grpChonMon.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpChonMon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpChonMon.Location = new System.Drawing.Point(5, 0);
            this.grpChonMon.Name = "grpChonMon";
            this.grpChonMon.Padding = new System.Windows.Forms.Padding(10);
            this.grpChonMon.Size = new System.Drawing.Size(364, 295);
            this.grpChonMon.TabIndex = 0;
            this.grpChonMon.TabStop = false;
            this.grpChonMon.Text = "CHỌN MÓN";
            // 
            // tblOrder
            // 
            this.tblOrder.ColumnCount = 1;
            this.tblOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblOrder.Controls.Add(this.lblDanhMuc, 0, 0);
            this.tblOrder.Controls.Add(this.dm, 0, 1);
            this.tblOrder.Controls.Add(this.lblTenMon, 0, 2);
            this.tblOrder.Controls.Add(this.tm, 0, 3);
            this.tblOrder.Controls.Add(this.lblSoLuong, 0, 4);
            this.tblOrder.Controls.Add(this.sl, 0, 5);
            this.tblOrder.Controls.Add(this.pnlNutOrder, 0, 6);
            this.tblOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblOrder.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tblOrder.Location = new System.Drawing.Point(10, 37);
            this.tblOrder.Name = "tblOrder";
            this.tblOrder.RowCount = 7;
            this.tblOrder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tblOrder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tblOrder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tblOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblOrder.Size = new System.Drawing.Size(344, 248);
            this.tblOrder.TabIndex = 0;
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Location = new System.Drawing.Point(3, 0);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(145, 25);
            this.lblDanhMuc.TabIndex = 0;
            this.lblDanhMuc.Text = "Danh mục món:";
            // 
            // dm
            // 
            this.dm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dm.Location = new System.Drawing.Point(3, 28);
            this.dm.Name = "dm";
            this.dm.Size = new System.Drawing.Size(338, 33);
            this.dm.TabIndex = 1;
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Location = new System.Drawing.Point(3, 63);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(88, 25);
            this.lblTenMon.TabIndex = 2;
            this.lblTenMon.Text = "Tên món:";
            // 
            // tm
            // 
            this.tm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tm.Location = new System.Drawing.Point(3, 91);
            this.tm.Name = "tm";
            this.tm.Size = new System.Drawing.Size(338, 33);
            this.tm.TabIndex = 3;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(3, 126);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(91, 25);
            this.lblSoLuong.TabIndex = 4;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // sl
            // 
            this.sl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sl.Location = new System.Drawing.Point(3, 154);
            this.sl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sl.Name = "sl";
            this.sl.Size = new System.Drawing.Size(338, 33);
            this.sl.TabIndex = 5;
            this.sl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pnlNutOrder
            // 
            this.pnlNutOrder.ColumnCount = 3;
            this.pnlNutOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.pnlNutOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.pnlNutOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.pnlNutOrder.Controls.Add(this.btm, 0, 0);
            this.pnlNutOrder.Controls.Add(this.bs, 1, 0);
            this.pnlNutOrder.Controls.Add(this.bx, 2, 0);
            this.pnlNutOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNutOrder.Location = new System.Drawing.Point(0, 189);
            this.pnlNutOrder.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNutOrder.Name = "pnlNutOrder";
            this.pnlNutOrder.RowCount = 1;
            this.pnlNutOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlNutOrder.Size = new System.Drawing.Size(344, 59);
            this.pnlNutOrder.TabIndex = 6;
            // 
            // btm
            // 
            this.btm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btm.FlatAppearance.BorderSize = 0;
            this.btm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btm.ForeColor = System.Drawing.Color.White;
            this.btm.Location = new System.Drawing.Point(3, 5);
            this.btm.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btm.Name = "btm";
            this.btm.Size = new System.Drawing.Size(138, 51);
            this.btm.TabIndex = 0;
            this.btm.Text = "+ THÊM";
            this.btm.UseVisualStyleBackColor = false;
            // 
            // bs
            // 
            this.bs.BackColor = System.Drawing.Color.DarkOrange;
            this.bs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bs.FlatAppearance.BorderSize = 0;
            this.bs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bs.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.bs.ForeColor = System.Drawing.Color.White;
            this.bs.Location = new System.Drawing.Point(147, 5);
            this.bs.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.bs.Name = "bs";
            this.bs.Size = new System.Drawing.Size(93, 51);
            this.bs.TabIndex = 1;
            this.bs.Text = "SỬA";
            this.bs.UseVisualStyleBackColor = false;
            // 
            // bx
            // 
            this.bx.BackColor = System.Drawing.Color.Crimson;
            this.bx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bx.FlatAppearance.BorderSize = 0;
            this.bx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bx.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.bx.ForeColor = System.Drawing.Color.White;
            this.bx.Location = new System.Drawing.Point(246, 5);
            this.bx.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.bx.Name = "bx";
            this.bx.Size = new System.Drawing.Size(95, 51);
            this.bx.TabIndex = 2;
            this.bx.Text = "XÓA";
            this.bx.UseVisualStyleBackColor = false;
            // 
            // gtt
            // 
            this.gtt.Controls.Add(this.btt);
            this.gtt.Controls.Add(this.tt);
            this.gtt.Controls.Add(this.lblTong);
            this.gtt.Controls.Add(this.lbdc);
            this.gtt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gtt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gtt.Location = new System.Drawing.Point(5, 422);
            this.gtt.Name = "gtt";
            this.gtt.Padding = new System.Windows.Forms.Padding(10);
            this.gtt.Size = new System.Drawing.Size(364, 215);
            this.gtt.TabIndex = 1;
            this.gtt.TabStop = false;
            this.gtt.Text = "THANH TOÁN";
            // 
            // btt
            // 
            this.btt.BackColor = System.Drawing.Color.SeaGreen;
            this.btt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btt.FlatAppearance.BorderSize = 0;
            this.btt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btt.ForeColor = System.Drawing.Color.White;
            this.btt.Location = new System.Drawing.Point(10, 155);
            this.btt.Name = "btt";
            this.btt.Size = new System.Drawing.Size(344, 50);
            this.btt.TabIndex = 0;
            this.btt.Text = "THANH TOÁN";
            this.btt.UseVisualStyleBackColor = false;
            // 
            // tt
            // 
            this.tt.BackColor = System.Drawing.Color.White;
            this.tt.Dock = System.Windows.Forms.DockStyle.Top;
            this.tt.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.tt.ForeColor = System.Drawing.Color.Firebrick;
            this.tt.Location = new System.Drawing.Point(10, 92);
            this.tt.Name = "tt";
            this.tt.ReadOnly = true;
            this.tt.Size = new System.Drawing.Size(344, 47);
            this.tt.TabIndex = 1;
            this.tt.Text = "0 VNĐ";
            this.tt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTong
            // 
            this.lblTong.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTong.Location = new System.Drawing.Point(10, 67);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(344, 25);
            this.lblTong.TabIndex = 2;
            this.lblTong.Text = "Tổng tiền thanh toán:";
            // 
            // lbdc
            // 
            this.lbdc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbdc.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbdc.Location = new System.Drawing.Point(10, 37);
            this.lbdc.Name = "lbdc";
            this.lbdc.Size = new System.Drawing.Size(344, 30);
            this.lbdc.TabIndex = 3;
            this.lbdc.Text = "Đang chọn: Chưa chọn bàn";
            // 
            // BanHang
            // 
            this.ClientSize = new System.Drawing.Size(1355, 701);
            this.Controls.Add(this.qlbh);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.qlbh.ResumeLayout(false);
            this.grpban.ResumeLayout(false);
            this.gcthd.ResumeLayout(false);
            this.pnlcm.ResumeLayout(false);
            this.grpChonMon.ResumeLayout(false);
            this.tblOrder.ResumeLayout(false);
            this.tblOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sl)).EndInit();
            this.pnlNutOrder.ResumeLayout(false);
            this.gtt.ResumeLayout(false);
            this.gtt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}