using LSkin;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace LSkin
{
    public partial class FormHeader : PanelX
    {
        private bool MaximizeBox = true;

        public FormHeader()
        {
            this.SetStyle(
          ControlStyles.UserPaint |  //控件自行绘制，而不使用操作系统的绘制
          ControlStyles.AllPaintingInWmPaint | //忽略擦出的消息，减少闪烁。
          ControlStyles.OptimizedDoubleBuffer |//在缓冲区上绘制，不直接绘制到屏幕上，减少闪烁。
          ControlStyles.ResizeRedraw | //控件大小发生变化时，重绘。                  
          ControlStyles.SupportsTransparentBackColor, true);//支持透明背景颜色

            Height = 45;
            BackColor = LSkinTheme.ThemeColor;
            ForeColor = Color.White;
            Font = LSkinTheme.Font;

        }



        Font btnFont = new Font("Marlett", 13); //图标字体样式

        Bitmap icon = null;
        /// <summary>
        /// 用于显示左上角小图标
        /// </summary>
        [Description("用于显示左上角小图标")]
        public Bitmap Icon
        {
            get => icon; set
            {
                icon = value;
                Invalidate();
            }
        }

        StringFormat left = StringFormatX.MiddleLeft;
        StringFormat center = StringFormatX.MiddleCenter;

        Rectangle minRectangle;
        Rectangle maxRectangle;
        Rectangle closeRectangle;
        Point mouseLocation;
        Color hoverColor;

        bool mouseDown = false;
        protected override void OnMouseUp(MouseEventArgs e)
        {
            mouseDown = false;
        }


        [Description("主题颜色")]
        public Color ThemeColor
        {

            set
            {
                BackColor = value;
            }

            get
            {
                return BackColor;
            }

        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]


        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        protected override void OnMouseDown(MouseEventArgs e)
        {
            mouseDown = true;
            base.OnMouseDown(e);
            if (e.Button != MouseButtons.Left) return;
            if (minRectangle.Contains(mouseLocation))
            {

                ParentForm.WindowState = FormWindowState.Minimized;
                Invalidate();
                return;
            }

            if (maxRectangle.Contains(mouseLocation))
            {
                if (ParentForm.WindowState == FormWindowState.Maximized)
                {
                    ParentForm.WindowState = FormWindowState.Normal;
                }
                else
                {
                    ParentForm.WindowState = FormWindowState.Maximized;
                }
                Invalidate();
                return;
            }
            if (closeRectangle.Contains(mouseLocation))
            {
                if (FormCloseClick != null)
                {
                    FormCloseClick(this, e);
                }
                else
                {
                    ParentForm.Close();
                }
                Invalidate();
                return;
            }

            ReleaseCapture();
            SendMessage(ParentForm.Handle, 274, 61458, 0);

        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            mouseLocation = e.Location;
            Invalidate();

        }

        [Description("当用户单机了关闭按钮时发生的事件")]
        public EventHandler FormCloseClick;
        protected override void OnForeColorChanged(EventArgs e)
        {
            hoverColor = DrawTool.ConvertColor(ForeColor, 0.8);
            Invalidate();
        }

        int fontHeight = 0;

        public override string Text
        {
            get => base.Text; set
            {
                fontHeight = DrawTool.GetFontSize(CreateGraphics(), Font, value).Height;
                base.Text = value;
            }
        }




        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);
            if (Width == 0 || Height == 0) return;



            if (Icon != null)
            {

                int paddOffset = -(Height - fontHeight) / 2 + 2;

                Rectangle iconRec = DrawTool.ConvertRectangle(new Rectangle(0, 0, Height, Height), new Padding(paddOffset));
                iconRec.X = 15;
                e.Graphics.DrawImage(Icon, iconRec);
                e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), new RectangleF(iconRec.X + iconRec.Width + (fontHeight / 2), 0 + 1.5f, Width / 2, Height), left);

            }
            else
            {
                e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), new RectangleF(15, 0 + 1.5f, Width - 100, Height), left);
            }




            if (ParentForm.MaximizeBox)
            {
                //最大化状态
                maxRectangle = new Rectangle(Width - 54, (Height - 16) / 2, 18, 18);
                Draw_Max_Buton(e.Graphics);
                //最小化按钮
                minRectangle = new Rectangle(Width - 54 - (MaximizeBox ? 1 : 0) * 22, (Height - 16) / 2, 18, 18);
            }
            else
            {
                //最小化按钮
                minRectangle = new Rectangle(Width - 54, (Height - 16) / 2, 18, 18);
            }

            Draw_Min_Button(e.Graphics);


            //关闭按钮
            closeRectangle = new Rectangle(Width - 32, (Height - 16) / 2, 18, 18);
            Draw_Close_Button(e.Graphics);



        }

        private void Draw_Max_Buton(Graphics graphics)
        {




            if (maxRectangle.Contains(mouseLocation) && ParentForm.WindowState == FormWindowState.Normal) //判断矩形内是否包含坐标内;
            {
                graphics.DrawString("1", btnFont, new SolidBrush(hoverColor), maxRectangle, center);
            }

            if (!maxRectangle.Contains(mouseLocation) && ParentForm.WindowState == FormWindowState.Normal) //判断矩形内是否包含坐标内;
            {
                graphics.DrawString("1", btnFont, new SolidBrush(ForeColor), maxRectangle, center);
            }

            if (maxRectangle.Contains(mouseLocation) && ParentForm.WindowState == FormWindowState.Maximized) //判断矩形内是否包含坐标内;
            {
                graphics.DrawString("2", btnFont, new SolidBrush(hoverColor), maxRectangle, center);
            }

            if (!maxRectangle.Contains(mouseLocation) && ParentForm.WindowState == FormWindowState.Maximized) //判断矩形内是否包含坐标内;
            {
                graphics.DrawString("2", btnFont, new SolidBrush(ForeColor), maxRectangle, center);
            }


        }

        private void Draw_Min_Button(Graphics graphics)
        {
            //最小化

            if (!minRectangle.Contains(mouseLocation)) //判断矩形内是否包含坐标内;
            {
                graphics.DrawString("0", btnFont, new SolidBrush(ForeColor), minRectangle, center);
            }
            else
            {
                graphics.DrawString("0", btnFont, new SolidBrush(hoverColor), minRectangle, center);
            }
        }

        private void Draw_Close_Button(Graphics graphics)
        {
            //关闭按钮

            if (!closeRectangle.Contains(mouseLocation)) //判断矩形内是否包含坐标内;
            {
                graphics.DrawString("r", btnFont, new SolidBrush(ForeColor), closeRectangle, center);
            }
            else
            {
                graphics.DrawString("r", btnFont, new SolidBrush(hoverColor), closeRectangle, center);
            }

        }
    }
}