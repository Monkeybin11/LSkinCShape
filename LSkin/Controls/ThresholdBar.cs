using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;


namespace LSkin
{
    public partial class ThresholdBar : PanelX
    {


        public ThresholdBar()
        {
            
            p.DashStyle = DashStyle.Dot;
            timer.Interval = 500;
            timer.Tick += new EventHandler(timer_Tick);
        }


        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();


        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private Color lineColor = Color.Red;
        [Description("颜色")]
        public Color LineColor
        {

            get
            {
                return lineColor;
            }
            set
            {
                lineColor = value;
                this.Invalidate();
            }
        }

        private int maxValue;
        //protected override void OnLoad(EventArgs e)
        //{
        //    initData();
        //}

        public delegate void callback(object sender, int threshold1, int threshold2);
        [Description("返回阈值")]
        public event callback EventcallBackParam;
        PointF[] points1 = new PointF[2];
        PointF[] points2 = new PointF[2];
        Pen p = new Pen(Color.Red, 2);

        Dictionary<Point, Point> list = new Dictionary<Point, Point>();

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            p.Color = lineColor;
            e.Graphics.DrawLine(p, new Point(5, this.Height / 2), new Point(this.Width - 5, this.Height / 2));
            e.Graphics.DrawLines(Pens.Green, points1);
            e.Graphics.DrawLines(Pens.Red, points2);
        }
     
        public void initData()
        {
            points1[0] = new Point(5, 0);
            points1[1] = new Point(5, this.Height);

            points2[0] = new Point(this.Width - 5, 0);
            points2[1] = new Point(this.Width - 5, this.Height);


            if (MinValue > 0 && MaxValue > 0) {


            }

            this.Invalidate();
        }

        bool isMouseDown = false;
        Point mousePoint;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            isMouseDown = true;
            mousePoint = e.Location;

            if (Math.Abs(e.X - points1[0].X) < 5)
            {
                lockIndex = 0;
            }
            if (Math.Abs(e.X - points2[0].X) < 5)
            {
                lockIndex = 1;
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            isMouseDown = false;
            lockIndex = -1;
        }
      
        int lockIndex = -1;

        double fistValue = 0;
        double lastValue = 0;

        [Description("阈值长度值")]
        public int ValueLength
        {
            get
            {
                return maxValue;
            }

            set
            {
                maxValue = value;
            }
        }

        [Description("最小阈值")]
        public double MinValue
        {
            set
            {
                

                if (value <= 0 || ValueLength<=0) {
                    points1[0] = new Point(5, 0);
                    points1[1] = new Point(5, this.Height );
                    this.Invalidate();
                    return;
                }

                fistValue = value;
            
                double bili = ValueLength * 1.0 / (this.Width - 10);

                int location = Convert.ToInt32(value / bili);

                points1[0] = new Point(location+5, 0);
                points1[1] = new Point(location+5, this.Height);

          

                this.Invalidate();
            }
            get
            {
                return fistValue;
            }

        }

        [Description("最大阈值")]
        public double MaxValue
        {
            set
            {
                if (value <= 0 || ValueLength <= 0)
                {
                    initData();
                    return;
                }

                lastValue = value;

                double bili = ValueLength * 1.0 / (this.Width - 10);

                int location = Convert.ToInt32(value / bili);

                points2[0] = new Point(location+ 5, 0);
                points2[1] = new Point(location+ 5, this.Height);

                this.Invalidate();
            }
            get
            {
                return lastValue;
            }

        }


        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (lockIndex == -1) this.Cursor = Cursors.Default;

            if (!isMouseDown) return;

            if (lockIndex == 0)
            {
                this.Cursor = Cursors.Cross;

                points1[0].X = e.X;
                points1[1].X = e.X;

                if (e.X > points2[0].X)
                {
                    points2[0].X = points1[0].X + 1;
                    //points2[0].Y = points1[0].Y + 1;

                    points2[1].X = points1[1].X + 1;
                    //points2[1].Y = points1[1].Y + 1;
                }

            }

            if (lockIndex == 1)
            {
                this.Cursor = Cursors.Cross;
                points2[0].X = e.X;
                points2[1].X = e.X;


                if (e.X < points1[0].X)
                {
                    points1[0].X = points2[0].X - 1;
                    //points1[0].Y = points2[0].Y - 1;

                    points1[1].X = points2[1].X - 1;
                    //points1[1].Y = points2[1].Y - 1;
                }

            }

            if (points1[0].X <= 5)
            {

                points1[0].X = 5;
                points1[1].X = 5;
            }

            if (points2[0].X <= 5)
            {
                points2[0].X = 6;
                points2[1].X = 6;
            }


            if (points1[0].X >= this.Width - 5)
            {

                points1[0].X = this.Width - 6;
                points1[1].X = this.Width - 6;

                points2[0].X = this.Width - 5;
                points2[1].X = this.Width - 5;
            }



            if (points2[0].X >= this.Width - 5)
            {
                points2[0].X = this.Width - 5;
                points2[1].X = this.Width - 5;
            }


            fistValue = points1[0].X - 5;

            lastValue = points2[0].X - 5;

            fistValue = (Convert.ToDouble(ValueLength) / (this.Width - 10)) * fistValue;
            lastValue = (Convert.ToDouble(ValueLength) / (this.Width - 10)) * lastValue;

            this.Invalidate();
            timer.Start();
        }

 
        //int threshol1 = 0;
        //int threshol2 = 0;

        private void timer_Tick(object sender, EventArgs e)
        {

            if (EventcallBackParam != null) EventcallBackParam(this, Convert.ToInt32(fistValue), Convert.ToInt32(lastValue));
            timer.Stop();
        }


    }
}
