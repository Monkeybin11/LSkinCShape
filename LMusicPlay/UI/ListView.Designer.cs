using LMusicPlay.Properties;
using LSkin;

namespace LMusicPlay.UI
{
    partial class ListView
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
            System.Drawing.StringFormat stringFormat1 = new System.Drawing.StringFormat();
            this.childNodeX1 = new LSkin.ChildNodeX();
            this.pages = new LSkin.PanelX();
            this.panelX2 = new LSkin.PanelX();
            this.buttonX3 = new LSkin.ButtonX();
            this.songName = new LSkin.LabelX();
            this.buttonX2 = new LSkin.ButtonX();
            this.singerName = new LSkin.LabelX();
            this.singerImg = new LSkin.ButtonX();
            this.panelX1 = new LSkin.PanelX();
            this.treeViewX1 = new LSkin.TreeViewX();
            this.panelX2.SuspendLayout();
            this.panelX1.SuspendLayout();
            this.SuspendLayout();
            // 
            // childNodeX1
            // 
            this.childNodeX1.CanOpen = true;
            this.childNodeX1.Icon = null;
            this.childNodeX1.IsOpen = true;
            this.childNodeX1.NodeName = "ChildNode";
            this.childNodeX1.Rec = new System.Drawing.Rectangle(0, 68, 198, 34);
            this.childNodeX1.RootNode = false;
            this.childNodeX1.Tag = null;
            // 
            // pages
            // 
            this.pages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pages.AutoFlow = false;
            this.pages.BackColor = System.Drawing.SystemColors.Control;
            this.pages.BorderColor = System.Drawing.SystemColors.ControlText;
            this.pages.BorderWidth = new System.Windows.Forms.Padding(0);
            this.pages.ContentText = "";
            this.pages.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pages.ForeColor = System.Drawing.Color.Black;
            this.pages.Location = new System.Drawing.Point(200, 0);
            this.pages.Name = "pages";
            this.pages.Size = new System.Drawing.Size(649, 570);
            this.pages.TabIndex = 17;
            this.pages.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.pages.TouchMove = false;
            // 
            // panelX2
            // 
            this.panelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelX2.AutoFlow = false;
            this.panelX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.panelX2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.panelX2.BorderWidth = new System.Windows.Forms.Padding(0, 1, 2, 0);
            this.panelX2.ContentText = "";
            this.panelX2.Controls.Add(this.buttonX3);
            this.panelX2.Controls.Add(this.songName);
            this.panelX2.Controls.Add(this.buttonX2);
            this.panelX2.Controls.Add(this.singerName);
            this.panelX2.Controls.Add(this.singerImg);
            this.panelX2.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelX2.ForeColor = System.Drawing.Color.Black;
            this.panelX2.Location = new System.Drawing.Point(0, 516);
            this.panelX2.Name = "panelX2";
            this.panelX2.Size = new System.Drawing.Size(200, 54);
            this.panelX2.TabIndex = 16;
            this.panelX2.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.panelX2.TouchMove = false;
            // 
            // buttonX3
            // 
            this.buttonX3.BackColor = System.Drawing.Color.Transparent;
            this.buttonX3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonX3.FlatAppearance.BorderSize = 0;
            this.buttonX3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonX3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonX3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX3.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX3.ForeColor = System.Drawing.Color.White;
            this.buttonX3.Icon = null;
            this.buttonX3.Image = global::LMusicPlay.Properties.Resources.fx;
            this.buttonX3.Location = new System.Drawing.Point(175, 33);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Radius = 0;
            this.buttonX3.Size = new System.Drawing.Size(14, 14);
            this.buttonX3.TabIndex = 18;
            this.buttonX3.TabStop = false;
            this.buttonX3.ThemeColor = System.Drawing.Color.Transparent;
            this.buttonX3.UseVisualStyleBackColor = false;
            // 
            // songName
            // 
            this.songName.ForeColor = System.Drawing.Color.Black;
            this.songName.Location = new System.Drawing.Point(57, 5);
            this.songName.Name = "songName";
            this.songName.Size = new System.Drawing.Size(112, 27);
            this.songName.TabIndex = 17;
            this.songName.Text = "HelloWord";
            this.songName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonX2
            // 
            this.buttonX2.BackColor = System.Drawing.Color.Transparent;
            this.buttonX2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonX2.FlatAppearance.BorderSize = 0;
            this.buttonX2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonX2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonX2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX2.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX2.ForeColor = System.Drawing.Color.White;
            this.buttonX2.Icon = null;
            this.buttonX2.Image = global::LMusicPlay.Properties.Resources.ax;
            this.buttonX2.Location = new System.Drawing.Point(175, 11);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Radius = 0;
            this.buttonX2.Size = new System.Drawing.Size(14, 14);
            this.buttonX2.TabIndex = 17;
            this.buttonX2.TabStop = false;
            this.buttonX2.ThemeColor = System.Drawing.Color.Transparent;
            this.buttonX2.UseVisualStyleBackColor = false;
            // 
            // singerName
            // 
            this.singerName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.singerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.singerName.Location = new System.Drawing.Point(57, 25);
            this.singerName.Name = "singerName";
            this.singerName.Size = new System.Drawing.Size(112, 27);
            this.singerName.TabIndex = 18;
            this.singerName.Text = "HelloWord";
            this.singerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // singerImg
            // 
            this.singerImg.BackColor = System.Drawing.Color.Black;
            this.singerImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.singerImg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.singerImg.FlatAppearance.BorderSize = 0;
            this.singerImg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.singerImg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.singerImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.singerImg.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.singerImg.ForeColor = System.Drawing.Color.White;
            this.singerImg.Icon = null;
            this.singerImg.Image = null;
            this.singerImg.Location = new System.Drawing.Point(6, 5);
            this.singerImg.Name = "singerImg";
            this.singerImg.Radius = 0;
            this.singerImg.Size = new System.Drawing.Size(44, 44);
            this.singerImg.TabIndex = 0;
            this.singerImg.TabStop = false;
            this.singerImg.ThemeColor = System.Drawing.Color.Black;
            this.singerImg.UseVisualStyleBackColor = false;
            // 
            // panelX1
            // 
            this.panelX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelX1.AutoFlow = false;
            this.panelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.panelX1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.panelX1.BorderWidth = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.panelX1.ContentText = "";
            this.panelX1.Controls.Add(this.treeViewX1);
            this.panelX1.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelX1.ForeColor = System.Drawing.Color.Black;
            this.panelX1.Location = new System.Drawing.Point(0, 0);
            this.panelX1.Name = "panelX1";
            this.panelX1.Size = new System.Drawing.Size(200, 516);
            this.panelX1.TabIndex = 15;
            this.panelX1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.panelX1.TouchMove = false;
            // 
            // treeViewX1
            // 
            this.treeViewX1.AutoFlow = false;
            this.treeViewX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.treeViewX1.BorderColor = System.Drawing.SystemColors.ControlText;
            this.treeViewX1.BorderWidth = new System.Windows.Forms.Padding(0);
            this.treeViewX1.ButtonList = false;
            this.treeViewX1.ContentText = "";
            this.treeViewX1.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeViewX1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.treeViewX1.ItemHeight = 34;
            this.treeViewX1.Location = new System.Drawing.Point(0, 0);
            this.treeViewX1.Name = "treeViewX1";
            this.treeViewX1.SelecedNode = this.childNodeX1;
            this.treeViewX1.Size = new System.Drawing.Size(199, 447);
            this.treeViewX1.TabIndex = 14;
            this.treeViewX1.TextIndent = 20;
            this.treeViewX1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.treeViewX1.TouchMove = false;
            stringFormat1.Alignment = System.Drawing.StringAlignment.Near;
            stringFormat1.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat1.LineAlignment = System.Drawing.StringAlignment.Center;
            stringFormat1.Trimming = System.Drawing.StringTrimming.Character;
            this.treeViewX1.TxtAlgin = stringFormat1;
            // 
            // ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Controls.Add(this.pages);
            this.Controls.Add(this.panelX2);
            this.Controls.Add(this.panelX1);
            this.Name = "ListView";
            this.Size = new System.Drawing.Size(849, 570);
            this.panelX2.ResumeLayout(false);
            this.panelX1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private  PanelX panelX1;
        private  PanelX panelX2;
        private ButtonX buttonX2;
        private  ButtonX buttonX3;
        public  ButtonX singerImg;
        public  LabelX singerName;
        public  LabelX songName;
        public TreeViewX treeViewX1;
        public  PanelX pages;
        private ChildNodeX childNodeX1;
    }
}
