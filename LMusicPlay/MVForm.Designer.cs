using LSkin;

    partial class MVForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.axPlayer1 = new AxPlayer3.AxPlayer();
            this.progressBarX1 = new LSkin.ProgressBarX();
            this.progressBarX2 = new LSkin.ProgressBarX();
            this.yinliangBtn = new LSkin.ButtonX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelX2 = new LSkin.LabelX();
            this.labelX1 = new LSkin.LabelX();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.header.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.header.Icon = global::LMusicPlay.Properties.Resources.sp;
            this.header.Size = new System.Drawing.Size(822, 40);
            this.header.Text = "MVForm";
            this.header.ThemeColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // axPlayer1
            // 
            this.axPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axPlayer1.Duration = 0;
            this.axPlayer1.Location = new System.Drawing.Point(2, 44);
            this.axPlayer1.Name = "axPlayer1";
            this.axPlayer1.Position = 0;
            this.axPlayer1.Size = new System.Drawing.Size(819, 366);
            this.axPlayer1.TabIndex = 1;
            this.axPlayer1.Volume = 80;
            // 
            // progressBarX1
            // 
            this.progressBarX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarX1.AsyncData = true;
            this.progressBarX1.AsyncShowIcon = false;
            this.progressBarX1.AutoFlow = false;
            this.progressBarX1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBarX1.BorderColor = System.Drawing.SystemColors.ControlText;
            this.progressBarX1.BorderWidth = new System.Windows.Forms.Padding(0);
            this.progressBarX1.ContentText = "";
            this.progressBarX1.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.progressBarX1.ForeColor = System.Drawing.Color.White;
            this.progressBarX1.Location = new System.Drawing.Point(664, 423);
            this.progressBarX1.Maximum = 100;
            this.progressBarX1.Name = "progressBarX1";
            this.progressBarX1.Size = new System.Drawing.Size(100, 16);
            this.progressBarX1.TabIndex = 16;
            this.progressBarX1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.progressBarX1.TouchMove = false;
            this.progressBarX1.Value = 50;
            this.progressBarX1.UserValueChange += new LSkin.ProgressBarX.ValueChangeEvent(this.progressBarX1_UserValueChange);
            // 
            // progressBarX2
            // 
            this.progressBarX2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarX2.AsyncData = false;
            this.progressBarX2.AsyncShowIcon = true;
            this.progressBarX2.AutoFlow = false;
            this.progressBarX2.BackColor = System.Drawing.SystemColors.Control;
            this.progressBarX2.BorderColor = System.Drawing.SystemColors.ControlText;
            this.progressBarX2.BorderWidth = new System.Windows.Forms.Padding(0);
            this.progressBarX2.ContentText = "";
            this.progressBarX2.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.progressBarX2.ForeColor = System.Drawing.Color.White;
            this.progressBarX2.Location = new System.Drawing.Point(91, 422);
            this.progressBarX2.Maximum = 300;
            this.progressBarX2.Name = "progressBarX2";
            this.progressBarX2.Size = new System.Drawing.Size(450, 16);
            this.progressBarX2.TabIndex = 15;
            this.progressBarX2.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.progressBarX2.TouchMove = false;
            this.progressBarX2.Value = 150;
            this.progressBarX2.UserValueChange += new LSkin.ProgressBarX.ValueChangeEvent(this.progressBarX2_UserValueChange);
            // 
            // yinliangBtn
            // 
            this.yinliangBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.yinliangBtn.BackColor = System.Drawing.Color.Transparent;
            this.yinliangBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yinliangBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.yinliangBtn.FlatAppearance.BorderSize = 0;
            this.yinliangBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.yinliangBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.yinliangBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yinliangBtn.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yinliangBtn.ForeColor = System.Drawing.Color.Transparent;
            this.yinliangBtn.Icon = null;
            this.yinliangBtn.Image = global::LMusicPlay.Properties.Resources.yinLiang50;
            this.yinliangBtn.Location = new System.Drawing.Point(633, 419);
            this.yinliangBtn.Name = "yinliangBtn";
            this.yinliangBtn.Radius = 0;
            this.yinliangBtn.Size = new System.Drawing.Size(25, 25);
            this.yinliangBtn.TabIndex = 14;
            this.yinliangBtn.TabStop = false;
            this.yinliangBtn.ThemeColor = System.Drawing.Color.Transparent;
            this.yinliangBtn.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX2.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.ForeColor = System.Drawing.Color.White;
            this.labelX2.Location = new System.Drawing.Point(561, 419);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(51, 23);
            this.labelX2.TabIndex = 18;
            this.labelX2.Text = "00:00";
            this.labelX2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelX1.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.ForeColor = System.Drawing.Color.White;
            this.labelX1.Location = new System.Drawing.Point(21, 419);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(51, 23);
            this.labelX1.TabIndex = 17;
            this.labelX1.Text = "00:00";
            this.labelX1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(822, 448);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.progressBarX1);
            this.Controls.Add(this.progressBarX2);
            this.Controls.Add(this.yinliangBtn);
            this.Controls.Add(this.axPlayer1);
            this.Name = "MVForm";
            this.Text = "MVForm";
            this.Controls.SetChildIndex(this.header, 0);
            this.Controls.SetChildIndex(this.axPlayer1, 0);
            this.Controls.SetChildIndex(this.yinliangBtn, 0);
            this.Controls.SetChildIndex(this.progressBarX2, 0);
            this.Controls.SetChildIndex(this.progressBarX1, 0);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.ResumeLayout(false);

        }

    #endregion

    private AxPlayer3.AxPlayer axPlayer1;
    private ProgressBarX progressBarX1;
    private ProgressBarX progressBarX2;
    private ButtonX yinliangBtn;
    private System.Windows.Forms.Timer timer1;
    private LabelX labelX2;
    private LabelX labelX1;
}
