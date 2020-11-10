using LSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

public class DataGridViewX : UserControl
{


    ListX<Header> colunms = new ListX<Header>();
    public DataGridViewX()
    {
        this.SetStyle(
                         ControlStyles.UserPaint |  //控件自行绘制，而不使用操作系统的绘制
                         ControlStyles.AllPaintingInWmPaint | //忽略擦出的消息，减少闪烁。
                         ControlStyles.OptimizedDoubleBuffer |//在缓冲区上绘制，不直接绘制到屏幕上，减少闪烁。
                      ControlStyles.ResizeRedraw | //控件大小发生变化时，重绘。                  
                         ControlStyles.SupportsTransparentBackColor, true);//支持透明背景颜色
        colunms.AddHandler += addHander;
        colunms.RemoveHandler += changeHander;
        Rows.AddHandler += AddRowHander;
        Rows.RemoveHandler += changeHander;
        BorderStyle = BorderStyle.FixedSingle;



    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

    }



    private void AddRowHander(object sender, EventArgs e)
    {
        DrawControl();
        DrawCell(sender as Cell[]);
    }

    public void DrawCell(Cell[] cell)
    {
        int ItemWidth = (Width - 0) / colunms.Count;
        Cell[] item = cell;
        UserControl userControl = new UserControl();
        userControl.Width = flowContent.Width - 17;
        int locationX = 0;
        userControl.Height = itemHeight;
        for (int i = 0; i < item.Length; i++)
        {
            Cell c = item[i];
            if (flowContent.Controls.Count % 2 != 0) //隔行变色
            {
                c.BackColor = Color.FromArgb(245, 245, 247);
                userControl.BackColor = Color.FromArgb(245, 245, 247);
            }
            else
            {
                c.BackColor = Color.White;
                userControl.BackColor = Color.White;
            }
            c.Width = ItemWidth;
            c.Height = itemHeight;
            c.Location = new Point(locationX, 0);
            c.Click += new EventHandler(aa);
            locationX += ItemWidth;
            userControl.Controls.Add(c);
        }
        userControl.Margin = new Padding(0, 0, 0, 0);
        userControl.Tag = flowContent.Width - userControl.Width;
        flowContent.Controls.Add(userControl);
    }

    private void addHander(object sender, EventArgs e)
    {

    }
    private void changeHander(object sender, EventArgs e)
    {

    }

    [Description("节点集合")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] //添加这个属性 重新生成 集合数据不会消失
    public ListX<Header> Colunms
    {
        get => colunms; set
        {
            colunms = value;
            Invalidate();
        }
    }

    [Description("节点集合")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] //添加这个属性 重新生成 集合数据不会消失
    public ListX<Cell[]> Rows
    {
        get => rows; set
        {
            rows = value;

        }
    }

    Panel flowP = null;
    FlowLayoutPanel flowContent = null;

    int itemHeight = 30;

    protected override void OnSizeChanged(EventArgs e)
    {
        base.OnSizeChanged(e);
        DrawData();
    }

    ListX<Cell[]> rows = new ListX<Cell[]>();


    private void DrawControl()
    {
        if (flowP == null)
        {
            flowP = new Panel();
            flowP.Dock = DockStyle.Top;
            flowP.Height = itemHeight;
            this.Controls.Add(flowP);
            flowContent = new FlowLayoutPanel();
            flowContent.Height = Height - flowP.Height;
            flowContent.BorderStyle = BorderStyle.None;
            flowContent.BackColor = Color.Gray;
            flowContent.AutoScroll = true;
            this.Controls.Add(flowContent);
            flowContent.BackColor = Color.White;
            flowContent.Width = Width;
            flowContent.Height = Height - itemHeight;
            flowContent.Location = new Point(0, itemHeight);
            flowContent.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
            flowContent.SizeChanged += FlowContent_SizeChanged;
            flowContent.FlowDirection = FlowDirection.LeftToRight;
            flowContent.WrapContents = true;
        }
    }

