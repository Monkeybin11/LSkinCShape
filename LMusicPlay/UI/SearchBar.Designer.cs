
namespace LSkin
{
    partial class SearchBar
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonX1 = new ButtonX();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(17, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 21);
            this.textBox1.TabIndex = 2;
            // 
            // buttonX1
            // 
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX1.BackColor = System.Drawing.Color.Transparent;
            this.buttonX1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonX1.FlatAppearance.BorderSize = 0;
            this.buttonX1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonX1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonX1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX1.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX1.ForeColor = System.Drawing.Color.White;
            this.buttonX1.Image = global::LMusicPlay.Properties.Resources.搜索__1_;
            this.buttonX1.Location = new System.Drawing.Point(174, 7);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Radius = 0;
            this.buttonX1.Size = new System.Drawing.Size(13, 13);
            this.buttonX1.TabIndex = 1;
            this.buttonX1.TabStop = false;
            this.buttonX1.ThemeColor = System.Drawing.Color.Transparent;
            this.buttonX1.UseVisualStyleBackColor = false;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // SearchBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonX1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(200, 27);
            this.MinimumSize = new System.Drawing.Size(200, 27);
            this.Name = "SearchBar";
            this.Size = new System.Drawing.Size(200, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ButtonX buttonX1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
