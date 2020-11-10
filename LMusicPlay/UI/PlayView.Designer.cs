using LSkin;

namespace LMusicPlay.UI
{
    partial class PlayView
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lrcPanel1 = new LSkin.LrcPanel();
            this.SuspendLayout();
            // 
            // lrcPanel1
            // 
            this.lrcPanel1.AutoFlow = false;
            this.lrcPanel1.BackColor = System.Drawing.Color.Transparent;
            this.lrcPanel1.BorderColor = System.Drawing.Color.Teal;
            this.lrcPanel1.BorderWidth = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.lrcPanel1.ContentText = "";
            this.lrcPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lrcPanel1.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lrcPanel1.ForeColor = System.Drawing.Color.Black;
            this.lrcPanel1.FousColor = System.Drawing.Color.DarkOrange;
            this.lrcPanel1.Location = new System.Drawing.Point(0, 0);
            this.lrcPanel1.MarginVertical = 40;
            this.lrcPanel1.Name = "lrcPanel1";
            this.lrcPanel1.ShowFontFrame = false;
            this.lrcPanel1.Size = new System.Drawing.Size(818, 570);
            this.lrcPanel1.TabIndex = 0;
            this.lrcPanel1.Text = "lrcPanel1";
            this.lrcPanel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lrcPanel1.TouchMove = false;
            // 
            // PlayView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.lrcPanel1);
            this.Name = "PlayView";
            this.Size = new System.Drawing.Size(818, 570);
            this.ResumeLayout(false);

        }

        #endregion

        public LrcPanel lrcPanel1;
    }
}
