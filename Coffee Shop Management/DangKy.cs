using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Coffee_Shop_Management
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            if (cbQuyen.Items.Count > 0) cbQuyen.SelectedIndex = 0;

            btnDangKy.Text = "ĐĂNG KÝ";
            btnDangKy.Cursor = Cursors.Hand;

            btnQuayLai.Text = "QUAY LẠI";
            btnQuayLai.Cursor = Cursors.Hand;

            chkHienMK.CheckedChanged += (s, e) =>
            {
                bool hien = chkHienMK.Checked;
                txtMatKhau.UseSystemPasswordChar = !hien;
                txtXacNhanMK.UseSystemPasswordChar = !hien;
            };

            btnDangKy.Click += (s, e) => XuLyDangKy();
            btnQuayLai.Click += (s, e) => this.Close();
        }

        private void XuLyDangKy()
        {
            string tenTK = txtTenTK.Text.Trim();
            string mk = txtMatKhau.Text.Trim();
            string xacNhan = txtXacNhanMK.Text.Trim();
            string quyen = cbQuyen.Text;

            if (string.IsNullOrEmpty(tenTK) || string.IsNullOrEmpty(mk))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên tài khoản và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (mk != xacNhan)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtXacNhanMK.Focus();
                return;
            }

            try
            {
                int tonTai = Convert.ToInt32(ketnoi.LayGiaTriDon(
                    "SELECT COUNT(*) FROM TaiKhoan WHERE TenTK = @TenTK",
                    new[] { new SqlParameter("@TenTK", tenTK) }));

                if (tonTai > 0)
                {
                    MessageBox.Show("Tên tài khoản này đã tồn tại, vui lòng chọn tên khác!", "Trùng tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenTK.Focus();
                    return;
                }

                ketnoi.ThucThiLenh(
                    "INSERT INTO TaiKhoan (TenTK, MK, Quyen) VALUES (@TenTK, @MK, @Quyen)",
                    new[]
                    {
                        new SqlParameter("@TenTK", tenTK),
                        new SqlParameter("@MK", mk),
                        new SqlParameter("@Quyen", quyen)
                    });

                MessageBox.Show("Đăng ký tài khoản thành công! Bạn có thể đăng nhập ngay bây giờ.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng ký tài khoản: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}