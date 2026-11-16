using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Coffee_Shop_Management
{
    public partial class TimKiemHoaDon : Form
    {
        public TimKiemHoaDon()
        {
            InitializeComponent();
            cbTrangThai.SelectedIndex = 0;

            chkLocNgay.CheckedChanged += (s, e) =>
            {
                dtpTuNgay.Enabled = chkLocNgay.Checked;
                dtpDenNgay.Enabled = chkLocNgay.Checked;
            };

            btim.Click += (s, e) => TimKiem();
            tbtk.TextChanged += (s, e) => TimKiem();
            cbTrangThai.SelectedIndexChanged += (s, e) => TimKiem();
            dgvHoaDon.CellClick += dgvHoaDon_CellClick;

            Load += (s, e) => TimKiem();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int idHD = Convert.ToInt32(dgvHoaDon.Rows[e.RowIndex].Cells["Mã HĐ"].Value);

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