    private void FlowContent_SizeChanged(object sender, EventArgs e)
    {
        int ItemWidth = (Width - 0) / colunms.Count;
        foreach (Control item in flowContent.Controls)
        {
            item.Width = flowContent.Width - 20;
            int X = 0;

            foreach (Control it in item.Controls)
            {
                it.Width = ItemWidth;
                it.Location = new Point(X, 0);
                X += ItemWidth;
                it.Invalidate();
            }
        }
        flowContent.FlowDirection = FlowDirection.LeftToRight;
    }

    private void DrawData()
    {
        DrawControl();
        if (colunms.Count == 0) return;
        int ItemWidth = (Width - 0) / colunms.Count;

        flowP.Controls.Clear();
        int headMarinLeft = 0;
        //绘制头部
        foreach (Header item in colunms)
        {
            item.Margin = new Padding(0);
            item.BorderColor = Color.FromArgb(100, 100, 100);
            item.BorderWidth = new Padding(0, 0, 2, 2);
            item.Location = new Point(headMarinLeft, 0);
            if (colunms.IndexOf(item) == colunms.Count - 1)
            {
                item.BorderWidth = new Padding(0, 0, 0, 2);
            }
            item.Width = ItemWidth;
            item.Height = itemHeight;
            flowP.Controls.Add(item);
            headMarinLeft += ItemWidth;
        }
    }
  
    private void aa(object sender, EventArgs e)
    {
        Control s = sender as Control;
        Control p = s.Parent;
        //MessageBox.Show(p.ToString());
    }
    public class Header : PanelX
    {
        ListX<Cell> cells = new ListX<Cell>();
        [Description("节点集合")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] //添加这个属性 重新生成 集合数据不会消失
        public string HeanderText
        {
            get => heanderText; set
            {
                heanderText = value;
                Invalidate();
            }
        }
        string heanderText = "item1";

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawString(heanderText, Font, new SolidBrush(ForeColor), new RectangleF(0, 0, Width, Height), StringFormatX.MiddleCenter);
        }
    }

    public class CellStyle
    {
        public Action StyleChange;
        private Color backColor = Color.Transparent;
        private Color foreColor = Color.Transparent;

        public Color BackColor { get => backColor; set
            {
                backColor = value;
                if (StyleChange != null) StyleChange();
            } }
        public Color ForeColor { get => foreColor; set
            {
                foreColor = value;
                if (StyleChange != null) StyleChange();
            } }
    }
    public class Cell : Control
    {
        string text = "cell";
        CellStyle style = new CellStyle();

        public CellStyle Style
        {
            get => style; set
            {
                style = value;
                Invalidate();
            }
        }

        public Cell()
        {
            style.StyleChange += styleChange;   
        }

        private void styleChange()
        {
            Invalidate();
        }

        public Cell(string text)
        {
            Text = text;
            style.StyleChange += styleChange;
        }
        public new string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                Invalidate();
            }
        }

        /// <summary>
        /// 单元格里面的控件
        /// </summary>
        public Control Control
        {
            get => control; set
            {
                if (value == null)
                {
                    if (control != null) this.Controls.Remove(control);
                }
                else
                {
                    value.Dock = DockStyle.Fill;
                    this.Controls.Add(value);
                }
                control = value;
                Invalidate();
            }
        }

        private Control control = null;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (control == null)
            {
                Color foreColor = ForeColor;
                if (Style.ForeColor != Color.Transparent)
                {
                    foreColor = Style.ForeColor;
                }

                if (Style.BackColor != Color.Transparent)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Style.BackColor), new RectangleF(0 + 1, 0 + 1, Width - 2, Height - 2));
                }

                e.Graphics.DrawString(text, Font, new SolidBrush(foreColor), new RectangleF(0, 0, Width, Height), StringFormatX.MiddleCenter);
            }

        }


    }
}



