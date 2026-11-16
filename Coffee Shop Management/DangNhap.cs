using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Coffee_Shop_Management
{
    public partial class DangNhap : Form
    {
        private readonly string strKetNoi = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=CoffeeShopManagement;Integrated Security=True";

        public DangNhap()
        {
            InitializeComponent();

            dn.Click += dn_Click;
            bt.Click += bt_Click;
            htmk.CheckedChanged += htmk_CheckedChanged;
        }

        private void htmk_CheckedChanged(object sender, EventArgs e)
        {
            mk.UseSystemPasswordChar = !htmk.Checked;
        }

        private void dn_Click(object sender, EventArgs e)
        {
            string tenTK = tk.Text.Trim();
            string matKhau = mk.Text;

            if (string.IsNullOrEmpty(tenTK) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tk.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(strKetNoi))
                {
                    conn.Open();
                    string query = "SELECT TenTK, Quyen FROM TaiKhoan WHERE TenTK = @TenTK AND MK = @MK";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TenTK", tenTK);
                    cmd.Parameters.AddWithValue("@MK", matKhau);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        string tkdung = dt.Rows[0]["TenTK"].ToString();
                        string quyen = dt.Rows[0]["Quyen"].ToString();

                        BanHang frmBanHang = new BanHang(tkdung);
                        this.Hide();
                        frmBanHang.ShowDialog();

                        mk.Clear();
                        this.Show();
                        tk.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        mk.Clear();
                        mk.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}