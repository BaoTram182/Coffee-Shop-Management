using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Coffee_Shop_Management
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();

            q.SelectedIndex = 0;

            htmk.CheckedChanged += (s, e) =>
            {
                bool hien = htmk.Checked;
                mk.UseSystemPasswordChar = !hien;
                xnmk.UseSystemPasswordChar = !hien;
            };

            dk.Click += dk_Click;
            bh.Click += (s, e) => this.Close();
        }

        private void dk_Click(object sender, EventArgs e)
        {
            string TenTK = tentk.Text.Trim();
            string MatKhau = mk.Text;
            string XacNhan = xnmk.Text;
            string Quyen = q.SelectedItem?.ToString() ?? "Nhân viên";

            if (string.IsNullOrEmpty(TenTK) || string.IsNullOrEmpty(MatKhau) || string.IsNullOrEmpty(XacNhan))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản và mật khẩu!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tentk.Focus();
                return;
            }

            if (TenTK.Contains(" "))
            {
                MessageBox.Show("Tên đăng nhập không được chứa khoảng trắng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tentk.Focus();
                return;
            }

            if (MatKhau != XacNhan)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                xnmk.Clear();
                xnmk.Focus();
                return;
            }

            try
            {
                // 2. Kiểm tra tên tài khoản đã tồn tại trong dbo.TaiKhoan chưa
                DataTable dtCheck = ketnoi.LayDuLieu(
                    "SELECT TenTK FROM TaiKhoan WHERE TenTK = @TenTK",
                    new[] { new SqlParameter("@TenTK", TenTK) });

                if (dtCheck.Rows.Count > 0)
                {
                    MessageBox.Show($"Tên tài khoản '{TenTK}' đã tồn tại! Vui lòng chọn tên khác.", "Trùng tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tentk.SelectAll();
                    tentk.Focus();
                    return;
                }

                int kq = ketnoi.ThucThiLenh(
                    "INSERT INTO TaiKhoan (TenTK, MK, Quyen) VALUES (@TenTK, @MK, @Quyen)",
                    new[] {
                        new SqlParameter("@TenTK", TenTK),
                        new SqlParameter("@MK", MatKhau),
                        new SqlParameter("@Quyen", Quyen)
                    });

                if (kq > 0)
                {
                    MessageBox.Show($"Đã tạo thành công tài khoản '{TenTK}' với quyền [{Quyen}]!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tentk.Clear();
                    mk.Clear();
                    xnmk.Clear();
                    q.SelectedIndex = 0;
                    tentk.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}