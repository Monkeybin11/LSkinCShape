using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace LSkin
{
    public partial class PanelX : ContainerControl
    {
        public PanelX()
        {
            this.SetStyle(
                         ControlStyles.UserPaint |  //控件自行绘制，而不使用操作系统的绘制
                         ControlStyles.AllPaintingInWmPaint | //忽略擦出的消息，减少闪烁。
                         ControlStyles.OptimizedDoubleBuffer |//在缓冲区上绘制，不直接绘制到屏幕上，减少闪烁。
                      ControlStyles.ResizeRedraw | //控件大小发生变化时，重绘。                  
                         ControlStyles.SupportsTransparentBackColor, true);//支持透明背景颜色
            base.BackColor = Color.FromArgb(0, 0, 0, 0);

            BorderColor = ForeColor;
            AutoScroll = false;
            AutoSize = false;

            ThemeColor = LSkinTheme.ThemeColor;
            BorderColor = LSkinTheme.ThemeColor;
            BackColor = LSkinTheme.BackColor;
            ForeColor = LSkinTheme.ForeColor;
            Font = LSkinTheme.Font;
            base.AutoScroll = false;
         


        }

        Color themeColor;


        bool touchMove = false;

        public bool TouchMove
        {
            set => touchMove = value;
            get => touchMove;
        }



        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (TouchMove)
            {
            }

        }

        Padding borderStyle = new Padding(0, 0, 0, 0);

        [Description("四周边框大小")]
        public Padding BorderWidth
        {
            get => borderStyle;

            set
            {
                borderStyle = value;
                Invalidate();
            }
        }

        Color borderColor;
        [Description("四周边框颜色")]
        public Color BorderColor
        {
            get => borderColor;

            set
            {
                borderColor = value;
                Invalidate();
            }
        }


        string text = "";
        /// <summary>
        /// 在控件中间显示文本
        /// </summary>
        public  string ContentText
        {
            get => text; set
            {
                text = value;
                Invalidate();
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {

            //     if (LSkinTheme.MouseDown) return;
            //   DrawTool.Optimization(e.Graphics);

            DrawBorder(e);///绘制边框

            if (ContentText != "")
            {
                e.Graphics.DrawString(text, Font, new SolidBrush(ForeColor), new RectangleF(0, 0, Width, Height), StringFormatX.MiddleCenter);
            }

          base.OnPaint(e);

        }

        //foreach (Control it in Controls)
        //   {
        //       if (it.Location.X + it.Width > Width - scollWdith - 1) it.Width = Width - scollWdith - it.Location.X; //如果存在滚动条 子控件缩小
        //   }


        bool autoFlow = false;
        public bool AutoFlow { get => autoFlow; set
            {
                autoFlow = value;
                Invalidate();
            } }
        public Color ThemeColor { get => themeColor; set {  themeColor = value;Invalidate(); } }

        private void DrawBorder(PaintEventArgs e)
        {
            if (borderStyle.Top > 0)
            {

                Pen pen = new Pen(borderColor, borderStyle.Top);

                e.Graphics.DrawLine(pen, new Point(0, 0), new Point(Width, 0));
            }

            if (borderStyle.Right > 0)
            {

                Pen pen = new Pen(borderColor, borderStyle.Right);

                e.Graphics.DrawLine(pen, new Point(Width, 0), new Point(Width, Height));
            }

            if (borderStyle.Bottom > 0)
            {
                Pen pen = new Pen(borderColor, borderStyle.Bottom);

                e.Graphics.DrawLine(pen, new Point(0, Height), new Point(Width, Height));
            }

            if (borderStyle.Left > 0)
            {
                Pen pen = new Pen(borderColor, borderStyle.Left);
                e.Graphics.DrawLine(pen, new Point(0, 0), new Point(0, Height));
            }
        }


    }

}
