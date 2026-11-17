namespace Coffee_Shop_Management
{
    partial class QuanLy
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
        private System.Windows.Forms.TabControl tabQuanLy;
        private System.Windows.Forms.TabPage tabMon;
        private System.Windows.Forms.TabPage tabDanhMuc;
        private System.Windows.Forms.TabPage tabBan;
        private System.Windows.Forms.TabPage tabTaiKhoan;

        // Controls Tab 1: Quản lý Món
        private System.Windows.Forms.DataGridView dgvMon;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.ComboBox cbDanhMuc;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.NumericUpDown numDonGia;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button btnSuaMon;
        private System.Windows.Forms.Button btnXoaMon;
        private System.Windows.Forms.Button btnLamMoiMon;

        // Controls Tab 2: Quản lý Danh mục
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.Label lblTenDM;
        private System.Windows.Forms.TextBox txtTenDM;
        private System.Windows.Forms.Button btnThemDM;
        private System.Windows.Forms.Button btnSuaDM;
        private System.Windows.Forms.Button btnXoaDM;
        private System.Windows.Forms.Button btnLamMoiDM;

        // Controls Tab 3: Quản lý Bàn
        private System.Windows.Forms.DataGridView dgvBan;
        private System.Windows.Forms.Label lblTenBan;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.Label lblLoaiBan;
        private System.Windows.Forms.ComboBox cbLoaiBan;
        private System.Windows.Forms.Button btnThemBan;
        private System.Windows.Forms.Button btnSuaBan;
        private System.Windows.Forms.Button btnXoaBan;
        private System.Windows.Forms.Button btnLamMoiBan;

        // Controls Tab 4: Quản lý Tài khoản
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.Label lblTenTK;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.Label lblQuyenTK;
        private System.Windows.Forms.ComboBox cbQuyenTK;
        private System.Windows.Forms.Label lblMKMoi;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.Button btnCapNhatTK;
        private System.Windows.Forms.Button btnXoaTK;
        private System.Windows.Forms.Button btnLamMoiTK;

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabQuanLy = new System.Windows.Forms.TabControl();
            this.tabMon = new System.Windows.Forms.TabPage();
            this.btnLamMoiMon = new System.Windows.Forms.Button();
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.btnSuaMon = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.numDonGia = new System.Windows.Forms.NumericUpDown();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.cbDanhMuc = new System.Windows.Forms.ComboBox();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.dgvMon = new System.Windows.Forms.DataGridView();
            this.tabDanhMuc = new System.Windows.Forms.TabPage();
            this.btnLamMoiDM = new System.Windows.Forms.Button();
            this.btnXoaDM = new System.Windows.Forms.Button();
            this.btnSuaDM = new System.Windows.Forms.Button();
            this.btnThemDM = new System.Windows.Forms.Button();
            this.txtTenDM = new System.Windows.Forms.TextBox();
            this.lblTenDM = new System.Windows.Forms.Label();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.tabBan = new System.Windows.Forms.TabPage();
            this.btnLamMoiBan = new System.Windows.Forms.Button();
            this.btnXoaBan = new System.Windows.Forms.Button();
            this.btnSuaBan = new System.Windows.Forms.Button();
            this.btnThemBan = new System.Windows.Forms.Button();
            this.cbLoaiBan = new System.Windows.Forms.ComboBox();
            this.lblLoaiBan = new System.Windows.Forms.Label();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.lblTenBan = new System.Windows.Forms.Label();
            this.dgvBan = new System.Windows.Forms.DataGridView();
            this.tabTaiKhoan = new System.Windows.Forms.TabPage();
            this.btnLamMoiTK = new System.Windows.Forms.Button();
            this.btnXoaTK = new System.Windows.Forms.Button();
            this.btnCapNhatTK = new System.Windows.Forms.Button();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.lblMKMoi = new System.Windows.Forms.Label();
            this.cbQuyenTK = new System.Windows.Forms.ComboBox();
            this.lblQuyenTK = new System.Windows.Forms.Label();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.lblTenTK = new System.Windows.Forms.Label();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.tabQuanLy.SuspendLayout();
            this.tabMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).BeginInit();
            this.tabDanhMuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.tabBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).BeginInit();
            this.tabTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(880, 74);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(98, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(692, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HỆ THỐNG QUẢN LÝ THỰC ĐƠN - BÀN - NHÂN SỰ";
            // 
            // tabQuanLy
            // 
            this.tabQuanLy.Controls.Add(this.tabMon);
            this.tabQuanLy.Controls.Add(this.tabDanhMuc);
            this.tabQuanLy.Controls.Add(this.tabBan);
            this.tabQuanLy.Controls.Add(this.tabTaiKhoan);
            this.tabQuanLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabQuanLy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabQuanLy.Location = new System.Drawing.Point(0, 74);
            this.tabQuanLy.Name = "tabQuanLy";
            this.tabQuanLy.SelectedIndex = 0;
            this.tabQuanLy.Size = new System.Drawing.Size(880, 487);
            this.tabQuanLy.TabIndex = 0;
            // 
            // tabMon
            // 
            this.tabMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.tabMon.Controls.Add(this.btnLamMoiMon);
            this.tabMon.Controls.Add(this.btnXoaMon);
            this.tabMon.Controls.Add(this.btnSuaMon);
            this.tabMon.Controls.Add(this.btnThemMon);
            this.tabMon.Controls.Add(this.numDonGia);
            this.tabMon.Controls.Add(this.lblDonGia);
            this.tabMon.Controls.Add(this.cbDanhMuc);
            this.tabMon.Controls.Add(this.lblDanhMuc);
            this.tabMon.Controls.Add(this.txtTenMon);
            this.tabMon.Controls.Add(this.lblTenMon);
            this.tabMon.Controls.Add(this.dgvMon);
            this.tabMon.Location = new System.Drawing.Point(4, 37);
            this.tabMon.Name = "tabMon";
            this.tabMon.Padding = new System.Windows.Forms.Padding(12);
            this.tabMon.Size = new System.Drawing.Size(872, 446);
            this.tabMon.TabIndex = 0;
            this.tabMon.Text = "  Thực đơn  ";
            // 
            // btnLamMoiMon
            // 
            this.btnLamMoiMon.Location = new System.Drawing.Point(713, 282);
            this.btnLamMoiMon.Name = "btnLamMoiMon";
            this.btnLamMoiMon.Size = new System.Drawing.Size(132, 42);
            this.btnLamMoiMon.TabIndex = 0;
            this.btnLamMoiMon.Text = "LÀM MỚI";
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.Location = new System.Drawing.Point(565, 282);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(132, 42);
            this.btnXoaMon.TabIndex = 1;
            this.btnXoaMon.Text = "XÓA";
            // 
            // btnSuaMon
            // 
            this.btnSuaMon.Location = new System.Drawing.Point(713, 228);
            this.btnSuaMon.Name = "btnSuaMon";
            this.btnSuaMon.Size = new System.Drawing.Size(132, 42);
            this.btnSuaMon.TabIndex = 2;
            this.btnSuaMon.Text = "SỬA";
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(565, 228);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(132, 42);
            this.btnThemMon.TabIndex = 3;
            this.btnThemMon.Text = "THÊM";
            // 
            // numDonGia
            // 
            this.numDonGia.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.numDonGia.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDonGia.Location = new System.Drawing.Point(565, 176);
            this.numDonGia.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numDonGia.Name = "numDonGia";
            this.numDonGia.Size = new System.Drawing.Size(280, 35);
            this.numDonGia.TabIndex = 4;
            this.numDonGia.ThousandsSeparator = true;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDonGia.Location = new System.Drawing.Point(562, 152);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(148, 25);
            this.lblDonGia.TabIndex = 5;
            this.lblDonGia.Text = "Đơn giá (VNĐ):";
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDanhMuc.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cbDanhMuc.Location = new System.Drawing.Point(565, 109);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(280, 38);
            this.cbDanhMuc.TabIndex = 6;
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDanhMuc.Location = new System.Drawing.Point(562, 85);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(107, 25);
            this.lblDanhMuc.TabIndex = 7;
            this.lblDanhMuc.Text = "Danh mục:";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtTenMon.Location = new System.Drawing.Point(565, 44);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(280, 35);
            this.txtTenMon.TabIndex = 8;
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTenMon.Location = new System.Drawing.Point(562, 20);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(94, 25);
            this.lblTenMon.TabIndex = 9;
            this.lblTenMon.Text = "Tên món:";
            // 
            // dgvMon
            // 
            this.dgvMon.AllowUserToAddRows = false;
            this.dgvMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMon.ColumnHeadersHeight = 34;
            this.dgvMon.Location = new System.Drawing.Point(16, 16);
            this.dgvMon.MultiSelect = false;
            this.dgvMon.Name = "dgvMon";
            this.dgvMon.ReadOnly = true;
            this.dgvMon.RowHeadersWidth = 62;
            this.dgvMon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMon.Size = new System.Drawing.Size(525, 415);
            this.dgvMon.TabIndex = 10;
            // 
            // tabDanhMuc
            // 
            this.tabDanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.tabDanhMuc.Controls.Add(this.btnLamMoiDM);
            this.tabDanhMuc.Controls.Add(this.btnXoaDM);
            this.tabDanhMuc.Controls.Add(this.btnSuaDM);
            this.tabDanhMuc.Controls.Add(this.btnThemDM);
            this.tabDanhMuc.Controls.Add(this.txtTenDM);
            this.tabDanhMuc.Controls.Add(this.lblTenDM);
            this.tabDanhMuc.Controls.Add(this.dgvDanhMuc);
            this.tabDanhMuc.Location = new System.Drawing.Point(4, 37);
            this.tabDanhMuc.Name = "tabDanhMuc";
            this.tabDanhMuc.Padding = new System.Windows.Forms.Padding(12);
            this.tabDanhMuc.Size = new System.Drawing.Size(872, 447);
            this.tabDanhMuc.TabIndex = 1;
            this.tabDanhMuc.Text = "  Danh mục món  ";
            // 
            // btnLamMoiDM
            // 
            this.btnLamMoiDM.Location = new System.Drawing.Point(713, 150);
            this.btnLamMoiDM.Name = "btnLamMoiDM";
            this.btnLamMoiDM.Size = new System.Drawing.Size(132, 42);
            this.btnLamMoiDM.TabIndex = 0;
            this.btnLamMoiDM.Text = "LÀM MỚI";
            // 
            // btnXoaDM
            // 
            this.btnXoaDM.Location = new System.Drawing.Point(565, 150);
            this.btnXoaDM.Name = "btnXoaDM";
            this.btnXoaDM.Size = new System.Drawing.Size(132, 42);
            this.btnXoaDM.TabIndex = 1;
            this.btnXoaDM.Text = "XÓA";
            // 
            // btnSuaDM
            // 
            this.btnSuaDM.Location = new System.Drawing.Point(713, 96);
            this.btnSuaDM.Name = "btnSuaDM";
            this.btnSuaDM.Size = new System.Drawing.Size(132, 42);
            this.btnSuaDM.TabIndex = 2;
            this.btnSuaDM.Text = "SỬA";
            // 
            // btnThemDM
            // 
            this.btnThemDM.Location = new System.Drawing.Point(565, 96);
            this.btnThemDM.Name = "btnThemDM";
            this.btnThemDM.Size = new System.Drawing.Size(132, 42);
            this.btnThemDM.TabIndex = 3;
            this.btnThemDM.Text = "THÊM";
            // 
            // txtTenDM
            // 
            this.txtTenDM.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtTenDM.Location = new System.Drawing.Point(565, 44);
            this.txtTenDM.Name = "txtTenDM";
            this.txtTenDM.Size = new System.Drawing.Size(280, 35);
            this.txtTenDM.TabIndex = 4;
            // 
            // lblTenDM
            // 
            this.lblTenDM.AutoSize = true;
            this.lblTenDM.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTenDM.Location = new System.Drawing.Point(562, 20);
            this.lblTenDM.Name = "lblTenDM";
            this.lblTenDM.Size = new System.Drawing.Size(331, 25);
            this.lblTenDM.TabIndex = 5;
            this.lblTenDM.Text = "Tên danh mục (VD: Cà phê, Trà sữa):";
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.AllowUserToAddRows = false;
            this.dgvDanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMuc.ColumnHeadersHeight = 34;
            this.dgvDanhMuc.Location = new System.Drawing.Point(16, 16);
            this.dgvDanhMuc.MultiSelect = false;
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.ReadOnly = true;
            this.dgvDanhMuc.RowHeadersWidth = 62;
            this.dgvDanhMuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMuc.Size = new System.Drawing.Size(525, 415);
            this.dgvDanhMuc.TabIndex = 6;
            // 
            // tabBan
            // 
            this.tabBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.tabBan.Controls.Add(this.btnLamMoiBan);
            this.tabBan.Controls.Add(this.btnXoaBan);
            this.tabBan.Controls.Add(this.btnSuaBan);
            this.tabBan.Controls.Add(this.btnThemBan);
            this.tabBan.Controls.Add(this.cbLoaiBan);
            this.tabBan.Controls.Add(this.lblLoaiBan);
            this.tabBan.Controls.Add(this.txtTenBan);
            this.tabBan.Controls.Add(this.lblTenBan);
            this.tabBan.Controls.Add(this.dgvBan);
            this.tabBan.Location = new System.Drawing.Point(4, 37);
            this.tabBan.Name = "tabBan";
            this.tabBan.Padding = new System.Windows.Forms.Padding(12);
            this.tabBan.Size = new System.Drawing.Size(872, 447);
            this.tabBan.TabIndex = 2;
            this.tabBan.Text = "  Sơ đồ Bàn  ";
            // 
            // btnLamMoiBan
            // 
            this.btnLamMoiBan.Location = new System.Drawing.Point(713, 222);
            this.btnLamMoiBan.Name = "btnLamMoiBan";
            this.btnLamMoiBan.Size = new System.Drawing.Size(132, 42);
            this.btnLamMoiBan.TabIndex = 0;
            this.btnLamMoiBan.Text = "LÀM MỚI";
            // 
            // btnXoaBan
            // 
            this.btnXoaBan.Location = new System.Drawing.Point(565, 222);
            this.btnXoaBan.Name = "btnXoaBan";
            this.btnXoaBan.Size = new System.Drawing.Size(132, 42);
            this.btnXoaBan.TabIndex = 1;
            this.btnXoaBan.Text = "XÓA";
            // 
            // btnSuaBan
            // 
            this.btnSuaBan.Location = new System.Drawing.Point(713, 168);
            this.btnSuaBan.Name = "btnSuaBan";
            this.btnSuaBan.Size = new System.Drawing.Size(132, 42);
            this.btnSuaBan.TabIndex = 2;
            this.btnSuaBan.Text = "SỬA";
            // 
            // btnThemBan
            // 
            this.btnThemBan.Location = new System.Drawing.Point(565, 168);
            this.btnThemBan.Name = "btnThemBan";
            this.btnThemBan.Size = new System.Drawing.Size(132, 42);
            this.btnThemBan.TabIndex = 3;
            this.btnThemBan.Text = "THÊM";
            // 
            // cbLoaiBan
            // 
            this.cbLoaiBan.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cbLoaiBan.Items.AddRange(new object[] {
            "Tầng 1",
            "Tầng 2",
            "Ban công",
            "VIP"});
            this.cbLoaiBan.Location = new System.Drawing.Point(565, 112);
            this.cbLoaiBan.Name = "cbLoaiBan";
            this.cbLoaiBan.Size = new System.Drawing.Size(280, 38);
            this.cbLoaiBan.TabIndex = 4;
            // 
            // lblLoaiBan
            // 
            this.lblLoaiBan.AutoSize = true;
            this.lblLoaiBan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblLoaiBan.Location = new System.Drawing.Point(562, 88);
            this.lblLoaiBan.Name = "lblLoaiBan";
            this.lblLoaiBan.Size = new System.Drawing.Size(183, 25);
            this.lblLoaiBan.TabIndex = 5;
            this.lblLoaiBan.Text = "Khu vực / Loại bàn:";
            // 
            // txtTenBan
            // 
            this.txtTenBan.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtTenBan.Location = new System.Drawing.Point(565, 44);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(280, 35);
            this.txtTenBan.TabIndex = 6;
            // 
            // lblTenBan
            // 
            this.lblTenBan.AutoSize = true;
            this.lblTenBan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTenBan.Location = new System.Drawing.Point(562, 20);
            this.lblTenBan.Name = "lblTenBan";
            this.lblTenBan.Size = new System.Drawing.Size(204, 25);
            this.lblTenBan.TabIndex = 7;
            this.lblTenBan.Text = "Tên bàn (VD: Bàn 11):";
            // 
            // dgvBan
            // 
            this.dgvBan.AllowUserToAddRows = false;
            this.dgvBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBan.ColumnHeadersHeight = 34;
            this.dgvBan.Location = new System.Drawing.Point(16, 16);
            this.dgvBan.MultiSelect = false;
            this.dgvBan.Name = "dgvBan";
            this.dgvBan.ReadOnly = true;
            this.dgvBan.RowHeadersWidth = 62;
            this.dgvBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBan.Size = new System.Drawing.Size(525, 415);
            this.dgvBan.TabIndex = 8;
            // 
            // tabTaiKhoan
            // 
            this.tabTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.tabTaiKhoan.Controls.Add(this.btnLamMoiTK);
            this.tabTaiKhoan.Controls.Add(this.btnXoaTK);
            this.tabTaiKhoan.Controls.Add(this.btnCapNhatTK);
            this.tabTaiKhoan.Controls.Add(this.txtMKMoi);
            this.tabTaiKhoan.Controls.Add(this.lblMKMoi);
            this.tabTaiKhoan.Controls.Add(this.cbQuyenTK);
            this.tabTaiKhoan.Controls.Add(this.lblQuyenTK);
            this.tabTaiKhoan.Controls.Add(this.txtTenTK);
            this.tabTaiKhoan.Controls.Add(this.lblTenTK);
            this.tabTaiKhoan.Controls.Add(this.dgvTaiKhoan);
            this.tabTaiKhoan.Location = new System.Drawing.Point(4, 37);
            this.tabTaiKhoan.Name = "tabTaiKhoan";
            this.tabTaiKhoan.Padding = new System.Windows.Forms.Padding(12);
            this.tabTaiKhoan.Size = new System.Drawing.Size(872, 447);
            this.tabTaiKhoan.TabIndex = 3;
            this.tabTaiKhoan.Text = "  Tài khoản nhân viên  ";
            // 
            // btnLamMoiTK
            // 
            this.btnLamMoiTK.Location = new System.Drawing.Point(713, 284);
            this.btnLamMoiTK.Name = "btnLamMoiTK";
            this.btnLamMoiTK.Size = new System.Drawing.Size(132, 42);
            this.btnLamMoiTK.TabIndex = 0;
            this.btnLamMoiTK.Text = "LÀM MỚI";
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.Location = new System.Drawing.Point(565, 284);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(132, 42);
            this.btnXoaTK.TabIndex = 1;
            this.btnXoaTK.Text = "XÓA TK";
            // 
            // btnCapNhatTK
            // 
            this.btnCapNhatTK.Location = new System.Drawing.Point(565, 228);
            this.btnCapNhatTK.Name = "btnCapNhatTK";
            this.btnCapNhatTK.Size = new System.Drawing.Size(280, 44);
            this.btnCapNhatTK.TabIndex = 2;
            this.btnCapNhatTK.Text = "CẬP NHẬT QUYỀN / MẬT KHẨU";
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtMKMoi.Location = new System.Drawing.Point(565, 176);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.Size = new System.Drawing.Size(280, 35);
            this.txtMKMoi.TabIndex = 3;
            // 
            // lblMKMoi
            // 
            this.lblMKMoi.AutoSize = true;
            this.lblMKMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblMKMoi.Location = new System.Drawing.Point(562, 152);
            this.lblMKMoi.Name = "lblMKMoi";
            this.lblMKMoi.Size = new System.Drawing.Size(421, 25);
            this.lblMKMoi.TabIndex = 4;
            this.lblMKMoi.Text = "Đặt mật khẩu mới (bỏ trống nếu giữ nguyên):";
            // 
            // cbQuyenTK
            // 
            this.cbQuyenTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuyenTK.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cbQuyenTK.Items.AddRange(new object[] {
            "Nhân viên",
            "Phục vụ",
            "Admin"});
            this.cbQuyenTK.Location = new System.Drawing.Point(565, 109);
            this.cbQuyenTK.Name = "cbQuyenTK";
            this.cbQuyenTK.Size = new System.Drawing.Size(280, 38);
            this.cbQuyenTK.TabIndex = 5;
            // 
            // lblQuyenTK
            // 
            this.lblQuyenTK.AutoSize = true;
            this.lblQuyenTK.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblQuyenTK.Location = new System.Drawing.Point(562, 85);
            this.lblQuyenTK.Name = "lblQuyenTK";
            this.lblQuyenTK.Size = new System.Drawing.Size(113, 25);
            this.lblQuyenTK.TabIndex = 6;
            this.lblQuyenTK.Text = "Quyền hạn:";
            // 
            // txtTenTK
            // 
            this.txtTenTK.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.txtTenTK.Location = new System.Drawing.Point(565, 44);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.ReadOnly = true;
            this.txtTenTK.Size = new System.Drawing.Size(280, 35);
            this.txtTenTK.TabIndex = 7;
            // 
            // lblTenTK
            // 
            this.lblTenTK.AutoSize = true;
            this.lblTenTK.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTenTK.Location = new System.Drawing.Point(562, 20);
            this.lblTenTK.Name = "lblTenTK";
            this.lblTenTK.Size = new System.Drawing.Size(236, 25);
            this.lblTenTK.TabIndex = 8;
            this.lblTenTK.Text = "Tên tài khoản đang chọn:";
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AllowUserToAddRows = false;
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.ColumnHeadersHeight = 34;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(16, 16);
            this.dgvTaiKhoan.MultiSelect = false;
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.ReadOnly = true;
            this.dgvTaiKhoan.RowHeadersWidth = 62;
            this.dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(525, 415);
            this.dgvTaiKhoan.TabIndex = 9;
            // 
            // QuanLy
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(880, 561);
            this.Controls.Add(this.tabQuanLy);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản trị Hệ thống";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabQuanLy.ResumeLayout(false);
            this.tabMon.ResumeLayout(false);
            this.tabMon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).EndInit();
            this.tabDanhMuc.ResumeLayout(false);
            this.tabDanhMuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.tabBan.ResumeLayout(false);
            this.tabBan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).EndInit();
            this.tabTaiKhoan.ResumeLayout(false);
            this.tabTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }
    }
}