using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Coffee_Shop_Management
{
    public partial class DangNhap : Form
    {
        private string taiKhoanDangChon = "";
        private string quyenDangChon = "";
        private string matKhauNhap = "";
        private int idPhienDangNhap = 0;

        public DangNhap(string quyenMacDinh = "")
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            GanSuKienBanPhimTouch();
            Load += (s, e) => LoadDanhSachTaiKhoan(quyenMacDinh);
            FormClosing += (s, e) => CapNhatCheckOut();
        }

        private void GanSuKienBanPhimTouch()
        {
            RoundedButton[] nutSo = { btnSo0, btnSo1, btnSo2, btnSo3, btnSo4, btnSo5, btnSo6, btnSo7, btnSo8, btnSo9 };
            foreach (RoundedButton btn in nutSo)
            {
                btn.Cursor = Cursors.Hand;
                btn.Click += (s, e) =>
                {
                    if (matKhauNhap.Length < 16)
                    {
                        matKhauNhap += btn.Text;
                        CapNhatOPIN();
                    }
                };
            }

            btnXoaHet.Cursor = Cursors.Hand;
            btnXoaHet.Click += (s, e) =>
            {
                matKhauNhap = "";
                CapNhatOPIN();
            };

            btnLui.Cursor = Cursors.Hand;
            btnLui.Click += (s, e) =>
            {
                if (matKhauNhap.Length > 0)
                {
                    matKhauNhap = matKhauNhap.Substring(0, matKhauNhap.Length - 1);
                    CapNhatOPIN();
                }
            };

            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Click += (s, e) => this.Close();

            btnVaoCa.Text = "ĐĂNG NHẬP";
            btnVaoCa.Cursor = Cursors.Hand;
            btnVaoCa.Click += (s, e) => XuLyDangNhap();
        }

        private void CapNhatOPIN()
        {
            if (string.IsNullOrEmpty(matKhauNhap))
            {
                lblHienThiPIN.Text = "Nhập mật khẩu";
                lblHienThiPIN.ForeColor = Color.Gray;
            }
            else
            {
                lblHienThiPIN.Text = new string('●', matKhauNhap.Length);
                lblHienThiPIN.ForeColor = CoffeeTheme.EspressoDark;
            }
        }

        private void LoadDanhSachTaiKhoan(string quyenMacDinh = "")
        {
            try
            {
                flpNhanVien.Controls.Clear();
                DataTable dt = ketnoi.LayDuLieu("SELECT TenTK, Quyen FROM TaiKhoan");

                foreach (DataRow row in dt.Rows)
                {
                    string tenTK = row["TenTK"].ToString();
                    string quyen = row["Quyen"].ToString();
                    bool isAdmin = quyen.Equals("Admin", StringComparison.OrdinalIgnoreCase);
                    bool dangChon = tenTK.Equals(taiKhoanDangChon, StringComparison.OrdinalIgnoreCase);

                    RoundedButton cardNV = new RoundedButton
                    {
                        Width = 195,
                        Height = 96,
                        Margin = new Padding(6),
                        BorderRadius = 14,
                        BorderSize = dangChon ? 3 : 1,
                        BorderColor = dangChon ? CoffeeTheme.EspressoDark : (isAdmin ? CoffeeTheme.PeachBorder : CoffeeTheme.MintBorder),
                        BackColor = dangChon ? CoffeeTheme.EspressoDark : (isAdmin ? CoffeeTheme.PeachBusy : CoffeeTheme.MintEmpty),
                        ForeColor = dangChon ? Color.White : CoffeeTheme.EspressoDark,
                        Font = new Font("Segoe UI", 10.5F, FontStyle.Bold),
                        Text = $"{tenTK}\n[{quyen}]",
                        Cursor = Cursors.Hand
                    };

                    cardNV.Click += (s, e) =>
                    {
                        taiKhoanDangChon = tenTK;
                        quyenDangChon = quyen;
                        matKhauNhap = "";
                        lblTaiKhoanChon.Text = $"Tài khoản: {tenTK} ({quyen})";
                        CapNhatOPIN();
                        LoadDanhSachTaiKhoan();
                    };

                    flpNhanVien.Controls.Add(cardNV);
                }

                if (string.IsNullOrEmpty(taiKhoanDangChon) && dt.Rows.Count > 0)
                {
                    DataRow chonRow = dt.Rows[0];
                    if (!string.IsNullOrEmpty(quyenMacDinh))
                    {
                        foreach (DataRow r in dt.Rows)
                        {
                            if (r["Quyen"].ToString().Equals(quyenMacDinh, StringComparison.OrdinalIgnoreCase))
                            {
                                chonRow = r;
                                break;
                            }
                        }
                    }

                    taiKhoanDangChon = chonRow["TenTK"].ToString();
                    quyenDangChon = chonRow["Quyen"].ToString();
                    lblTaiKhoanChon.Text = $"Tài khoản: {taiKhoanDangChon} ({quyenDangChon})";
                    LoadDanhSachTaiKhoan();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách tài khoản: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CapNhatCheckOut()
        {
            if (idPhienDangNhap > 0)
            {
                try
                {
                    ketnoi.ThucThiLenh(
                        "UPDATE LichSuDN SET Checkout = GETDATE(), TrangThai = N'Đã đăng xuất' WHERE ID = @ID AND Checkout IS NULL",
                        new[] { new SqlParameter("@ID", idPhienDangNhap) });
                }
                catch { }
                idPhienDangNhap = 0;
            }
        }

        private void XuLyDangNhap()
        {
            if (string.IsNullOrEmpty(taiKhoanDangChon))
            {
                MessageBox.Show("Vui lòng chạm chọn tài khoản nhân viên trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(matKhauNhap))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu bằng bàn phím số bên phải!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = ketnoi.LayDuLieu(
                    "SELECT TenTK, Quyen FROM TaiKhoan WHERE TenTK = @TenTK AND MK = @MK",
                    new[] { new SqlParameter("@TenTK", taiKhoanDangChon), new SqlParameter("@MK", matKhauNhap) });

                if (dt.Rows.Count > 0)
                {
                    string ten = dt.Rows[0]["TenTK"].ToString();
                    string quyen = dt.Rows[0]["Quyen"].ToString();

                    object idLogObj = ketnoi.LayGiaTriDon(
                        "INSERT INTO LichSuDN (TenTK, Quyen, Checkin, TrangThai) OUTPUT INSERTED.ID VALUES (@TenTK, @Quyen, GETDATE(), N'Đang đăng nhập')",
                        new[] { new SqlParameter("@TenTK", ten), new SqlParameter("@Quyen", quyen) });
                    idPhienDangNhap = Convert.ToInt32(idLogObj);

                    this.Hide();
                    BanHang frmPOS = new BanHang(ten, quyen);
                    frmPOS.FormClosed += (s, e) => CapNhatCheckOut();
                    frmPOS.ShowDialog();

                    CapNhatCheckOut();
                    matKhauNhap = "";
                    CapNhatOPIN();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu đăng nhập, vui lòng thử lại!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    matKhauNhap = "";
                    CapNhatOPIN();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng nhập: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}