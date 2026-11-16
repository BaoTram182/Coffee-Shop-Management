using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Coffee_Shop_Management
{
    public partial class TimKiemHD : Form
    {
        public TimKiemHD()
        {
            InitializeComponent();
            UIHelper.StyleDataGridView(dgvHoaDon);
            UIHelper.StyleDataGridView(dgvChiTiet);
            this.BackColor = CoffeeTheme.CreamBg;

            cbTrangThai.SelectedIndex = 0;

            // Lọc realtime ngay khi gõ từ khóa, đổi trạng thái hoặc đổi ngày
            tbtk.TextChanged += (s, e) => TimKiem();
            cbTrangThai.SelectedIndexChanged += (s, e) => TimKiem();
            dtpTuNgay.ValueChanged += (s, e) => { if (chkLocNgay.Checked) TimKiem(); };
            dtpDenNgay.ValueChanged += (s, e) => { if (chkLocNgay.Checked) TimKiem(); };

            chkLocNgay.CheckedChanged += (s, e) =>
            {
                dtpTuNgay.Enabled = chkLocNgay.Checked;
                dtpDenNgay.Enabled = chkLocNgay.Checked;
                TimKiem();
            };

            // Lọc nhanh 1 chạm hóa đơn trong ngày hôm nay
            btnHomNay.Click += (s, e) =>
            {
                chkLocNgay.Checked = true;
                dtpTuNgay.Value = DateTime.Today;
                dtpDenNgay.Value = DateTime.Today;
                TimKiem();
            };

            // Xóa toàn bộ bộ lọc về mặc định
            btnLamMoi.Click += (s, e) =>
            {
                tbtk.Clear();
                cbTrangThai.SelectedIndex = 0;
                chkLocNgay.Checked = false;
                TimKiem();
                tbtk.Focus();
            };

            // Tự động hiển thị chi tiết món của dòng đang chọn
            dgvHoaDon.SelectionChanged += (s, e) =>
            {
                if (dgvHoaDon.CurrentRow == null)
                {
                    dgvChiTiet.DataSource = null;
                    return;
                }
                if (int.TryParse(dgvHoaDon.CurrentRow.Cells["Mã HĐ"].Value?.ToString(), out int idHD))
                {
                    HienThiChiTiet(idHD);
                }
            };

            Load += (s, e) =>
            {
                TimKiem();
                tbtk.Focus();
            };
        }

        private void TimKiem()
        {
            try
            {
                string tukhoa = tbtk.Text.Trim();
                string trangThai = cbTrangThai.SelectedItem?.ToString() ?? "Tất cả";

                string query = @"
                    SELECT hd.ID AS [Mã HĐ],
                           b.TenBan AS [Tên bàn],
                           hd.TenNV AS [Nhân viên],
                           hd.Checkin AS [Giờ vào],
                           hd.Checkout AS [Giờ ra],
                           hd.TongTien AS [Tổng tiền],
                           hd.TrangThai AS [Trạng thái]
                    FROM HoaDon hd
                    LEFT JOIN Ban b ON hd.IDb = b.ID
                    WHERE 1 = 1";

                List<SqlParameter> p = new List<SqlParameter>();

                if (!string.IsNullOrEmpty(tukhoa))
                {
                    query += @" AND (CAST(hd.ID AS NVARCHAR) LIKE @TK 
                                  OR b.TenBan LIKE @TK 
                                  OR hd.TenNV LIKE @TK)";
                    p.Add(new SqlParameter("@TK", "%" + tukhoa + "%"));
                }

                if (trangThai != "Tất cả")
                {
                    query += " AND hd.TrangThai = @TrangThai";
                    p.Add(new SqlParameter("@TrangThai", trangThai));
                }

                if (chkLocNgay.Checked)
                {
                    query += " AND CAST(hd.Checkin AS DATE) BETWEEN @TuNgay AND @DenNgay";
                    p.Add(new SqlParameter("@TuNgay", dtpTuNgay.Value.Date));
                    p.Add(new SqlParameter("@DenNgay", dtpDenNgay.Value.Date));
                }

                query += " ORDER BY hd.ID DESC";

                DataTable dt = ketnoi.LayDuLieu(query, p.ToArray());
                dgvHoaDon.DataSource = dt;

                if (dgvHoaDon.Columns["Tổng tiền"] != null)
                    dgvHoaDon.Columns["Tổng tiền"].DefaultCellStyle.Format = "N0";

                decimal tongDoanhThu = 0;
                foreach (DataRow r in dt.Rows)
                {
                    if (r["Tổng tiền"] != DBNull.Value)
                        tongDoanhThu += Convert.ToDecimal(r["Tổng tiền"]);
                }
                lblThongKe.Text = $"Tìm thấy: {dt.Rows.Count} hóa đơn  |  Tổng cộng: {tongDoanhThu:N0} VNĐ";

                if (dt.Rows.Count == 0)
                    dgvChiTiet.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiChiTiet(int idHD)
        {
            string queryCT = @"
                SELECT m.Tenmon AS [Tên món],
                       ct.SoLuong AS [Số lượng],
                       ct.DonGia AS [Đơn giá],
                       ct.ThanhTien AS [Thành tiền]
                FROM CTHD ct
                JOIN Menu m ON ct.IDm = m.ID
                WHERE ct.IDhd = @IDhd";

            DataTable dtCT = ketnoi.LayDuLieu(queryCT, new[] { new SqlParameter("@IDhd", idHD) });
            dgvChiTiet.DataSource = dtCT;

            if (dgvChiTiet.Columns["Đơn giá"] != null)
                dgvChiTiet.Columns["Đơn giá"].DefaultCellStyle.Format = "N0";
            if (dgvChiTiet.Columns["Thành tiền"] != null)
                dgvChiTiet.Columns["Thành tiền"].DefaultCellStyle.Format = "N0";
        }
    }
}