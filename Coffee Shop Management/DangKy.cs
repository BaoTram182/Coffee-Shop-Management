using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Coffee_Shop_Management
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
            TrangTriGiaoDien();
            quyen.SelectedIndex = 0; // Mặc định chọn "Nhân viên"

            htmk.CheckedChanged += (s, e) =>
            {
                mk.UseSystemPasswordChar = !htmk.Checked;
                nlmk.UseSystemPasswordChar = !htmk.Checked;
            };

            dk.Click += dk_Click;
            bt.Click += (s, e) => this.Close();
        }

        private void TrangTriGiaoDien()
        {
            this.BackColor = CoffeeTheme.CreamBg;

            PictureBox picLogo = new PictureBox
            {
                Size = new Size(36, 36),
                Location = new Point(20, 28),
                BackColor = Color.FromArgb(62, 39, 35),
                Image = CoffeeIcons.CoffeeCup(Color.FromArgb(255, 224, 130), 34)
            };
            this.Controls.Add(picLogo);
            picLogo.BringToFront();

            UIHelper.StyleFlatRoundedButton(dk, CoffeeTheme.SuccessGreen, Color.FromArgb(67, 160, 71), Color.White);
            UIHelper.StyleFlatRoundedButton(bt, Color.FromArgb(224, 220, 215), Color.FromArgb(200, 195, 190), Color.FromArgb(60, 60, 60));
        }

        private void dk_Click(object sender, EventArgs e)
        {
            string tenTK = tentk.Text.Trim();
            string matKhau = mk.Text.Trim();
            string xacNhanMK = nlmk.Text.Trim();
            string quyenChon = quyen.SelectedItem?.ToString() ?? "Nhân viên";

            if (string.IsNullOrEmpty(tenTK) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(xacNhanMK))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (matKhau != xacNhanMK)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nlmk.Focus();
                return;
            }

            try
            {
                DataTable dtCheck = ketnoi.LayDuLieu(
                    "SELECT * FROM TaiKhoan WHERE TenTK = @TenTK",
                    new[] { new SqlParameter("@TenTK", tenTK) });

                if (dtCheck.Rows.Count > 0)
                {
                    MessageBox.Show("Tên tài khoản này đã tồn tại, vui lòng chọn tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tentk.Focus();
                    return;
                }

                ketnoi.ThucThiLenh(
                    "INSERT INTO TaiKhoan (TenTK, MK, Quyen) VALUES (@TenTK, @MK, @Quyen)",
                    new[] {
                        new SqlParameter("@TenTK", tenTK),
                        new SqlParameter("@MK", matKhau),
                        new SqlParameter("@Quyen", quyenChon)
                    });

                MessageBox.Show($"Đăng ký tài khoản '{tenTK}' ({quyenChon}) thành công!", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng ký: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}