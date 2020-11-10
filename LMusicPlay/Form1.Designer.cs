using LSkin;

namespace MusicPlay
{
    partial class Form1
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

   

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            LSkin.RootNodeX rootNodeX1 = new LSkin.RootNodeX();
            LSkin.ChildNodeX childNodeX1 = new LSkin.ChildNodeX();
            LSkin.ChildNodeX childNodeX2 = new LSkin.ChildNodeX();
            LSkin.ChildNodeX childNodeX3 = new LSkin.ChildNodeX();
            LSkin.RootNodeX rootNodeX2 = new LSkin.RootNodeX();
            LSkin.RootNodeX rootNodeX3 = new LSkin.RootNodeX();
            System.Drawing.StringFormat stringFormat1 = new System.Drawing.StringFormat();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.formHeader1 = new LSkin.FormHeader();
            this.buttonX1 = new LSkin.ButtonX();
            this.panelX1 = new LSkin.PanelX();
            this.button14 = new System.Windows.Forms.Button();
            this.progressBarX1 = new LSkin.ProgressBarX();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.treeViewX1 = new LSkin.TreeViewX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelX1 = new LSkin.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panelX1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(104, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 67);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(64, 398);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 67);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(94, 700);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1020, 174);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(10, 229);
            this.vScrollBar1.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(832, 380);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(850, 334);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(872, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1046, 105);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown1.TabIndex = 14;
            // 
            // formHeader1
            // 
            this.formHeader1.AutoFlow = false;
            this.formHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(105)))), ((int)(((byte)(199)))));
            this.formHeader1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(105)))), ((int)(((byte)(199)))));
            this.formHeader1.BorderWidth = new System.Windows.Forms.Padding(0);
            this.formHeader1.ContentText = "";
            this.formHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.formHeader1.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.formHeader1.ForeColor = System.Drawing.Color.White;
            this.formHeader1.Icon = global::LMusicPlay.Properties.Resources.网易云音乐__1_;
            this.formHeader1.Location = new System.Drawing.Point(0, 0);
            this.formHeader1.Name = "formHeader1";
            this.formHeader1.Size = new System.Drawing.Size(1210, 44);
            this.formHeader1.TabIndex = 15;
            this.formHeader1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(105)))), ((int)(((byte)(199)))));
            this.formHeader1.TouchMove = false;
            // 
            // buttonX1
            // 
            this.buttonX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(105)))), ((int)(((byte)(199)))));
            this.buttonX1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonX1.FlatAppearance.BorderSize = 0;
            this.buttonX1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonX1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonX1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX1.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX1.ForeColor = System.Drawing.Color.White;
            this.buttonX1.Icon = null;
            this.buttonX1.Image = null;
            this.buttonX1.Location = new System.Drawing.Point(22, 516);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Radius = 20;
            this.buttonX1.Size = new System.Drawing.Size(109, 79);
            this.buttonX1.TabIndex = 13;
            this.buttonX1.TabStop = false;
            this.buttonX1.Text = "buttonX1";
            this.buttonX1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(105)))), ((int)(((byte)(199)))));
            this.buttonX1.UseVisualStyleBackColor = false;
            // 
            // panelX1
            // 
            this.panelX1.AutoFlow = false;
            this.panelX1.AutoScroll = true;
            this.panelX1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelX1.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelX1.BorderWidth = new System.Windows.Forms.Padding(1);
            this.panelX1.ContentText = "";
            this.panelX1.Controls.Add(this.button14);
            this.panelX1.Controls.Add(this.progressBarX1);
            this.panelX1.Controls.Add(this.button13);
            this.panelX1.Controls.Add(this.button2);
            this.panelX1.Controls.Add(this.button12);
            this.panelX1.Controls.Add(this.button15);
            this.panelX1.Controls.Add(this.button1);
            this.panelX1.Controls.Add(this.panel2);
            this.panelX1.Controls.Add(this.buttonX1);
            this.panelX1.Controls.Add(this.button11);
            this.panelX1.Controls.Add(this.button5);
            this.panelX1.Controls.Add(this.panel1);
            this.panelX1.Controls.Add(this.button8);
            this.panelX1.Controls.Add(this.button7);
            this.panelX1.Controls.Add(this.button10);
            this.panelX1.Controls.Add(this.button9);
            this.panelX1.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelX1.ForeColor = System.Drawing.Color.White;
            this.panelX1.Location = new System.Drawing.Point(12, 105);
            this.panelX1.Name = "panelX1";
            this.panelX1.Size = new System.Drawing.Size(357, 334);
            this.panelX1.TabIndex = 4;
            this.panelX1.TouchMove = false;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(15, 195);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(219, 23);
            this.button14.TabIndex = 12;
            this.button14.Text = "button11";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // progressBarX1
            // 
            this.progressBarX1.AsyncData = false;
            this.progressBarX1.AsyncShowIcon = true;
            this.progressBarX1.AutoFlow = false;
            this.progressBarX1.BackColor = System.Drawing.Color.Gray;
            this.progressBarX1.BorderColor = System.Drawing.Color.Teal;
            this.progressBarX1.BorderWidth = new System.Windows.Forms.Padding(0);
            this.progressBarX1.ContentText = "";
            this.progressBarX1.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.progressBarX1.ForeColor = System.Drawing.Color.Black;
            this.progressBarX1.Location = new System.Drawing.Point(41, 637);
            this.progressBarX1.Maximum = 100;
            this.progressBarX1.Name = "progressBarX1";
            this.progressBarX1.Size = new System.Drawing.Size(159, 23);
            this.progressBarX1.TabIndex = 16;
            this.progressBarX1.Text = "progressBarX1";
            this.progressBarX1.ThemeColor = System.Drawing.Color.Teal;
            this.progressBarX1.TouchMove = true;
            this.progressBarX1.Value = 0;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(28, 224);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(213, 23);
            this.button13.TabIndex = 12;
            this.button13.Text = "button11";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(166, 264);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 12;
            this.button12.Text = "button11";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(166, 387);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 12;
            this.button15.Text = "button11";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(56, 309);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 12;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(166, 442);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(166, 490);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(166, 537);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(166, 590);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 10;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.Location = new System.Drawing.Point(219, 653);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 11;
            this.button9.Text = "end";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // treeViewX1
            // 
            this.treeViewX1.AutoFlow = false;
            this.treeViewX1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.treeViewX1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(105)))), ((int)(((byte)(199)))));
            this.treeViewX1.BorderWidth = new System.Windows.Forms.Padding(0);
            this.treeViewX1.ContentText = "";
            this.treeViewX1.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeViewX1.ForeColor = System.Drawing.Color.Black;
            this.treeViewX1.ItemHeight = 34;
            rootNodeX1.CanOpen = true;
            rootNodeX1.Icon = null;
            rootNodeX1.IsOpen = true;
            rootNodeX1.NodeName = "RootNode";
            childNodeX1.CanOpen = true;
            childNodeX1.Icon = null;
            childNodeX1.IsOpen = true;
            childNodeX1.NodeName = "ChildNode";
            childNodeX1.Rec = new System.Drawing.Rectangle(0, 34, 263, 34);
            childNodeX1.RootNode = false;
            childNodeX1.Tag = null;
            childNodeX2.CanOpen = true;
            childNodeX2.Icon = null;
            childNodeX2.IsOpen = true;
            childNodeX2.NodeName = "ChildNode";
            childNodeX2.Rec = new System.Drawing.Rectangle(0, 68, 263, 34);
            childNodeX2.RootNode = false;
            childNodeX2.Tag = null;
            childNodeX3.CanOpen = true;
            childNodeX3.Icon = null;
            childNodeX3.IsOpen = true;
            childNodeX3.NodeName = "ChildNode";
            childNodeX3.Rec = new System.Drawing.Rectangle(0, 102, 263, 34);
            childNodeX3.RootNode = false;
            childNodeX3.Tag = null;
            rootNodeX1.Nodes.Add(childNodeX1);
            rootNodeX1.Nodes.Add(childNodeX2);
            rootNodeX1.Nodes.Add(childNodeX3);
            rootNodeX1.Rec = new System.Drawing.Rectangle(0, 0, 263, 34);
            rootNodeX1.RootNode = true;
            rootNodeX1.Tag = null;
            rootNodeX2.CanOpen = true;
            rootNodeX2.Icon = null;
            rootNodeX2.IsOpen = true;
            rootNodeX2.NodeName = "RootNode";
            rootNodeX2.Rec = new System.Drawing.Rectangle(0, 136, 263, 34);
            rootNodeX2.RootNode = true;
            rootNodeX2.Tag = null;
            rootNodeX3.CanOpen = true;
            rootNodeX3.Icon = null;
            rootNodeX3.IsOpen = true;
            rootNodeX3.NodeName = "RootNode";
            rootNodeX3.Rec = new System.Drawing.Rectangle(0, 170, 263, 34);
            rootNodeX3.RootNode = true;
            rootNodeX3.Tag = null;
            this.treeViewX1.Items.Add(rootNodeX1);
            this.treeViewX1.Items.Add(rootNodeX2);
            this.treeViewX1.Items.Add(rootNodeX3);
            this.treeViewX1.Location = new System.Drawing.Point(562, 233);
            this.treeViewX1.Name = "treeViewX1";
            this.treeViewX1.SelecedNode = childNodeX3;
            this.treeViewX1.Size = new System.Drawing.Size(264, 345);
            this.treeViewX1.TabIndex = 12;
            this.treeViewX1.TextIndent = 20;
            this.treeViewX1.ThemeColor = System.Drawing.SystemColors.Highlight;
            this.treeViewX1.TouchMove = false;
            stringFormat1.Alignment = System.Drawing.StringAlignment.Near;
            stringFormat1.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat1.LineAlignment = System.Drawing.StringAlignment.Center;
            stringFormat1.Trimming = System.Drawing.StringTrimming.Character;
            this.treeViewX1.TxtAlgin = stringFormat1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(561, 133);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(173, 97);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "labelX1";
            this.labelX1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelX1.Paint += new System.Windows.Forms.PaintEventHandler(this.label1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1210, 742);
            this.Controls.Add(this.formHeader1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.treeViewX1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.panelX1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panelX1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private LSkin.LabelX labelX1;
        private System.Windows.Forms.Button button2;
        private PanelX panelX1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private TreeViewX treeViewX1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button15;
        private ButtonX buttonX1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private FormHeader formHeader1;
        private ProgressBarX progressBarX1;
        private System.Windows.Forms.Timer timer1;
    }
}