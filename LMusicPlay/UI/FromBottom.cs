using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LSkin
{
    public class FromBottom : PanelX
    {

        public FromBottom()
        {
            Height = 50;
            Dock = DockStyle.Bottom;
        }

        Font iconFont = new Font("Marlett", 10); //图标字体样式

        StringFormat left = new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Far }; //对其方式

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (iconFont != null)
            {
                e.Graphics.DrawString("o", iconFont, new SolidBrush(ForeColor), new Rectangle(0, 0, Width, Height), left);
            }
            else {
                   e.Graphics.DrawString("o", iconFont, new SolidBrush(ForeColor), new Rectangle(0, 0, Width, Height), left);
            }

        }


    }
}
