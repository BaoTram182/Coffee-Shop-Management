using System;
using System.Windows.Forms;

namespace Coffee_Shop_Management
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            btnDangNhap.Text = "ĐĂNG NHẬP";
            btnDangNhap.Cursor = Cursors.Hand;

            btnDangKy.Text = "ĐĂNG KÝ";
            btnDangKy.Cursor = Cursors.Hand;

            btnThoat.Text = "THOÁT";
            btnThoat.Cursor = Cursors.Hand;

            Load += (s, e) =>
            {
                UIHelper.RoundControl(pnlCard, 18);
                UIHelper.RoundControl(btnDangNhap, 14);
                UIHelper.RoundControl(btnDangKy, 14);
                UIHelper.RoundControl(btnThoat, 14);
            };

            btnDangNhap.Click += (s, e) =>
            {
                this.Hide();
                DangNhap frmDN = new DangNhap();
                frmDN.ShowDialog();
                this.Show();
            };

            btnDangKy.Click += (s, e) =>
            {
                this.Hide();
                DangKy frmDK = new DangKy();
                frmDK.ShowDialog();
                this.Show();
            };

            btnThoat.Click += (s, e) => Application.Exit();
        }
    }
}