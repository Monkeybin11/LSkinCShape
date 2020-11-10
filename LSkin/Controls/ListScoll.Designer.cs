using System.Windows.Forms;

namespace LSkin
{
    partial class ListScoll
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
            this.panelX2 = new System.Windows.Forms.FlowLayoutPanel();
            this.verticalScrollX1 = new LSkin.VerticalScrollX();
            this.SuspendLayout();
            // 
            // panelX2
            // 
            this.panelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelX2.AutoScroll = true;
            this.panelX2.BackColor = System.Drawing.SystemColors.Control;
            this.panelX2.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelX2.ForeColor = System.Drawing.Color.Black;
            this.panelX2.Location = new System.Drawing.Point(0, 0);
            this.panelX2.Name = "panelX2";
            this.panelX2.Size = new System.Drawing.Size(497, 439);
            this.panelX2.TabIndex = 1;
            this.panelX2.Text = "panelX2";
            // 
            // verticalScrollX1
            // 
            this.verticalScrollX1.AutoFlow = false;
            this.verticalScrollX1.BackColor = System.Drawing.Color.Transparent;
            this.verticalScrollX1.BorderColor = System.Drawing.Color.Teal;
            this.verticalScrollX1.BorderWidth = new System.Windows.Forms.Padding(0);
            this.verticalScrollX1.ContentText = "";
            this.verticalScrollX1.Dock = System.Windows.Forms.DockStyle.Right;
            this.verticalScrollX1.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.verticalScrollX1.ForeColor = System.Drawing.Color.Black;
            this.verticalScrollX1.Location = new System.Drawing.Point(477, 0);
            this.verticalScrollX1.Name = "verticalScrollX1";
            this.verticalScrollX1.ScollControl = this.panelX2;
            this.verticalScrollX1.ScollWdith = 10;
            this.verticalScrollX1.Size = new System.Drawing.Size(9, 439);
            this.verticalScrollX1.TabIndex = 0;
            this.verticalScrollX1.Text = "verticalScrollX1";
            this.verticalScrollX1.TouchMove = false;
            // 
            // ListScoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.verticalScrollX1);
            this.Controls.Add(this.panelX2);
            this.Name = "ListScoll";
            this.Size = new System.Drawing.Size(486, 439);
            this.ResumeLayout(false);

        }

        #endregion
        private FlowLayoutPanel panelX2;
        private LSkin.VerticalScrollX verticalScrollX1;
    }
}
