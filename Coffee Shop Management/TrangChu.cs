using System;
using System.Windows.Forms;

namespace Coffee_Shop_Management
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();

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
    }
}