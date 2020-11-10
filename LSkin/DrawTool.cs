using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;


    /// <summary>
    /// 画圆角，颜色转换 工具类
    /// </summary>
    public static class DrawTool
    {

        /// <summary>
        /// 如何使用资源文件中的字体，无安装无释放
        /// </summary>
        /// <param name="bytes">资源文件中的字体文件,如Properties.Resources.华文行楷</param>
        /// <returns></returns>
        public static Font GetFontResoruce(byte[] bytes)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            IntPtr MeAdd = Marshal.AllocHGlobal(bytes.Length);
            Marshal.Copy(bytes, 0, MeAdd, bytes.Length);
            pfc.AddMemoryFont(MeAdd, bytes.Length);
            return new Font(pfc.Families[0], 15, FontStyle.Regular);
        }

        /// <summary>
        /// 根据字体文件路径获得字体
        /// </summary>
        /// <param name="fileName">文件路径</param>
        /// <param name="emSize">字体大小</param>
        /// <returns></returns>
        public static Font GetFont(string filePath, float emSize)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(filePath);//字体文件的路径
            Font f = new Font(pfc.Families[0].Name, emSize);
    
            return f;
        }

        /// <summary>
        /// 安装字体并返回字体对象
        /// </summary>
        /// <param name="fileName">字体文件路径</param>
        /// <returns></returns>
        public static Font Install(string fileName)
        {

            try
            {
                PrivateFontCollection font = new PrivateFontCollection();
                font.AddFontFile(fileName);//字体的路径及名字
                Font newFont = new Font(font.Families[0].Name,
                9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
                return newFont;
            }
            catch
            {
                return null;
            }
        }



        /// <summary>
        /// 优化图像效果
        /// </summary>
        /// <param name="g"></param>
        public static void Optimization(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;//抗锯齿
            g.PixelOffsetMode = PixelOffsetMode.Half;//高质量显示 抗锯齿
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;//高质量显示文本
            g.InterpolationMode = InterpolationMode.HighQualityBicubic; //高质量插值法
        }

        /// <summary>
        /// 调整矩形内边距
        /// </summary>
        /// <param name="rec"></param>
        /// <param name="padd"></param>
        /// <returns></returns>
        public static Rectangle ConvertRectangle(Rectangle rec, Padding padd)
        {

            Rectangle recX = rec;
            if (padd.Top != 0)
            {
                recX.Y -= padd.Top;
                recX.Height += padd.Top;
            }
            if (padd.Right != 0)
            {

                recX.Width += padd.Right;
            }

            if (padd.Bottom != 0)
            {
                recX.Height += padd.Bottom;
            }
            if (padd.Left != 0)
            {
                recX.X -= padd.Left;
                recX.Width += padd.Left;
            }

            //return new Rectangle(rec.X - (width), rec.Y - (width), rec.Width + (width * 2), rec.Height + (width * 2));

            return recX;

        }

        /// <summary>
        /// 颜色转换，变深或变浅
        /// </summary>
        /// <param name="color"></param>
        /// <param name="multiple">颜色浅的倍数</param>
        /// <returns></returns>
        public static Color ConvertColor(Color color, double multiple)
        {
            int r = Convert.ToInt32(color.R * multiple);
            int g = Convert.ToInt32(color.G * multiple);
            int b = Convert.ToInt32(color.B * multiple);

            if (multiple > 1)
            {
                return Color.FromArgb(r > 255 ? 255 : r, g > 255 ? 255 : g, b > 255 ? 255 : b);
            }
            else
            {
                return Color.FromArgb(r < 0 ? 0 : r, g < 0 ? 0 : g, b < 0 ? 0 : b);
            }



        }

        /// <summary>
        /// 测量字符的宽高
        /// </summary>
        /// <param name="g"></param>
        /// <param name="font"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        public static Size GetFontSize(Graphics g, Font font, string str)
        {
            SizeF size = g.MeasureString(str, font);//测量字符串的宽高;
            return new Size((int)size.Width, (int)size.Height);
        }

        /// <summary>
        /// 画一个矩形
        /// </summary>
        /// <param name="g"></param>
        /// <param name="rec">位置</param>
        /// <param name="radius">锐角</param>
        /// <returns></returns>
        public static GraphicsPath DrawRectangle(Rectangle rec, int radius)
        {


            

            int width = rec.Width;
            int height = rec.Height;

            if (width < height && radius > width) radius = width;
            if (height < width && radius > height) radius = height;


            int x = rec.X;
            int y = rec.Y;
            var gpp = new GraphicsPath();

            if (radius <= 0)
            {
                gpp.AddRectangle(rec);
                return gpp;
            }

            if (width == height && radius * 2 >= width)
            {
                gpp.AddEllipse(rec);
                return gpp;
            }
            if (!(width == height) || (width == height && radius * 2 <= width))
            {
                gpp = DrawRectangleRound(rec, radius);
                return gpp;
            }



            return gpp;
        }

        private static GraphicsPath DrawRectangleRound(Rectangle rect, int radius)
        {
            int diameter = radius;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();
            //   左上角      
            path.AddArc(arcRect, 180, 90);
            //   右上角      
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);
            //   右下角      
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);
            //   左下角      
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();
            return path;
        }
    }




    //
    // 摘要:
    //     指定的绘图图面上的内容对齐方式。 用于字符
    public static class StringFormatX
    {
        /// <summary>
        ///   内容是在顶部，垂直对齐和水平方向上左对齐。
        /// </summary>
        public static StringFormat TopLeft = new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Near };


        /// <summary>
        ///  内容是在顶部，垂直对齐和水平方向上居中对齐。
        /// </summary>
        public static StringFormat TopCenter = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Near };

        /// <summary>
        ///  内容是在顶部，垂直对齐和水平方向上右对齐。
        /// </summary>
        public static StringFormat TopRight = new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Near };

        /// <summary>
        /// 内容是在中间，垂直对齐和水平方向上左对齐。
        /// </summary>
        public static StringFormat MiddleLeft = new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center };

        /// <summary>
        /// 内容是在中间，垂直对齐和水平方向上居中对齐。
        /// </summary>
        public static StringFormat MiddleCenter = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };

        /// <summary>
        ///  内容是在中间，垂直对齐和水平方向上右对齐。
        /// </summary>
        public static StringFormat MiddleRight = new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Center };

        /// <summary>
        /// 内容是在底部，垂直对齐和水平方向上左对齐。
        /// </summary>
        public static StringFormat BottomLeft = new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Far };

        /// <summary>
        /// 内容是在底部，垂直对齐和水平方向上居中对齐。
        /// </summary>
        public static StringFormat BottomCenter = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Far };

        /// <summary>
        /// 内容是在底部，垂直对齐和水平方向上右对齐。
        /// </summary>
        public static StringFormat BottomRight = new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Far };
    }
    public static class MathCount
    {
        //计算两点距离
        public static double countLength(Point p1, Point p2)
        {
            int width = p2.X - p1.X;
            int height = p2.Y - p1.Y;
            double result = (width * width) + (height * height);
            result = Math.Sqrt(result);//根号
            return result;
        }
        /// <summary>
        /// 两点之间计算中点
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static Point countMidPoint(Point p1, Point p2)
        {
            return new Point((int)(p1.X + p2.X) / 2, (int)(p1.Y + p2.Y) / 2);
        }

        /// <summary>
        /// 根据三点求圆的坐标，高宽
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        /// <returns></returns>

        /// <summary>
        /// 计算直线的类
        /// </summary>
    }
