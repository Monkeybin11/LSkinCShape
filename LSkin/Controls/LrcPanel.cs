using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing.Drawing2D;
using System.Drawing.Text;


namespace LSkin
{
    public partial class LrcPanel : PanelX
    {

        int offsetY = 0;
        List<Lrc> LrcList = new List<Lrc>();
        /// <summary>
        /// 当前进度歌词
        /// </summary>
        Lrc LrcNow = new Lrc();

        /// <summary>
        /// 当鼠标悬浮在某个歌词行的时候触发的对象
        /// </summary>
        public Lrc MouseOnLrc = null;

        /// <summary>
        /// 启用&关闭 歌词文字边框
        /// </summary>
        private bool showFontFrame = false;
        /// <summary>
        /// 上下居中的Y坐标值
        /// </summary>
        int VerticalCenter = 0;
        /// <summary>
        /// 负责上下滚动的计时器动画
        /// </summary>


        Color fousColor = Color.FromArgb(250, 218, 131);
        /// <summary>
        /// 当前正在播放的歌词颜色
        /// </summary>
        public Color FousColor
        {
            get => fousColor;

            set
            {
                fousColor = value;
                Invalidate();
            }

        }
        SizeF fontSize; //测量字符串的宽高;
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            FontHeight = DrawTool.GetFontSize(this.CreateGraphics(), Font, "测ABC").Height;
            fontSize = DrawTool.GetFontSize(CreateGraphics(), Font, "测ABC");//测量字符串的宽高;
            Invalidate();
        }


        private int marginVertical = 40;
        /// <summary>
        /// 歌词上下的边距
        /// </summary>
        public int MarginVertical
        {
            get
            {
                return marginVertical;
            }

            set
            {
                marginVertical = value;
                initData();

                Invalidate();
            }
        }


        bool tmpLine = false;


        StringFormat LrcAlign = StringFormatX.MiddleCenter;
        ContentAlignment textAlgin = ContentAlignment.MiddleCenter;

        /// <summary>
        /// 歌词对其方式 (0:靠左 1:中间 2:右边)
        /// </summary>
        public ContentAlignment TextAlign
        {
            get => textAlgin;
            set
            {


                switch (value)
                {

                    case ContentAlignment.MiddleLeft:
                        textAlgin = value;
                        LrcAlign = StringFormatX.MiddleLeft;
                        Invalidate();
                        break;
                    case ContentAlignment.MiddleCenter:
                        textAlgin = value;
                        LrcAlign = StringFormatX.MiddleCenter;
                        Invalidate();
                        break;
                    case ContentAlignment.MiddleRight:
                        LrcAlign = StringFormatX.MiddleRight;
                        textAlgin = value;
                        Invalidate();
                        break;
                }


            }
        }





        /// <summary>
        /// 鼠标单击了歌词行，返回对象 ：sender: LrcPanel-> MouseOnLrc
        /// </summary>
        public event EventHandler ClickLrcEvent;
        /// <summary>
        /// 当鼠标悬浮在某个歌词行的时候触发的事件，sender: LrcPanel-> MouseOnLrc
        /// </summary>
        public event EventHandler MouseHoverLrcEvent;

        ListX<string> lrcsTemp = new ListX<string>();
        public ListX<string> LrcsList
        {

            get { return lrcsTemp; }

            set
            {
                lrcsTemp = value;
            }

        }


        Point MousePoint;
        public LrcPanel()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.DoubleBuffered = true;
            this.MouseMove += new MouseEventHandler(MouseMoveEvent);
            this.MouseDown += new MouseEventHandler(MouseDownEvent);
            this.MouseUp += new MouseEventHandler(MouseUpEvent);

            ForeColor = Color.FromArgb(254, 254, 254);


