using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Coffee_Shop_Management
{
    public static class CoffeeTheme
    {
        public static readonly Color EspressoDark = Color.FromArgb(62, 39, 35);
        public static readonly Color CoffeeMedium = Color.FromArgb(93, 64, 55);
        public static readonly Color CreamBg = Color.FromArgb(250, 246, 240);
        public static readonly Color MintEmpty = Color.FromArgb(232, 245, 233);
        public static readonly Color MintBorder = Color.FromArgb(129, 199, 132);
        public static readonly Color PeachBusy = Color.FromArgb(255, 224, 178);
        public static readonly Color PeachBorder = Color.FromArgb(255, 167, 38);
        public static readonly Color GreenSuccess = Color.FromArgb(46, 125, 50);
        public static readonly Color SuccessGreen = Color.FromArgb(46, 125, 50);
        public static readonly Color BlueInfo = Color.FromArgb(25, 118, 210);
        public static readonly Color PrimaryBlue = Color.FromArgb(25, 118, 210);
        public static readonly Color OrangeWarn = Color.FromArgb(245, 124, 0);
        public static readonly Color WarningOrange = Color.FromArgb(245, 124, 0);
        public static readonly Color RedDanger = Color.FromArgb(211, 47, 47);
        public static readonly Color DangerRed = Color.FromArgb(211, 47, 47);
    }

    public class RoundedButton : Button
    {
        private int borderSize = 0;
        private int borderRadius = 12;
        private Color borderColor = Color.Transparent;

        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; this.Invalidate(); }
        }

        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; this.Invalidate(); }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; this.Invalidate(); }
        }

        public RoundedButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 45);
            this.BackColor = CoffeeTheme.EspressoDark;
            this.ForeColor = Color.White;
            this.Resize += (s, e) =>
            {
                if (borderRadius > this.Height)
                    borderRadius = this.Height;
            };
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
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;

            if (borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent != null ? this.Parent.BackColor : Color.White, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    if (borderSize >= 1)
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                this.Region = new Region(rectSurface);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (this.Parent != null)
            {
                this.Parent.BackColorChanged += (s, ev) => this.Invalidate();
            }
        }
    }

    public static class CoffeeIcons
    {
        private static Bitmap TaoCanvas(int size, Action<Graphics, Pen> ve)
        {
            Bitmap bmp = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(Color.White, 2.2f))
                {
                    pen.StartCap = LineCap.Round;
                    pen.EndCap = LineCap.Round;
                    ve(g, pen);
                }
            }
            return bmp;
        }

        public static Image Check(Color mau, int size = 20)
        {
            return TaoCanvas(size, (g, p) =>
            {
                p.Color = mau;
                g.DrawLines(p, new[]
                {
                    new PointF(size * 0.2f, size * 0.52f),
                    new PointF(size * 0.42f, size * 0.75f),
                    new PointF(size * 0.82f, size * 0.28f)
                });
            });
        }

        public static Image Plus(Color mau, int size = 20)
        {
            return TaoCanvas(size, (g, p) =>
            {
                p.Color = mau;
                g.DrawLine(p, size * 0.5f, size * 0.2f, size * 0.5f, size * 0.8f);
                g.DrawLine(p, size * 0.2f, size * 0.5f, size * 0.8f, size * 0.5f);
            });
        }

        public static Image Logout(Color mau, int size = 20)
        {
            return TaoCanvas(size, (g, p) =>
            {
                p.Color = mau;
                g.DrawLines(p, new[]
                {
                    new PointF(size * 0.45f, size * 0.2f),
                    new PointF(size * 0.2f, size * 0.2f),
                    new PointF(size * 0.2f, size * 0.8f),
                    new PointF(size * 0.45f, size * 0.8f)
                });
                g.DrawLine(p, size * 0.4f, size * 0.5f, size * 0.82f, size * 0.5f);
                g.DrawLines(p, new[]
                {
                    new PointF(size * 0.65f, size * 0.32f),
                    new PointF(size * 0.82f, size * 0.5f),
                    new PointF(size * 0.65f, size * 0.68f)
                });
            });
        }

        public static Image Edit(Color mau, int size = 20)
        {
            return TaoCanvas(size, (g, p) =>
            {
                p.Color = mau;
                g.DrawLine(p, size * 0.25f, size * 0.75f, size * 0.75f, size * 0.25f);
                g.DrawLine(p, size * 0.2f, size * 0.82f, size * 0.8f, size * 0.82f);
            });
        }

        public static Image Trash(Color mau, int size = 20)
        {
            return TaoCanvas(size, (g, p) =>
            {
                p.Color = mau;
                g.DrawLine(p, size * 0.2f, size * 0.28f, size * 0.8f, size * 0.28f);
                g.DrawRectangle(p, size * 0.28f, size * 0.28f, size * 0.44f, size * 0.54f);
            });
        }

        public static Image Search(Color mau, int size = 20)
        {
            return TaoCanvas(size, (g, p) =>
            {
                p.Color = mau;
                g.DrawEllipse(p, size * 0.2f, size * 0.2f, size * 0.46f, size * 0.46f);
                g.DrawLine(p, size * 0.6f, size * 0.6f, size * 0.82f, size * 0.82f);
            });
        }

        public static Image EmptyTable(Color mau, int size = 22)
        {
            return TaoCanvas(size, (g, p) =>
            {
                p.Color = mau;
                g.DrawLine(p, size * 0.2f, size * 0.32f, size * 0.8f, size * 0.32f);
                g.DrawLine(p, size * 0.5f, size * 0.32f, size * 0.5f, size * 0.78f);
                g.DrawLine(p, size * 0.32f, size * 0.78f, size * 0.68f, size * 0.78f);
            });
        }

        public static Image BusyTable(Color mau, int size = 22)
        {
            return EmptyTable(mau, size);
        }

        public static Image CoffeeCup(Color mau, int size = 22)
        {
            return TaoCanvas(size, (g, p) =>
            {
                p.Color = mau;
                g.DrawRectangle(p, size * 0.24f, size * 0.34f, size * 0.42f, size * 0.42f);
                g.DrawArc(p, size * 0.58f, size * 0.4f, size * 0.2f, size * 0.24f, 270, 180);
                g.DrawLine(p, size * 0.2f, size * 0.8f, size * 0.72f, size * 0.8f);
            });
        }

        public static Image Transfer(Color mau, int size = 20)
        {
            return TaoCanvas(size, (g, p) =>
            {
                p.Color = mau;
                g.DrawLine(p, size * 0.2f, size * 0.36f, size * 0.8f, size * 0.36f);
                g.DrawLine(p, size * 0.64f, size * 0.22f, size * 0.8f, size * 0.36f);
                g.DrawLine(p, size * 0.2f, size * 0.64f, size * 0.8f, size * 0.64f);
                g.DrawLine(p, size * 0.36f, size * 0.78f, size * 0.2f, size * 0.64f);
            });
        }
    }

    public static class UIHelper
    {
        public static void RoundControl(Control ctrl, int radius = 12)
        {
            if (ctrl == null || ctrl.Width <= 0 || ctrl.Height <= 0) return;
            GraphicsPath path = new GraphicsPath();
            float d = radius * 2F;
            path.StartFigure();
            path.AddArc(0, 0, d, d, 180, 90);
            path.AddArc(ctrl.Width - d, 0, d, d, 270, 90);
            path.AddArc(ctrl.Width - d, ctrl.Height - d, d, d, 0, 90);
            path.AddArc(0, ctrl.Height - d, d, d, 90, 90);
            path.CloseFigure();
            ctrl.Region = new Region(path);
        }

        public static void ApplyStyle(Form frm)
        {
            if (frm != null)
            {
                frm.BackColor = CoffeeTheme.CreamBg;
            }
        }
    }
}