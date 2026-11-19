using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Coffee_Shop_Management
{
    public partial class TimKiemHD : Form
    {
        private bool locTatCa = false;

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);

        private const int EM_SETCUEBANNER = 0x1501;

        public TimKiemHD()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            DinhDangBang(dgvHoaDon);
            DinhDangBang(dgvChiTiet);
            GanSuKien();

            Load += (s, e) =>
            {
                SendMessage(txtTuKhoa.Handle, EM_SETCUEBANNER, (IntPtr)1, "Nhập số hóa đơn, bàn");
                ChonNutLocNhanh(btnHomNay);
                dtpTuNgay.Value = DateTime.Today;
                dtpDenNgay.Value = DateTime.Today;
                locTatCa = false;
                TaiDanhSachHoaDon();
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

        private void ChonNutLocNhanh(RoundedButton nutDangChon)
        {
            RoundedButton[] nhomNut = { btnHomNay, btn7Ngay, btnThangNay, btnTatCa };
            foreach (RoundedButton b in nhomNut)
            {
                bool active = (b == nutDangChon);
                b.BackColor = active ? CoffeeTheme.EspressoDark : CoffeeTheme.CreamBg;
                b.ForeColor = active ? Color.White : CoffeeTheme.EspressoDark;
                b.BorderSize = active ? 0 : 1;
            }

            bool tatCa = (nutDangChon == btnTatCa);
            dtpTuNgay.Enabled = !tatCa;
            dtpDenNgay.Enabled = !tatCa;
        }

        private void GanSuKien()
        {
            btnDong.Cursor = Cursors.Hand;
            btnDong.Click += (s, e) => this.Close();

            btnTimKiem.Image = CoffeeIcons.Search(Color.White, 18);
            btnTimKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTimKiem.Cursor = Cursors.Hand;

            btnHomNay.Click += (s, e) =>
            {
                ChonNutLocNhanh(btnHomNay);
                dtpTuNgay.Value = DateTime.Today;
                dtpDenNgay.Value = DateTime.Today;
                locTatCa = false;
                TaiDanhSachHoaDon();
            };

            btn7Ngay.Click += (s, e) =>
            {
                ChonNutLocNhanh(btn7Ngay);
                dtpTuNgay.Value = DateTime.Today.AddDays(-6);
                dtpDenNgay.Value = DateTime.Today;
                locTatCa = false;
                TaiDanhSachHoaDon();
            };

            btnThangNay.Click += (s, e) =>
            {
                ChonNutLocNhanh(btnThangNay);
                dtpTuNgay.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                dtpDenNgay.Value = DateTime.Today;
                locTatCa = false;
                TaiDanhSachHoaDon();
            };

            btnTatCa.Click += (s, e) =>
            {
                ChonNutLocNhanh(btnTatCa);
                locTatCa = true;
                TaiDanhSachHoaDon();
            };

            btnTimKiem.Click += (s, e) =>
            {
                TaiDanhSachHoaDon();
            };

            txtTuKhoa.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    TaiDanhSachHoaDon();
                }
            };

            dgvHoaDon.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0 && dgvHoaDon.CurrentRow != null)
                {
                    int idHD = Convert.ToInt32(dgvHoaDon.CurrentRow.Cells["ID"].Value);
                    string tenBan = dgvHoaDon.CurrentRow.Cells["TenBan"].Value?.ToString() ?? "";
                    TaiChiTietHoaDon(idHD, tenBan);
                }
            };
        }

        private void TaiDanhSachHoaDon()
        {
            try
            {
                List<SqlParameter> thamSo = new List<SqlParameter>();

                string sql = @"
                    SELECT hd.ID, b.TenBan, hd.TenNV, hd.Checkin, hd.Checkout, hd.TongTien, hd.TrangThai
                    FROM HoaDon hd
                    LEFT JOIN Ban b ON hd.IDb = b.ID
                    WHERE hd.TrangThai = @TT AND hd.TongTien > 0";
                thamSo.Add(new SqlParameter("@TT", "Đã thanh toán"));

                if (!locTatCa)
                {
                    DateTime tuNgay = dtpTuNgay.Value.Date;
                    DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1);
                    sql += " AND hd.Checkin >= @TuNgay AND hd.Checkin < @DenNgay";
                    thamSo.Add(new SqlParameter("@TuNgay", tuNgay));
                    thamSo.Add(new SqlParameter("@DenNgay", denNgay));
                }

                string tuKhoa = txtTuKhoa.Text.Trim();
                if (!string.IsNullOrEmpty(tuKhoa))
                {
                    sql += " AND (CAST(hd.ID AS NVARCHAR(20)) LIKE @KW OR b.TenBan LIKE @KW OR hd.TenNV LIKE @KW)";
                    thamSo.Add(new SqlParameter("@KW", "%" + tuKhoa + "%"));
                }

                sql += " ORDER BY hd.ID ASC";

                DataTable dt = ketnoi.LayDuLieu(sql, thamSo.ToArray());
                dgvHoaDon.DataSource = dt;
                dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dgvHoaDon.Columns.Contains("ID"))
                {
                    dgvHoaDon.Columns["ID"].HeaderText = "Số HĐ";
                    dgvHoaDon.Columns["ID"].FillWeight = 8;
                }
                if (dgvHoaDon.Columns.Contains("TenBan"))
                {
                    dgvHoaDon.Columns["TenBan"].HeaderText = "Bàn";
                    dgvHoaDon.Columns["TenBan"].FillWeight = 12;
                }
                if (dgvHoaDon.Columns.Contains("TenNV"))
                {
                    dgvHoaDon.Columns["TenNV"].HeaderText = "Thu ngân";
                    dgvHoaDon.Columns["TenNV"].FillWeight = 14;
                }
                if (dgvHoaDon.Columns.Contains("Checkin"))
                {
                    dgvHoaDon.Columns["Checkin"].HeaderText = "Giờ vào";
                    dgvHoaDon.Columns["Checkin"].DefaultCellStyle.Format = "dd/MM/yy HH:mm";
                    dgvHoaDon.Columns["Checkin"].FillWeight = 20;
                }
                if (dgvHoaDon.Columns.Contains("Checkout"))
                {
                    dgvHoaDon.Columns["Checkout"].HeaderText = "Giờ thanh toán";
                    dgvHoaDon.Columns["Checkout"].DefaultCellStyle.Format = "dd/MM/yy HH:mm";
                    dgvHoaDon.Columns["Checkout"].FillWeight = 20;
                }
                if (dgvHoaDon.Columns.Contains("TongTien"))
                {
                    dgvHoaDon.Columns["TongTien"].HeaderText = "Tổng tiền";
                    dgvHoaDon.Columns["TongTien"].DefaultCellStyle.Format = "N0";
                    dgvHoaDon.Columns["TongTien"].FillWeight = 14;
                }
                if (dgvHoaDon.Columns.Contains("TrangThai"))
                {
                    dgvHoaDon.Columns["TrangThai"].HeaderText = "Trạng thái";
                    dgvHoaDon.Columns["TrangThai"].FillWeight = 16;
                }

                decimal tongDoanhThu = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (row["TrangThai"].ToString() == "Đã thanh toán")
                    {
                        tongDoanhThu += Convert.ToDecimal(row["TongTien"]);
                    }
                }

                lblSoLuongHD.Text = $"Tổng số hóa đơn: {dt.Rows.Count}";
                lblTongDoanhThu.Text = $"TỔNG DOANH THU: {tongDoanhThu:N0} VNĐ";

                if (dt.Rows.Count > 0)
                {
                    int idDau = Convert.ToInt32(dt.Rows[0]["ID"]);
                    string banDau = dt.Rows[0]["TenBan"]?.ToString() ?? "";
                    TaiChiTietHoaDon(idDau, banDau);
                }
                else
                {
                    dgvChiTiet.DataSource = null;
                    lblThongTinHD.Text = "Không có dữ liệu hóa đơn";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tra cứu hóa đơn: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TaiChiTietHoaDon(int idHD, string tenBan)
        {
            try
            {
                lblThongTinHD.Text = $"HÓA ĐƠN #{idHD}  -  {tenBan.ToUpper()}";
                string sql = @"
                    SELECT m.Tenmon, ct.SoLuong, ct.DonGia, ct.ThanhTien
                    FROM CTHD ct
                    JOIN Menu m ON ct.IDm = m.ID
                    WHERE ct.IDhd = @IDhd";

                DataTable dt = ketnoi.LayDuLieu(sql, new[] { new SqlParameter("@IDhd", idHD) });
                dgvChiTiet.DataSource = dt;

                dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dgvChiTiet.Columns.Contains("Tenmon"))
                {
                    dgvChiTiet.Columns["Tenmon"].HeaderText = "Tên món";
                    dgvChiTiet.Columns["Tenmon"].FillWeight = 50;
                }
                if (dgvChiTiet.Columns.Contains("SoLuong"))
                {
                    dgvChiTiet.Columns["SoLuong"].HeaderText = "SL";
                    dgvChiTiet.Columns["SoLuong"].FillWeight = 10;
                }
                if (dgvChiTiet.Columns.Contains("DonGia"))
                {
                    dgvChiTiet.Columns["DonGia"].HeaderText = "Đơn giá";
                    dgvChiTiet.Columns["DonGia"].DefaultCellStyle.Format = "N0";
                    dgvChiTiet.Columns["DonGia"].FillWeight = 20;
                }
                if (dgvChiTiet.Columns.Contains("ThanhTien"))
                {
                    dgvChiTiet.Columns["ThanhTien"].HeaderText = "Thành tiền";
                    dgvChiTiet.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
                    dgvChiTiet.Columns["ThanhTien"].FillWeight = 20;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải chi tiết hóa đơn: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}