            lrcsTemp.AddHandler += lrcAdd;

        }


        private void initData()
        {
            Clear();
            //[00:30.10]看这沉默不语的世界
            List<string> list = new List<string>();

            list.Add("[00:00.00]听音乐 享生活");
            list.Add("[00:00.10]作者QQ:1512637782");
            list.Add("[00:00.20]邮箱:1512637782@qq.com");

            LoadLrc(list);

        }


        private void lrcAdd(object sender, EventArgs e)
        {
            Clear();
            List<string> tmps = new List<string>();
            foreach (var item in lrcsTemp)
            {
                tmps.Add(item.ToString());
            }
            LoadLrc(tmps);
        }

        private void MouseUpEvent(object sender, MouseEventArgs e)
        {
            tmpLine = false;
            this.Invalidate();
        }

        private void MouseDownEvent(object sender, MouseEventArgs e)
        {
            MousePoint = e.Location;
            if (ClickLrcEvent != null && MouseOnLrc != null)
            {
                tmpLine = true;
                ClickLrcEvent(MouseOnLrc, e);
            }
        }

        bool overlap = false;//是否移动到某一个图形的控制点;

        private void MouseMoveEvent(object sender, MouseEventArgs e)
        {
            overlap = false;
            Lrc tmp = null;
            foreach (Lrc item in LrcList)
            {
                //if ((e.X > item.FontRectangle.X && e.X < item.FontRectangle.X + item.FontRectangle.Width) && (e.Y > item.FontRectangle.Y && e.Y < item.FontRectangle.Y + FontHeight))
                if (item.FontRectangle.Contains(e.Location))
                {
                    overlap = true;
                    tmp = item;
                    break;
                }
            }

            if (overlap)
            {
                if (MouseOnLrc == tmp)
                {
                    return;
                }
                MouseOnLrc = tmp;
                Cursor = Cursors.Hand;
                if (MouseHoverLrcEvent != null) MouseHoverLrcEvent(this, e);

            }
            else
            {
                MouseOnLrc = null;
                Cursor = Cursors.Default;
            }

            //if (tmpLine)
            //{

            //    foreach (Lrc item in LrcList)
            //    {

            //        int offsetY = e.Y - item.point.Y;
            //        item.point.Y += offsetY;

            //    }

            //    //LrcNow.point.Y += e.Y - LrcNow.point.Y;
            //}

        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        public bool ShowFontFrame
        {
            get => showFontFrame;

            set
            {
                showFontFrame = value;
                Invalidate();
            }

        }

        Dictionary<double, byte> Temp = new Dictionary<double, byte>();

        //System.Threading.Timer AnimationTick;
        Timer AnimationTick;

        /// <summary>
        /// 加载歌词文件并且布局到LrcPanel
        /// </summary>
        /// <param name="fileName">歌词文件路径</param>
        public void LoadLrc(string fileName)
        {
            if (AnimationTick != null) AnimationTick.Dispose();
            this.Clear();
            StreamReader sr = new StreamReader(fileName, Encoding.UTF8);
            List<string> lrc = new List<string>();
            while (true)
            {
                string l = sr.ReadLine();
                lrc.Add(l);
                if (l == null) break;
            }
            sr.Close();
            lrc.Remove(string.Empty);
            lrc.Remove("");
            lrc.Remove(null);
            LoadLrc(lrc);
        }




        private void LoadLrc(List<string> lrc)
        {
            VerticalCenter = this.Height / 2 - (MarginVertical + FontHeight) / 2;
            //Regex reg2 = new Regex("\\[\\d{2}:\\d{2}.\\d{2}\\]");
            //Console.WriteLine(reg2.Match(item).Value);

            //Regex regeTime = new Regex("[0-9]+:[0-9]+");
            //Regex regText = new Regex(@"(?:\[[^\]]*\]|<[^>]*>)");

            //string time = regeTime.Match(item).Value;
            //string text = Regex.Replace(item, @"(?:\[[^\]]*\]|<[^>]*>)", ""); 

            //key：时间 value:歌词

            Regex regeTime = new Regex("[0-9]+:[0-9]+.[0-9]+");//提取歌词时[00:11:22]间 表达式
            Regex regeTime2 = new Regex("[0-9]+:[0-9]+");//提取歌词时[00:11]间 表达式

            Regex regText = new Regex(@"(?:\[[^\]]*\]|<[^>]*>)");//提取歌词文字 表达式

            foreach (string item in lrc)
            {
                //如果符合歌词标准 [00:00.00]
                if (Regex.IsMatch(item, "\\[\\d{2}:\\d{2}.\\d{2}\\]"))
                {
                    string timeStr = regeTime.Match(item).Value;//时间
                    string text = Regex.Replace(item, @"(?:\[[^\]]*\]|<[^>]*>)", "");//歌词
                    int fen = Convert.ToInt32(timeStr.Substring(0, 2));
                    double miao = Convert.ToDouble(timeStr.Substring(3, 5)) * 1000;

                    double postion = (int)(fen * 60 * 1000 + miao);

                    postion = Math.Floor(postion / 100);

                    if (Temp.ContainsKey(postion))
                    {
                        postion += 10;
                    }
                    else
                    {
                        Temp.Add(postion, 0);
                    }

                    //垂直坐标递增
                    this.LrcList.Add(new Lrc(postion, regeTime2.Match(item).Value, text, new Point(0, VerticalCenter)));
                    VerticalCenter += (FontHeight + MarginVertical);
                }

            }
            Temp.Clear();

            if (this.LrcList.Count > 0)
            {

                AnimationTick = new Timer();
                AnimationTick.Interval = 1;
                AnimationTick.Tick += new EventHandler(Animation_Tick);
                AnimationTick.Start();

                ChangePostion(this.LrcList[0].PostionDouble);//如果有一句歌词默认是第一句歌词变色

            }
        }

        /// <summary>
        /// 清除所有歌词
        /// </summary>
        public void Clear()
        {
            LrcList.Clear();
            VerticalCenter = this.Height / 2 - (MarginVertical + FontHeight) / 2;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;//消除锯齿
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;//高质量显示
            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;//最高质量显示文本
            if (tmpLine)
            {
                e.Graphics.DrawLine(Pens.White, new Point(0, VerticalCenter + FontHeight / 2), new Point(this.Width, VerticalCenter + FontHeight / 2));
            }
            foreach (var item in LrcList)
            {
                Lrc lrc = item as Lrc;


                //  fontSize = DrawTool.GetFontSize(CreateGraphics(), Font, "测ABC");//测量字符串的宽高;
                Rectangle rectangle = new Rectangle(lrc.point.X, lrc.point.Y, this.Width, (int)fontSize.Height + 2);

                Rectangle drawRec = new Rectangle(0 - 5, Convert.ToInt32(marginVertical / 2), Width + 10, Height - Convert.ToInt32(marginVertical / 2));


                if (ShowFontFrame) //画出字符可以可绘画区域轮廓
                {
                    lrc.FontRectangle = new Rectangle(this.Width / 2 - (int)fontSize.Width / 2, lrc.point.Y, (int)fontSize.Width, (int)fontSize.Height);
                    e.Graphics.DrawRectangle(Pens.Red, lrc.FontRectangle);

                    e.Graphics.DrawRectangle(Pens.Blue, drawRec);
                    e.Graphics.DrawRectangle(Pens.Red, rectangle);

                }

                if (drawRec.Contains(rectangle))
                { //包含在此区域内的歌词才可以绘制

                    //     e.Graphics.DrawString(lrc.text, font, pen, rectangle, LrcAlign);

                    if (LrcNow == lrc)
                    {
                        Font nowFont = new Font(Font.FontFamily, Font.Size + 1F);
                        rectangle = DrawTool.ConvertRectangle(rectangle, new Padding(3));
                        e.Graphics.DrawString(lrc.text, nowFont, new SolidBrush(fousColor), rectangle, LrcAlign);
                    }
                    else
                    {
                        e.Graphics.DrawString(lrc.text, Font, new SolidBrush(ForeColor), rectangle, LrcAlign);
                    }

                }



            }
        }
        /// <summary>
        /// 传入进度时间滚动到所在时间的位置
        /// </summary>
        /// <param name="postion">时间/秒</param>
        public void ChangePostion(double postion)
        {
            postion = Math.Floor(postion / 100);
            foreach (Lrc item in LrcList)
            {
                if (item.PostionDouble / 100 == postion)
                {
                    LrcNow = item;
                    break;
                }
            }
            VerticalCenter = this.Height / 2 - (MarginVertical + FontHeight) / 2;
            offsetY = LrcNow.point.Y - VerticalCenter;

            if (AnimationTick != null) AnimationTick.Start();
        }
        public void Animation_Tick(object sender, EventArgs e)
        {
            offsetY = LrcNow.point.Y - VerticalCenter;
            if (Math.Abs(offsetY) <= 2)
            {
                AnimationTick.Stop();
                return;
            }
            foreach (var item in LrcList)
            {
                Lrc lrc = item;

                if (offsetY < 0)
                {
                    lrc.point.Y += 2;
                }
                else
                {
                    lrc.point.Y -= 2;
                }
            }
            this.Invalidate();
        }
    }
    public class Lrc
    {
        public string text;
        public Point point;
        private double postionDouble;
        public string postionSting;
        //  public int postion;
        public Lrc(double postionInt, string timeStr, string text, Point point)
        {
            this.postionSting = timeStr;
            this.PostionDouble = postionInt;
            this.text = text;
            this.point = point;
        }

        /// <summary>
        /// 歌词文字边框的参数
        /// </summary>
        public Rectangle FontRectangle;
        /// <summary>
        /// 歌词进度，毫秒
        /// </summary>
        public double PostionDouble
        {
            get
            {
                return postionDouble * 100;
            }

            set
            {
                postionDouble = value;
            }
        }

        public Lrc()
        {
        }
    }


    /// <summary>
    /// 歌词样式类
    /// </summary>
    public class StyleLrc
    {
        private Font font;
        private Color pen;
        public Brush brush;

        public int FontHeight = 0;

        public Color fontColor
        {
            get
            {
                return pen;
            }
            set
            {
                pen = value;
                brush = new SolidBrush(pen);
            }
        }

        public Font Font
        {
            get
            {
                return font;
            }

            set
            {
                font = value;

                //创建新图位图
                Bitmap bitmap = new Bitmap(1, 1);
                //创建作图区域
                Graphics graphic = Graphics.FromImage(bitmap);
                SizeF sizeF = graphic.MeasureString("你好，世界", font);//测量字符串的宽高;
                FontHeight = (int)sizeF.Height;
                graphic.Dispose();
                bitmap.Dispose();
            }
        }

        public StyleLrc(Font font, Color fontColor)
        {
            this.Font = font;
            this.fontColor = fontColor;
        }
    }
}
