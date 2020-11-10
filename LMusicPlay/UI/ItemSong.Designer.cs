
namespace LSkin
{
    partial class ItemSong
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
            this.components = new System.ComponentModel.Container();
            this.MV = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Sname = new LSkin.LabelX();
            this.singer = new LSkin.LabelX();
            this.buttonX1 = new LSkin.ButtonX();
            this.SuspendLayout();
            // 
            // MV
            // 
            this.MV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MV.BackColor = System.Drawing.Color.Transparent;
            this.MV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MV.Image = global::LMusicPlay.Properties.Resources.mvicon;
            this.MV.Location = new System.Drawing.Point(670, 0);
            this.MV.Name = "MV";
            this.MV.Size = new System.Drawing.Size(23, 31);
            this.MV.TabIndex = 1;
            this.MV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.MV, "观看MV");
            this.MV.Click += new System.EventHandler(this.MV_Click);
            this.MV.MouseEnter += new System.EventHandler(this.songname_MouseEnter);
            this.MV.MouseLeave += new System.EventHandler(this.songname_MouseLeave);
            // 
            // time
            // 
            this.time.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Location = new System.Drawing.Point(706, 1);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(56, 31);
            this.time.TabIndex = 2;
            this.time.Text = "00:00";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.time.DoubleClick += new System.EventHandler(this.time_DoubleClick);
            this.time.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.songname_MouseDoubleClick);
            this.time.MouseEnter += new System.EventHandler(this.songname_MouseEnter);
            this.time.MouseLeave += new System.EventHandler(this.songname_MouseLeave);
            this.time.MouseHover += new System.EventHandler(this.songname_MouseHover);
            // 
            // Sname
            // 
            this.Sname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sname.Location = new System.Drawing.Point(55, 8);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(304, 17);
            this.Sname.TabIndex = 4;
            this.Sname.Text = "Sname";
            this.Sname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sname.DoubleClick += new System.EventHandler(this.time_DoubleClick);
            // 
            // singer
            // 
            this.singer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.singer.Location = new System.Drawing.Point(377, 8);
            this.singer.Name = "singer";
            this.singer.Size = new System.Drawing.Size(198, 17);
            this.singer.TabIndex = 4;
            this.singer.Text = "singer";
            this.singer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.singer.DoubleClick += new System.EventHandler(this.time_DoubleClick);
            // 
            // buttonX1
            // 
            this.buttonX1.BackColor = System.Drawing.Color.Transparent;
            this.buttonX1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonX1.FlatAppearance.BorderSize = 0;
            this.buttonX1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonX1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonX1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX1.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX1.ForeColor = System.Drawing.Color.White;
            this.buttonX1.Icon = null;
            this.buttonX1.Image = global::LMusicPlay.Properties.Resources.ax;
            this.buttonX1.Location = new System.Drawing.Point(29, 5);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Radius = 0;
            this.buttonX1.Size = new System.Drawing.Size(20, 20);
            this.buttonX1.TabIndex = 3;
            this.buttonX1.TabStop = false;
            this.buttonX1.ThemeColor = System.Drawing.Color.Transparent;
            this.buttonX1.UseVisualStyleBackColor = false;
            // 
            // ItemSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.singer);
            this.Controls.Add(this.Sname);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.MV);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(765, 30);
            this.Name = "ItemSong";
            this.Size = new System.Drawing.Size(765, 32);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label MV;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.ToolTip toolTip1;
        private ButtonX buttonX1;
        private LabelX Sname;
        private LabelX singer;
    }
}
