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
            };

            dgvMon.CellClick += (s, e) =>
            {
                if (e.RowIndex < 0) return;
                DataGridViewRow row = dgvMon.Rows[e.RowIndex];
                idMonDangChon = Convert.ToInt32(row.Cells["ID"].Value);
                txtTenMon.Text = row.Cells["Tenmon"].Value.ToString();
                cbDanhMuc.SelectedValue = row.Cells["IDdmm"].Value;
                numDonGia.Value = Convert.ToDecimal(row.Cells["DonGia"].Value);
            };

            dgvBan.CellClick += (s, e) =>
            {
                if (e.RowIndex < 0) return;
                DataGridViewRow row = dgvBan.Rows[e.RowIndex];
                idBanDangChon = Convert.ToInt32(row.Cells["ID"].Value);
                txtTenBan.Text = row.Cells["TenBan"].Value.ToString();
                cbLoaiBan.Text = row.Cells["Loai"].Value?.ToString() ?? "";
            };

            btnThemMon.Click += BtnThemMon_Click;
            btnSuaMon.Click += BtnSuaMon_Click;
            btnXoaMon.Click += BtnXoaMon_Click;
            btnLamMoiMon.Click += (s, e) => ResetFormMon();

            btnThemBan.Click += BtnThemBan_Click;
            btnSuaBan.Click += BtnSuaBan_Click;
            btnXoaBan.Click += BtnXoaBan_Click;
            btnLamMoiBan.Click += (s, e) => ResetFormBan();
        }

        private void TrangTriGiaoDien()
        {
            UIHelper.StyleDataGridView(dgvMon);
            UIHelper.StyleDataGridView(dgvBan);

            UIHelper.StyleFlatRoundedButton(btnThemMon, CoffeeTheme.PrimaryBlue, Color.FromArgb(30, 136, 229), Color.White, CoffeeIcons.Plus(Color.White, 16));
            UIHelper.StyleFlatRoundedButton(btnSuaMon, CoffeeTheme.WarningOrange, Color.FromArgb(251, 140, 0), Color.White, CoffeeIcons.Edit(Color.White, 16));
            UIHelper.StyleFlatRoundedButton(btnXoaMon, CoffeeTheme.DangerRed, Color.FromArgb(229, 57, 53), Color.White, CoffeeIcons.Trash(Color.White, 16));
            UIHelper.StyleFlatRoundedButton(btnLamMoiMon, Color.FromArgb(120, 144, 156), Color.FromArgb(144, 164, 174), Color.White);

            UIHelper.StyleFlatRoundedButton(btnThemBan, CoffeeTheme.PrimaryBlue, Color.FromArgb(30, 136, 229), Color.White, CoffeeIcons.Plus(Color.White, 16));
            UIHelper.StyleFlatRoundedButton(btnSuaBan, CoffeeTheme.WarningOrange, Color.FromArgb(251, 140, 0), Color.White, CoffeeIcons.Edit(Color.White, 16));
            UIHelper.StyleFlatRoundedButton(btnXoaBan, CoffeeTheme.DangerRed, Color.FromArgb(229, 57, 53), Color.White, CoffeeIcons.Trash(Color.White, 16));
            UIHelper.StyleFlatRoundedButton(btnLamMoiBan, Color.FromArgb(120, 144, 156), Color.FromArgb(144, 164, 174), Color.White);
        }

        private void LoadDanhMuc()
        {
            DataTable dt = ketnoi.LayDuLieu("SELECT * FROM DanhMucMon");
            cbDanhMuc.DisplayMember = "TenDanhMuc";
            cbDanhMuc.ValueMember = "ID";
            cbDanhMuc.DataSource = dt;
        }

        private void LoadDanhSachMon()
        {
            string sql = @"
                SELECT m.ID, m.Tenmon, dm.TenDanhMuc AS DanhMuc, m.DonGia, m.IDdmm
                FROM Menu m
                JOIN DanhMucMon dm ON m.IDdmm = dm.ID
                ORDER BY m.ID DESC";
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
                int idDM = Convert.ToInt32(cbDanhMuc.SelectedValue);
                decimal donGia = numDonGia.Value;

                ketnoi.ThucThiLenh(
                    "INSERT INTO Menu (Tenmon, IDdmm, DonGia) VALUES (@Ten, @IDdm, @Gia)",
                    new[] {
                        new SqlParameter("@Ten", tenMon),
                        new SqlParameter("@IDdm", idDM),
                        new SqlParameter("@Gia", donGia)
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
    }
}