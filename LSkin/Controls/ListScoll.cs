using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LSkin;

namespace LSkin
{
    public partial class ListScoll : UserControl
    {
        public FlowLayoutPanel FolwPanel=null;
        public ListScoll()
        {
            InitializeComponent();
            FolwPanel = panelX2;
            controls.AddHandler += addControl;
            controls.RemoveHandler +=removeControl;
            controls.ClearHandler += ClearHandler;
            DoubleBuffered = true;
            panelX2.ControlRemoved += PanelX2_ControlRemoved;
        }

        private void PanelX2_ControlRemoved(object sender, ControlEventArgs e)
        {
            Items.Remove(e.Control);
        }

        private void ClearHandler(object sender, EventArgs e)
        {
            panelX2.Controls.Clear();
        }

        private void removeControl(object sender, EventArgs e)
        {
            panelX2.Controls.Remove(sender as Control);
        }

        private void addControl(object sender, EventArgs e)
        {
            Control ct = sender as Control;

            if (ct == panelX2 || ct == verticalScrollX1) return;

            int maxWidth = this.Width - 10;
            int x = ct.Location.X + ct.Width;

            if (x > maxWidth)
            {
                ct.Width -= x - maxWidth;
            }
            panelX2.Controls.Add(ct);


        }

        ListX<Control> controls = new ListX<Control>();
        [Description("Controls不可被隐藏重写，会导致不控件显示，所以新建属性")]
        public ListX<Control> Items { get => controls; set => controls = value; }



        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

        }


    }
}
