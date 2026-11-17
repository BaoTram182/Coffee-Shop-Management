using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Coffee_Shop_Management
{
    public partial class BanHang : Form
    {
        private int idbdc = -1;
        private int idDanhMucDangChon = -1;
        private readonly string TenNhanVien;
        private readonly string QuyenHan;

        public BanHang(string TenTK = "admin", string Quyen = "Admin")
        {
            InitializeComponent();
            this.TenNhanVien = TenTK;
            this.QuyenHan = Quyen;
            this.Text = $"Gác Xép Tháng Tư - Touch POS | Thu ngân: {TenNhanVien} ({QuyenHan})";
            this.DoubleBuffered = true;

            ThietLapThanhMenuTouch();
            KhoiTaoSuKienGiaoDienPOS();

            Load += (s, e) =>
            {
                try
                {
                    LoadDanhSachBan();
                    LoadThanhDanhMucPOS();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
        }

        private void ThietLapThanhMenuTouch()
        {
            bool isAdmin = QuyenHan.Equals("Admin", StringComparison.OrdinalIgnoreCase);

            menuStrip1.Renderer = new CoffeeMenuRenderer();

            mnuTraCuuHD.Text = "  Tra cứu hóa đơn  ";
            mnuTraCuuHD.Image = CoffeeIcons.Search(Color.FromArgb(255, 224, 130), 22);
            mnuTraCuuHD.ImageScaling = ToolStripItemImageScaling.None;
            mnuTraCuuHD.Visible = isAdmin;
            mnuTraCuuHD.Enabled = isAdmin;
            mnuTraCuuHD.Click += (s, e) => new TimKiemHD().ShowDialog();

            ToolStripMenuItem mnuQuanLy = new ToolStripMenuItem("  Quản lý Thực đơn && Bàn  ")
            {
                ForeColor = Color.FromArgb(165, 214, 167),
                Image = CoffeeIcons.Edit(Color.FromArgb(165, 214, 167), 22),
                ImageScaling = ToolStripItemImageScaling.None,
                Visible = isAdmin,
                Enabled = isAdmin
            };
            mnuQuanLy.Click += (s, e) =>
            {
                new QuanLy().ShowDialog();
                LoadDanhSachBan();
                LoadThanhDanhMucPOS();
            };
            menuStrip1.Items.Insert(1, mnuQuanLy);

            ToolStripMenuItem mnuChuyenBan = new ToolStripMenuItem("  Chuyển / Gộp bàn  ")
            {
                ForeColor = Color.FromArgb(129, 212, 250),
                Image = CoffeeIcons.EmptyTable(Color.FromArgb(129, 212, 250), 22),
                ImageScaling = ToolStripItemImageScaling.None
            };
            mnuChuyenBan.Click += (s, e) => MoHopThoaiChuyenGopBan();
            menuStrip1.Items.Insert(isAdmin ? 2 : 1, mnuChuyenBan);

            mnuDangXuat.Text = "  Đăng xuất  ";
            mnuDangXuat.Click += (s, e) =>
            {
                if (MessageBox.Show("Bạn có muốn đăng xuất ca làm việc này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            };
        }

        private void KhoiTaoSuKienGiaoDienPOS()
        {
            BatDoubleBuffer(sdb);
            BatDoubleBuffer(flpDanhMucPOS);
            BatDoubleBuffer(flpThucDonPOS);
            BatDoubleBuffer(lsvhd);

            KichHoatVuotCuon(sdb);
            KichHoatVuotCuon(flpDanhMucPOS, vuotNgang: true);
            KichHoatVuotCuon(flpThucDonPOS);

            lsvhd.SmallImageList = new ImageList { ImageSize = new Size(1, 44) };
            lsvhd.SizeChanged += (s, e) => CanChinhCotHoaDon();

            btnSuaTouch.Image = CoffeeIcons.Edit(Color.White, 18);
            btnSuaTouch.TextImageRelation = TextImageRelation.ImageBeforeText;

            btnXoaTouch.Image = CoffeeIcons.Trash(Color.White, 18);
            btnXoaTouch.TextImageRelation = TextImageRelation.ImageBeforeText;

            btnThanhToanTouch.Text = "  THANH TOÁN";
            btnThanhToanTouch.Image = CoffeeIcons.Check(Color.White, 26);
            btnThanhToanTouch.TextImageRelation = TextImageRelation.ImageBeforeText;

            GanHieuUngHover(btnThemTouch, CoffeeTheme.PrimaryBlue, Color.FromArgb(30, 136, 229));
            GanHieuUngHover(btnSuaTouch, CoffeeTheme.WarningOrange, Color.FromArgb(251, 140, 0));
            GanHieuUngHover(btnXoaTouch, CoffeeTheme.DangerRed, Color.FromArgb(229, 57, 53));
            GanHieuUngHover(btnThanhToanTouch, CoffeeTheme.SuccessGreen, Color.FromArgb(67, 160, 71));

            btnThemTouch.Click += (s, e) => CapNhatSoLuongNhanh(1);
            btnSuaTouch.Click += (s, e) => MoHopThoaiSuaSoLuong();
            btnXoaTouch.Click += (s, e) => XoaMonDangChon();
            btnThanhToanTouch.Click += btt_Click;

            CanChinhCotHoaDon();
        }

        private void GanHieuUngHover(RoundedButton btn, Color bg, Color hover)
        {
            btn.Cursor = Cursors.Hand;
            btn.MouseEnter += (s, e) => btn.BackColor = hover;
            btn.MouseLeave += (s, e) => btn.BackColor = bg;
        }

        private void CanChinhCotHoaDon()
        {
            if (lsvhd.Columns.Count >= 4 && lsvhd.ClientSize.Width > 80)
            {
                int w = lsvhd.ClientSize.Width - 4;
                lsvhd.Columns[0].Width = (int)(w * 0.40);
                lsvhd.Columns[1].Width = (int)(w * 0.13);
                lsvhd.Columns[2].Width = (int)(w * 0.22);
                lsvhd.Columns[3].Width = w - lsvhd.Columns[0].Width - lsvhd.Columns[1].Width - lsvhd.Columns[2].Width;
            }
        }

        private void BatDoubleBuffer(Control ctrl)
        {
            typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                ?.SetValue(ctrl, true, null);
        }

        private void KichHoatVuotCuon(FlowLayoutPanel panel, bool vuotNgang = false)
        {
            bool dangGiu = false;
            bool daVuot = false;
            Point viTriDau = Point.Empty;
            Point scrollDau = Point.Empty;

            void GanSuKien(Control c)
            {
                if (c.Tag?.ToString() == "DaGanVuot") return;

                c.MouseDown += (s, e) =>
                {
                    if (e.Button != MouseButtons.Left) return;
                    dangGiu = true;
                    daVuot = false;
                    viTriDau = Cursor.Position;
                    scrollDau = new Point(-panel.AutoScrollPosition.X, -panel.AutoScrollPosition.Y);
                };

                c.MouseMove += (s, e) =>
                {
                    if (!dangGiu) return;
                    int dx = Cursor.Position.X - viTriDau.X;
                    int dy = Cursor.Position.Y - viTriDau.Y;

                    if (Math.Abs(dx) > 8 || Math.Abs(dy) > 8)
                    {
                        daVuot = true;
                        panel.Tag = "DangVuot";
                        if (vuotNgang)
                            panel.AutoScrollPosition = new Point(scrollDau.X - dx, scrollDau.Y);
                        else
                            panel.AutoScrollPosition = new Point(scrollDau.X, scrollDau.Y - dy);
                    }
                };

                c.MouseUp += (s, e) =>
                {
                    dangGiu = false;
                    if (daVuot)
                    {
                        Timer t = new Timer { Interval = 80 };
                        t.Tick += (ts, te) => { panel.Tag = null; t.Stop(); t.Dispose(); };
                        t.Start();
                    }
                    else
                    {
                        panel.Tag = null;
                    }
                };
            }

            GanSuKien(panel);
            panel.ControlAdded += (s, e) => GanSuKien(e.Control);
        }

        private void LoadDanhSachBan()
        {
            sdb.SuspendLayout();
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
                    Width = 116,
                    Height = 112,
                    Margin = new Padding(7),
                    Padding = new Padding(0, 10, 0, 8),
                    BorderRadius = 16,
                    BorderSize = (idBan == idbdc) ? 4 : 2,
                    BorderColor = (idBan == idbdc) ? CoffeeTheme.EspressoDark : (isTrong ? CoffeeTheme.MintBorder : CoffeeTheme.PeachBorder),
                    BackColor = isTrong ? CoffeeTheme.MintEmpty : CoffeeTheme.PeachBusy,
                    ForeColor = CoffeeTheme.EspressoDark,
                    Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                    Image = isTrong
                        ? CoffeeIcons.EmptyTable(Color.FromArgb(46, 125, 50), 26)
                        : CoffeeIcons.CoffeeCup(Color.FromArgb(216, 67, 21), 26),
                    ImageAlign = ContentAlignment.TopCenter,
                    TextImageRelation = TextImageRelation.ImageAboveText,
                    TextAlign = ContentAlignment.BottomCenter,
                    Text = string.IsNullOrWhiteSpace(loaiBan)
                        ? $"{tenBan}\n[{trangThai}]"
                        : $"{tenBan} ({loaiBan})\n[{trangThai}]",
                    Tag = new Tuple<int, string>(idBan, tenBan)
                };

                btn.Click += (s, e) =>
                {
                    if (sdb.Tag?.ToString() == "DangVuot") return;
                    var info = (Tuple<int, string>)btn.Tag;
                    idbdc = info.Item1;
                    lblTieuDeBanPOS.Text = $"ĐANG PHỤC VỤ: {info.Item2.ToUpper()}";
                    LoadDanhSachBan();
                    HienThiHoaDon(idbdc);
                };

                sdb.Controls.Add(btn);
            }
            sdb.ResumeLayout();
        }

        private void LoadThanhDanhMucPOS()
        {
            flpDanhMucPOS.Controls.Clear();
            DataTable dt = ketnoi.LayDuLieu("SELECT * FROM DanhMucMon ORDER BY ID");

            ThemNutDanhMucPOS(-1, "Tất cả món");

            foreach (DataRow row in dt.Rows)
            {
                int idDM = Convert.ToInt32(row["ID"]);
                string tenDM = row["TenDanhMuc"].ToString();
                ThemNutDanhMucPOS(idDM, tenDM);
            }

            LoadLuoiThucDonPOS(idDanhMucDangChon);
        }

        private void ThemNutDanhMucPOS(int idDM, string tenDM)
        {
            bool dangChon = (idDM == idDanhMucDangChon);
            RoundedButton btnDM = new RoundedButton
            {
                Height = 44,
                AutoSize = true,
                MinimumSize = new Size(105, 44),
                Padding = new Padding(14, 0, 14, 0),
                Margin = new Padding(4, 0, 4, 0),
                BorderRadius = 12,
                BackColor = dangChon ? CoffeeTheme.EspressoDark : Color.White,
                ForeColor = dangChon ? Color.White : CoffeeTheme.EspressoDark,
                BorderSize = 1,
                BorderColor = CoffeeTheme.EspressoDark,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Text = tenDM
            };

            btnDM.Click += (s, e) =>
            {
                if (flpDanhMucPOS.Tag?.ToString() == "DangVuot") return;
                idDanhMucDangChon = idDM;
                LoadThanhDanhMucPOS();
            };

            flpDanhMucPOS.Controls.Add(btnDM);
        }

        private void LoadLuoiThucDonPOS(int idDanhMuc)
        {
            flpThucDonPOS.SuspendLayout();
            flpThucDonPOS.Controls.Clear();

            DataTable dt = (idDanhMuc == -1)
                ? ketnoi.LayDuLieu("SELECT ID, Tenmon, DonGia FROM Menu ORDER BY ID ASC")
                : ketnoi.LayDuLieu("SELECT ID, Tenmon, DonGia FROM Menu WHERE IDdmm = @IDdmm ORDER BY ID ASC",
                    new[] { new SqlParameter("@IDdmm", idDanhMuc) });

            foreach (DataRow row in dt.Rows)
            {
                int idMon = Convert.ToInt32(row["ID"]);
                string tenMon = row["Tenmon"].ToString();
                decimal donGia = Convert.ToDecimal(row["DonGia"]);

                RoundedButton cardMon = new RoundedButton
                {
                    Width = 156,
                    Height = 124,
                    Margin = new Padding(7),
                    Padding = new Padding(6),
                    BorderRadius = 14,
                    BorderSize = 1,
                    BorderColor = Color.FromArgb(215, 204, 200),
                    BackColor = CoffeeTheme.CreamBg,
                    ForeColor = CoffeeTheme.EspressoDark,
                    Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = $"{tenMon}\n{donGia:N0} đ"
                };

                cardMon.MouseDown += (s, e) => cardMon.BackColor = Color.FromArgb(255, 224, 178);
                cardMon.MouseUp += (s, e) => cardMon.BackColor = CoffeeTheme.CreamBg;

                cardMon.Click += (s, e) =>
                {
                    if (flpThucDonPOS.Tag?.ToString() == "DangVuot") return;
                    ThemMonNhanh1Cham(idMon, donGia);
                };

                flpThucDonPOS.Controls.Add(cardMon);
            }
            flpThucDonPOS.ResumeLayout();
        }

        private void ThemMonNhanh1Cham(int idMon, decimal donGia)
        {
            try
            {
                if (idbdc == -1)
                {
                    MessageBox.Show("Vui lòng chạm chọn một bàn ở cột bên trái trước!", "Chưa chọn bàn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable dtHD = ketnoi.LayDuLieu(
                    "SELECT ID FROM HoaDon WHERE IDb = @IDb AND TrangThai = N'Chưa thanh toán'",
                    new[] { new SqlParameter("@IDb", idbdc) });

                int idHD;
                bool banMoiMo = false;
                if (dtHD.Rows.Count == 0)
                {
                    ketnoi.ThucThiLenh(
                        "INSERT INTO HoaDon (Checkin, IDb, TenNV, TrangThai, TongTien) VALUES (GETDATE(), @IDb, @TenNV, N'Chưa thanh toán', 0)",
                        new[] { new SqlParameter("@IDb", idbdc), new SqlParameter("@TenNV", TenNhanVien) });

                    ketnoi.ThucThiLenh("UPDATE Ban SET TrangThai = N'Có người' WHERE ID = @ID", new[] { new SqlParameter("@ID", idbdc) });
                    idHD = Convert.ToInt32(ketnoi.LayGiaTriDon("SELECT MAX(ID) FROM HoaDon"));
                    banMoiMo = true;
                }
                else
                {
                    idHD = Convert.ToInt32(dtHD.Rows[0]["ID"]);
                }

                DataTable dtMon = ketnoi.LayDuLieu(
                    "SELECT IDhd FROM CTHD WHERE IDhd = @IDhd AND IDm = @IDm",
                    new[] { new SqlParameter("@IDhd", idHD), new SqlParameter("@IDm", idMon) });

                if (dtMon.Rows.Count > 0)
                {
                    ketnoi.ThucThiLenh(
                        "UPDATE CTHD SET SoLuong = SoLuong + 1 WHERE IDhd = @IDhd AND IDm = @IDm",
                        new[] { new SqlParameter("@IDhd", idHD), new SqlParameter("@IDm", idMon) });
                }
                else
                {
                    ketnoi.ThucThiLenh(
                        "INSERT INTO CTHD (IDhd, IDm, SoLuong, DonGia) VALUES (@IDhd, @IDm, 1, @DonGia)",
                        new[] { new SqlParameter("@IDhd", idHD), new SqlParameter("@IDm", idMon), new SqlParameter("@DonGia", donGia) });
                }

                ketnoi.ThucThiLenh(
                    "UPDATE HoaDon SET TongTien = (SELECT ISNULL(SUM(ThanhTien), 0) FROM CTHD WHERE IDhd = @IDhd) WHERE ID = @IDhd",
                    new[] { new SqlParameter("@IDhd", idHD) });

                HienThiHoaDon(idbdc);
                if (banMoiMo) LoadDanhSachBan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gọi món: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            DataTable dt = ketnoi.LayDuLieu(query, new[] { new SqlParameter("@IDb", idBan) });

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

            txtTongTienPOS.Text = tongTien.ToString("N0") + " VNĐ";
        }

        private void CapNhatSoLuongNhanh(int ThayDoi)
        {
            try
            {
                if (idbdc == -1 || lsvhd.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Vui lòng chạm chọn một món trong bảng Chi tiết hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        new[] { new SqlParameter("@ThayDoi", ThayDoi), new SqlParameter("@IDhd", idHD), new SqlParameter("@IDm", idMon) });

                    ketnoi.ThucThiLenh(
                        "UPDATE HoaDon SET TongTien = (SELECT ISNULL(SUM(ThanhTien), 0) FROM CTHD WHERE IDhd = @IDhd) WHERE ID = @IDhd",
                        new[] { new SqlParameter("@IDhd", idHD) });

                    HienThiHoaDon(idbdc);

                    foreach (ListViewItem item in lsvhd.Items)
                    {
                        if (item.Text == tenMon) { item.Selected = true; break; }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật số lượng: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MoHopThoaiSuaSoLuong()
        {
            try
            {
                if (idbdc == -1 || lsvhd.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Vui lòng chạm chọn một món trong bảng Chi tiết hóa đơn để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string tenMon = lsvhd.SelectedItems[0].SubItems[0].Text;
                int soLuongCu = int.Parse(lsvhd.SelectedItems[0].SubItems[1].Text);
                int soLuongMoi = soLuongCu;

                using (Form dlg = new Form())
                {
                    dlg.Text = "Sửa số lượng món";
                    dlg.Size = new Size(340, 410);
                    dlg.StartPosition = FormStartPosition.CenterParent;
                    dlg.FormBorderStyle = FormBorderStyle.FixedDialog;
                    dlg.MaximizeBox = false;
                    dlg.MinimizeBox = false;
                    dlg.BackColor = CoffeeTheme.CreamBg;

                    Label lblTen = new Label
                    {
                        Dock = DockStyle.Top,
                        Height = 46,
                        Text = tenMon,
                        Font = new Font("Segoe UI", 11.5F, FontStyle.Bold),
                        ForeColor = Color.White,
                        BackColor = CoffeeTheme.EspressoDark,
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    Label lblSoLuong = new Label
                    {
                        Location = new Point(20, 58),
                        Size = new Size(284, 52),
                        Text = soLuongMoi.ToString(),
                        Font = new Font("Segoe UI", 20F, FontStyle.Bold),
                        ForeColor = CoffeeTheme.PrimaryBlue,
                        BackColor = Color.White,
                        BorderStyle = BorderStyle.FixedSingle,
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    TableLayoutPanel tblPad = new TableLayoutPanel
                    {
                        Location = new Point(20, 120),
                        Size = new Size(284, 180),
                        ColumnCount = 3,
                        RowCount = 4
                    };
                    for (int c = 0; c < 3; c++) tblPad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
                    for (int r = 0; r < 4; r++) tblPad.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));

                    string[] nut = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "Xóa", "0", "Lùi" };
                    for (int i = 0; i < nut.Length; i++)
                    {
                        string k = nut[i];
                        bool laChucNang = (k == "Xóa" || k == "Lùi");
                        RoundedButton b = new RoundedButton
                        {
                            Dock = DockStyle.Fill,
                            Text = k,
                            Margin = new Padding(3),
                            BorderRadius = 10,
                            BackColor = laChucNang ? Color.FromArgb(239, 235, 233) : Color.White,
                            ForeColor = laChucNang ? CoffeeTheme.DangerRed : CoffeeTheme.EspressoDark,
                            BorderSize = 1,
                            BorderColor = Color.FromArgb(200, 195, 190),
                            Font = new Font("Segoe UI", 11F, FontStyle.Bold)
                        };

                        b.Click += (s, e) =>
                        {
                            string cur = soLuongMoi.ToString();
                            if (k == "Xóa") soLuongMoi = 0;
                            else if (k == "Lùi") soLuongMoi = cur.Length > 1 ? int.Parse(cur.Substring(0, cur.Length - 1)) : 0;
                            else
                            {
                                string next = (cur == "0" ? "" : cur) + k;
                                if (next.Length <= 3 && int.TryParse(next, out int val)) soLuongMoi = val;
                            }
                            lblSoLuong.Text = soLuongMoi.ToString();
                        };
                        tblPad.Controls.Add(b, i % 3, i / 3);
                    }

                    RoundedButton btnLuu = new RoundedButton
                    {
                        Text = "CẬP NHẬT SỐ LƯỢNG",
                        Location = new Point(20, 310),
                        Size = new Size(284, 48),
                        BorderRadius = 12,
                        BackColor = CoffeeTheme.SuccessGreen,
                        ForeColor = Color.White,
                        Font = new Font("Segoe UI", 10.5F, FontStyle.Bold)
                    };

                    btnLuu.Click += (s, e) =>
                    {
                        if (soLuongMoi <= 0)
                        {
                            dlg.Close();
                            XoaMonDangChon();
                            return;
                        }

                        int chenhLech = soLuongMoi - soLuongCu;
                        dlg.Close();
                        if (chenhLech != 0) CapNhatSoLuongNhanh(chenhLech);
                    };

                    dlg.Controls.AddRange(new Control[] { lblTen, lblSoLuong, tblPad, btnLuu });
                    dlg.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa số lượng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XoaMonDangChon()
        {
            try
            {
                if (idbdc == -1 || lsvhd.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Vui lòng chạm chọn món cần xóa trong hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string tenMon = lsvhd.SelectedItems[0].SubItems[0].Text;

                if (MessageBox.Show($"Xóa món '{tenMon}' khỏi hóa đơn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
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

                    ketnoi.ThucThiLenh("DELETE FROM CTHD WHERE IDhd = @IDhd AND IDm = @IDm",
                        new[] { new SqlParameter("@IDhd", idHD), new SqlParameter("@IDm", idMon) });

                    int soMonConLai = Convert.ToInt32(ketnoi.LayGiaTriDon(
                        "SELECT COUNT(*) FROM CTHD WHERE IDhd = @IDhd",
                        new[] { new SqlParameter("@IDhd", idHD) }));

                    if (soMonConLai == 0)
                    {
                        ketnoi.ThucThiLenh("DELETE FROM HoaDon WHERE ID = @IDhd", new[] { new SqlParameter("@IDhd", idHD) });
                        ketnoi.ThucThiLenh("UPDATE Ban SET TrangThai = N'Trống' WHERE ID = @IDb", new[] { new SqlParameter("@IDb", idbdc) });
                        LoadDanhSachBan();
                    }
                    else
                    {
                        ketnoi.ThucThiLenh(
                            "UPDATE HoaDon SET TongTien = (SELECT ISNULL(SUM(ThanhTien), 0) FROM CTHD WHERE IDhd = @IDhd) WHERE ID = @IDhd",
                            new[] { new SqlParameter("@IDhd", idHD) });
                    }

                    HienThiHoaDon(idbdc);
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
                    MessageBox.Show("Vui lòng chạm chọn bàn cần thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable dtHD = ketnoi.LayDuLieu(
                    "SELECT ID, TongTien FROM HoaDon WHERE IDb = @IDb AND TrangThai = N'Chưa thanh toán'",
                    new[] { new SqlParameter("@IDb", idbdc) });

                if (dtHD.Rows.Count > 0)
                {
                    int idHD = Convert.ToInt32(dtHD.Rows[0]["ID"]);
                    decimal tongTien = Convert.ToDecimal(dtHD.Rows[0]["TongTien"]);
                    string tenBanHienTai = lblTieuDeBanPOS.Text.Replace("ĐANG PHỤC VỤ: ", "");

                    var ketQuaThanhToan = MoHopThoaiThanhToanCamUng(tenBanHienTai, tongTien);
                    if (ketQuaThanhToan.DaXacNhan)
                    {
                        DataTable dtChiTietIn = ketnoi.LayDuLieu(@"
                            SELECT m.Tenmon, ct.SoLuong, ct.DonGia, ct.ThanhTien
                            FROM CTHD ct
                            JOIN Menu m ON ct.IDm = m.ID
                            WHERE ct.IDhd = @IDhd",
                            new[] { new SqlParameter("@IDhd", idHD) });

                        ketnoi.ThucThiLenh("UPDATE HoaDon SET Checkout = GETDATE(), TrangThai = N'Đã thanh toán' WHERE ID = @ID",
                            new[] { new SqlParameter("@ID", idHD) });

                        ketnoi.ThucThiLenh("UPDATE Ban SET TrangThai = N'Trống' WHERE ID = @ID",
                            new[] { new SqlParameter("@ID", idbdc) });

                        HienThiHoaDon(idbdc);
                        LoadDanhSachBan();

                        if (ketQuaThanhToan.InHoaDon)
                        {
                            InHoaDon(idHD, tenBanHienTai, dtChiTietIn, tongTien, ketQuaThanhToan.TienKhachDua, ketQuaThanhToan.TienThoi);
                        }
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

        private (bool DaXacNhan, bool InHoaDon, decimal TienKhachDua, decimal TienThoi) MoHopThoaiThanhToanCamUng(string tenBan, decimal tongTien)
        {
            decimal tienKhachDua = tongTien;
            bool xacNhan = false;
            bool muonIn = true;

            using (Form dlg = new Form())
            {
                dlg.Text = $"Thanh toán cảm ứng - {tenBan}";
                dlg.Size = new Size(560, 560);
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.FormBorderStyle = FormBorderStyle.FixedDialog;
                dlg.MaximizeBox = false;
                dlg.MinimizeBox = false;
                dlg.BackColor = CoffeeTheme.CreamBg;

                Panel pnlTop = new Panel { Dock = DockStyle.Top, Height = 56, BackColor = CoffeeTheme.EspressoDark };
                Label lblHeader = new Label
                {
                    Dock = DockStyle.Fill,
                    Text = $"  THANH TOÁN: {tenBan}",
                    Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.MiddleLeft
                };
                pnlTop.Controls.Add(lblHeader);

                TableLayoutPanel tblSummary = new TableLayoutPanel
                {
                    Location = new Point(20, 70),
                    Size = new Size(504, 126),
                    ColumnCount = 2,
                    RowCount = 3,
                    BackColor = Color.White,
                    CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
                };
                tblSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48F));
                tblSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52F));
                for (int i = 0; i < 3; i++) tblSummary.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));

                Label TaoLblTrai(string txt) => new Label
                {
                    Dock = DockStyle.Fill,
                    Text = "  " + txt,
                    Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                    ForeColor = CoffeeTheme.EspressoDark,
                    TextAlign = ContentAlignment.MiddleLeft
                };

                Label TaoLblPhai(string txt, Color mau) => new Label
                {
                    Dock = DockStyle.Fill,
                    Text = txt + "  ",
                    Font = new Font("Segoe UI", 13.5F, FontStyle.Bold),
                    ForeColor = mau,
                    TextAlign = ContentAlignment.MiddleRight
                };

                Label lblValTong = TaoLblPhai($"{tongTien:N0} đ", CoffeeTheme.EspressoDark);
                Label lblValKhachDua = TaoLblPhai($"{tienKhachDua:N0} đ", CoffeeTheme.PrimaryBlue);
                Label lblValTienThoi = TaoLblPhai("0 đ", CoffeeTheme.SuccessGreen);

                tblSummary.Controls.Add(TaoLblTrai("Tổng thanh toán:"), 0, 0);
                tblSummary.Controls.Add(lblValTong, 1, 0);
                tblSummary.Controls.Add(TaoLblTrai("Tiền khách đưa:"), 0, 1);
                tblSummary.Controls.Add(lblValKhachDua, 1, 1);
                tblSummary.Controls.Add(TaoLblTrai("Tiền thừa trả khách:"), 0, 2);
                tblSummary.Controls.Add(lblValTienThoi, 1, 2);

                void CapNhatHienThiTien()
                {
                    lblValKhachDua.Text = $"{tienKhachDua:N0} đ  ";
                    decimal thoi = tienKhachDua - tongTien;
                    if (thoi >= 0)
                    {
                        lblValTienThoi.Text = $"{thoi:N0} đ  ";
                        lblValTienThoi.ForeColor = CoffeeTheme.SuccessGreen;
                    }
                    else
                    {
                        lblValTienThoi.Text = $"Thiếu {Math.Abs(thoi):N0} đ  ";
                        lblValTienThoi.ForeColor = CoffeeTheme.DangerRed;
                    }
                }

                TableLayoutPanel tblMenhGia = new TableLayoutPanel
                {
                    Location = new Point(20, 208),
                    Size = new Size(504, 54),
                    ColumnCount = 5,
                    RowCount = 1
                };
                for (int i = 0; i < 5; i++) tblMenhGia.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));

                var menhGias = new (string Nhan, decimal GiaTri)[]
                {
                    ("Đủ tiền", tongTien),
                    ("50.000", 50000),
                    ("100.000", 100000),
                    ("200.000", 200000),
                    ("500.000", 500000)
                };

                for (int i = 0; i < menhGias.Length; i++)
                {
                    var item = menhGias[i];
                    RoundedButton btnMG = new RoundedButton
                    {
                        Dock = DockStyle.Fill,
                        Text = item.Nhan,
                        Margin = new Padding(3),
                        BorderRadius = 10,
                        BackColor = (i == 0) ? CoffeeTheme.EspressoDark : Color.White,
                        ForeColor = (i == 0) ? Color.White : CoffeeTheme.EspressoDark,
                        BorderSize = 1,
                        BorderColor = CoffeeTheme.EspressoDark,
                        Font = new Font("Segoe UI", 9.5F, FontStyle.Bold)
                    };
                    btnMG.Click += (s, e) =>
                    {
                        tienKhachDua = item.GiaTri;
                        CapNhatHienThiTien();
                    };
                    tblMenhGia.Controls.Add(btnMG, i, 0);
                }

                TableLayoutPanel tblNumpad = new TableLayoutPanel
                {
                    Location = new Point(20, 270),
                    Size = new Size(504, 165),
                    ColumnCount = 4,
                    RowCount = 3
                };
                for (int c = 0; c < 4; c++) tblNumpad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                for (int r = 0; r < 3; r++) tblNumpad.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));

                string[] phimSo = { "1", "2", "3", "Xóa hết", "4", "5", "6", "Lùi 1 số", "7", "8", "9", "000" };
                for (int idx = 0; idx < phimSo.Length; idx++)
                {
                    string kyTu = phimSo[idx];
                    bool laNutChucNang = kyTu.Contains("Xóa") || kyTu.Contains("Lùi");
                    RoundedButton btnSo = new RoundedButton
                    {
                        Dock = DockStyle.Fill,
                        Text = kyTu,
                        Margin = new Padding(3),
                        BorderRadius = 10,
                        BackColor = laNutChucNang ? Color.FromArgb(239, 235, 233) : Color.White,
                        ForeColor = laNutChucNang ? CoffeeTheme.DangerRed : CoffeeTheme.EspressoDark,
                        BorderSize = 1,
                        BorderColor = Color.FromArgb(200, 195, 190),
                        Font = new Font("Segoe UI", 11F, FontStyle.Bold)
                    };

                    btnSo.Click += (s, e) =>
                    {
                        string chuoiHienTai = ((long)tienKhachDua).ToString();
                        if (kyTu == "Xóa hết") tienKhachDua = 0;
                        else if (kyTu == "Lùi 1 số")
                            tienKhachDua = chuoiHienTai.Length > 1 ? decimal.Parse(chuoiHienTai.Substring(0, chuoiHienTai.Length - 1)) : 0;
                        else
                        {
                            string chuoiMoi = (chuoiHienTai == "0" ? "" : chuoiHienTai) + kyTu;
                            if (chuoiMoi.Length <= 10 && decimal.TryParse(chuoiMoi, out decimal valMoi))
                                tienKhachDua = valMoi;
                        }
                        CapNhatHienThiTien();
                    };
                    tblNumpad.Controls.Add(btnSo, idx % 4, idx / 4);
                }

                RoundedButton btnChotKhongIn = new RoundedButton
                {
                    Text = "CHỐT ĐƠN (KHÔNG IN)",
                    Location = new Point(20, 448),
                    Size = new Size(215, 56),
                    BorderRadius = 12,
                    BackColor = CoffeeTheme.PrimaryBlue,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold)
                };

                RoundedButton btnChotVaIn = new RoundedButton
                {
                    Text = "  THANH TOÁN & IN PHIẾU",
                    Location = new Point(245, 448),
                    Size = new Size(279, 56),
                    BorderRadius = 12,
                    BackColor = CoffeeTheme.SuccessGreen,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10.5F, FontStyle.Bold),
                    Image = CoffeeIcons.Check(Color.White, 22),
                    TextImageRelation = TextImageRelation.ImageBeforeText
                };

                void XuLyChot(bool inPhieu)
                {
                    if (tienKhachDua < tongTien)
                    {
                        MessageBox.Show($"Tiền khách đưa còn thiếu {(tongTien - tienKhachDua):N0} VNĐ!", "Chưa đủ tiền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    xacNhan = true;
                    muonIn = inPhieu;
                    dlg.DialogResult = DialogResult.OK;
                    dlg.Close();
                }

                btnChotKhongIn.Click += (s, e) => XuLyChot(false);
                btnChotVaIn.Click += (s, e) => XuLyChot(true);

                dlg.Controls.AddRange(new Control[] { pnlTop, tblSummary, tblMenhGia, tblNumpad, btnChotKhongIn, btnChotVaIn });
                dlg.ShowDialog(this);
            }

            return (xacNhan, muonIn, tienKhachDua, Math.Max(0, tienKhachDua - tongTien));
        }

        private void MoHopThoaiChuyenGopBan()
        {
            if (idbdc == -1)
            {
                MessageBox.Show("Vui lòng chạm chọn bàn nguồn cần chuyển/gộp trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dtHDNguon = ketnoi.LayDuLieu(
                "SELECT ID FROM HoaDon WHERE IDb = @IDb AND TrangThai = N'Chưa thanh toán'",
                new[] { new SqlParameter("@IDb", idbdc) });

            if (dtHDNguon.Rows.Count == 0)
            {
                MessageBox.Show("Bàn đang chọn hiện trống, không có hóa đơn để chuyển hoặc gộp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable dtBanDich = ketnoi.LayDuLieu(
                "SELECT ID, TenBan + N' [' + TrangThai + N']' AS HienThi FROM Ban WHERE ID <> @IDb",
                new[] { new SqlParameter("@IDb", idbdc) });

            if (dtBanDich.Rows.Count == 0) return;

            using (Form dlg = new Form())
            {
                dlg.Text = "Chuyển bàn / Gộp bàn";
                dlg.Size = new Size(400, 225);
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.FormBorderStyle = FormBorderStyle.FixedDialog;
                dlg.MaximizeBox = false;
                dlg.MinimizeBox = false;
                dlg.BackColor = CoffeeTheme.CreamBg;

                Label lbl = new Label
                {
                    Text = $"Từ {lblTieuDeBanPOS.Text.Replace("ĐANG PHỤC VỤ: ", "")} chuyển / gộp sang:",
                    Location = new Point(22, 22),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                    ForeColor = CoffeeTheme.EspressoDark
                };

                ComboBox cbBanDich = new ComboBox
                {
                    Location = new Point(22, 58),
                    Width = 340,
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    Font = new Font("Segoe UI", 12F),
                    DisplayMember = "HienThi",
                    ValueMember = "ID",
                    DataSource = dtBanDich
                };

                RoundedButton btnXacNhan = new RoundedButton
                {
                    Text = "XÁC NHẬN",
                    Location = new Point(115, 114),
                    Size = new Size(150, 48),
                    BorderRadius = 12,
                    BackColor = CoffeeTheme.PrimaryBlue,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                    DialogResult = DialogResult.OK
                };

                dlg.Controls.AddRange(new Control[] { lbl, cbBanDich, btnXacNhan });
                if (dlg.ShowDialog(this) == DialogResult.OK && cbBanDich.SelectedValue != null)
                {
                    int idBanDich = Convert.ToInt32(cbBanDich.SelectedValue);
                    string tenBanDich = cbBanDich.Text.Split('[')[0].Trim();
                    ChuyenHoacGopBan(idbdc, idBanDich, tenBanDich);
                }
            }
        }

        private void ChuyenHoacGopBan(int idBanNguon, int idBanDich, string tenBanDich)
        {
            try
            {
                int idHDNguon = Convert.ToInt32(ketnoi.LayGiaTriDon(
                    "SELECT ID FROM HoaDon WHERE IDb = @IDb AND TrangThai = N'Chưa thanh toán'",
                    new[] { new SqlParameter("@IDb", idBanNguon) }));

                DataTable dtHDDich = ketnoi.LayDuLieu(
                    "SELECT ID FROM HoaDon WHERE IDb = @IDb AND TrangThai = N'Chưa thanh toán'",
                    new[] { new SqlParameter("@IDb", idBanDich) });

                if (dtHDDich.Rows.Count == 0)
                {
                    ketnoi.ThucThiLenh("UPDATE HoaDon SET IDb = @IDDich WHERE ID = @IDhd",
                        new[] { new SqlParameter("@IDDich", idBanDich), new SqlParameter("@IDhd", idHDNguon) });
                    ketnoi.ThucThiLenh("UPDATE Ban SET TrangThai = N'Trống' WHERE ID = @ID", new[] { new SqlParameter("@ID", idBanNguon) });
                    ketnoi.ThucThiLenh("UPDATE Ban SET TrangThai = N'Có người' WHERE ID = @ID", new[] { new SqlParameter("@ID", idBanDich) });

                    MessageBox.Show($"Đã chuyển sang {tenBanDich} thành công!", "Chuyển bàn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int idHDDich = Convert.ToInt32(dtHDDich.Rows[0]["ID"]);
                    DataTable dtMonNguon = ketnoi.LayDuLieu("SELECT IDm, SoLuong, DonGia FROM CTHD WHERE IDhd = @IDhd",
                        new[] { new SqlParameter("@IDhd", idHDNguon) });

                    foreach (DataRow row in dtMonNguon.Rows)
                    {
                        int idMon = Convert.ToInt32(row["IDm"]);
                        int soLuong = Convert.ToInt32(row["SoLuong"]);
                        decimal donGia = Convert.ToDecimal(row["DonGia"]);

                        DataTable dtTrung = ketnoi.LayDuLieu("SELECT IDhd FROM CTHD WHERE IDhd = @IDhd AND IDm = @IDm",
                            new[] { new SqlParameter("@IDhd", idHDDich), new SqlParameter("@IDm", idMon) });

                        if (dtTrung.Rows.Count > 0)
                        {
                            ketnoi.ThucThiLenh("UPDATE CTHD SET SoLuong = SoLuong + @SL WHERE IDhd = @IDhd AND IDm = @IDm",
                                new[] { new SqlParameter("@SL", soLuong), new SqlParameter("@IDhd", idHDDich), new SqlParameter("@IDm", idMon) });
                        }
                        else
                        {
                            ketnoi.ThucThiLenh("INSERT INTO CTHD (IDhd, IDm, SoLuong, DonGia) VALUES (@IDhd, @IDm, @SL, @DonGia)",
                                new[] { new SqlParameter("@IDhd", idHDDich), new SqlParameter("@IDm", idMon), new SqlParameter("@SL", soLuong), new SqlParameter("@DonGia", donGia) });
                        }
                    }

                    ketnoi.ThucThiLenh("DELETE FROM CTHD WHERE IDhd = @IDhd", new[] { new SqlParameter("@IDhd", idHDNguon) });
                    ketnoi.ThucThiLenh("DELETE FROM HoaDon WHERE ID = @IDhd", new[] { new SqlParameter("@IDhd", idHDNguon) });
                    ketnoi.ThucThiLenh("UPDATE Ban SET TrangThai = N'Trống' WHERE ID = @ID", new[] { new SqlParameter("@ID", idBanNguon) });
                    ketnoi.ThucThiLenh("UPDATE HoaDon SET TongTien = (SELECT ISNULL(SUM(ThanhTien), 0) FROM CTHD WHERE IDhd = @IDhd) WHERE ID = @IDhd",
                        new[] { new SqlParameter("@IDhd", idHDDich) });

                    MessageBox.Show($"Đã gộp hóa đơn vào {tenBanDich} thành công!", "Gộp bàn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                idbdc = idBanDich;
                lblTieuDeBanPOS.Text = $"ĐANG PHỤC VỤ: {tenBanDich.ToUpper()}";
                LoadDanhSachBan();
                HienThiHoaDon(idbdc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chuyển/gộp bàn: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InHoaDon(int idHD, string tenBan, DataTable dtChiTiet, decimal tongTien, decimal tienKhachDua, decimal tienThoi)
        {
            PrintDocument printDoc = new PrintDocument();
            int chieuCaoGiay = 390 + (dtChiTiet.Rows.Count * 28);
            printDoc.DefaultPageSettings.PaperSize = new PaperSize("BillK80", 320, chieuCaoGiay);

            printDoc.PrintPage += (s, ev) =>
            {
                Graphics g = ev.Graphics;
                Font fTieuDe = new Font("Segoe UI", 13, FontStyle.Bold);
                Font fSub = new Font("Segoe UI", 8.5f, FontStyle.Italic);
                Font fHoaDon = new Font("Segoe UI", 11, FontStyle.Bold);
                Font fThuong = new Font("Segoe UI", 8.5f, FontStyle.Regular);
                Font fDam = new Font("Segoe UI", 8.5f, FontStyle.Bold);
                Font fTong = new Font("Segoe UI", 10.5f, FontStyle.Bold);

                Brush brushNau = new SolidBrush(Color.FromArgb(62, 39, 35));
                Pen penNetDut = new Pen(Color.Gray, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };
                StringFormat canGiua = new StringFormat { Alignment = StringAlignment.Center };
                StringFormat canPhai = new StringFormat { Alignment = StringAlignment.Far };

                int y = 15, width = 320;
                g.DrawString("GÁC XÉP THÁNG TƯ", fTieuDe, brushNau, new RectangleF(0, y, width, 24), canGiua);
                y += 24;
                g.DrawString("Coffee & Tea - Ấm áp từng khoảnh khắc", fSub, Brushes.Black, new RectangleF(0, y, width, 18), canGiua);
                y += 22;
                g.DrawLine(penNetDut, 12, y, width - 12, y);
                y += 10;

                g.DrawString("PHIẾU THANH TOÁN", fHoaDon, Brushes.Black, new RectangleF(0, y, width, 22), canGiua);
                y += 26;
                g.DrawString($"Số HĐ: #{idHD}", fThuong, Brushes.Black, 14, y);
                g.DrawString($"Bàn: {tenBan}", fDam, Brushes.Black, width - 14, y, canPhai);
                y += 18;
                g.DrawString($"Ngày: {DateTime.Now:dd/MM/yyyy HH:mm}", fThuong, Brushes.Black, 14, y);
                g.DrawString($"NV: {TenNhanVien}", fThuong, Brushes.Black, width - 14, y, canPhai);
                y += 22;
                g.DrawLine(penNetDut, 12, y, width - 12, y);
                y += 8;

                g.DrawString("Tên món", fDam, Brushes.Black, 14, y);
                g.DrawString("SL", fDam, Brushes.Black, 185, y, canGiua);
                g.DrawString("Thành tiền", fDam, Brushes.Black, width - 14, y, canPhai);
                y += 20;
                g.DrawLine(penNetDut, 12, y, width - 12, y);
                y += 8;

                foreach (DataRow row in dtChiTiet.Rows)
                {
                    string tenMon = row["Tenmon"].ToString();
                    if (tenMon.Length > 21) tenMon = tenMon.Substring(0, 20) + "…";
                    g.DrawString(tenMon, fThuong, Brushes.Black, 14, y);
                    g.DrawString(row["SoLuong"].ToString(), fThuong, Brushes.Black, 185, y, canGiua);
                    g.DrawString(Convert.ToDecimal(row["ThanhTien"]).ToString("N0"), fThuong, Brushes.Black, width - 14, y, canPhai);
                    y += 22;
                }

                y += 4;
                g.DrawLine(penNetDut, 12, y, width - 12, y);
                y += 10;
                g.DrawString("TỔNG CỘNG:", fTong, brushNau, 14, y);
                g.DrawString($"{tongTien:N0} VNĐ", fTong, brushNau, width - 14, y, canPhai);
                y += 24;
                g.DrawString("Tiền khách đưa:", fThuong, Brushes.Black, 14, y);
                g.DrawString($"{tienKhachDua:N0} VNĐ", fThuong, Brushes.Black, width - 14, y, canPhai);
                y += 20;
                g.DrawString("Tiền thừa trả khách:", fDam, Brushes.Black, 14, y);
                g.DrawString($"{tienThoi:N0} VNĐ", fDam, Brushes.Black, width - 14, y, canPhai);
                y += 30;
                g.DrawString("Cảm ơn quý khách và hẹn gặp lại!", fSub, Brushes.Black, new RectangleF(0, y, width, 20), canGiua);
            };

            using (PrintPreviewDialog previewDlg = new PrintPreviewDialog())
            {
                previewDlg.Document = printDoc;
                previewDlg.Text = $"Xem trước Phiếu thanh toán #{idHD} - {tenBan}";
                previewDlg.Width = 520;
                previewDlg.Height = 680;
                previewDlg.StartPosition = FormStartPosition.CenterParent;
                previewDlg.ShowDialog(this);
            }
        }
    }

    public class CoffeeMenuRenderer : ToolStripProfessionalRenderer
    {
        public CoffeeMenuRenderer() : base(new CoffeeColorTable()) { }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            e.TextColor = e.Item.ForeColor;
            base.OnRenderItemText(e);
        }
    }

    public class CoffeeColorTable : ProfessionalColorTable
    {
        public override Color MenuItemSelected => Color.FromArgb(93, 64, 55);
        public override Color MenuItemSelectedGradientBegin => Color.FromArgb(93, 64, 55);
        public override Color MenuItemSelectedGradientEnd => Color.FromArgb(93, 64, 55);
        public override Color MenuItemBorder => Color.FromArgb(141, 110, 99);
        public override Color MenuItemPressedGradientBegin => Color.FromArgb(78, 52, 46);
        public override Color MenuItemPressedGradientEnd => Color.FromArgb(78, 52, 46);
    }
}