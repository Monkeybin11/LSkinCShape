using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LSkin
{
    public class ProgressBarX : PanelX
    {
        public ProgressBarX()
        {
            this.SetStyle(
          ControlStyles.UserPaint |  //控件自行绘制，而不使用操作系统的绘制
          ControlStyles.AllPaintingInWmPaint | //忽略擦出的消息，减少闪烁。
          ControlStyles.OptimizedDoubleBuffer |//在缓冲区上绘制，不直接绘制到屏幕上，减少闪烁。
          ControlStyles.ResizeRedraw | //控件大小发生变化时，重绘。                  
          ControlStyles.SupportsTransparentBackColor, true);//支持透明背景颜色

            base.BackColor = Color.FromArgb(0, 0, 0, 0);
            BackColor = Color.Gray;
            ThemeColor = LSkinTheme.ThemeColor;

            ForeColor = LSkinTheme.ForeColor;
            Font = LSkinTheme.Font;
        }

        Color themeColor = Color.FromArgb(232, 60, 60);



        Rectangle roundRec;

        /// <summary>
        /// 数据返回事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="value">当前值</param>
        /// <param name="ratio">当前进度百分比 1-100</param>
        public delegate void ValueChangeEvent(object sender, int value, int ratio);

        [Description("当用户在UI层操作控件进度时发生的事件")]
        public event ValueChangeEvent UserValueChange;

        Point mousePoint;
        private bool mouseDown = false;

        Color backColor;
        [Description("背景颜色")]
        public new Color BackColor
        {

            get
            {
                return backColor;
            }

            set
            {
                backColor = value;
                Invalidate();
            }

        }

        [Description("主题颜色")]
        public Color ThemeColor
        {
            get
            {
                return themeColor;
            }
            set
            {
                themeColor = value;
                Invalidate();
            }

        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            mousePoint = e.Location;
            if (roundRec.Contains(e.Location))
            {
                Cursor = Cursors.Hand;

                if (mouseDown)
                {
                    Invalidate();
                }

            }
            else
            {
                Cursor = Cursors.Default;
            }
            mouseHover = true;
        }




        int maxNum = 100;
        [Description("最大值")]
        public int Maximum
        {
            set
            {
                maxNum = value;
                Invalidate();
            }
            get => maxNum;
        }

        int valueNum = 0;
        /// <summary>
        /// 记录上一次的值
        /// </summary>
        int upVlaue = 0;
        [Description("当前进度值")]
        public int Value
        {
            get => valueNum;
            set
            {
                if (value < 0 || value > maxNum) return;
                valueNum = value;
                if (mouseDown && AsyncData)
                {

                    if (upVlaue != value)
                    {
                        BackData();
                        upVlaue = value;
                    }
                }

                Invalidate();

            }
        }

        /// <summary>
        /// 进度百分比
        /// </summary>
        int ratio = 0;

        bool asyncData = false;
        [Description("是否实时返回数据")]
        public bool AsyncData
        {

            get
            {
                return asyncData;
            }
            set
            {

                asyncData = value;
            }
        }


        bool asyncShowIcon = true;

        [Description("实时显示进度拖动控件（小图标:小圆圈）")]
        public bool AsyncShowIcon
        {

            get
            {
                return asyncShowIcon;
            }
            set
            {

                asyncShowIcon = value;
                Invalidate();
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            mousePoint = e.Location;
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;
                Invalidate();
            }
            base.OnMouseDown(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseDown = false;
                BackData();
            }
            base.OnMouseUp(e);

        }


        /// <summary>
        /// 返回数据给用户
        /// </summary>
        private void BackData()
        {


            if (valueNum > 0)
            {
                ratio = Convert.ToInt32(valueNum * 1.0 / Maximum * 100);

            }
            else
            {
                ratio = 0;
            }

            if (UserValueChange != null)
            {
                UserValueChange(this, valueNum, ratio);
            }
        }

        bool mouseHover = false;


        protected override void OnMouseLeave(EventArgs e)
        {

            mouseHover = false;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawTool.Optimization(e.Graphics); //优化绘画效果

            int offset = Convert.ToInt32((Height - Height * 0.25) / 2.0);

            int margin = Convert.ToInt32(Height / 2.0);

            int pointX = Convert.ToInt32((Width - margin * 2.0) / Maximum * 1.0 * valueNum * 1.0);


            var Back_Fore_REC = DrawTool.ConvertRectangle(new Rectangle(0, 0, Width, Height), new Padding(-margin, Convert.ToInt32(-margin * 0.7), -margin, Convert.ToInt32(-margin * 0.7)));

            int radius = Back_Fore_REC.Height;

            var gpp = DrawTool.DrawRectangle(Back_Fore_REC, radius);


            e.Graphics.FillPath(new SolidBrush(backColor), gpp);



            if (valueNum > 0)
            {

                Back_Fore_REC.Width = pointX;
                gpp = DrawTool.DrawRectangle(Back_Fore_REC, radius);
                e.Graphics.FillPath(new SolidBrush(themeColor), gpp);
            }

            Bitmap bitmap = new Bitmap(Height, Height);//创建作图区域
            int x = 2;
            Graphics graphic = Graphics.FromImage(bitmap);
            DrawTool.Optimization(graphic);
            var icon = DrawTool.DrawRectangle(new Rectangle(0 + x, 0 + x, bitmap.Width - x * 2, bitmap.Height - x * 2), Width);
            graphic.FillPath(new SolidBrush(Color.White), icon);

            icon = DrawTool.DrawRectangle(new Rectangle(0 + x, 0 + x, bitmap.Width - x * 2, bitmap.Height - x * 2), Width);
            graphic.DrawPath(new Pen(Color.Gray), icon);
            int roundOffset = Convert.ToInt32((bitmap.Width - bitmap.Width * 0.25) / 2.0);
            icon = DrawTool.DrawRectangle(new Rectangle(0 + roundOffset, 0 + roundOffset, bitmap.Width - roundOffset * 2, bitmap.Width - roundOffset * 2), roundOffset); //中心小圆圈
            graphic.FillPath(new SolidBrush(themeColor), icon);

            roundRec = new Rectangle(new Point(pointX, 0), new Size(bitmap.Width, bitmap.Height));

            try
            {
                if (mouseDown)
                {
                    if (mousePoint.X <= 0 + margin)
                    {
                        Value = 0;
                    }
                    else if (mousePoint.X >= Width - margin)
                    {
                        Value = Maximum;
                    }
                    else
                    {
                        Value = Convert.ToInt32((mousePoint.X - margin) / ((Width - margin * 2.0) / Maximum * 1.0));
                    }
                }

                if (AsyncShowIcon)
                {
                    e.Graphics.DrawImage(bitmap, roundRec);
                }
                else if (mouseHover && asyncShowIcon == false)
                    e.Graphics.DrawImage(bitmap, roundRec);

                base.OnPaint(e);

            }
            catch (Exception)
            {
            }

        }

    }
}
