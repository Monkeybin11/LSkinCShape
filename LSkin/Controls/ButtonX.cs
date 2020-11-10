using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace LSkin
{
    public partial class ButtonX : Button
    {
        public ButtonX()
        {
            this.SetStyle(
              ControlStyles.UserPaint |  //控件自行绘制，而不使用操作系统的绘制
              ControlStyles.AllPaintingInWmPaint | //忽略擦出的消息，减少闪烁。
              ControlStyles.OptimizedDoubleBuffer |//在缓冲区上绘制，不直接绘制到屏幕上，减少闪烁。
              ControlStyles.ResizeRedraw | //控件大小发生变化时，重绘。                  
              ControlStyles.SupportsTransparentBackColor, true);//支持透明背景颜色

            base.BackColor = Color.FromArgb(0, 0, 0, 0);
            TabStop = false;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 0, 0);

            ///初始化
            ForeColor = Color.White;
            Font = LSkinTheme.Font;
            ThemeColor = LSkinTheme.ThemeColor;
            Cursor = Cursors.Hand;
        }



        [Description("背景颜色")]
        public new Color BackColor
        {
            get => themeColor;

            set
            {
                ThemeColor = value;

            }
        }

        int radius = 0; //锐角大小

        Color themeColor;
        Color color_hover;

        [Description("主题颜色")]
        public Color ThemeColor
        {
            set
            {
                themeColor = value;


                if (value == Color.Transparent)
                {
                    color_hover = value;
                }
                else
                {
                    color_hover = DrawTool.ConvertColor(value, 0.8);
                }
                Invalidate();
            }
            get
            {
                return themeColor;
            }
        }


        Bitmap icon = null;
        [Description("用于和文本共同显示的小图标")]
        public Bitmap Icon
        {
            get => icon;
            set
            {
                icon = value;
                Invalidate();
            }
        }


        Bitmap image = null;
        [Description("按钮上显示的图片")]
        public new Bitmap Image
        {
            get => image;

            set
            {
                image = value;
                Invalidate();
            }

        }

        [Description("锐角大小,如果控件宽与高相等，radius值大于宽度则是正圆")]
        public int Radius
        {
            set
            {
                radius = value;
                this.Invalidate();
            }
            get
            {
                return radius;
            }
        }
        bool isHover = false;
        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            base.OnMouseMove(mevent);
            isHover = true;
            Invalidate();

        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isHover = false;
            Invalidate();
        }


        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);
            DrawTool.Optimization(e.Graphics);

            if (!isHover)
            {
                GraphicsPath gpp = DrawTool.DrawRectangle(new Rectangle(0, 0, Width, Height), radius);
                e.Graphics.FillPath(new SolidBrush(ThemeColor), gpp);
            }
            else
            {
                GraphicsPath gpp = DrawTool.DrawRectangle(new Rectangle(0, 0, Width, Height), radius);
                e.Graphics.FillPath(new SolidBrush(color_hover), gpp);
            }

            if (image != null)
            {
                e.Graphics.DrawImage(image, new RectangleF(0, 0, Width, Height));
            }

            if (Icon != null)
            {
                Size fontSize = DrawTool.GetFontSize(e.Graphics, Font, Text);
                int marignLeft = (Width - (fontSize.Width + fontSize.Height)) / 2;
                int marignTop = (Height - fontSize.Height) / 2;

                Rectangle imageRec = new Rectangle(marignLeft, marignTop, fontSize.Height, fontSize.Height);

                imageRec.X -= 2;
                e.Graphics.DrawImage(Icon, imageRec);

                e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), new RectangleF(imageRec.X + imageRec.Width + 3, 0 + 1.5F, Width, Height), StringFormatX.MiddleLeft);

            }
            else
            {
                e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), new RectangleF(0, 0 + 1.5F, Width, Height), StringFormatX.MiddleCenter);
            }
        }

    }
}
