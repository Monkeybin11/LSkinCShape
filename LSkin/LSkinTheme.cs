using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

    public static class LSkinTheme
    {

    /// <summary>
    /// 主题颜色
    /// </summary>
    public static Color ThemeColor = Color.FromArgb(45, 125, 154);

    /// <summary>
    /// 主题前景色,如字体颜色
    /// </summary>
    public static Color ForeColor = Color.Black;

        /// <summary>
        /// 主题背景色,控件的背景颜色
        /// </summary>
        public static Color BackColor = SystemColors.Control;

        /// <summary>
        /// 字体样式,新宋体,小五号
        /// </summary>
        public static Font Font = new Font("新宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));


    }

