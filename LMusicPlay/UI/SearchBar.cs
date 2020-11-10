using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace LSkin
{
    public partial class SearchBar : UserControl
    {
        public SearchBar()
        {
            InitializeComponent();
            this.textBox1.BorderStyle = BorderStyle.None;
            this.BackColor = Color.Transparent;
            if (DebugTool.IsDesignMode)
            {
                textBox1.Location = new Point(textBox1.Location.X, textBox1.Location.Y - 2);
            }
            ForeColor = Color.White;
            textBox1.KeyDown += TextBox1_KeyDown;
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (callBackText != null)
                {
                    callBackText(this, this.textBox1, this.textBox1.Text);
                }
            }
        }

        Color backColor = Color.Transparent;


        public void RefreshBackColor()
        {
            SetBackColor();
            Invalidate();
        }

        private void SetBackColor()
        {
          
                backColor = DrawTool.ConvertColor(Parent.BackColor, 0.9);
                this.textBox1.BackColor = backColor;

        }

        public override Color ForeColor
        {
            get => base.ForeColor; set
            {
                base.ForeColor = value;
                this.textBox1.ForeColor = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;//消除锯齿
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;//高质量显示
            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;//最高质量显示文本

            SetBackColor();
            GraphicsPath gpp = DrawTool.DrawRectangle(new Rectangle(0, 0, Width, Height), Height);

            e.Graphics.FillPath(new SolidBrush(backColor), gpp);

            if (DebugTool.IsDesignMode)
            {
                e.Graphics.DrawPath(Pens.Black, gpp);
            }
            base.OnPaint(e);
        }

        public delegate void BackInputText(object sender, object input, string inputStr);
        /// <summary>
        /// 点击按钮返回输入的字符
        /// </summary>
        public event BackInputText callBackText;

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (callBackText != null)
            {
                callBackText(this, this.textBox1, this.textBox1.Text);
            }
        }

    }
}
