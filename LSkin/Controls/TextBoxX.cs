using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace LSkin
{
    public class TextBoxxX : TextBox
    {
        public TextBoxxX()
        {
            this.SetStyle(
          ControlStyles.UserPaint |  //控件自行绘制，而不使用操作系统的绘制
          ControlStyles.AllPaintingInWmPaint | //忽略擦出的消息，减少闪烁。
          ControlStyles.OptimizedDoubleBuffer |//在缓冲区上绘制，不直接绘制到屏幕上，减少闪烁。
          ControlStyles.ResizeRedraw | //控件大小发生变化时，重绘。                  
          ControlStyles.SupportsTransparentBackColor, true);//支持透明背景颜色
            base.BorderStyle = BorderStyle.None;
            //       base.BackColor = Color.FromArgb(0, 0, 0, 0);
            base.Multiline = true;
            TabStop = false;
            Font = LSkinTheme.Font;
            ForeColor = LSkinTheme.ForeColor;

            if (DebugTool.IsDesignMode) {
                base.BorderStyle = BorderStyle.FixedSingle;
            }

        }

    }
}
