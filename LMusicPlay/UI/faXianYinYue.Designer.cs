
using LSkin;

namespace LMusicPlay.UI
{
    partial class faXianYinYue
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
            this.fxyyList = new LSkin.ListScoll();
            this.SuspendLayout();
            // 
            // fxyyList
            // 
            this.fxyyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fxyyList.Location = new System.Drawing.Point(0, 0);
            this.fxyyList.Name = "fxyyList";
            this.fxyyList.Size = new System.Drawing.Size(629, 532);
            this.fxyyList.TabIndex = 0;
            // 
            // faXianYinYue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fxyyList);
            this.Name = "faXianYinYue";
            this.Size = new System.Drawing.Size(629, 532);
            this.ResumeLayout(false);

        }

        #endregion

        public ListScoll fxyyList;
    }
}
