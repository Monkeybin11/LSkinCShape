using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LSkin
{
    public class LabelX : Label
    {
        public LabelX()
        {
            this.AutoSize = false;
            this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            dianWidth = DrawTool.GetFontSize(CreateGraphics(), Font, "...").Width + 1;

        }

        public override Font Font
        {
            get => base.Font; set
            {
                base.Font = value;
                dianWidth = DrawTool.GetFontSize(CreateGraphics(), Font, "...").Width + 1;
            }
        }

        int dianWidth = 0;
        public override string Text
        {
            get => base.Text;
            set
            {
                string str = value;

                Size s = DrawTool.GetFontSize(CreateGraphics(), Font, str);

                if (s.Width > Width)
                {
                    try
                    {
                        str = str.Substring(0, str.Length - 3) + "...";
                    }
                    catch (Exception)
                    {

                        base.Text = value;
                    }
                }

                base.Text = str;
            }
        }
    }
}
