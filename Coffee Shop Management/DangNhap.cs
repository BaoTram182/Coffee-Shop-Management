using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Coffee_Shop_Management
{
    public partial class DangNhap : Form
    {
        public DangNhap(string tenTKMacDinh = "")
        {
            InitializeComponent();
            TrangTriGiaoDien();

            if (!string.IsNullOrEmpty(tenTKMacDinh))
            {
                tentk.Text = tenTKMacDinh;
                this.Shown += (s, e) => mk.Focus();
            }

            htmk.CheckedChanged += (s, e) =>
            {
                mk.UseSystemPasswordChar = !htmk.Checked;
            };

            dn.Click += dn_Click;
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

            UIHelper.StyleFlatRoundedButton(dn, CoffeeTheme.EspressoDark, Color.FromArgb(93, 64, 55), Color.White);
            UIHelper.StyleFlatRoundedButton(bt, Color.FromArgb(224, 220, 215), Color.FromArgb(200, 195, 190), Color.FromArgb(60, 60, 60));
        }

        private void dn_Click(object sender, EventArgs e)
        {
            string tenTK = tentk.Text.Trim();
            string matKhau = mk.Text.Trim();

            if (string.IsNullOrEmpty(tenTK) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên tài khoản và Mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = ketnoi.LayDuLieu(
                    "SELECT * FROM TaiKhoan WHERE TenTK = @TenTK AND MK = @MK",
                    new[] {
                        new SqlParameter("@TenTK", tenTK),
                        new SqlParameter("@MK", matKhau)
                    });

                if (dt.Rows.Count > 0)
                {
                    string quyen = dt.Columns.Contains("Quyen") && dt.Rows[0]["Quyen"] != DBNull.Value
                        ? dt.Rows[0]["Quyen"].ToString()
                        : "Nhân viên";

                    BanHang frmBanHang = new BanHang(tenTK, quyen);
                    this.Hide();
                    frmBanHang.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mk.Clear();
                    mk.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}