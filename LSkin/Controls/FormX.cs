using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace LSkin
{
    public partial class FormX : Form
    {
        ShadowWin Sw;
        public FormX()
        {




            FormBorderStyle = FormBorderStyle.None;

            StartPosition = FormStartPosition.CenterScreen;
            header.Dock = DockStyle.Top;

            InitializeComponent();

            this.SetStyle(
  ControlStyles.AllPaintingInWmPaint | //忽略擦出的消息，减少闪烁。
  ControlStyles.OptimizedDoubleBuffer |//在缓冲区上绘制，不直接绘制到屏幕上，减少闪烁。
                                       //  ControlStyles.ResizeRedraw | //控件大小发生变化时，重绘。                  
  ControlStyles.SupportsTransparentBackColor, true);//支持透明背景颜色
            BackColor = LSkinTheme.BackColor;
            ForeColor = LSkinTheme.ForeColor;
            Font = LSkinTheme.Font;

            this.Controls.Add(header);
        }

        public FormHeader header = new FormHeader();

        public override void Refresh()
        {
            if (!DebugTool.IsDesignMode)
            {
                if (Sw != null)
                {
                    Sw.Close();
                }
                Sw = new ShadowWin(this, header);
                Sw.Show(this);
            }
            base.Refresh();


        }



        #region 允许点击任务栏最小化
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_MINIMIZEBOX = 0x00020000;  // Winuser.h中定义
                CreateParams cp = base.CreateParams;
                cp.Style = cp.Style | WS_MINIMIZEBOX;   // 允许最小化操作

                //     cp.ExStyle |= 0x02000000;//防止闪烁
                return cp;
            }
        }
        #endregion

        protected override void OnVisibleChanged(EventArgs e)
        {

            base.OnVisibleChanged(e);
            if (Visible)
            {
                Invalidate();
                if (!DebugTool.IsDesignMode)
                {


                    Sw = new ShadowWin(this, header);
                    Sw.Show(this);

                }
            }

        }






        //窗体关闭时
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            //先关闭阴影窗体
            if (Sw != null)
            {
                Sw.Close();
            }
            //在Form_FormClosing中添加代码实现窗体的淡出

        }







        public override string Text
        {
            get
            {
                if (this.header != null)
                {
                    return this.header.Text;
                }
                else
                {
                    return "";
                }
            }
            set
            {
                if (this.header != null)
                {
                    this.header.Text = value;

                    header.Invalidate();
                }
            }
        }



        [DllImport("user32.dll ", EntryPoint = "ReleaseCapture ")]
        public static extern int ReleaseCapture();
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF012;
        public bool _canResize = true;

        const int HTLEFT = 10;

        const int HTRIGHT = 11;

        const int HTTOP = 12;

        const int HTTOPLEFT = 13;

        const int HTTOPRIGHT = 14;

        const int HTBOTTOM = 15;

        const int HTBOTTOMLEFT = 0x10;

        const int HTBOTTOMRIGHT = 17;

        protected override void WndProc(ref Message m)

        {

            switch (m.Msg)

            {

                case 0x0084:

                    base.WndProc(ref m);

                    Point vPoint = new Point((int)m.LParam & 0xFFFF,

                     (int)m.LParam >> 16 & 0xFFFF);

                    vPoint = PointToClient(vPoint);

                    if (vPoint.X <= 5)

                        if (vPoint.Y <= 5)

                            m.Result = (IntPtr)HTTOPLEFT;

                        else if (vPoint.Y >= ClientSize.Height - 5)

                            m.Result = (IntPtr)HTBOTTOMLEFT;

                        else m.Result = (IntPtr)HTLEFT;

                    else if (vPoint.X >= ClientSize.Width - 5)

                        if (vPoint.Y <= 5)

                            m.Result = (IntPtr)HTTOPRIGHT;

                        else if (vPoint.Y >= ClientSize.Height - 5)


                            m.Result = (IntPtr)HTBOTTOMRIGHT;

                        else m.Result = (IntPtr)HTRIGHT;

                    else if (vPoint.Y <= 5)


                        m.Result = (IntPtr)HTTOP;

                    else if (vPoint.Y >= ClientSize.Height - 5)


                        m.Result = (IntPtr)HTBOTTOM;

                    break;

                case 0x0201://鼠标左键按下的消息 用于实现拖动窗口功能

                    m.Msg = 0x00A1;//更改消息为非客户区按下鼠标

                    m.LParam = IntPtr.Zero;//默认值

                    m.WParam = new IntPtr(2);//鼠标放在标题栏内

                    base.WndProc(ref m);

                    break;

                default:

                    base.WndProc(ref m);

                    break;

            }

        }

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);




    }
    partial class ShadowWin : Form
    {

        //控件层
        private FormX Main;
        private FormHeader fh;

        //带参构造
        public ShadowWin(FormX mainWin, FormHeader fh)
        {

            this.fh = fh;
            //将控制层传值过来
            this.Main = mainWin;
            //InitializeComponent();
            //置顶窗体
            Main.TopMost = TopMost = Main.TopMost;
            Main.BringToFront();
            //是否在任务栏显示
            ShowInTaskbar = false;
            //无边框模式
            FormBorderStyle = FormBorderStyle.None;
            //设置绘图层显示位置
            this.Location = new Point(Main.Location.X - 5, Main.Location.Y - 5);
            //设置ICO
            Icon = Main.Icon;
            ShowIcon = Main.ShowIcon;
            //设置大小
            Width = Main.Width + 10;
            Height = Main.Height + 10;
            //设置标题名
            Text = Main.Text;
            //绘图层窗体移动
            Main.LocationChanged += new EventHandler(Main_LocationChanged);
            Main.SizeChanged += new EventHandler(Main_SizeChanged);
            Main.VisibleChanged += new EventHandler(Main_VisibleChanged);
            //还原任务栏右键菜单
            //CommonClass.SetTaskMenu(Main);
            //加载背景
            Action();
            //窗口鼠标穿透效果
            CanPenetrate();


        }



        #region 初始化
        private void Init()
        {
            //置顶窗体
            TopMost = Main.TopMost;
            Main.BringToFront();
            //是否在任务栏显示
            ShowInTaskbar = false;
            //无边框模式
            FormBorderStyle = FormBorderStyle.None;
            //设置绘图层显示位置
            this.Location = new Point(Main.Location.X - 5, Main.Location.Y - 5);
            //设置ICO
            Icon = Main.Icon;
            ShowIcon = Main.ShowIcon;
            //设置大小
            Width = Main.Width + 10;
            Height = Main.Height + 10;
            //设置标题名
            Text = Main.Text;
            //绘图层窗体移动
            Main.LocationChanged += new EventHandler(Main_LocationChanged);
            Main.SizeChanged += new EventHandler(Main_SizeChanged);
            Main.VisibleChanged += new EventHandler(Main_VisibleChanged);
            //还原任务栏右键菜单
            //CommonClass.SetTaskMenu(Main);
            //加载背景
            Action();
            //窗口鼠标穿透效果
            CanPenetrate();
        }
        #endregion

        #region 还原任务栏右键菜单
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cParms = base.CreateParams;
                cParms.ExStyle |= 0x00080000; // WS_EX_LAYERED
                return cParms;
            }
        }
        public class CommonClass
        {
            [DllImport("user32.dll", EntryPoint = "GetWindowLong", CharSet = CharSet.Auto)]
            static extern int GetWindowLong(HandleRef hWnd, int nIndex);
            [DllImport("user32.dll", EntryPoint = "SetWindowLong", CharSet = CharSet.Auto)]
            static extern IntPtr SetWindowLong(HandleRef hWnd, int nIndex, int dwNewLong);
            public const int WS_SYSMENU = 0x00080000;
            public const int WS_MINIMIZEBOX = 0x20000;
            public static void SetTaskMenu(Form form)
            {
                int windowLong = (GetWindowLong(new HandleRef(form, form.Handle), -16));
                SetWindowLong(new HandleRef(form, form.Handle), -16, windowLong | WS_SYSMENU | WS_MINIMIZEBOX);
            }
        }
        #endregion

        #region 减少闪烁
        private void SetStyles()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                //       ControlStyles.ResizeRedraw |
                ControlStyles.DoubleBuffer, true);
            //强制分配样式重新应用到控件上
            UpdateStyles();
            base.AutoScaleMode = AutoScaleMode.None;
        }
        #endregion

        #region 控件层相关事件
        //移动主窗体时
        void Main_LocationChanged(object sender, EventArgs e)
        {
            Location = new Point(Main.Left - 5, Main.Top - 5);

        }

        //主窗体大小改变时
        void Main_SizeChanged(object sender, EventArgs e)
        {
            //设置大小
            Width = Main.Width + 10;
            Height = Main.Height + 10;
            Action();
        }

        //主窗体显示或隐藏时
        void Main_VisibleChanged(object sender, EventArgs e)
        {
            this.Visible = Main.Visible;
        }
        #endregion

        #region 使窗口有鼠标穿透功能
        /// <summary>
        /// 使窗口有鼠标穿透功能
        /// </summary>
        private void CanPenetrate()
        {
            int intExTemp = Win32.GetWindowLong(this.Handle, Win32.GWL_EXSTYLE);
            int oldGWLEx = Win32.SetWindowLong(this.Handle, Win32.GWL_EXSTYLE, Win32.WS_EX_TRANSPARENT | Win32.WS_EX_LAYERED);
        }
        #endregion

        public void Action()
        {
            SetBits();

        }
        Bitmap bitmap;
        IntPtr oldBits;
        IntPtr screenDC;
        IntPtr hBitmap;
        IntPtr memDc;
        #region 不规则无毛边方法
        public void SetBits()
        {

            //绘制绘图层背景
            bitmap = new Bitmap(Main.Width + 10, Main.Height + 10);

            Rectangle _BacklightLTRB = new Rectangle(20, 20, 20, 20);//窗体光泽重绘边界
            Graphics g = Graphics.FromImage(bitmap);
            g.SmoothingMode = SmoothingMode.HighQuality; //高质量
            g.PixelOffsetMode = PixelOffsetMode.HighQuality; //高像素偏移质量
            DrawRect(g, Properties.Resources.FormBack, new Rectangle(0, 0, Width, Height), Rectangle.FromLTRB(_BacklightLTRB.X, _BacklightLTRB.Y, _BacklightLTRB.Width, _BacklightLTRB.Height), 1, 1, fh);

            if (!Bitmap.IsCanonicalPixelFormat(bitmap.PixelFormat) || !Bitmap.IsAlphaPixelFormat(bitmap.PixelFormat))
                throw new ApplicationException("图片必须是32位带Alhpa通道的图片。");
            oldBits = IntPtr.Zero;
            screenDC = Win32.GetDC(IntPtr.Zero);
            hBitmap = IntPtr.Zero;
            memDc = Win32.CreateCompatibleDC(screenDC);
            NewMethod(bitmap, oldBits, screenDC, hBitmap, memDc);
        }

        //private void T_Tick(object sender, EventArgs e)
        //{
        //    System.Windows.Forms.Timer t = sender as System.Windows.Forms.Timer;
        //    t.Stop();
        //    Action();
        //    return;

        //}

        private void NewMethod(Bitmap bitmap, IntPtr oldBits, IntPtr screenDC, IntPtr hBitmap, IntPtr memDc)
        {
            try
            {
                Win32.Point topLoc = new Win32.Point(Left, Top);
                Win32.Size bitMapSize = new Win32.Size(Width, Height);
                Win32.BLENDFUNCTION blendFunc = new Win32.BLENDFUNCTION();
                Win32.Point srcLoc = new Win32.Point(0, 0);

                hBitmap = bitmap.GetHbitmap(Color.FromArgb(0));
                oldBits = Win32.SelectObject(memDc, hBitmap);

                blendFunc.BlendOp = Win32.AC_SRC_OVER;
                blendFunc.SourceConstantAlpha = Byte.Parse("255");
                blendFunc.AlphaFormat = Win32.AC_SRC_ALPHA;
                blendFunc.BlendFlags = 0;


                try
                {
                    Win32.UpdateLayeredWindow(Handle, screenDC, ref topLoc, ref bitMapSize, memDc, ref srcLoc, 0, ref blendFunc, Win32.ULW_ALPHA);
                }
                catch (Exception)
                {

                }
            }
            finally
            {
                if (hBitmap != IntPtr.Zero)
                {
                    Win32.SelectObject(memDc, oldBits);
                    Win32.DeleteObject(hBitmap);
                }
                Win32.ReleaseDC(IntPtr.Zero, screenDC);
                Win32.DeleteDC(memDc);
            }
        }

        public static void DrawRect(Graphics g, Bitmap img, Rectangle r, Rectangle lr, int index, int Totalindex, FormHeader fh)
        {

            if (img == null) return;
            Rectangle r1, r2;
            int x = (index - 1) * img.Width / Totalindex;
            int y = 0;
            int x1 = r.Left;
            int y1 = r.Top;

            if (r.Height > img.Height && r.Width <= img.Width / Totalindex)
            {
                r1 = new Rectangle(x, y, img.Width / Totalindex, lr.Top);
                r2 = new Rectangle(x1, y1, r.Width, lr.Top);
                g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);

                r1 = new Rectangle(x, y + lr.Top, img.Width / Totalindex, img.Height - lr.Top - lr.Bottom);
                r2 = new Rectangle(x1, y1 + lr.Top, r.Width, r.Height - lr.Top - lr.Bottom);
                if ((lr.Top + lr.Bottom) == 0) r1.Height = r1.Height - 1;
                g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);

                r1 = new Rectangle(x, y + img.Height - lr.Bottom, img.Width / Totalindex, lr.Bottom);
                r2 = new Rectangle(x1, y1 + r.Height - lr.Bottom, r.Width, lr.Bottom);
                g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);
            }
            else
                if (r.Height <= img.Height && r.Width > img.Width / Totalindex)
            {
                r1 = new Rectangle(x, y, lr.Left, img.Height);
                r2 = new Rectangle(x1, y1, lr.Left, r.Height);
                g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);
                r1 = new Rectangle(x + lr.Left, y, img.Width / Totalindex - lr.Left - lr.Right, img.Height);
                r2 = new Rectangle(x1 + lr.Left, y1, r.Width - lr.Left - lr.Right, r.Height);
                g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);
                r1 = new Rectangle(x + img.Width / Totalindex - lr.Right, y, lr.Right, img.Height);
                r2 = new Rectangle(x1 + r.Width - lr.Right, y1, lr.Right, r.Height);
                g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);
            }
            else
                    if (r.Height <= img.Height && r.Width <= img.Width / Totalindex)
            {
                r1 = new Rectangle((index - 1) * img.Width / Totalindex, 0, img.Width / Totalindex, img.Height - 1);
                g.DrawImage(img, new Rectangle(x1, y1, r.Width, r.Height), r1, GraphicsUnit.Pixel);
            }
            else if (r.Height > img.Height && r.Width > img.Width / Totalindex)
            {
                //top-left
                r1 = new Rectangle(x, y, lr.Left, lr.Top);
                r2 = new Rectangle(x1, y1, lr.Left, lr.Top);
                g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);

                //top-bottom
                r1 = new Rectangle(x, y + img.Height - lr.Bottom, lr.Left, lr.Bottom);
                r2 = new Rectangle(x1, y1 + r.Height - lr.Bottom, lr.Left, lr.Bottom);
                g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);

                //left
                r1 = new Rectangle(x, y + lr.Top, lr.Left, img.Height - lr.Top - lr.Bottom);
                r2 = new Rectangle(x1, y1 + lr.Top, lr.Left, r.Height - lr.Top - lr.Bottom);
                g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);

                //top
                r1 = new Rectangle(x + lr.Left, y,
                    img.Width / Totalindex - lr.Left - lr.Right, lr.Top);
                r2 = new Rectangle(x1 + lr.Left, y1,
                    r.Width - lr.Left - lr.Right, lr.Top);
                g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);

                //right-top
                r1 = new Rectangle(x + img.Width / Totalindex - lr.Right, y, lr.Right, lr.Top);
                r2 = new Rectangle(x1 + r.Width - lr.Right, y1, lr.Right, lr.Top);
                g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);

                //Right
                r1 = new Rectangle(x + img.Width / Totalindex - lr.Right, y + lr.Top,
                    lr.Right, img.Height - lr.Top - lr.Bottom);
                r2 = new Rectangle(x1 + r.Width - lr.Right, y1 + lr.Top,
                    lr.Right, r.Height - lr.Top - lr.Bottom);
                g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);

                //right-bottom
                r1 = new Rectangle(x + img.Width / Totalindex - lr.Right, y + img.Height - lr.Bottom,
                    lr.Right, lr.Bottom);
                r2 = new Rectangle(x1 + r.Width - lr.Right, y1 + r.Height - lr.Bottom,
                    lr.Right, lr.Bottom);
                g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);

                //bottom
                r1 = new Rectangle(x + lr.Left, y + img.Height - lr.Bottom,
                    img.Width / Totalindex - lr.Left - lr.Right, lr.Bottom);
                r2 = new Rectangle(x1 + lr.Left, y1 + r.Height - lr.Bottom,
                    r.Width - lr.Left - lr.Right, lr.Bottom);
                g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);

                //Center
                r1 = new Rectangle(x + lr.Left, y + lr.Top,
                    img.Width / Totalindex - lr.Left - lr.Right, img.Height - lr.Top - lr.Bottom);
                r2 = new Rectangle(x1 + lr.Left, y1 + lr.Top,
                    r.Width - lr.Left - lr.Right, r.Height - lr.Top - lr.Bottom);
                g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);
            }

            if (fh != null)
            {
                return;
                int w = 5;

                g.FillRectangle(new SolidBrush(fh.BackColor), new Rectangle(w, w, w, w));
                g.FillRectangle(new SolidBrush(fh.BackColor), new Rectangle(r.Width - w * 2, w, w, w));

            }

        }


        #endregion
    }
}

