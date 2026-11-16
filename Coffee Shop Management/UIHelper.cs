using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Coffee_Shop_Management
{
    // 1. Bảng màu chủ đạo Quán Cà Phê
    public static class CoffeeTheme
    {
        public static readonly Color EspressoDark = Color.FromArgb(62, 39, 35);     // Nâu đậm header
        public static readonly Color CoffeeMedium = Color.FromArgb(109, 76, 65);    // Nâu vừa
        public static readonly Color CreamBg = Color.FromArgb(250, 247, 242);       // Nền kem ấm
        public static readonly Color CardBg = Color.White;                          // Nền thẻ trắng
        public static readonly Color LatteAccent = Color.FromArgb(215, 204, 200);   // Viền / Hover nhạt
        public static readonly Color MintEmpty = Color.FromArgb(232, 245, 233);     // Bàn trống (Xanh lá nhạt)
        public static readonly Color MintBorder = Color.FromArgb(129, 199, 132);
        public static readonly Color PeachBusy = Color.FromArgb(255, 224, 178);     // Bàn có khách (Cam đào ấm)
        public static readonly Color PeachBorder = Color.FromArgb(255, 167, 38);
        public static readonly Color SuccessGreen = Color.FromArgb(46, 125, 50);    // Nút Thanh toán / Đăng ký
        public static readonly Color PrimaryBlue = Color.FromArgb(25, 118, 210);    // Nút Thêm / Đăng nhập
        public static readonly Color WarningOrange = Color.FromArgb(239, 108, 0);   // Nút Sửa
        public static readonly Color DangerRed = Color.FromArgb(198, 40, 40);       // Nút Xóa
    }

    // 2. Nút bấm bo góc hiện đại (Dùng cho thẻ Bàn ở Form BanHang)
    public class RoundedButton : Button
    {
        public int BorderRadius { get; set; } = 12;
        public Color BorderColor { get; set; } = Color.Transparent;
        public int BorderSize { get; set; } = 0;

        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Cursor = Cursors.Hand;
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ForeColor = Color.White;
            BackColor = CoffeeTheme.CoffeeMedium;
            Resize += (s, e) => { if (BorderRadius > Height) BorderRadius = Height; };
        }

        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            if (curveSize <= 0)
            {
                path.AddRectangle(rect);
                return path;
            }
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rectSurface = ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -BorderSize, -BorderSize);
            int smoothSize = BorderSize > 0 ? BorderSize : 2;

            if (BorderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, BorderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, BorderRadius - BorderSize))
                using (Pen penSurface = new Pen(Parent?.BackColor ?? Color.White, smoothSize))
                using (Pen penBorder = new Pen(BorderColor, BorderSize))
                {
                    Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    if (BorderSize >= 1)
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                Region = new Region(rectSurface);
            }
        }
    }

    // 3. Lớp hàm dùng chung làm đẹp DataGridView và Button
    public static class UIHelper
    {
        public static void StyleDataGridView(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = CoffeeTheme.EspressoDark;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 0, 6, 0);
            dgv.ColumnHeadersHeight = 38;

            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40);
            dgv.DefaultCellStyle.SelectionBackColor = CoffeeTheme.LatteAccent;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.DefaultCellStyle.Padding = new Padding(6, 0, 6, 0);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = CoffeeTheme.CreamBg;

            dgv.RowTemplate.Height = 34;
            dgv.RowHeadersVisible = false;
            dgv.GridColor = Color.FromArgb(235, 230, 225);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }

        public static void StyleFlatRoundedButton(Button btn, Color mauNen, Color mauHover, Color mauChu, Image icon = null)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = mauNen;
            btn.ForeColor = mauChu;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;

            if (icon != null)
            {
                btn.Image = icon;
                btn.Text = "  " + btn.Text.Trim();
                btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                btn.ImageAlign = ContentAlignment.MiddleCenter;
                btn.TextAlign = ContentAlignment.MiddleCenter;
            }

            GraphicsPath path = new GraphicsPath();
            int r = 12;
            path.AddArc(0, 0, r * 2, r * 2, 180, 90);
            path.AddArc(btn.Width - r * 2, 0, r * 2, r * 2, 270, 90);
            path.AddArc(btn.Width - r * 2, btn.Height - r * 2, r * 2, r * 2, 0, 90);
            path.AddArc(0, btn.Height - r * 2, r * 2, r * 2, 90, 90);
            path.CloseFigure();
            btn.Region = new Region(path);

            btn.MouseEnter += (s, e) => btn.BackColor = mauHover;
            btn.MouseLeave += (s, e) => btn.BackColor = mauNen;
        }
    }

    // 4. Bộ tự vẽ Icon Vector sắc nét bằng GDI+ (Không phụ thuộc file ảnh ngoài)
    public static class CoffeeIcons
    {
        private static Bitmap CreateCanvas(int size, Action<Graphics> drawAction)
        {
            Bitmap bmp = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);
                drawAction(g);
            }
            return bmp;
        }

        public static Image CoffeeCup(Color color, int size = 24) => CreateCanvas(size, g =>
        {
            float s = size / 24f;
            using (Pen p = new Pen(color, 2f * s) { StartCap = LineCap.Round, EndCap = LineCap.Round })
            using (SolidBrush b = new SolidBrush(color))
            {
                g.DrawArc(p, 7 * s, 2 * s, 3 * s, 4 * s, 90, 180);
                g.DrawArc(p, 13 * s, 2 * s, 3 * s, 4 * s, 90, 180);
                GraphicsPath cup = new GraphicsPath();
                cup.AddLine(4 * s, 8 * s, 18 * s, 8 * s);
                cup.AddLine(18 * s, 8 * s, 16 * s, 18 * s);
                cup.AddArc(6 * s, 15 * s, 10 * s, 5 * s, 0, 180);
                cup.CloseFigure();
                g.FillPath(b, cup);
                g.DrawArc(p, 16 * s, 9.5f * s, 5 * s, 6 * s, -90, 180);
                g.DrawLine(p, 3 * s, 21 * s, 19 * s, 21 * s);
            }
        });

        public static Image EmptyTable(Color color, int size = 24) => CreateCanvas(size, g =>
        {
            float s = size / 24f;
            using (Pen p = new Pen(color, 2f * s) { StartCap = LineCap.Round, EndCap = LineCap.Round })
            {
                g.DrawLine(p, 3 * s, 8 * s, 21 * s, 8 * s);
                g.DrawLine(p, 12 * s, 8 * s, 12 * s, 20 * s);
                g.DrawLine(p, 7 * s, 20 * s, 17 * s, 20 * s);
            }
        });

        public static Image Plus(Color color, int size = 18) => CreateCanvas(size, g =>
        {
            float s = size / 18f;
            using (Pen p = new Pen(color, 2.4f * s) { StartCap = LineCap.Round })
            {
                g.DrawLine(p, 9 * s, 3 * s, 9 * s, 15 * s);
                g.DrawLine(p, 3 * s, 9 * s, 15 * s, 9 * s);
            }
        });

        public static Image Edit(Color color, int size = 18) => CreateCanvas(size, g =>
        {
            float s = size / 18f;
            using (Pen p = new Pen(color, 2f * s) { LineJoin = LineJoin.Round })
            {
                PointF[] body = {
                    new PointF(12 * s, 2.5f * s),
                    new PointF(15.5f * s, 6 * s),
                    new PointF(6.5f * s, 15 * s),
                    new PointF(3 * s, 15 * s),
                    new PointF(3 * s, 11.5f * s)
                };
                g.DrawPolygon(p, body);
            }
        });

        public static Image Trash(Color color, int size = 18) => CreateCanvas(size, g =>
        {
            float s = size / 18f;
            using (Pen p = new Pen(color, 2f * s) { StartCap = LineCap.Round })
            {
                g.DrawLine(p, 3 * s, 5 * s, 15 * s, 5 * s);
                g.DrawLine(p, 7 * s, 2.5f * s, 11 * s, 2.5f * s);
                g.DrawRectangle(p, 4.5f * s, 5 * s, 9 * s, 10.5f * s);
            }
        });

        public static Image Check(Color color, int size = 22) => CreateCanvas(size, g =>
        {
            float s = size / 22f;
            using (Pen p = new Pen(color, 2.8f * s) { StartCap = LineCap.Round, EndCap = LineCap.Round, LineJoin = LineJoin.Round })
            {
                g.DrawLines(p, new[] { new PointF(4 * s, 11 * s), new PointF(9 * s, 16 * s), new PointF(18 * s, 6 * s) });
            }
        });

        public static Image Search(Color color, int size = 18) => CreateCanvas(size, g =>
        {
            float s = size / 18f;
            using (Pen p = new Pen(color, 2.1f * s) { StartCap = LineCap.Round })
            {
                g.DrawEllipse(p, 2.5f * s, 2.5f * s, 9.5f * s, 9.5f * s);
                g.DrawLine(p, 11 * s, 11 * s, 15.5f * s, 15.5f * s);
            }
        });
    }
}