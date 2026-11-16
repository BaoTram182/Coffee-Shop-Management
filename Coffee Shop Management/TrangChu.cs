using System;
using System.Drawing;
using System.Windows.Forms;

namespace Coffee_Shop_Management
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
            TrangTriGiaoDien();

            modn.Click += (s, e) =>
            {
                DangNhap frmDangNhap = new DangNhap();
                this.Hide();
                frmDangNhap.ShowDialog();
                if (!this.IsDisposed) this.Show();
            };

            modk.Click += (s, e) =>
            {
                DangKy frmDangKy = new DangKy();
                this.Hide();
                frmDangKy.ShowDialog();
                if (!this.IsDisposed) this.Show();
            };

            bt.Click += (s, e) =>
            {
                if (MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            };
        }

        private void TrangTriGiaoDien()
        {
            this.BackColor = CoffeeTheme.CreamBg;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            PictureBox picLogo = new PictureBox
            {
                Size = new Size(48, 48),
                Location = new Point(22, 18),
                BackColor = Color.Transparent,
                Image = CoffeeIcons.CoffeeCup(CoffeeTheme.EspressoDark, 44)
            };
            this.Controls.Add(picLogo);

            UIHelper.StyleFlatRoundedButton(modn, CoffeeTheme.EspressoDark, Color.FromArgb(93, 64, 55), Color.White);
            UIHelper.StyleFlatRoundedButton(modk, CoffeeTheme.SuccessGreen, Color.FromArgb(67, 160, 71), Color.White);
            UIHelper.StyleFlatRoundedButton(bt, Color.FromArgb(224, 220, 215), Color.FromArgb(200, 195, 190), Color.FromArgb(60, 60, 60));
        }
    }
}