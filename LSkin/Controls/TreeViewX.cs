using LSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LSkin
{
    public class TreeViewX : PanelX
    {
        public TreeViewX()
        {
            this.SetStyle(
          ControlStyles.UserPaint |  //控件自行绘制，而不使用操作系统的绘制
          ControlStyles.AllPaintingInWmPaint | //忽略擦出的消息，减少闪烁。
        ControlStyles.OptimizedDoubleBuffer |//在缓冲区上绘制，不直接绘制到屏幕上，减少闪烁。
          ControlStyles.ResizeRedraw | //控件大小发生变化时，重绘。                  
          ControlStyles.SupportsTransparentBackColor, true);//支持透明背景颜色


            items.AddHandler += addDone;
            items.RemoveHandler += addDone;
            BackColor = LSkinTheme.BackColor;
            ForeColor = LSkinTheme.ForeColor;
            ThemeColor = LSkinTheme.ThemeColor;
            Font = LSkinTheme.Font;
        }

        bool buttonList = false;

        /// <summary>
        /// 当用户按下某个节点时发生的事件,sender为node
        /// </summary>
        [Description("当用户按下某个节点时发生的事件,sender为node")]
        public event EventHandler NodeClick;


        private ListX<RootNodeX> items = new ListX<RootNodeX>();


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] //添加这个属性 重新生成 集合数据不会消失
        public ListX<RootNodeX> Items
        {
            get
            {
                return items;
            }
            set
            {
                items = value;
                Invalidate();
            }

        }

        private Color themeColor;
        public Color ThemeColor
        {
            get => themeColor; set
            {
                themeColor = value;
                Invalidate();
            }
        }

        //string nodesName = "title name";
        //public string NodesName
        //{
        //    get => nodesName;


        //    set
        //    {
        //        nodesName = value;
        //        Invalidate();
        //    }
        //}



        StringFormat txtAlgin = new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center }; //对其方式

        public StringFormat TxtAlgin
        {

            get
            {
                return txtAlgin;
            }
            set
            {
                txtAlgin = value;
                Invalidate();
            }
        }


        int itemHeight = 34;

        public int ItemHeight
        {
            get => itemHeight;

            set
            {
                itemHeight = value;

                getFontHeight();

                Invalidate();
            }

        }



        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            getFontHeight();
        }

        Point mousePoint;

        RootNodeX selecedNode = null;
        [Description("当前的获得选中的节点或者重新设置一个新的节点")]
        public RootNodeX SelecedNode
        {
            get => selecedNode;
            set
            {
                selecedNode = value;
                Invalidate();
            }
        }

        bool overlap = false;//是否移动到某一个图形的控制点;

        protected override void OnMouseMove(MouseEventArgs e)
        {


            mousePoint = e.Location;
            mouseHover = true;
            overlap = false;
            Invalidate();

            foreach (RootNodeX item in items)
            {
                if (item.Rec.Contains(mousePoint) && item.CanOpen)
                {
                    overlap = true;
                    break;
                }

            }

            if (overlap)
            {

                Cursor = Cursors.Hand;

            }
            else
            {
                //Cursor = Cursors.Default;
            }


            base.OnMouseMove(e);
        }


        protected override void OnMouseDown(MouseEventArgs e)
        {


            if (e.Button != MouseButtons.Left) return;

            List<RootNodeX> tempList = new List<RootNodeX>();
            foreach (RootNodeX item in items)
            {
                tempList.Add(item);
                foreach (RootNodeX itemC in item.Nodes)
                {
                    tempList.Add(itemC);
                }
            }

            foreach (var item in tempList)
            {
                if (item.Rec.Contains(mousePoint))
                {
                    if (!item.RootNode) SelecedNode = item;

                    if (item.RootNode && item.CanOpen)
                    {
                        item.IsOpen = !item.IsOpen;
                    }
                    item.TriggerClick(item, e);//单独触发节点事件
                    if (NodeClick != null) NodeClick(item, e);//广播所有节点事件
                    Invalidate();
                    break;
                }
            }
            tempList.Clear();


            base.OnMouseDown(e);
        }

        bool mouseHover = false;





        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            mouseHover = false;
            Invalidate();

        }


        private void getFontHeight()
        {
            fontHeight = (DrawTool.GetFontSize(CreateGraphics(), Font, "Test").Height + DrawTool.GetFontSize(CreateGraphics(), Font, "测试").Height) / 2;

            iconWidth = Convert.ToInt32(fontHeight * 1);
            iconMargionTop = Convert.ToInt32((itemHeight - iconWidth) / 2.0);
            Invalidate();
        }

        int textIndent = 20;
        public int TextIndent
        {
            get => textIndent;

            set
            {
                textIndent = value;
                Invalidate();

            }

        }

        public bool ButtonList { get => buttonList; set => buttonList = value; }

        int fontHeight = 0;
        int iconWidth = 0;
        int iconMargionTop = 0;
        private void addDone(object sender, EventArgs e)
        {
            Invalidate();
        }

        int controlsHeight = 0;

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            Invalidate();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);


            controlsHeight = 0;
            Graphics g = e.Graphics;
            DrawTool.Optimization(e.Graphics); //优化绘画效果
            foreach (RootNodeX item in items)
            {

                if (item.RootNode)
                {

                    item.Rec = new Rectangle(0, controlsHeight, Width - 1, itemHeight);

                    //  g.DrawRectangle(new Pen(Color.Red),item.Rec); //调试用途，画出根节点矩形

                    g.DrawString(item.NodeName, Font, new SolidBrush(ForeColor), new RectangleF(0, 0 + 2 + controlsHeight, Width, itemHeight), txtAlgin);
                    if (item.CanOpen)
                    {
                        Font f = new Font(Font.FontFamily, 9F, FontStyle.Bold);

                        //﹀〉
                        if (item.IsOpen)
                        {
                            g.DrawString("﹀", f, new SolidBrush(DrawTool.ConvertColor(ForeColor, 1.3)), new RectangleF(Width - iconMargionTop * 3, 0 + 2 + controlsHeight, Width, itemHeight), txtAlgin);

                        }
                        else
                        {
                            g.DrawString("〉", f, new SolidBrush(DrawTool.ConvertColor(ForeColor, 1.3)), new RectangleF(Width - iconMargionTop * 3, 0 + 2 + controlsHeight, Width, itemHeight), txtAlgin);

                        }

                    }

                    controlsHeight += itemHeight;


                    foreach (RootNodeX chrildItem in item.Nodes)
                    {
                        DrawChildNode(g, chrildItem, item.IsOpen); //画出子节点
                    }
                }
            }

            if (!DebugTool.IsDesignMode)
            {
                if (controlsHeight == 0) controlsHeight = itemHeight; //没有item也让高度等于1，避免控件不刷新;

                if (AutoFlow)
                {
                    Height = controlsHeight;
                }

            }


        }

        private void DrawChildNode(Graphics g, RootNodeX item, bool IsOpen)
        {

            if (!IsOpen) //如果该 item没有被展开，则给一个无效的矩形区域
            {

                item.Rec = new Rectangle(0, 0, 0, 0);
                item.IsOpen = false;
                return;
            }

            if (DebugTool.IsDesignMode || buttonList)
            {

                selecedNode = null;
            }



            RectangleF tmpStrRec;

            if (SelecedNode != null && SelecedNode == item)
            {
                g.FillRectangle(new SolidBrush(DrawTool.ConvertColor(BackColor, 0.93)), new Rectangle(SelecedNode.Rec.X, SelecedNode.Rec.Y, Width - BorderWidth.Right, SelecedNode.Rec.Height));
                //   g.FillRectangle(new SolidBrush(themeColor), new Rectangle(0, SelecedNode.Rec.Y, 3, ItemHeight));
            }

            if (item.Icon == null)
            {
                tmpStrRec = new RectangleF(0 + textIndent, controlsHeight, Width, itemHeight);
            }
            else
            {
                Rectangle iconRec = new Rectangle(0 + textIndent, controlsHeight, iconWidth, iconWidth);
                g.DrawImage(item.Icon, new Rectangle(0 + textIndent, controlsHeight + iconMargionTop, iconWidth, iconWidth));
                tmpStrRec = new RectangleF(0 + textIndent + iconWidth, controlsHeight, Width, itemHeight);
            }

            tmpStrRec.Y += 2; //字体高度计算纯在偏差 +2矫正

            if (item.Rec.Contains(mousePoint) && mouseHover)
            {
                g.DrawString(item.NodeName, Font, new SolidBrush(DrawTool.ConvertColor(ForeColor, 0.8)), tmpStrRec, txtAlgin);

                //   g.DrawString(item.NodeName, Font, new SolidBrush(DrawTool.ConvertColor(ForeColor, 1)), tmpStrRec, txtAlgin);
            }
            else
            {
                g.DrawString(item.NodeName, Font, new SolidBrush(ForeColor), tmpStrRec, txtAlgin);
            }

            item.Rec = new Rectangle(0, controlsHeight, Width - 1, itemHeight);

            //if (Controls.IndexOf(item) == -1) {
                //Controls.Add(item);
            //}


            if (SelecedNode != null && SelecedNode == item)  //最后画左边边框，避免出现绘画问题
            {
                g.FillRectangle(new SolidBrush(themeColor), new Rectangle(0, SelecedNode.Rec.Y, 3, ItemHeight));
            }

            controlsHeight += itemHeight;
        }
    }

    [DefaultEvent("Click")]
    public class RootNodeX : UserControl
    {

        public event EventHandler Click;
        private Bitmap icon;
        private string nodeName = "RootNode";
        private Rectangle rec;
        private ListX<ChildNodeX> items = new ListX<ChildNodeX>();
        private bool rootNode = true; //是否为根节点
        private bool isOpen = true;
        private bool canOpen = true;
        private object tag = null;

        public object Tag { get => tag; set => tag = value; }
        public Bitmap Icon { get => icon; set => icon = value; }
        public string NodeName
        {
            get => nodeName; set
            {

                nodeName = value;
                this.Name = nodeName;

            }
        }
        public Rectangle Rec
        {
            get => rec; set
            {
                rec = value;
                this.Location = value.Location;
                this.Size = value.Size;
            }
        }
        public bool RootNode
        {
            get => rootNode;
            set
            {
                rootNode = value;
            }
        }
        /// <summary>
        /// 触发单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TriggerClick(object sender, EventArgs e)
        {
            if (this.Click != null) Click(sender, e);
        }

        [Description("节点集合")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ListX<ChildNodeX> Nodes
        {
            get
            {
                return items;
            }
            set
            {
                items = value;

            }
        }
        /// <summary>
        /// 树形菜单是否已展开
        /// </summary>
        public bool IsOpen { get => isOpen; set => isOpen = value; }
        /// <summary>
        /// 树形菜单是否允许展开
        /// </summary>
        public bool CanOpen { get => canOpen; set => canOpen = value; }

        public RootNodeX()
        {
            BackColor = Color.Transparent;
        }
        public RootNodeX(Bitmap icon, string text)
        {
            BackColor = Color.Transparent;
            this.icon = icon;
            this.nodeName = text;
        }



    }


    public class ChildNodeX : RootNodeX
    {
        public ChildNodeX()
        {
            this.RootNode = false;
            this.NodeName = "ChildNode";

        }

        public ChildNodeX(Bitmap icon, string nodeName)
        {
            this.Icon = icon;
            this.NodeName = nodeName;
            this.RootNode = false;
        }


        public new ListX<ChildNodeX> Nodes
        { //不允许子节点下面有子节点
            get => new ListX<ChildNodeX>();
        }


    }
}
