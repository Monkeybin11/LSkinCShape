using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MusicPlay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }
      

        private void Draw(Rectangle rectangle, Graphics g, int _radius, bool cusp, Color begin_color, Color end_color)
        {


            int span = 2;
            //抗锯齿
            g.SmoothingMode = SmoothingMode.AntiAlias;
            //渐变填充
            LinearGradientBrush myLinearGradientBrush = new LinearGradientBrush(rectangle, begin_color, end_color, LinearGradientMode.Vertical);
            //画尖角
            if (cusp)
            {
                span = 10;
                PointF p1 = new PointF(rectangle.Width - 12, rectangle.Y + 10);
                PointF p2 = new PointF(rectangle.Width - 12, rectangle.Y + 30);
                PointF p3 = new PointF(rectangle.Width, rectangle.Y + 20);
                PointF[] ptsArray = { p1, p2, p3 };
                g.FillPolygon(myLinearGradientBrush, ptsArray);
            }
            //填充
            g.FillPath(myLinearGradientBrush, DrawRoundRect(rectangle.X, rectangle.Y, rectangle.Width - span, rectangle.Height - 1, _radius));
        }
        public static GraphicsPath DrawRoundRect(int x, int y, int width, int height, int radius)
        {
            //四边圆角
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(x, y, radius, radius, 180, 90);
            gp.AddArc(width - radius, y, radius, radius, 270, 90);
            gp.AddArc(width - radius, height - radius, radius, radius, 0, 90);
            gp.AddArc(x, height - radius, radius, radius, 90, 90);
            gp.CloseAllFigures();
            return gp;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.ClipRectangle, e.Graphics, 18, true, Color.FromArgb(90, 143, 0), Color.FromArgb(41, 67, 0));
            base.OnPaint(e);
            Graphics g = e.Graphics;
        //    g.DrawString("其实我是个Panel", new Font("微软雅黑", 9, FontStyle.Regular), new SolidBrush(Color.White), new PointF(10, 10));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.ClipRectangle, e.Graphics, 18, false, Color.FromArgb(113, 113, 113), Color.FromArgb(0, 0, 0));
            base.OnPaint(e);
            Graphics g = e.Graphics;
       //     g.DrawString("其实我是个Panel", new Font("微软雅黑", 9, FontStyle.Regular), new SolidBrush(Color.White), new PointF(10, 10));
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.ClipRectangle, e.Graphics, 18, false, Color.FromArgb(0, 122, 204), Color.FromArgb(8, 39, 57));
            base.OnPaint(e);
            Graphics g = e.Graphics;
            //g.DrawString("其实我是个按钮", new Font("微软雅黑", 9, FontStyle.Regular), new SolidBrush(Color.White), new PointF(10, 10));
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.ClipRectangle, e.Graphics, 18, false, Color.FromArgb(210, 210, 210), Color.FromArgb(242, 242, 242));
            base.OnPaint(e);

            Graphics g = e.Graphics;
        //    g.DrawString("其实我是Label", new Font("微软雅黑", 9, FontStyle.Regular), new SolidBrush(Color.Black), new PointF(10, 10));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.VerticalScroll.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelX1.Controls.Add(button1);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Text = this.VerticalScroll.Maximum+"_"+ this.VerticalScroll.Minimum+ "_"+this.VerticalScroll.Value+"_"+ this.VerticalScroll.LargeChange;
        }


    }
}