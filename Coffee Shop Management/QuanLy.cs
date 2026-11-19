using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Coffee_Shop_Management
{
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            DinhDangBang(dgvMon);
            DinhDangBang(dgvBan);
            DinhDangBang(dgvTaiKhoan);
            DinhDangBang(dgvLichSuDN);
            GanSuKienNut();

            Load += (s, e) =>
            {
                try
                {
                    LoadDanhMuc();
                    LoadDanhSachMon();
                    LoadDanhSachBan();
                    LoadDanhSachTaiKhoan();
                    LoadLichSuDangNhap(true);
                    if (cbLoaiBan.Items.Count > 0) cbLoaiBan.SelectedIndex = 0;
                    if (cbQuyen.Items.Count > 0) cbQuyen.SelectedIndex = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu quản trị: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
        }

        private void DinhDangBang(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = CoffeeTheme.EspressoDark;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10.5F);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 224, 178);
            dgv.DefaultCellStyle.SelectionForeColor = CoffeeTheme.EspressoDark;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = CoffeeTheme.CreamBg;
        }

        private void GanSuKienNut()
        {
            btnDongQuanLy.Cursor = Cursors.Hand;
            btnDongQuanLy.Click += (s, e) => this.Close();

            dgvMon.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0 && dgvMon.CurrentRow != null)
                {
                    txtIDMon.Text = dgvMon.CurrentRow.Cells["ID"].Value?.ToString();
                    txtTenMon.Text = dgvMon.CurrentRow.Cells["Tenmon"].Value?.ToString();
                    txtDonGia.Text = Convert.ToDecimal(dgvMon.CurrentRow.Cells["DonGia"].Value).ToString("0");
                    if (dgvMon.CurrentRow.Cells["IDdmm"].Value != null)
                        cbDanhMuc.SelectedValue = Convert.ToInt32(dgvMon.CurrentRow.Cells["IDdmm"].Value);
                }
            };

            btnThemMon.Click += (s, e) => ThemMon();
            btnSuaMon.Click += (s, e) => SuaMon();
            btnXoaMon.Click += (s, e) => XoaMon();
            btnLamMoiMon.Click += (s, e) =>
            {
                txtIDMon.Clear();
                txtTenMon.Clear();
                txtDonGia.Clear();
                if (cbDanhMuc.Items.Count > 0) cbDanhMuc.SelectedIndex = 0;
            };

            dgvBan.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0 && dgvBan.CurrentRow != null)
                {
                    txtIDBan.Text = dgvBan.CurrentRow.Cells["ID"].Value?.ToString();
                    txtTenBan.Text = dgvBan.CurrentRow.Cells["TenBan"].Value?.ToString();
                    string loai = dgvBan.CurrentRow.Cells["Loai"].Value?.ToString() ?? "";
                    if (cbLoaiBan.Items.Contains(loai)) cbLoaiBan.SelectedItem = loai;
                }
            };

            btnThemBan.Click += (s, e) => ThemBan();
            btnSuaBan.Click += (s, e) => SuaBan();
            btnXoaBan.Click += (s, e) => XoaBan();
            btnLamMoiBan.Click += (s, e) =>
            {
                txtIDBan.Clear();
                txtTenBan.Clear();
                if (cbLoaiBan.Items.Count > 0) cbLoaiBan.SelectedIndex = 0;
            };

            dgvTaiKhoan.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0 && dgvTaiKhoan.CurrentRow != null)
                {
                    txtTenTK.Text = dgvTaiKhoan.CurrentRow.Cells["TenTK"].Value?.ToString();
                    txtMatKhau.Text = dgvTaiKhoan.CurrentRow.Cells["MK"].Value?.ToString();
                    string quyen = dgvTaiKhoan.CurrentRow.Cells["Quyen"].Value?.ToString() ?? "NhanVien";
                    if (cbQuyen.Items.Contains(quyen)) cbQuyen.SelectedItem = quyen;
                }
            };

            btnThemTK.Click += (s, e) => ThemTaiKhoan();
            btnSuaTK.Click += (s, e) => SuaTaiKhoan();
            btnXoaTK.Click += (s, e) => XoaTaiKhoan();
            btnLamMoiTK.Click += (s, e) =>
            {
                txtTenTK.Clear();
                txtMatKhau.Clear();
                if (cbQuyen.Items.Count > 0) cbQuyen.SelectedIndex = 1;
            };

            btnHomNayDN.Click += (s, e) =>
            {
                dtpNgayDN.Value = DateTime.Today;
                btnHomNayDN.BackColor = CoffeeTheme.EspressoDark;
                btnHomNayDN.ForeColor = Color.White;
                btnTatCaDN.BackColor = CoffeeTheme.CreamBg;
                btnTatCaDN.ForeColor = CoffeeTheme.EspressoDark;
                LoadLichSuDangNhap(true);
            };

            btnTatCaDN.Click += (s, e) =>
            {
                btnTatCaDN.BackColor = CoffeeTheme.EspressoDark;
                btnTatCaDN.ForeColor = Color.White;
                btnHomNayDN.BackColor = CoffeeTheme.CreamBg;
                btnHomNayDN.ForeColor = CoffeeTheme.EspressoDark;
                LoadLichSuDangNhap(false);
            };

            btnLocDN.Click += (s, e) =>
            {
                btnHomNayDN.BackColor = CoffeeTheme.CreamBg;
                btnHomNayDN.ForeColor = CoffeeTheme.EspressoDark;
                btnTatCaDN.BackColor = CoffeeTheme.CreamBg;
                btnTatCaDN.ForeColor = CoffeeTheme.EspressoDark;
                LoadLichSuDangNhap(true);
            };
        }

        private void LoadDanhMuc()
        {
            DataTable dt = ketnoi.LayDuLieu("SELECT ID, TenDanhMuc FROM DanhMucMon ORDER BY ID");
            cbDanhMuc.DisplayMember = "TenDanhMuc";
            cbDanhMuc.ValueMember = "ID";
            cbDanhMuc.DataSource = dt;
        }

        private void LoadDanhSachMon()
        {
            string sql = @"
                SELECT m.ID, m.Tenmon, dm.TenDanhMuc, m.DonGia, m.IDdmm
                FROM Menu m
                LEFT JOIN DanhMucMon dm ON m.IDdmm = dm.ID
                ORDER BY m.ID ASC";
            dgvMon.DataSource = ketnoi.LayDuLieu(sql);
            if (dgvMon.Columns.Contains("IDdmm")) dgvMon.Columns["IDdmm"].Visible = false;
            if (dgvMon.Columns.Contains("ID")) dgvMon.Columns["ID"].HeaderText = "Mã";
            if (dgvMon.Columns.Contains("Tenmon")) dgvMon.Columns["Tenmon"].HeaderText = "Tên món";
            if (dgvMon.Columns.Contains("TenDanhMuc")) dgvMon.Columns["TenDanhMuc"].HeaderText = "Danh mục";
            if (dgvMon.Columns.Contains("DonGia"))
            {
                dgvMon.Columns["DonGia"].HeaderText = "Đơn giá";
                dgvMon.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            }
        }

        private void ThemMon()
        {
            if (string.IsNullOrWhiteSpace(txtTenMon.Text) || !decimal.TryParse(txtDonGia.Text, out decimal gia) || gia < 0)
            {
                MessageBox.Show("Vui lòng nhập tên món và đơn giá hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ketnoi.ThucThiLenh(
                "INSERT INTO Menu (Tenmon, IDdmm, DonGia) VALUES (@Ten, @IDdm, @Gia)",
                new[]
                {
                    new SqlParameter("@Ten", txtTenMon.Text.Trim()),
                    new SqlParameter("@IDdm", cbDanhMuc.SelectedValue),
                    new SqlParameter("@Gia", gia)
                });
            LoadDanhSachMon();
            MessageBox.Show("Đã thêm món mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SuaMon()
        {
            if (!int.TryParse(txtIDMon.Text, out int idMon))
            {
                MessageBox.Show("Vui lòng chọn món cần sửa trong bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenMon.Text) || !decimal.TryParse(txtDonGia.Text, out decimal gia) || gia < 0)
            {
                MessageBox.Show("Vui lòng nhập tên món và đơn giá hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ketnoi.ThucThiLenh(
                "UPDATE Menu SET Tenmon = @Ten, IDdmm = @IDdm, DonGia = @Gia WHERE ID = @ID",
                new[]
                {
                    new SqlParameter("@Ten", txtTenMon.Text.Trim()),
                    new SqlParameter("@IDdm", cbDanhMuc.SelectedValue),
                    new SqlParameter("@Gia", gia),
                    new SqlParameter("@ID", idMon)
                });
            LoadDanhSachMon();
            MessageBox.Show("Đã cập nhật món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void XoaMon()
        {
            if (!int.TryParse(txtIDMon.Text, out int idMon))
            {
                MessageBox.Show("Vui lòng chọn món cần xóa trong bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Xác nhận xóa món '{txtTenMon.Text}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ketnoi.ThucThiLenh("DELETE FROM Menu WHERE ID = @ID", new[] { new SqlParameter("@ID", idMon) });
                txtIDMon.Clear();
                txtTenMon.Clear();
                txtDonGia.Clear();
                LoadDanhSachMon();
            }
        }

        private void LoadDanhSachBan()
        {
            dgvBan.DataSource = ketnoi.LayDuLieu("SELECT ID, TenBan, Loai, TrangThai FROM Ban ORDER BY ID ASC");
            if (dgvBan.Columns.Contains("ID")) dgvBan.Columns["ID"].HeaderText = "Mã bàn";
            if (dgvBan.Columns.Contains("TenBan")) dgvBan.Columns["TenBan"].HeaderText = "Tên bàn";
            if (dgvBan.Columns.Contains("Loai")) dgvBan.Columns["Loai"].HeaderText = "Khu vực";
            if (dgvBan.Columns.Contains("TrangThai")) dgvBan.Columns["TrangThai"].HeaderText = "Trạng thái";
        }

        private void ThemBan()
        {
            if (string.IsNullOrWhiteSpace(txtTenBan.Text))
            {
                MessageBox.Show("Vui lòng nhập tên bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ketnoi.ThucThiLenh(
                "INSERT INTO Ban (TenBan, Loai, TrangThai) VALUES (@Ten, @Loai, N'Trống')",
                new[]
                {
                    new SqlParameter("@Ten", txtTenBan.Text.Trim()),
                    new SqlParameter("@Loai", cbLoaiBan.Text)
                });
            LoadDanhSachBan();
            MessageBox.Show("Đã thêm bàn mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SuaBan()
        {
            if (!int.TryParse(txtIDBan.Text, out int idBan) || string.IsNullOrWhiteSpace(txtTenBan.Text))
            {
                MessageBox.Show("Vui lòng chọn bàn cần sửa trong bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ketnoi.ThucThiLenh(
                "UPDATE Ban SET TenBan = @Ten, Loai = @Loai WHERE ID = @ID",
                new[]
                {
                    new SqlParameter("@Ten", txtTenBan.Text.Trim()),
                    new SqlParameter("@Loai", cbLoaiBan.Text),
                    new SqlParameter("@ID", idBan)
                });
            LoadDanhSachBan();
            MessageBox.Show("Đã cập nhật thông tin bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void XoaBan()
        {
            if (!int.TryParse(txtIDBan.Text, out int idBan))
            {
                MessageBox.Show("Vui lòng chọn bàn cần xóa trong bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Xác nhận xóa '{txtTenBan.Text}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ketnoi.ThucThiLenh("DELETE FROM Ban WHERE ID = @ID", new[] { new SqlParameter("@ID", idBan) });
                txtIDBan.Clear();
                txtTenBan.Clear();
                LoadDanhSachBan();
            }
        }

        private void LoadDanhSachTaiKhoan()
        {
            dgvTaiKhoan.DataSource = ketnoi.LayDuLieu("SELECT TenTK, MK, Quyen FROM TaiKhoan");
            if (dgvTaiKhoan.Columns.Contains("TenTK")) dgvTaiKhoan.Columns["TenTK"].HeaderText = "Tên tài khoản";
            if (dgvTaiKhoan.Columns.Contains("MK")) dgvTaiKhoan.Columns["MK"].HeaderText = "Mật khẩu / PIN";
            if (dgvTaiKhoan.Columns.Contains("Quyen")) dgvTaiKhoan.Columns["Quyen"].HeaderText = "Quyền hạn";
        }

        private void ThemTaiKhoan()
        {
            if (string.IsNullOrWhiteSpace(txtTenTK.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên tài khoản và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tonTai = Convert.ToInt32(ketnoi.LayGiaTriDon(
                "SELECT COUNT(*) FROM TaiKhoan WHERE TenTK = @Ten",
                new[] { new SqlParameter("@Ten", txtTenTK.Text.Trim()) }));

            if (tonTai > 0)
            {
                MessageBox.Show("Tên tài khoản này đã tồn tại!", "Trùng tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ketnoi.ThucThiLenh(
                "INSERT INTO TaiKhoan (TenTK, MK, Quyen) VALUES (@Ten, @MK, @Quyen)",
                new[]
                {
                    new SqlParameter("@Ten", txtTenTK.Text.Trim()),
                    new SqlParameter("@MK", txtMatKhau.Text.Trim()),
                    new SqlParameter("@Quyen", cbQuyen.Text)
                });
            LoadDanhSachTaiKhoan();
            MessageBox.Show("Đã thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SuaTaiKhoan()
        {
            if (string.IsNullOrWhiteSpace(txtTenTK.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng chọn tài khoản và nhập mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ketnoi.ThucThiLenh(
                "UPDATE TaiKhoan SET MK = @MK, Quyen = @Quyen WHERE TenTK = @Ten",
                new[]
                {
                    new SqlParameter("@MK", txtMatKhau.Text.Trim()),
                    new SqlParameter("@Quyen", cbQuyen.Text),
                    new SqlParameter("@Ten", txtTenTK.Text.Trim())
                });
            LoadDanhSachTaiKhoan();
            MessageBox.Show("Đã cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void XoaTaiKhoan()
        {
            if (string.IsNullOrWhiteSpace(txtTenTK.Text))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa trong bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Xác nhận xóa tài khoản '{txtTenTK.Text}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ketnoi.ThucThiLenh("DELETE FROM TaiKhoan WHERE TenTK = @Ten", new[] { new SqlParameter("@Ten", txtTenTK.Text.Trim()) });
                txtTenTK.Clear();
                txtMatKhau.Clear();
                LoadDanhSachTaiKhoan();
            }
        }

        private void LoadLichSuDangNhap(bool locTheoNgay)
        {
            string sql = @"
                SELECT 
                    ID,
                    TenTK,
                    Quyen,
                    Checkin,
                    Checkout,
                    DATEDIFF(MINUTE, Checkin, ISNULL(Checkout, GETDATE())) AS SoPhutTruc,
                    TrangThai
                FROM LichSuDN";

            DataTable dt;
            if (locTheoNgay)
            {
                DateTime tuNgay = dtpNgayDN.Value.Date;
                DateTime denNgay = tuNgay.AddDays(1).AddSeconds(-1);
                sql += " WHERE Checkin BETWEEN @TuNgay AND @DenNgay ORDER BY ID DESC";
                dt = ketnoi.LayDuLieu(sql, new[]
                {
                    new SqlParameter("@TuNgay", tuNgay),
                    new SqlParameter("@DenNgay", denNgay)
                });
            }
            else
            {
                sql += " ORDER BY ID DESC";
                dt = ketnoi.LayDuLieu(sql);
            }

            dgvLichSuDN.DataSource = dt;

            if (dgvLichSuDN.Columns.Contains("ID")) dgvLichSuDN.Columns["ID"].HeaderText = "Mã phiên";
            if (dgvLichSuDN.Columns.Contains("TenTK")) dgvLichSuDN.Columns["TenTK"].HeaderText = "Tài khoản";
            if (dgvLichSuDN.Columns.Contains("Quyen")) dgvLichSuDN.Columns["Quyen"].HeaderText = "Quyền";
            if (dgvLichSuDN.Columns.Contains("Checkin"))
            {
                dgvLichSuDN.Columns["Checkin"].HeaderText = "Ngày giờ Check-in";
                dgvLichSuDN.Columns["Checkin"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            }
            if (dgvLichSuDN.Columns.Contains("Checkout"))
            {
                dgvLichSuDN.Columns["Checkout"].HeaderText = "Ngày giờ Check-out";
                dgvLichSuDN.Columns["Checkout"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            }
            if (dgvLichSuDN.Columns.Contains("SoPhutTruc")) dgvLichSuDN.Columns["SoPhutTruc"].HeaderText = "Tổng phút";
            if (dgvLichSuDN.Columns.Contains("TrangThai")) dgvLichSuDN.Columns["TrangThai"].HeaderText = "Trạng thái";
        }
    }
}