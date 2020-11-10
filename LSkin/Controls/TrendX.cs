using LSkin;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public partial class TrendX : PanelX
{
    public TrendX()
    {
        ThemeColor = LSkinTheme.ThemeColor;
        MaxTop = 500;
        data.AddHandler += valueChange;
        data.RemoveHandler += valueChange;
        Height = 200;
        Width = 300;
    }

    private void valueChange(object sender, EventArgs e)
    {
        Invalidate();
    }

    /// <summary>
    /// 数据集合
    /// </summary>
    /// 
    private ListX<TrendItem> data = new ListX<TrendItem>();

    /// <summary>
    /// 柱状图宽度
    /// </summary>
    private int recWidth = 40;



    /// <summary>
    /// 每个柱状图左边距
    /// </summary>
    private int marginLeft = 20;

    /// <summary>
    /// 获取或设置上限值
    /// </summary>
    private int maxTop = 100;

    /// <summary>
    /// 自动计算的上限值
    /// </summary>
    private int maxTopIntger = 0;

    /// <summary>
    /// 图像偏移多少像素
    /// </summary>
    private int imageLeft = 40;
    /// <summary>
    /// 显示多少个段落
    /// </summary>
    private int phase = 10;
    [Description("最大值")]
    public int MaxTop
    {
        get => maxTop; set
        {
            maxTop = value;
            if (maxTop < 50) maxTop = 50;
            ///自动化整
            string s = maxTop.ToString();
            int a = int.Parse(s.Substring(0, 1)) + 1;
            string z = a + "";
            for (int i = 0; i < s.Length - 1; i++)
            {
                z += "0";
            }
            maxTopIntger = int.Parse(z);
            Invalidate();
        }
    }

    [Description("节点集合")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] //添加这个属性 重新生成 集合数据不会消失
    public ListX<TrendItem> Items
    {
        get => data; set
        {
            data = value;
            Invalidate();
        }
    }
    public int RecWidth
    {
        get => recWidth; set
        {
            recWidth = value;
            Invalidate();
        }
    }
    public int MarginLeft
    {
        get => marginLeft; set
        {
            marginLeft = value;
            Invalidate();
        }
    }

    public int MaxTopInt
    {
        get => maxTopIntger;
    }
    public int ImageLeft
    {
        get => imageLeft; set
        {
            imageLeft = value;
            Invalidate();

        }
    }
    public int Phase
    {
        get => phase; set
        {
            phase = value;
            Invalidate();
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {

        base.OnPaint(e);
        int ImageW = Width - ImageLeft;
        int ImageH = Height - ImageLeft;
        if (ImageW <= 0 || ImageH <= 0) return;
        Bitmap b = new Bitmap(ImageW, ImageH);

        Graphics g = Graphics.FromImage(b);
        float LocationX = 0;
        //Height控件高度
        //Maxtop 传入的封顶高度
        double bili = b.Height * 1.0 / MaxTopInt;
        int textHeight = MaxTopInt / Phase;

        double marTop = 0;
        double h = ((textHeight * bili));

        //分成5段显示
        for (int i = 0; i < Phase + 1; i++)
        {
            RectangleF rec = new RectangleF(0, float.Parse(marTop + ""), ImageLeft, 30);
            if (i != 0)
            {
                if (i < Phase)
                {
                    g.DrawLine(new Pen(ThemeColor), new PointF(0, rec.Y), new PointF(b.Width, rec.Y));
                }
                rec.Y -= 15;
                e.Graphics.DrawString(MaxTopInt - textHeight * i + "", Font, new SolidBrush(ThemeColor), rec, StringFormatX.MiddleRight);
            }
            marTop += h;
        }

        // this.Controls.Clear();
        foreach (TrendItem item in Items)
        {
            float heig = float.Parse((item.Value * bili) + "");
            LocationX += MarginLeft;
            RectangleF recF = new RectangleF(LocationX, b.Height - heig, RecWidth, heig);

            if (AutoFlow)
            {
                recF.Width = (b.Width - ((Items.Count + 1) * MarginLeft)) / Items.Count;
            }


            Color c = Color.FromArgb(200, item.Color.R, item.Color.G, item.Color.B);
            g.FillRectangle(new SolidBrush(c), recF);

            //item.Location = new Point((int)recF.X+ imageLeft, (int)recF.Y);
            //item.Size = new Size((int)recF.Width, (int)recF.Height);
            //item.BackColor = item.Color;

            //this.Controls.Add(item);


            RectangleF textRec = new RectangleF(recF.X, recF.Y - 30, recF.Width, 30);


            if (recF.Height + 30 >= b.Height)
            {
                textRec.Y += 30;
                g.DrawString(item.Value + "", Font, new SolidBrush(Color.White), textRec, StringFormatX.MiddleCenter);
            }
            else
            {
                g.DrawString(item.Value + "", Font, new SolidBrush(ThemeColor), textRec, StringFormatX.BottomCenter);
            }

            Pen p = new Pen(ThemeColor);
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            LocationX += recF.Width;


            RectangleF textRecF = new RectangleF(ImageLeft + recF.X, b.Height + 2, recF.Width, ImageLeft - 4);

            //e.Graphics.FillRectangle(new SolidBrush(item.BorderColor), textRecF.X, textRecF.Y + imageLeft / 2 / 2, textRecF.Width, textRecF.Height - imageLeft /1);

            e.Graphics.FillRectangle(new SolidBrush(item.BorderColor), DrawTool.ConvertRectangle(new Rectangle((int)textRecF.X, (int)textRecF.Y, (int)textRecF.Width, (int)textRecF.Height), new Padding(0, -2, 0, -2)));

            e.Graphics.DrawString(item.Name, Font, new SolidBrush(Color.White), textRecF, StringFormatX.MiddleCenter);

        }

        e.Graphics.DrawImage(b, new Rectangle(ImageLeft, 0, b.Width, b.Height));
        e.Graphics.DrawRectangle(new Pen(ThemeColor), new Rectangle(ImageLeft, 0, b.Width, b.Height));

    }

}

public class TrendItem : Control
{
    private float value = 0;
    private Color color = Color.Black;
    private string name = "item";
    public float Value
    {
        get => value; set
        {

            this.value = value;
            Invalidate();
        }
    }
    public Color Color
    {
        get => color; set
        {
            color = value;
            Invalidate();
        }
    }
    public string Name
    {
        get => name; set
        {
            name = value;
            Invalidate();
        }
    }
    public Color BorderColor
    {
        get => borderColor; set
        {
            borderColor = value;
            Invalidate();
        }
    }

    Color borderColor = Color.Transparent;

}