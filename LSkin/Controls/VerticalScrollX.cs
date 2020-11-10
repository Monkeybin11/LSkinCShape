using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace LSkin
{
    /// <summary>
    /// 垂直滚动条
    /// </summary>
    public class VerticalScrollX : PanelX
    {

        public VerticalScrollX()
        {
            this.SetStyle(
  ControlStyles.UserPaint |  //控件自行绘制，而不使用操作系统的绘制
  ControlStyles.AllPaintingInWmPaint | //忽略擦出的消息，减少闪烁。
  ControlStyles.OptimizedDoubleBuffer |//在缓冲区上绘制，不直接绘制到屏幕上，减少闪烁。
  ControlStyles.ResizeRedraw | //控件大小发生变化时，重绘。                  
  ControlStyles.SupportsTransparentBackColor, true);//支持透明背景颜色
            base.BackColor = Color.FromArgb(0, 0, 0, 0);



        }


        ScrollableControl scollControl = null;

        [Description("绑定可滚动的控件")]
        public ScrollableControl ScollControl
        {
            get => scollControl;
            set
            {

                if (value != null && value.GetType() == typeof(VerticalScrollX))
                {
                    MessageBox.Show("无效的控件!");
                    return;
                }

                if (value != null)
                {
                    scollControl = value;

                    scollControl.Scroll += ScollControl_Scroll;
                    scollControl.MouseWheel += ScollControl_MouseWheel;
                    scollControl.VisibleChanged += ScollControl_VisibleChanged;
                    scollControl.SizeChanged += ScollControl_VisibleChanged;
                    scollControl.ControlAdded += ScollControl_ControlAdded;
                    scollControl.ControlRemoved += ScollControl_ControlAdded;

                    ScrollRefresh();
                }

            }
        }

        private void ScollControl_ControlAdded(object sender, ControlEventArgs e)
        {
            Invalidate();
        }

        private void ScollControl_VisibleChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void ScollControl_MouseWheel(object sender, MouseEventArgs e)
        {
            ScrollRefresh();
        }


        public void ScrollRefresh()
        {
            Invalidate();
        }

        private void ScollControl_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollRefresh();
        }


        int tmpY = -1;
        protected override void OnMouseMove(MouseEventArgs e)
        {


            if (mouseDown)
            {

                int dy = e.Y - mousePoint.Y;
                ScollMaxH = Height - ScollHeight;
                mousePoint.Y = e.Y;

                ScollY += dy;

                if (ScollY < 0)
                {
                    ScollY = 0;
                    dy = 0;
                }


                else if (ScollY > ScollMaxH)
                {
                    ScollY = Height - ScollHeight;
                    dy = 0;
                }
                else
                {

                    if (tmpY == ScollY) return;
                    Invalidate();
                    tmpY = ScollY;

                    if (scollControl != null)
                    {
                        int heightX = Height - ScollHeight;
                        int scrollHeightX = scollControl.VerticalScroll.Maximum - scollControl.VerticalScroll.LargeChange;
                        //0~heightX
                        //0~scrollHeightX
                        scollControl.VerticalScroll.Value = (int)(scrollHeightX * 1.0 / heightX * ScollY);
                    }
                }

            }
            base.OnMouseMove(e);
        }
        [Description("滚动条宽度")]
        public int ScollWdith
        {
            get => scollWdith;

            set
            {
                scollWdith = value;
                Invalidate();
            }


        }
        int ScollMaxH = 0;

        Rectangle ScollRec;
        int scollWdith = 10;
        int ScollHeight = 0;
        int ScollY = 0;


        private void DrawScoll(PaintEventArgs e)
        {
            //0~heightX
            //0~scrollHeightX
            //   ScollY = (int)(scollControl.VerticalScroll.Value * 1.0 / scrollHeightX * heightX);
            if (!DebugTool.IsDesignMode && scollControl.VerticalScroll.Maximum <= scollControl.Height) return;


            ScollHeight = Convert.ToInt32(Height * 1.0 / scollControl.VerticalScroll.Maximum * scollControl.VerticalScroll.LargeChange);

            if (mouseDown)
            {
                ScollHeight = Convert.ToInt32(Height * 1.0 / scollControl.VerticalScroll.Maximum * scollControl.VerticalScroll.LargeChange);
                ScollRec = new Rectangle((Width - scollWdith), ScollY, scollWdith, ScollHeight);
            }
            else
            {

                int heightX = Height - ScollHeight;
                int scrollHeightX = scollControl.VerticalScroll.Maximum - scollControl.VerticalScroll.LargeChange;

                ScollY = (int)(scollControl.VerticalScroll.Value * 1.0 / scrollHeightX * heightX);
                ScollHeight = Convert.ToInt32(Height * 1.0 / scollControl.VerticalScroll.Maximum * scollControl.VerticalScroll.LargeChange);
                ScollRec = new Rectangle((Width - scollWdith), ScollY, scollWdith, ScollHeight);
            }

            GraphicsPath gpp = DrawTool.DrawRectangle(DrawTool.ConvertRectangle(ScollRec, new Padding(-1)), scollWdith);

            if (mouseDown)
            {
                e.Graphics.FillPath(new SolidBrush(DrawTool.ConvertColor(BackColor, 0.75)), gpp);

            }
            else {
                e.Graphics.FillPath(new SolidBrush(DrawTool.ConvertColor(BackColor, 0.88)), gpp);

            }

        }

        bool mouseDown = false;
        Point mousePoint;
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (ScollRec.Contains(e.Location))
            {
                mouseDown = true;
                mousePoint = e.Location;
            }

            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            mouseDown = false;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            DrawTool.Optimization(e.Graphics);

            DrawScoll(e);

        }



    }
}
