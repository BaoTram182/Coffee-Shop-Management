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
        private System.Windows.Forms.TabPage tabBan;

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

        // Controls Tab Quản lý Bàn
        private System.Windows.Forms.DataGridView dgvBan;
        private System.Windows.Forms.Label lblTenBan;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.Label lblLoaiBan;
        private System.Windows.Forms.ComboBox cbLoaiBan;
        private System.Windows.Forms.Button btnThemBan;
        private System.Windows.Forms.Button btnSuaBan;
        private System.Windows.Forms.Button btnXoaBan;
        private System.Windows.Forms.Button btnLamMoiBan;

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
            this.pnlHeader.SuspendLayout();
            this.tabQuanLy.SuspendLayout();
            this.tabMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).BeginInit();
            this.tabBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(860, 75);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(188, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(501, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HỆ THỐNG THỰC ĐƠN - SƠ ĐỒ BÀN";
            // 
            // tabQuanLy
            // 
            this.tabQuanLy.Controls.Add(this.tabMon);
            this.tabQuanLy.Controls.Add(this.tabBan);
            this.tabQuanLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabQuanLy.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.tabQuanLy.Location = new System.Drawing.Point(0, 75);
            this.tabQuanLy.Name = "tabQuanLy";
            this.tabQuanLy.SelectedIndex = 0;
            this.tabQuanLy.Size = new System.Drawing.Size(860, 483);
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
            this.tabMon.Location = new System.Drawing.Point(4, 39);
            this.tabMon.Name = "tabMon";
            this.tabMon.Padding = new System.Windows.Forms.Padding(12);
            this.tabMon.Size = new System.Drawing.Size(852, 440);
            this.tabMon.TabIndex = 0;
            this.tabMon.Text = "   Quản lý Thực đơn   ";
            // 
            // btnLamMoiMon
            // 
            this.btnLamMoiMon.Location = new System.Drawing.Point(700, 282);
            this.btnLamMoiMon.Name = "btnLamMoiMon";
            this.btnLamMoiMon.Size = new System.Drawing.Size(130, 42);
            this.btnLamMoiMon.TabIndex = 0;
            this.btnLamMoiMon.Text = "LÀM MỚI";
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.Location = new System.Drawing.Point(555, 282);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(130, 42);
            this.btnXoaMon.TabIndex = 1;
            this.btnXoaMon.Text = "XÓA";
            // 
            // btnSuaMon
            // 
            this.btnSuaMon.Location = new System.Drawing.Point(700, 228);
            this.btnSuaMon.Name = "btnSuaMon";
            this.btnSuaMon.Size = new System.Drawing.Size(130, 42);
            this.btnSuaMon.TabIndex = 2;
            this.btnSuaMon.Text = "SỬA";
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(555, 228);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(130, 42);
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
            this.numDonGia.Location = new System.Drawing.Point(555, 176);
            this.numDonGia.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numDonGia.Name = "numDonGia";
            this.numDonGia.Size = new System.Drawing.Size(275, 35);
            this.numDonGia.TabIndex = 4;
            this.numDonGia.ThousandsSeparator = true;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDonGia.Location = new System.Drawing.Point(552, 152);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(148, 25);
            this.lblDonGia.TabIndex = 5;
            this.lblDonGia.Text = "Đơn giá (VNĐ):";
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDanhMuc.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cbDanhMuc.Location = new System.Drawing.Point(555, 109);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(275, 38);
            this.cbDanhMuc.TabIndex = 6;
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDanhMuc.Location = new System.Drawing.Point(552, 85);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(107, 25);
            this.lblDanhMuc.TabIndex = 7;
            this.lblDanhMuc.Text = "Danh mục:";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtTenMon.Location = new System.Drawing.Point(555, 44);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(275, 35);
            this.txtTenMon.TabIndex = 8;
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTenMon.Location = new System.Drawing.Point(552, 20);
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
            this.dgvMon.Size = new System.Drawing.Size(515, 405);
            this.dgvMon.TabIndex = 10;
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
            this.tabBan.Location = new System.Drawing.Point(4, 39);
            this.tabBan.Name = "tabBan";
            this.tabBan.Padding = new System.Windows.Forms.Padding(12);
            this.tabBan.Size = new System.Drawing.Size(852, 435);
            this.tabBan.TabIndex = 1;
            this.tabBan.Text = "   Quản lý Sơ đồ Bàn   ";
            // 
            // btnLamMoiBan
            // 
            this.btnLamMoiBan.Location = new System.Drawing.Point(700, 222);
            this.btnLamMoiBan.Name = "btnLamMoiBan";
            this.btnLamMoiBan.Size = new System.Drawing.Size(130, 42);
            this.btnLamMoiBan.TabIndex = 0;
            this.btnLamMoiBan.Text = "LÀM MỚI";
            // 
            // btnXoaBan
            // 
            this.btnXoaBan.Location = new System.Drawing.Point(555, 222);
            this.btnXoaBan.Name = "btnXoaBan";
            this.btnXoaBan.Size = new System.Drawing.Size(130, 42);
            this.btnXoaBan.TabIndex = 1;
            this.btnXoaBan.Text = "XÓA";
            // 
            // btnSuaBan
            // 
            this.btnSuaBan.Location = new System.Drawing.Point(700, 168);
            this.btnSuaBan.Name = "btnSuaBan";
            this.btnSuaBan.Size = new System.Drawing.Size(130, 42);
            this.btnSuaBan.TabIndex = 2;
            this.btnSuaBan.Text = "SỬA";
            // 
            // btnThemBan
            // 
            this.btnThemBan.Location = new System.Drawing.Point(555, 168);
            this.btnThemBan.Name = "btnThemBan";
            this.btnThemBan.Size = new System.Drawing.Size(130, 42);
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
            this.cbLoaiBan.Location = new System.Drawing.Point(555, 112);
            this.cbLoaiBan.Name = "cbLoaiBan";
            this.cbLoaiBan.Size = new System.Drawing.Size(275, 38);
            this.cbLoaiBan.TabIndex = 4;
            // 
            // lblLoaiBan
            // 
            this.lblLoaiBan.AutoSize = true;
            this.lblLoaiBan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblLoaiBan.Location = new System.Drawing.Point(552, 88);
            this.lblLoaiBan.Name = "lblLoaiBan";
            this.lblLoaiBan.Size = new System.Drawing.Size(183, 25);
            this.lblLoaiBan.TabIndex = 5;
            this.lblLoaiBan.Text = "Khu vực / Loại bàn:";
            // 
            // txtTenBan
            // 
            this.txtTenBan.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtTenBan.Location = new System.Drawing.Point(555, 44);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(275, 35);
            this.txtTenBan.TabIndex = 6;
            // 
            // lblTenBan
            // 
            this.lblTenBan.AutoSize = true;
            this.lblTenBan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTenBan.Location = new System.Drawing.Point(552, 20);
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
            this.dgvBan.Size = new System.Drawing.Size(515, 405);
            this.dgvBan.TabIndex = 8;
            // 
            // QuanLy
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(860, 558);
            this.Controls.Add(this.tabQuanLy);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản trị Thực đơn & Bàn";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabQuanLy.ResumeLayout(false);
            this.tabMon.ResumeLayout(false);
            this.tabMon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).EndInit();
            this.tabBan.ResumeLayout(false);
            this.tabBan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).EndInit();
            this.ResumeLayout(false);

        }
    }
}