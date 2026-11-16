using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Coffee_Shop_Management
{
    public partial class BanHang : Form
    {
        private int idbdc = -1;
        private readonly string TenNhanVien;
        private readonly string QuyenHan;

        public BanHang(string TenTK = "admin", string Quyen = "Admin")
        {
            InitializeComponent();
            this.TenNhanVien = TenTK;
            this.QuyenHan = Quyen;
            this.Text = $"Gác Xép Tháng Tư - Quản lý bán hàng | Tài khoản: {TenNhanVien} ({QuyenHan})";

            TrangTriGiaoDienBanHang();

            bx.Enabled = true;

            bool isAdmin = QuyenHan.Equals("Admin", StringComparison.OrdinalIgnoreCase);
            mnuTraCuuHD.Visible = isAdmin;
            mnuTraCuuHD.Enabled = isAdmin;

            mnuTraCuuHD.Click += (s, e) =>
            {
                if (!QuyenHan.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Bạn không có quyền truy cập chức năng Tra cứu hóa đơn!", "Phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                new TimKiemHD().ShowDialog();
            };

            mnuDangXuat.Click += (s, e) =>
            {
                if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            };

            dm.SelectedIndexChanged += dm_SelectedIndexChanged;
            btm.Click += btm_Click;
            bs.Click += bs_Click;
            bx.Click += (s, e) => XoaMonDangChon();
            btt.Click += btt_Click;

            lsvhd.SelectedIndexChanged += (s, e) =>
            {
                if (lsvhd.SelectedItems.Count == 0) return;
                string tenMonChon = lsvhd.SelectedItems[0].SubItems[0].Text;
                int slChon = int.Parse(lsvhd.SelectedItems[0].SubItems[1].Text);

                DataTable dtMon = ketnoi.LayDuLieu(
                    "SELECT ID, IDdmm FROM Menu WHERE Tenmon = @Ten",
                    new[] { new SqlParameter("@Ten", tenMonChon) });

                if (dtMon.Rows.Count > 0)
                {
                    dm.SelectedValue = dtMon.Rows[0]["IDdmm"];
                    tm.SelectedValue = dtMon.Rows[0]["ID"];
                    sl.Value = slChon;
                }
            };

            ContextMenuStrip menuHoaDon = new ContextMenuStrip();
            ToolStripMenuItem itemTang1 = new ToolStripMenuItem("Tăng 1 phần (+1)");
            ToolStripMenuItem itemGiam1 = new ToolStripMenuItem("Giảm 1 phần (-1)");
            ToolStripMenuItem itemXoaMon = new ToolStripMenuItem("Xóa món này (Delete)");

            itemTang1.Click += (s, e) => CapNhatSoLuongNhanh(1);
            itemGiam1.Click += (s, e) => CapNhatSoLuongNhanh(-1);
            itemXoaMon.Click += (s, e) => XoaMonDangChon();

            menuHoaDon.Items.AddRange(new ToolStripItem[] { itemTang1, itemGiam1, new ToolStripSeparator(), itemXoaMon });
            lsvhd.ContextMenuStrip = menuHoaDon;

            lsvhd.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Delete) XoaMonDangChon();
            };

            Load += (s, e) =>
            {
                try
                {
                    LoadDanhSachBan();
                    LoadDanhMucMon();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
        }

        private void TrangTriGiaoDienBanHang()
        {
            this.BackColor = CoffeeTheme.CreamBg;

            menuStrip1.BackColor = CoffeeTheme.EspressoDark;
            menuStrip1.ForeColor = Color.White;
            menuStrip1.Padding = new Padding(10, 5, 10, 5);
            mnuTraCuuHD.Text = "Tra cứu hóa đơn (F3)";
            mnuTraCuuHD.ForeColor = Color.FromArgb(255, 224, 130);
            mnuTraCuuHD.Image = CoffeeIcons.Search(Color.FromArgb(255, 224, 130), 18);
            mnuDangXuat.ForeColor = Color.FromArgb(255, 171, 145);

            grpban.ForeColor = CoffeeTheme.EspressoDark;
            gcthd.ForeColor = CoffeeTheme.EspressoDark;
            grpChonMon.ForeColor = CoffeeTheme.EspressoDark;
            gtt.ForeColor = CoffeeTheme.EspressoDark;

            sdb.BackColor = Color.White;
            lsvhd.BackColor = Color.White;
            lsvhd.BorderStyle = BorderStyle.None;

            GanIconNut(btm, CoffeeTheme.PrimaryBlue, CoffeeIcons.Plus(Color.White, 16), " THÊM");
            GanIconNut(bs, CoffeeTheme.WarningOrange, CoffeeIcons.Edit(Color.White, 16), " SỬA");
            GanIconNut(bx, CoffeeTheme.DangerRed, CoffeeIcons.Trash(Color.White, 16), " XÓA");
            GanIconNut(btt, CoffeeTheme.SuccessGreen, CoffeeIcons.Check(Color.White, 22), " THANH TOÁN");

            tt.BackColor = CoffeeTheme.CreamBg;
            tt.BorderStyle = BorderStyle.FixedSingle;
        }

        private void GanIconNut(Button btn, Color mauNen, Image icon, string chu)
        {
            btn.BackColor = mauNen;
            btn.Image = icon;
            btn.Text = chu;
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn.ImageAlign = ContentAlignment.MiddleCenter;
            btn.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void LoadDanhSachBan()
        {
            sdb.Controls.Clear();
            DataTable dt = ketnoi.LayDuLieu("SELECT * FROM Ban");

            foreach (DataRow row in dt.Rows)
            {
                int idBan = Convert.ToInt32(row["ID"]);
                string tenBan = row["TenBan"].ToString();
                string loaiBan = row["Loai"]?.ToString() ?? "";
                string trangThai = row["TrangThai"].ToString();
                bool isTrong = (trangThai == "Trống");

                RoundedButton btn = new RoundedButton
                {
                    Width = 108,
                    Height = 104,
                    Margin = new Padding(7),
                    Padding = new Padding(0, 8, 0, 6),
                    BorderRadius = 14,
                    BorderSize = 2,
                    BorderColor = isTrong ? CoffeeTheme.MintBorder : CoffeeTheme.PeachBorder,
                    BackColor = isTrong ? CoffeeTheme.MintEmpty : CoffeeTheme.PeachBusy,
                    ForeColor = CoffeeTheme.EspressoDark,
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    Image = isTrong
                        ? CoffeeIcons.EmptyTable(Color.FromArgb(46, 125, 50), 24)
                        : CoffeeIcons.CoffeeCup(Color.FromArgb(216, 67, 21), 24),
                    ImageAlign = ContentAlignment.TopCenter,
                    TextImageRelation = TextImageRelation.ImageAboveText,
                    TextAlign = ContentAlignment.BottomCenter,
                    Text = string.IsNullOrWhiteSpace(loaiBan)
                        ? $"{tenBan}\n[{trangThai}]"
                        : $"{tenBan} ({loaiBan})\n[{trangThai}]",
                    Tag = new Tuple<int, string>(idBan, tenBan)
                };

                if (idBan == idbdc)
                {
                    btn.BorderSize = 3;
                    btn.BorderColor = CoffeeTheme.EspressoDark;
                }

                btn.Click += BtnBan_Click;
                sdb.Controls.Add(btn);
            }
        }

        private void BtnBan_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            var info = (Tuple<int, string>)btn.Tag;
            idbdc = info.Item1;
            lbdc.Text = $"Đang chọn: {info.Item2}";

            LoadDanhSachBan();
            HienThiHoaDon(idbdc);
        }

        private void HienThiHoaDon(int idBan)
        {
            lsvhd.Items.Clear();
            decimal tongTien = 0;

            string query = @"
                SELECT m.Tenmon, ct.SoLuong, ct.DonGia, ct.ThanhTien
                FROM CTHD ct
                JOIN HoaDon hd ON ct.IDhd = hd.ID
                JOIN Menu m ON ct.IDm = m.ID
                WHERE hd.IDb = @IDb AND hd.TrangThai = N'Chưa thanh toán'";

            SqlParameter[] p = { new SqlParameter("@IDb", idBan) };
            DataTable dt = ketnoi.LayDuLieu(query, p);

            int index = 0;
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["Tenmon"].ToString());
                item.SubItems.Add(row["SoLuong"].ToString());
                item.SubItems.Add(Convert.ToDecimal(row["DonGia"]).ToString("N0"));

                decimal thanhTien = Convert.ToDecimal(row["ThanhTien"]);
                item.SubItems.Add(thanhTien.ToString("N0"));
                tongTien += thanhTien;

                if (index % 2 == 1) item.BackColor = CoffeeTheme.CreamBg;
                index++;

                lsvhd.Items.Add(item);
            }

            tt.Text = tongTien.ToString("N0") + " VNĐ";
        }

        private void LoadDanhMucMon()
        {
            DataTable dt = ketnoi.LayDuLieu("SELECT * FROM DanhMucMon");
            dm.DisplayMember = "TenDanhMuc";
            dm.ValueMember = "ID";
            dm.DataSource = dt;
        }

        private void dm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dm.SelectedValue == null) return;
            if (int.TryParse(dm.SelectedValue.ToString(), out int idDanhMuc))
            {
                SqlParameter[] p = { new SqlParameter("@IDdmm", idDanhMuc) };
                DataTable dt = ketnoi.LayDuLieu("SELECT * FROM Menu WHERE IDdmm = @IDdmm", p);

                tm.DisplayMember = "Tenmon";
                tm.ValueMember = "ID";
                tm.DataSource = dt;
            }
        }

        private void btm_Click(object sender, EventArgs e)
        {
            try
            {
                if (idbdc == -1)
                {
                    MessageBox.Show("Vui lòng chọn bàn trước khi thêm món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (tm.SelectedValue == null)
                {
                    MessageBox.Show("Chưa có món ăn nào được chọn trong danh mục này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idMon = Convert.ToInt32(tm.SelectedValue);
                int soLuong = (int)sl.Value;

                object giaObj = ketnoi.LayGiaTriDon("SELECT DonGia FROM Menu WHERE ID = @ID", new[] { new SqlParameter("@ID", idMon) });
                decimal donGia = Convert.ToDecimal(giaObj);

                DataTable dtHD = ketnoi.LayDuLieu(
                    "SELECT ID FROM HoaDon WHERE IDb = @IDb AND TrangThai = N'Chưa thanh toán'",
                    new[] { new SqlParameter("@IDb", idbdc) });

                int idHD;
                if (dtHD.Rows.Count == 0)
                {
                    ketnoi.ThucThiLenh(
                        "INSERT INTO HoaDon (Checkin, IDb, TenNV, TrangThai, TongTien) VALUES (GETDATE(), @IDb, @TenNV, N'Chưa thanh toán', 0)",
                        new[] {
                            new SqlParameter("@IDb", idbdc),
                            new SqlParameter("@TenNV", TenNhanVien)
                        });

                    ketnoi.ThucThiLenh(
                        "UPDATE Ban SET TrangThai = N'Có người' WHERE ID = @ID",
                        new[] { new SqlParameter("@ID", idbdc) });

                    idHD = Convert.ToInt32(ketnoi.LayGiaTriDon("SELECT MAX(ID) FROM HoaDon"));
                }
                else
                {
                    idHD = Convert.ToInt32(dtHD.Rows[0]["ID"]);
                }

                DataTable dtMon = ketnoi.LayDuLieu(
                    "SELECT * FROM CTHD WHERE IDhd = @IDhd AND IDm = @IDm",
                    new[] { new SqlParameter("@IDhd", idHD), new SqlParameter("@IDm", idMon) });

                if (dtMon.Rows.Count > 0)
                {
                    ketnoi.ThucThiLenh(
                        "UPDATE CTHD SET SoLuong = SoLuong + @SL WHERE IDhd = @IDhd AND IDm = @IDm",
                        new[] {
                            new SqlParameter("@SL", soLuong),
                            new SqlParameter("@IDhd", idHD),
                            new SqlParameter("@IDm", idMon)
                        });
                }
                else
                {
                    ketnoi.ThucThiLenh(
                        "INSERT INTO CTHD (IDhd, IDm, SoLuong, DonGia) VALUES (@IDhd, @IDm, @SL, @DonGia)",
                        new[] {
                            new SqlParameter("@IDhd", idHD),
                            new SqlParameter("@IDm", idMon),
                            new SqlParameter("@SL", soLuong),
                            new SqlParameter("@DonGia", donGia)
                        });
                }

                ketnoi.ThucThiLenh(
                    "UPDATE HoaDon SET TongTien = (SELECT ISNULL(SUM(ThanhTien), 0) FROM CTHD WHERE IDhd = @IDhd) WHERE ID = @IDhd",
                    new[] { new SqlParameter("@IDhd", idHD) });

                HienThiHoaDon(idbdc);
                LoadDanhSachBan();
                sl.Value = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm món: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bs_Click(object sender, EventArgs e)
        {
            try
            {
                if (idbdc == -1 || lsvhd.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một món trong bảng Chi tiết hóa đơn để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (tm.SelectedValue == null) return;

                string tenMonCu = lsvhd.SelectedItems[0].SubItems[0].Text;
                int idMonMoi = Convert.ToInt32(tm.SelectedValue);
                int soLuongMoi = (int)sl.Value;

                DataTable dtHD = ketnoi.LayDuLieu(
                    "SELECT ID FROM HoaDon WHERE IDb = @IDb AND TrangThai = N'Chưa thanh toán'",
                    new[] { new SqlParameter("@IDb", idbdc) });

                if (dtHD.Rows.Count == 0) return;
                int idHD = Convert.ToInt32(dtHD.Rows[0]["ID"]);

                int idMonCu = Convert.ToInt32(ketnoi.LayGiaTriDon(
                    "SELECT ID FROM Menu WHERE Tenmon = @Ten",
                    new[] { new SqlParameter("@Ten", tenMonCu) }));

                if (idMonCu == idMonMoi)
                {
                    ketnoi.ThucThiLenh(
                        "UPDATE CTHD SET SoLuong = @SL WHERE IDhd = @IDhd AND IDm = @IDm",
                        new[] {
                            new SqlParameter("@SL", soLuongMoi),
                            new SqlParameter("@IDhd", idHD),
                            new SqlParameter("@IDm", idMonCu)
                        });
                }
                else
                {
                    decimal donGiaMoi = Convert.ToDecimal(ketnoi.LayGiaTriDon(
                        "SELECT DonGia FROM Menu WHERE ID = @ID",
                        new[] { new SqlParameter("@ID", idMonMoi) }));

                    ketnoi.ThucThiLenh("DELETE FROM CTHD WHERE IDhd = @IDhd AND IDm = @IDm",
                        new[] { new SqlParameter("@IDhd", idHD), new SqlParameter("@IDm", idMonCu) });

                    DataTable dtTonTai = ketnoi.LayDuLieu("SELECT * FROM CTHD WHERE IDhd = @IDhd AND IDm = @IDm",
                        new[] { new SqlParameter("@IDhd", idHD), new SqlParameter("@IDm", idMonMoi) });

                    if (dtTonTai.Rows.Count > 0)
                    {
                        ketnoi.ThucThiLenh("UPDATE CTHD SET SoLuong = SoLuong + @SL WHERE IDhd = @IDhd AND IDm = @IDm",
                            new[] { new SqlParameter("@SL", soLuongMoi), new SqlParameter("@IDhd", idHD), new SqlParameter("@IDm", idMonMoi) });
                    }
                    else
                    {
                        ketnoi.ThucThiLenh("INSERT INTO CTHD (IDhd, IDm, SoLuong, DonGia) VALUES (@IDhd, @IDm, @SL, @DonGia)",
                            new[] { new SqlParameter("@IDhd", idHD), new SqlParameter("@IDm", idMonMoi), new SqlParameter("@SL", soLuongMoi), new SqlParameter("@DonGia", donGiaMoi) });
                    }
                }

                ketnoi.ThucThiLenh(
                    "UPDATE HoaDon SET TongTien = (SELECT ISNULL(SUM(ThanhTien), 0) FROM CTHD WHERE IDhd = @IDhd) WHERE ID = @IDhd",
                    new[] { new SqlParameter("@IDhd", idHD) });

                HienThiHoaDon(idbdc);
                sl.Value = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa món: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CapNhatSoLuongNhanh(int ThayDoi)
        {
            try
            {
                if (idbdc == -1 || lsvhd.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Vui lòng click chọn một món trong hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string tenMon = lsvhd.SelectedItems[0].SubItems[0].Text;
                int soLuongHienTai = int.Parse(lsvhd.SelectedItems[0].SubItems[1].Text);

                if (soLuongHienTai + ThayDoi <= 0)
                {
                    XoaMonDangChon();
                    return;
                }

                DataTable dt = ketnoi.LayDuLieu(@"
                    SELECT hd.ID AS IDhd, m.ID AS IDm
                    FROM HoaDon hd
                    JOIN CTHD ct ON hd.ID = ct.IDhd
                    JOIN Menu m ON ct.IDm = m.ID
                    WHERE hd.IDb = @IDb AND hd.TrangThai = N'Chưa thanh toán' AND m.Tenmon = @TenMon",
                    new[] { new SqlParameter("@IDb", idbdc), new SqlParameter("@TenMon", tenMon) });

                if (dt.Rows.Count > 0)
                {
                    int idHD = Convert.ToInt32(dt.Rows[0]["IDhd"]);
                    int idMon = Convert.ToInt32(dt.Rows[0]["IDm"]);

                    ketnoi.ThucThiLenh(
                        "UPDATE CTHD SET SoLuong = SoLuong + @ThayDoi WHERE IDhd = @IDhd AND IDm = @IDm",
                        new[] {
                            new SqlParameter("@ThayDoi", ThayDoi),
                            new SqlParameter("@IDhd", idHD),
                            new SqlParameter("@IDm", idMon)
                        });

                    ketnoi.ThucThiLenh(
                        "UPDATE HoaDon SET TongTien = (SELECT ISNULL(SUM(ThanhTien), 0) FROM CTHD WHERE IDhd = @IDhd) WHERE ID = @IDhd",
                        new[] { new SqlParameter("@IDhd", idHD) });

                    HienThiHoaDon(idbdc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật số lượng: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XoaMonDangChon()
        {
            try
            {
                if (idbdc == -1 || lsvhd.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Vui lòng click chọn một món trong bảng Chi tiết hóa đơn cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string tenMon = lsvhd.SelectedItems[0].SubItems[0].Text;

                if (MessageBox.Show($"Bạn có chắc muốn xóa món '{tenMon}' khỏi hóa đơn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                DataTable dt = ketnoi.LayDuLieu(@"
                    SELECT hd.ID AS IDhd, m.ID AS IDm
                    FROM HoaDon hd
                    JOIN CTHD ct ON hd.ID = ct.IDhd
                    JOIN Menu m ON ct.IDm = m.ID
                    WHERE hd.IDb = @IDb AND hd.TrangThai = N'Chưa thanh toán' AND m.Tenmon = @TenMon",
                    new[] { new SqlParameter("@IDb", idbdc), new SqlParameter("@TenMon", tenMon) });

                if (dt.Rows.Count > 0)
                {
                    int idHD = Convert.ToInt32(dt.Rows[0]["IDhd"]);
                    int idMon = Convert.ToInt32(dt.Rows[0]["IDm"]);

                    ketnoi.ThucThiLenh(
                        "DELETE FROM CTHD WHERE IDhd = @IDhd AND IDm = @IDm",
                        new[] { new SqlParameter("@IDhd", idHD), new SqlParameter("@IDm", idMon) });

                    int soMonConLai = Convert.ToInt32(ketnoi.LayGiaTriDon(
                        "SELECT COUNT(*) FROM CTHD WHERE IDhd = @IDhd",
                        new[] { new SqlParameter("@IDhd", idHD) }));

                    if (soMonConLai == 0)
                    {
                        ketnoi.ThucThiLenh("DELETE FROM HoaDon WHERE ID = @IDhd", new[] { new SqlParameter("@IDhd", idHD) });
                        ketnoi.ThucThiLenh("UPDATE Ban SET TrangThai = N'Trống' WHERE ID = @IDb", new[] { new SqlParameter("@IDb", idbdc) });
                    }
                    else
                    {
                        ketnoi.ThucThiLenh(
                            "UPDATE HoaDon SET TongTien = (SELECT ISNULL(SUM(ThanhTien), 0) FROM CTHD WHERE IDhd = @IDhd) WHERE ID = @IDhd",
                            new[] { new SqlParameter("@IDhd", idHD) });
                    }

                    HienThiHoaDon(idbdc);
                    LoadDanhSachBan();
                    sl.Value = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa món: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btt_Click(object sender, EventArgs e)
        {
            try
            {
                if (idbdc == -1)
                {
                    MessageBox.Show("Vui lòng chọn bàn cần thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable dtHD = ketnoi.LayDuLieu(
                    "SELECT ID, TongTien FROM HoaDon WHERE IDb = @IDb AND TrangThai = N'Chưa thanh toán'",
                    new[] { new SqlParameter("@IDb", idbdc) });

                if (dtHD.Rows.Count > 0)
                {
                    int idHD = Convert.ToInt32(dtHD.Rows[0]["ID"]);
                    decimal tongTien = Convert.ToDecimal(dtHD.Rows[0]["TongTien"]);

                    if (MessageBox.Show($"Xác nhận thanh toán hóa đơn?\nTổng tiền: {tongTien:N0} VNĐ", "Thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ketnoi.ThucThiLenh(
                            "UPDATE HoaDon SET Checkout = GETDATE(), TrangThai = N'Đã thanh toán' WHERE ID = @ID",
                            new[] { new SqlParameter("@ID", idHD) });

                        ketnoi.ThucThiLenh(
                            "UPDATE Ban SET TrangThai = N'Trống' WHERE ID = @ID",
                            new[] { new SqlParameter("@ID", idbdc) });

                        HienThiHoaDon(idbdc);
                        LoadDanhSachBan();
                    }
                }
                else
                {
                    MessageBox.Show("Bàn này hiện đang trống, không có hóa đơn để thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thanh toán: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}