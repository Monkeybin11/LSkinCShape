using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LSkin
{
    public class TabControlX : TabControl
    {
        public TabControlX()
        {
     

        }

        //protected override void OnDrawItem(DrawItemEventArgs e)
        //{
        //    //    base.OnDrawItem(e);
        //    Console.WriteLine(0);
        //    return;
        //}

        //public override Rectangle DisplayRectangle
        //{
        //    get
        //    {
        //        Rectangle rect = base.DisplayRectangle;
        //        return rect;
        //    }
        //}
        bool hideTitle = false;

        public bool HideTitle { get => hideTitle; set{

                hideTitle = value;
                Invalidate();
            } }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);


            foreach (TabPage item in TabPages)
            {
                if (hideTitle) {
                    item.Parent = null;
                    this.SetStyle(ControlStyles.UserPaint, true);
                }
                else {
                    item.Parent = this;
                    this.SetStyle(ControlStyles.UserPaint, false);
                }
            }

        }

    }
}
