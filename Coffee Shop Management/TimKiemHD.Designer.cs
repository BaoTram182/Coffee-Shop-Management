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

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.TextBox tbtk;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.CheckBox chkLocNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnHomNay;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpHoaDon;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.GroupBox grpChiTiet;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblThongKe;

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnHomNay = new System.Windows.Forms.Button();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.chkLocNgay = new System.Windows.Forms.CheckBox();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.tbtk = new System.Windows.Forms.TextBox();
            this.lblTuKhoa = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpHoaDon = new System.Windows.Forms.GroupBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.grpChiTiet = new System.Windows.Forms.GroupBox();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblThongKe = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.grpChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.pnlTop.Controls.Add(this.btnLamMoi);
            this.pnlTop.Controls.Add(this.btnHomNay);
            this.pnlTop.Controls.Add(this.dtpDenNgay);
            this.pnlTop.Controls.Add(this.dtpTuNgay);
            this.pnlTop.Controls.Add(this.chkLocNgay);
            this.pnlTop.Controls.Add(this.cbTrangThai);
            this.pnlTop.Controls.Add(this.lblTrangThai);
            this.pnlTop.Controls.Add(this.tbtk);
            this.pnlTop.Controls.Add(this.lblTuKhoa);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1316, 100);
            this.pnlTop.TabIndex = 2;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(204)))), ((int)(((byte)(200)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.btnLamMoi.Location = new System.Drawing.Point(1159, 28);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(145, 34);
            this.btnLamMoi.TabIndex = 0;
            this.btnLamMoi.Text = "XÓA BỘ LỌC";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnHomNay
            // 
            this.btnHomNay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.btnHomNay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHomNay.FlatAppearance.BorderSize = 0;
            this.btnHomNay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomNay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnHomNay.ForeColor = System.Drawing.Color.White;
            this.btnHomNay.Location = new System.Drawing.Point(976, 28);
            this.btnHomNay.Name = "btnHomNay";
            this.btnHomNay.Size = new System.Drawing.Size(165, 34);
            this.btnHomNay.TabIndex = 1;
            this.btnHomNay.Text = "HĐ HÔM NAY";
            this.btnHomNay.UseVisualStyleBackColor = false;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Enabled = false;
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(829, 37);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(120, 26);
            this.dtpDenNgay.TabIndex = 2;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Enabled = false;
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(699, 37);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(120, 26);
            this.dtpTuNgay.TabIndex = 3;
            // 
            // chkLocNgay
            // 
            this.chkLocNgay.AutoSize = true;
            this.chkLocNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.chkLocNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.chkLocNgay.Location = new System.Drawing.Point(699, 12);
            this.chkLocNgay.Name = "chkLocNgay";
            this.chkLocNgay.Size = new System.Drawing.Size(168, 29);
            this.chkLocNgay.TabIndex = 4;
            this.chkLocNgay.Text = "Lọc theo ngày:";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTrangThai.Items.AddRange(new object[] {
            "Tất cả",
            "Đã thanh toán",
            "Chưa thanh toán"});
            this.cbTrangThai.Location = new System.Drawing.Point(432, 39);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(181, 36);
            this.cbTrangThai.TabIndex = 5;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblTrangThai.Location = new System.Drawing.Point(427, 8);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(107, 25);
            this.lblTrangThai.TabIndex = 6;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // tbtk
            // 
            this.tbtk.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tbtk.Location = new System.Drawing.Point(21, 38);
            this.tbtk.Name = "tbtk";
            this.tbtk.Size = new System.Drawing.Size(362, 35);
            this.tbtk.TabIndex = 7;
            // 
            // lblTuKhoa
            // 
            this.lblTuKhoa.AutoSize = true;
            this.lblTuKhoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTuKhoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblTuKhoa.Location = new System.Drawing.Point(16, 8);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.Size = new System.Drawing.Size(367, 25);
            this.lblTuKhoa.TabIndex = 8;
            this.lblTuKhoa.Text = "Gõ nhanh Mã HĐ / Tên bàn / Nhân viên:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 100);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpHoaDon);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpChiTiet);
            this.splitContainer1.Size = new System.Drawing.Size(1316, 498);
            this.splitContainer1.SplitterDistance = 273;
            this.splitContainer1.TabIndex = 0;
            // 
            // grpHoaDon
            // 
            this.grpHoaDon.Controls.Add(this.dgvHoaDon);
            this.grpHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpHoaDon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.grpHoaDon.Location = new System.Drawing.Point(0, 0);
            this.grpHoaDon.Name = "grpHoaDon";
            this.grpHoaDon.Padding = new System.Windows.Forms.Padding(8);
            this.grpHoaDon.Size = new System.Drawing.Size(1316, 273);
            this.grpHoaDon.TabIndex = 0;
            this.grpHoaDon.TabStop = false;
            this.grpHoaDon.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.ColumnHeadersHeight = 34;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(8, 35);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersWidth = 62;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(1300, 230);
            this.dgvHoaDon.TabIndex = 0;
            // 
            // grpChiTiet
            // 
            this.grpChiTiet.Controls.Add(this.dgvChiTiet);
            this.grpChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpChiTiet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpChiTiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.grpChiTiet.Location = new System.Drawing.Point(0, 0);
            this.grpChiTiet.Name = "grpChiTiet";
            this.grpChiTiet.Padding = new System.Windows.Forms.Padding(8);
            this.grpChiTiet.Size = new System.Drawing.Size(1316, 221);
            this.grpChiTiet.TabIndex = 0;
            this.grpChiTiet.TabStop = false;
            this.grpChiTiet.Text = "CHI TIẾT CÁC MÓN TRONG HÓA ĐƠN";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTiet.ColumnHeadersHeight = 34;
            this.dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTiet.Location = new System.Drawing.Point(8, 35);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.ReadOnly = true;
            this.dgvChiTiet.RowHeadersWidth = 62;
            this.dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTiet.Size = new System.Drawing.Size(1300, 178);
            this.dgvChiTiet.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.pnlBottom.Controls.Add(this.lblThongKe);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 598);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1316, 42);
            this.pnlBottom.TabIndex = 1;
            // 
            // lblThongKe
            // 
            this.lblThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThongKe.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblThongKe.Location = new System.Drawing.Point(0, 0);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.lblThongKe.Size = new System.Drawing.Size(1316, 42);
            this.lblThongKe.TabIndex = 0;
            this.lblThongKe.Text = "Tìm thấy: 0 hóa đơn | Tổng tiền: 0 VNĐ";
            this.lblThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TimKiemHD
            // 
            this.ClientSize = new System.Drawing.Size(1316, 640);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Name = "TimKiemHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gác Xép Tháng Tư - Tra cứu & Tìm kiếm hóa đơn";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.grpChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}