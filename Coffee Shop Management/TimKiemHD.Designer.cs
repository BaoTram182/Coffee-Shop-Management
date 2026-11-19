namespace Coffee_Shop_Management
{
    partial class TimKiemHD
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
            this.btnDong = new Coffee_Shop_Management.RoundedButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.btnHomNay = new Coffee_Shop_Management.RoundedButton();
            this.btn7Ngay = new Coffee_Shop_Management.RoundedButton();
            this.btnThangNay = new Coffee_Shop_Management.RoundedButton();
            this.btnTatCa = new Coffee_Shop_Management.RoundedButton();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new Coffee_Shop_Management.RoundedButton();
            this.mainSplit = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLeftHD = new System.Windows.Forms.Panel();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.lblHeaderLeft = new System.Windows.Forms.Label();
            this.pnlRightCT = new System.Windows.Forms.Panel();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.lblThongTinHD = new System.Windows.Forms.Label();
            this.lblHeaderRight = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.lblSoLuongHD = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.mainSplit.SuspendLayout();
            this.pnlLeftHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.pnlRightCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();

            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.pnlHeader.Controls.Add(this.btnDong);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.pnlHeader.Size = new System.Drawing.Size(1264, 62);
            this.pnlHeader.TabIndex = 0;

            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnDong.BorderColor = System.Drawing.Color.Transparent;
            this.btnDong.BorderRadius = 10;
            this.btnDong.BorderSize = 0;
            this.btnDong.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDong.FlatAppearance.BorderSize = 0;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(1112, 8);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(140, 46);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "ĐÓNG";
            this.btnDong.UseVisualStyleBackColor = false;

            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1100, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TRA CỨU HÓA ĐƠN & DOANH THU  |  GÁC XÉP THÁNG TƯ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.Controls.Add(this.btnTimKiem);
            this.pnlFilter.Controls.Add(this.txtTuKhoa);
            this.pnlFilter.Controls.Add(this.dtpDenNgay);
            this.pnlFilter.Controls.Add(this.lblDenNgay);
            this.pnlFilter.Controls.Add(this.dtpTuNgay);
            this.pnlFilter.Controls.Add(this.lblTuNgay);
            this.pnlFilter.Controls.Add(this.btnTatCa);
            this.pnlFilter.Controls.Add(this.btnThangNay);
            this.pnlFilter.Controls.Add(this.btn7Ngay);
            this.pnlFilter.Controls.Add(this.btnHomNay);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 62);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Padding = new System.Windows.Forms.Padding(12);
            this.pnlFilter.Size = new System.Drawing.Size(1264, 68);
            this.pnlFilter.TabIndex = 1;

            this.btnHomNay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.btnHomNay.BorderColor = System.Drawing.Color.Transparent;
            this.btnHomNay.BorderRadius = 10;
            this.btnHomNay.BorderSize = 0;
            this.btnHomNay.FlatAppearance.BorderSize = 0;
            this.btnHomNay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomNay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnHomNay.ForeColor = System.Drawing.Color.White;
            this.btnHomNay.Location = new System.Drawing.Point(14, 12);
            this.btnHomNay.Name = "btnHomNay";
            this.btnHomNay.Size = new System.Drawing.Size(96, 44);
            this.btnHomNay.TabIndex = 0;
            this.btnHomNay.Text = "Hôm nay";
            this.btnHomNay.UseVisualStyleBackColor = false;

            this.btn7Ngay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.btn7Ngay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.btn7Ngay.BorderRadius = 10;
            this.btn7Ngay.BorderSize = 1;
            this.btn7Ngay.FlatAppearance.BorderSize = 0;
            this.btn7Ngay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7Ngay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btn7Ngay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.btn7Ngay.Location = new System.Drawing.Point(116, 12);
            this.btn7Ngay.Name = "btn7Ngay";
            this.btn7Ngay.Size = new System.Drawing.Size(102, 44);
            this.btn7Ngay.TabIndex = 1;
            this.btn7Ngay.Text = "7 ngày qua";
            this.btn7Ngay.UseVisualStyleBackColor = false;

            this.btnThangNay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.btnThangNay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.btnThangNay.BorderRadius = 10;
            this.btnThangNay.BorderSize = 1;
            this.btnThangNay.FlatAppearance.BorderSize = 0;
            this.btnThangNay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThangNay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThangNay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.btnThangNay.Location = new System.Drawing.Point(224, 12);
            this.btnThangNay.Name = "btnThangNay";
            this.btnThangNay.Size = new System.Drawing.Size(102, 44);
            this.btnThangNay.TabIndex = 2;
            this.btnThangNay.Text = "Tháng này";
            this.btnThangNay.UseVisualStyleBackColor = false;

            this.btnTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.btnTatCa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.btnTatCa.BorderRadius = 10;
            this.btnTatCa.BorderSize = 1;
            this.btnTatCa.FlatAppearance.BorderSize = 0;
            this.btnTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTatCa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTatCa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.btnTatCa.Location = new System.Drawing.Point(332, 12);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(86, 44);
            this.btnTatCa.TabIndex = 3;
            this.btnTatCa.Text = "Tất cả";
            this.btnTatCa.UseVisualStyleBackColor = false;

            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTuNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblTuNgay.Location = new System.Drawing.Point(432, 25);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(30, 17);
            this.lblTuNgay.TabIndex = 4;
            this.lblTuNgay.Text = "Từ:";

            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(466, 20);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(124, 26);
            this.dtpTuNgay.TabIndex = 5;

            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDenNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblDenNgay.Location = new System.Drawing.Point(598, 25);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(37, 17);
            this.lblDenNgay.TabIndex = 6;
            this.lblDenNgay.Text = "Đến:";

            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(638, 20);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(124, 26);
            this.dtpDenNgay.TabIndex = 7;

            this.txtTuKhoa.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTuKhoa.Location = new System.Drawing.Point(776, 19);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(295, 27);
            this.txtTuKhoa.TabIndex = 8;

            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnTimKiem.BorderColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.BorderRadius = 10;
            this.btnTimKiem.BorderSize = 0;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(1082, 12);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(164, 44);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.UseVisualStyleBackColor = false;

            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.pnlFooter.Controls.Add(this.lblTongDoanhThu);
            this.pnlFooter.Controls.Add(this.lblSoLuongHD);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 625);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.pnlFooter.Size = new System.Drawing.Size(1264, 56);
            this.pnlFooter.TabIndex = 3;

            this.lblTongDoanhThu.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Bold);
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblTongDoanhThu.Location = new System.Drawing.Point(746, 10);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(500, 36);
            this.lblTongDoanhThu.TabIndex = 1;
            this.lblTongDoanhThu.Text = "TỔNG DOANH THU: 0 VNĐ";
            this.lblTongDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblSoLuongHD.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSoLuongHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSoLuongHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblSoLuongHD.Location = new System.Drawing.Point(18, 10);
            this.lblSoLuongHD.Name = "lblSoLuongHD";
            this.lblSoLuongHD.Size = new System.Drawing.Size(420, 36);
            this.lblSoLuongHD.TabIndex = 0;
            this.lblSoLuongHD.Text = "Tổng số hóa đơn: 0";
            this.lblSoLuongHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.mainSplit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.mainSplit.ColumnCount = 2;
            this.mainSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.mainSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainSplit.Controls.Add(this.pnlLeftHD, 0, 0);
            this.mainSplit.Controls.Add(this.pnlRightCT, 1, 0);
            this.mainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplit.Location = new System.Drawing.Point(0, 130);
            this.mainSplit.Name = "mainSplit";
            this.mainSplit.Padding = new System.Windows.Forms.Padding(10);
            this.mainSplit.RowCount = 1;
            this.mainSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainSplit.Size = new System.Drawing.Size(1264, 495);
            this.mainSplit.TabIndex = 2;

            this.pnlLeftHD.BackColor = System.Drawing.Color.White;
            this.pnlLeftHD.Controls.Add(this.dgvHoaDon);
            this.pnlLeftHD.Controls.Add(this.lblHeaderLeft);
            this.pnlLeftHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftHD.Location = new System.Drawing.Point(16, 16);
            this.pnlLeftHD.Margin = new System.Windows.Forms.Padding(6);
            this.pnlLeftHD.Name = "pnlLeftHD";
            this.pnlLeftHD.Size = new System.Drawing.Size(734, 463);
            this.pnlLeftHD.TabIndex = 0;

            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDon.ColumnHeadersHeight = 42;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 40);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowTemplate.Height = 38;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(734, 423);
            this.dgvHoaDon.TabIndex = 1;

            this.lblHeaderLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblHeaderLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeaderLeft.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblHeaderLeft.ForeColor = System.Drawing.Color.White;
            this.lblHeaderLeft.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderLeft.Name = "lblHeaderLeft";
            this.lblHeaderLeft.Size = new System.Drawing.Size(734, 40);
            this.lblHeaderLeft.TabIndex = 0;
            this.lblHeaderLeft.Text = "  DANH SÁCH HÓA ĐƠN ";
            this.lblHeaderLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.pnlRightCT.BackColor = System.Drawing.Color.White;
            this.pnlRightCT.Controls.Add(this.dgvChiTiet);
            this.pnlRightCT.Controls.Add(this.lblThongTinHD);
            this.pnlRightCT.Controls.Add(this.lblHeaderRight);
            this.pnlRightCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightCT.Location = new System.Drawing.Point(762, 16);
            this.pnlRightCT.Margin = new System.Windows.Forms.Padding(6);
            this.pnlRightCT.Name = "pnlRightCT";
            this.pnlRightCT.Size = new System.Drawing.Size(486, 463);
            this.pnlRightCT.TabIndex = 1;

            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.AllowUserToDeleteRows = false;
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChiTiet.ColumnHeadersHeight = 42;
            this.dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTiet.Location = new System.Drawing.Point(0, 82);
            this.dgvChiTiet.MultiSelect = false;
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.ReadOnly = true;
            this.dgvChiTiet.RowHeadersVisible = false;
            this.dgvChiTiet.RowTemplate.Height = 38;
            this.dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTiet.Size = new System.Drawing.Size(486, 381);
            this.dgvChiTiet.TabIndex = 2;

            this.lblThongTinHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.lblThongTinHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblThongTinHD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblThongTinHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(67)))), ((int)(((byte)(21)))));
            this.lblThongTinHD.Location = new System.Drawing.Point(0, 40);
            this.lblThongTinHD.Name = "lblThongTinHD";
            this.lblThongTinHD.Size = new System.Drawing.Size(486, 42);
            this.lblThongTinHD.TabIndex = 1;
            this.lblThongTinHD.Text = "Chưa chọn hóa đơn";
            this.lblThongTinHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblHeaderRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblHeaderRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeaderRight.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblHeaderRight.ForeColor = System.Drawing.Color.White;
            this.lblHeaderRight.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderRight.Name = "lblHeaderRight";
            this.lblHeaderRight.Size = new System.Drawing.Size(486, 40);
            this.lblHeaderRight.TabIndex = 0;
            this.lblHeaderRight.Text = "  CHI TIẾT CÁC MÓN ĐÃ GỌI  ";
            this.lblHeaderRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.mainSplit);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlHeader);
            this.Name = "TimKiemHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu Hóa đơn - Gác Xép Tháng Tư";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeader.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.mainSplit.ResumeLayout(false);
            this.pnlLeftHD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.pnlRightCT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private Coffee_Shop_Management.RoundedButton btnDong;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFilter;
        private Coffee_Shop_Management.RoundedButton btnHomNay;
        private Coffee_Shop_Management.RoundedButton btn7Ngay;
        private Coffee_Shop_Management.RoundedButton btnThangNay;
        private Coffee_Shop_Management.RoundedButton btnTatCa;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private Coffee_Shop_Management.RoundedButton btnTimKiem;
        private System.Windows.Forms.TableLayoutPanel mainSplit;
        private System.Windows.Forms.Panel pnlLeftHD;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Label lblHeaderLeft;
        private System.Windows.Forms.Panel pnlRightCT;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.Label lblThongTinHD;
        private System.Windows.Forms.Label lblHeaderRight;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label lblSoLuongHD;
    }
}