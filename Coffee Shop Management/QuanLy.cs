using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Coffee_Shop_Management
{
    public partial class QuanLy : Form
    {
        private int idMonDangChon = -1;
        private int idDMDangChon = -1;
        private int idBanDangChon = -1;

        public QuanLy()
        {
            InitializeComponent();
            TrangTriGiaoDien();

            Load += (s, e) =>
            {
                LoadDanhMuc();
                LoadDanhSachMon();
                LoadDanhSachBan();
                LoadDanhSachTaiKhoan();
            };

            // Click dòng trên bảng Món
            dgvMon.CellClick += (s, e) =>
            {
                if (e.RowIndex < 0) return;
                DataGridViewRow row = dgvMon.Rows[e.RowIndex];
                idMonDangChon = Convert.ToInt32(row.Cells["ID"].Value);
                txtTenMon.Text = row.Cells["Tenmon"].Value.ToString();
                cbDanhMuc.SelectedValue = row.Cells["IDdmm"].Value;
                numDonGia.Value = Convert.ToDecimal(row.Cells["DonGia"].Value);
            };

            // Click dòng trên bảng Danh mục
            dgvDanhMuc.CellClick += (s, e) =>
            {
                if (e.RowIndex < 0) return;
                DataGridViewRow row = dgvDanhMuc.Rows[e.RowIndex];
                idDMDangChon = Convert.ToInt32(row.Cells["ID"].Value);
                txtTenDM.Text = row.Cells["TenDanhMuc"].Value.ToString();
            };

            // Click dòng trên bảng Bàn
            dgvBan.CellClick += (s, e) =>
            {
                if (e.RowIndex < 0) return;
                DataGridViewRow row = dgvBan.Rows[e.RowIndex];
                idBanDangChon = Convert.ToInt32(row.Cells["ID"].Value);
                txtTenBan.Text = row.Cells["TenBan"].Value.ToString();
                cbLoaiBan.Text = row.Cells["Loai"].Value?.ToString() ?? "";
            };

            // Click dòng trên bảng Tài khoản
            dgvTaiKhoan.CellClick += (s, e) =>
            {
                if (e.RowIndex < 0) return;
                DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];
                txtTenTK.Text = row.Cells["TenTK"].Value.ToString();
                string quyen = row.Cells["Quyen"].Value?.ToString() ?? "Nhân viên";
                cbQuyenTK.SelectedItem = cbQuyenTK.Items.Contains(quyen) ? quyen : "Nhân viên";
                txtMKMoi.Clear();
            };

            // Sự kiện các nút Tab 1: Món
            btnThemMon.Click += BtnThemMon_Click;
            btnSuaMon.Click += BtnSuaMon_Click;
            btnXoaMon.Click += BtnXoaMon_Click;
            btnLamMoiMon.Click += (s, e) => ResetFormMon();

            // Sự kiện các nút Tab 2: Danh mục
            btnThemDM.Click += BtnThemDM_Click;
            btnSuaDM.Click += BtnSuaDM_Click;
            btnXoaDM.Click += BtnXoaDM_Click;
            btnLamMoiDM.Click += (s, e) => ResetFormDM();

            // Sự kiện các nút Tab 3: Bàn
            btnThemBan.Click += BtnThemBan_Click;
            btnSuaBan.Click += BtnSuaBan_Click;
            btnXoaBan.Click += BtnXoaBan_Click;
            btnLamMoiBan.Click += (s, e) => ResetFormBan();

            // Sự kiện các nút Tab 4: Tài khoản
            btnCapNhatTK.Click += BtnCapNhatTK_Click;
            btnXoaTK.Click += BtnXoaTK_Click;
            btnLamMoiTK.Click += (s, e) => ResetFormTK();
        }

        private void TrangTriGiaoDien()
        {
            UIHelper.StyleDataGridView(dgvMon);
            UIHelper.StyleDataGridView(dgvDanhMuc);
            UIHelper.StyleDataGridView(dgvBan);
            UIHelper.StyleDataGridView(dgvTaiKhoan);

            Color grayBtn = Color.FromArgb(120, 144, 156);
            Color grayHover = Color.FromArgb(144, 164, 174);

            // Tab Món
            UIHelper.StyleFlatRoundedButton(btnThemMon, CoffeeTheme.PrimaryBlue, Color.FromArgb(30, 136, 229), Color.White, CoffeeIcons.Plus(Color.White, 16));
            UIHelper.StyleFlatRoundedButton(btnSuaMon, CoffeeTheme.WarningOrange, Color.FromArgb(251, 140, 0), Color.White, CoffeeIcons.Edit(Color.White, 16));
            UIHelper.StyleFlatRoundedButton(btnXoaMon, CoffeeTheme.DangerRed, Color.FromArgb(229, 57, 53), Color.White, CoffeeIcons.Trash(Color.White, 16));
            UIHelper.StyleFlatRoundedButton(btnLamMoiMon, grayBtn, grayHover, Color.White);

            // Tab Danh mục
            UIHelper.StyleFlatRoundedButton(btnThemDM, CoffeeTheme.PrimaryBlue, Color.FromArgb(30, 136, 229), Color.White, CoffeeIcons.Plus(Color.White, 16));
            UIHelper.StyleFlatRoundedButton(btnSuaDM, CoffeeTheme.WarningOrange, Color.FromArgb(251, 140, 0), Color.White, CoffeeIcons.Edit(Color.White, 16));
            UIHelper.StyleFlatRoundedButton(btnXoaDM, CoffeeTheme.DangerRed, Color.FromArgb(229, 57, 53), Color.White, CoffeeIcons.Trash(Color.White, 16));
            UIHelper.StyleFlatRoundedButton(btnLamMoiDM, grayBtn, grayHover, Color.White);

            // Tab Bàn
            UIHelper.StyleFlatRoundedButton(btnThemBan, CoffeeTheme.PrimaryBlue, Color.FromArgb(30, 136, 229), Color.White, CoffeeIcons.Plus(Color.White, 16));
            UIHelper.StyleFlatRoundedButton(btnSuaBan, CoffeeTheme.WarningOrange, Color.FromArgb(251, 140, 0), Color.White, CoffeeIcons.Edit(Color.White, 16));
            UIHelper.StyleFlatRoundedButton(btnXoaBan, CoffeeTheme.DangerRed, Color.FromArgb(229, 57, 53), Color.White, CoffeeIcons.Trash(Color.White, 16));
            UIHelper.StyleFlatRoundedButton(btnLamMoiBan, grayBtn, grayHover, Color.White);

            // Tab Tài khoản
            UIHelper.StyleFlatRoundedButton(btnCapNhatTK, CoffeeTheme.SuccessGreen, Color.FromArgb(67, 160, 71), Color.White, CoffeeIcons.Check(Color.White, 18));
            UIHelper.StyleFlatRoundedButton(btnXoaTK, CoffeeTheme.DangerRed, Color.FromArgb(229, 57, 53), Color.White, CoffeeIcons.Trash(Color.White, 16));
            UIHelper.StyleFlatRoundedButton(btnLamMoiTK, grayBtn, grayHover, Color.White);
        }

        // ==================== TAB 1: QUẢN LÝ MÓN ====================
        private void LoadDanhMuc()
        {
            DataTable dt = ketnoi.LayDuLieu("SELECT ID, TenDanhMuc FROM DanhMucMon ORDER BY ID");
            cbDanhMuc.DisplayMember = "TenDanhMuc";
            cbDanhMuc.ValueMember = "ID";
            cbDanhMuc.DataSource = dt.Copy();

            dgvDanhMuc.DataSource = dt;
            if (dgvDanhMuc.Columns.Contains("ID")) dgvDanhMuc.Columns["ID"].Width = 60;
            if (dgvDanhMuc.Columns.Contains("TenDanhMuc")) dgvDanhMuc.Columns["TenDanhMuc"].HeaderText = "Tên danh mục";
        }

        private void LoadDanhSachMon()
        {
            string sql = @"
                SELECT m.ID, m.Tenmon, dm.TenDanhMuc AS DanhMuc, m.DonGia, m.IDdmm
                FROM Menu m
                JOIN DanhMucMon dm ON m.IDdmm = dm.ID
                ORDER BY m.ID ASC";
            dgvMon.DataSource = ketnoi.LayDuLieu(sql);

            if (dgvMon.Columns.Contains("IDdmm")) dgvMon.Columns["IDdmm"].Visible = false;
            if (dgvMon.Columns.Contains("ID")) dgvMon.Columns["ID"].Width = 50;
            if (dgvMon.Columns.Contains("Tenmon")) dgvMon.Columns["Tenmon"].HeaderText = "Tên món";
            if (dgvMon.Columns.Contains("DanhMuc")) dgvMon.Columns["DanhMuc"].HeaderText = "Danh mục";
            if (dgvMon.Columns.Contains("DonGia"))
            {
                dgvMon.Columns["DonGia"].HeaderText = "Đơn giá";
                dgvMon.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            }
            dgvMon.ClearSelection();
        }

        private void ResetFormMon()
        {
            idMonDangChon = -1;
            txtTenMon.Clear();
            numDonGia.Value = 0;
            if (cbDanhMuc.Items.Count > 0) cbDanhMuc.SelectedIndex = 0;
            txtTenMon.Focus();
        }

        private void BtnThemMon_Click(object sender, EventArgs e)
        {
            string tenMon = txtTenMon.Text.Trim();
            if (string.IsNullOrEmpty(tenMon) || cbDanhMuc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập Tên món và chọn Danh mục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ketnoi.ThucThiLenh(
                    "INSERT INTO Menu (Tenmon, IDdmm, DonGia) VALUES (@Ten, @IDdm, @Gia)",
                    new[] {
                        new SqlParameter("@Ten", tenMon),
                        new SqlParameter("@IDdm", Convert.ToInt32(cbDanhMuc.SelectedValue)),
                        new SqlParameter("@Gia", numDonGia.Value)
                    });

                MessageBox.Show("Thêm món mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachMon();
                ResetFormMon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm món: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSuaMon_Click(object sender, EventArgs e)
        {
            if (idMonDangChon == -1)
            {
                MessageBox.Show("Vui lòng chọn một món trong bảng bên trái để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ketnoi.ThucThiLenh(
                    "UPDATE Menu SET Tenmon = @Ten, IDdmm = @IDdm, DonGia = @Gia WHERE ID = @ID",
                    new[] {
                        new SqlParameter("@Ten", txtTenMon.Text.Trim()),
                        new SqlParameter("@IDdm", Convert.ToInt32(cbDanhMuc.SelectedValue)),
                        new SqlParameter("@Gia", numDonGia.Value),
                        new SqlParameter("@ID", idMonDangChon)
                    });

                MessageBox.Show("Cập nhật món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachMon();
                ResetFormMon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa món: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnXoaMon_Click(object sender, EventArgs e)
        {
            if (idMonDangChon == -1)
            {
                MessageBox.Show("Vui lòng chọn món cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa món '{txtTenMon.Text}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                ketnoi.ThucThiLenh("DELETE FROM Menu WHERE ID = @ID", new[] { new SqlParameter("@ID", idMonDangChon) });
                MessageBox.Show("Đã xóa món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachMon();
                ResetFormMon();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa món này vì đã có trong lịch sử hóa đơn cũ!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ==================== TAB 2: QUẢN LÝ DANH MỤC ====================
        private void ResetFormDM()
        {
            idDMDangChon = -1;
            txtTenDM.Clear();
            txtTenDM.Focus();
        }

        private void BtnThemDM_Click(object sender, EventArgs e)
        {
            string tenDM = txtTenDM.Text.Trim();
            if (string.IsNullOrEmpty(tenDM))
            {
                MessageBox.Show("Vui lòng nhập Tên danh mục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ketnoi.ThucThiLenh("INSERT INTO DanhMucMon (TenDanhMuc) VALUES (@Ten)", new[] { new SqlParameter("@Ten", tenDM) });
                MessageBox.Show("Thêm danh mục mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhMuc();
                ResetFormDM();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm danh mục: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSuaDM_Click(object sender, EventArgs e)
        {
            if (idDMDangChon == -1)
            {
                MessageBox.Show("Vui lòng chọn danh mục cần sửa trong bảng bên trái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ketnoi.ThucThiLenh(
                    "UPDATE DanhMucMon SET TenDanhMuc = @Ten WHERE ID = @ID",
                    new[] { new SqlParameter("@Ten", txtTenDM.Text.Trim()), new SqlParameter("@ID", idDMDangChon) });

                MessageBox.Show("Cập nhật danh mục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhMuc();
                LoadDanhSachMon();
                ResetFormDM();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa danh mục: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnXoaDM_Click(object sender, EventArgs e)
        {
            if (idDMDangChon == -1)
            {
                MessageBox.Show("Vui lòng chọn danh mục cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa danh mục '{txtTenDM.Text}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                ketnoi.ThucThiLenh("DELETE FROM DanhMucMon WHERE ID = @ID", new[] { new SqlParameter("@ID", idDMDangChon) });
                MessageBox.Show("Đã xóa danh mục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhMuc();
                ResetFormDM();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa danh mục này vì vẫn còn món thuộc danh mục đó!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ==================== TAB 3: QUẢN LÝ BÀN ====================
        private void LoadDanhSachBan()
        {
            dgvBan.DataSource = ketnoi.LayDuLieu("SELECT ID, TenBan, Loai, TrangThai FROM Ban ORDER BY ID");
            if (dgvBan.Columns.Contains("ID")) dgvBan.Columns["ID"].Width = 50;
            if (dgvBan.Columns.Contains("TenBan")) dgvBan.Columns["TenBan"].HeaderText = "Tên bàn";
            if (dgvBan.Columns.Contains("Loai")) dgvBan.Columns["Loai"].HeaderText = "Khu vực / Loại";
            if (dgvBan.Columns.Contains("TrangThai")) dgvBan.Columns["TrangThai"].HeaderText = "Trạng thái";
        }

        private void ResetFormBan()
        {
            idBanDangChon = -1;
            txtTenBan.Clear();
            cbLoaiBan.SelectedIndex = -1;
            txtTenBan.Focus();
        }

        private void BtnThemBan_Click(object sender, EventArgs e)
        {
            string tenBan = txtTenBan.Text.Trim();
            string loaiBan = cbLoaiBan.Text.Trim();

            if (string.IsNullOrEmpty(tenBan))
            {
                MessageBox.Show("Vui lòng nhập Tên bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ketnoi.ThucThiLenh(
                    "INSERT INTO Ban (TenBan, Loai, TrangThai) VALUES (@Ten, @Loai, N'Trống')",
                    new[] {
                        new SqlParameter("@Ten", tenBan),
                        new SqlParameter("@Loai", loaiBan)
                    });

                MessageBox.Show("Thêm bàn mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachBan();
                ResetFormBan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm bàn: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSuaBan_Click(object sender, EventArgs e)
        {
            if (idBanDangChon == -1)
            {
                MessageBox.Show("Vui lòng chọn bàn cần sửa trong bảng bên trái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ketnoi.ThucThiLenh(
                    "UPDATE Ban SET TenBan = @Ten, Loai = @Loai WHERE ID = @ID",
                    new[] {
                        new SqlParameter("@Ten", txtTenBan.Text.Trim()),
                        new SqlParameter("@Loai", cbLoaiBan.Text.Trim()),
                        new SqlParameter("@ID", idBanDangChon)
                    });

                MessageBox.Show("Cập nhật thông tin bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachBan();
                ResetFormBan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa bàn: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnXoaBan_Click(object sender, EventArgs e)
        {
            if (idBanDangChon == -1)
            {
                MessageBox.Show("Vui lòng chọn bàn cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa '{txtTenBan.Text}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                ketnoi.ThucThiLenh("DELETE FROM Ban WHERE ID = @ID", new[] { new SqlParameter("@ID", idBanDangChon) });
                MessageBox.Show("Đã xóa bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachBan();
                ResetFormBan();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa bàn này vì bàn đang có khách hoặc đã từng phát sinh hóa đơn!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ==================== TAB 4: QUẢN LÝ TÀI KHOẢN ====================
        private void LoadDanhSachTaiKhoan()
        {
            dgvTaiKhoan.DataSource = ketnoi.LayDuLieu("SELECT TenTK, Quyen FROM TaiKhoan ORDER BY Quyen, TenTK");
            if (dgvTaiKhoan.Columns.Contains("TenTK")) dgvTaiKhoan.Columns["TenTK"].HeaderText = "Tên tài khoản";
            if (dgvTaiKhoan.Columns.Contains("Quyen")) dgvTaiKhoan.Columns["Quyen"].HeaderText = "Quyền hạn";
        }

        private void ResetFormTK()
        {
            txtTenTK.Clear();
            txtMKMoi.Clear();
            cbQuyenTK.SelectedIndex = -1;
        }

        private void BtnCapNhatTK_Click(object sender, EventArgs e)
        {
            string tenTK = txtTenTK.Text.Trim();
            if (string.IsNullOrEmpty(tenTK))
            {
                MessageBox.Show("Vui lòng click chọn một tài khoản trong bảng bên trái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string quyenMoi = cbQuyenTK.SelectedItem?.ToString() ?? "Nhân viên";
            string mkMoi = txtMKMoi.Text.Trim();

            if (tenTK.Equals("admin", StringComparison.OrdinalIgnoreCase) && !quyenMoi.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Không thể hạ quyền của tài khoản quản trị gốc 'admin'!", "Bảo vệ hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (string.IsNullOrEmpty(mkMoi))
                {
                    ketnoi.ThucThiLenh(
                        "UPDATE TaiKhoan SET Quyen = @Quyen WHERE TenTK = @TenTK",
                        new[] { new SqlParameter("@Quyen", quyenMoi), new SqlParameter("@TenTK", tenTK) });
                }
                else
                {
                    ketnoi.ThucThiLenh(
                        "UPDATE TaiKhoan SET Quyen = @Quyen, MK = @MK WHERE TenTK = @TenTK",
                        new[] {
                            new SqlParameter("@Quyen", quyenMoi),
                            new SqlParameter("@MK", mkMoi),
                            new SqlParameter("@TenTK", tenTK)
                        });
                }

                MessageBox.Show($"Đã cập nhật tài khoản '{tenTK}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachTaiKhoan();
                ResetFormTK();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật tài khoản: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnXoaTK_Click(object sender, EventArgs e)
        {
            string tenTK = txtTenTK.Text.Trim();
            if (string.IsNullOrEmpty(tenTK))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tenTK.Equals("admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Không thể xóa tài khoản quản trị gốc 'admin'!", "Bảo vệ hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa vĩnh viễn tài khoản '{tenTK}'?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                ketnoi.ThucThiLenh("DELETE FROM TaiKhoan WHERE TenTK = @TenTK", new[] { new SqlParameter("@TenTK", tenTK) });
                MessageBox.Show("Đã xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachTaiKhoan();
                ResetFormTK();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa tài khoản: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}