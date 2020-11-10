using LSkin;

namespace MusicPlay
{
  
    partial class MainWindow
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.volume1 = new LSkin.Volume();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonX7 = new LSkin.ButtonX();
            this.buttonX4 = new LSkin.ButtonX();
            this.buttonX6 = new LSkin.ButtonX();
            this.buttonX8 = new LSkin.ButtonX();
            this.buttonX5 = new LSkin.ButtonX();
            this.pages = new LSkin.PanelX();
            this.playView1 = new LMusicPlay.UI.PlayView();
            this.listView1 = new LMusicPlay.UI.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonX10 = new LSkin.ButtonX();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fromBottom1 = new LSkin.FromBottom();
            this.progressBarX1 = new LSkin.ProgressBarX();
            this.labelX2 = new LSkin.LabelX();
            this.labelX1 = new LSkin.LabelX();
            this.progressBarX2 = new LSkin.ProgressBarX();
            this.buttonX3 = new LSkin.ButtonX();
            this.buttonX1 = new LSkin.ButtonX();
            this.yinliangBtn = new LSkin.ButtonX();
            this.nextbtn = new LSkin.ButtonX();
            this.playBtn = new LSkin.ButtonX();
            this.upBtn = new LSkin.ButtonX();
            this.searchBar1 = new LSkin.SearchBar();
            this.header.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pages.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.fromBottom1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.header.Controls.Add(this.buttonX10);
            this.header.Controls.Add(this.searchBar1);
            this.header.Icon = global::LMusicPlay.Properties.Resources.网易云音乐__1_;
            this.header.Size = new System.Drawing.Size(1022, 51);
            this.header.Text = "网易云音乐";
            this.header.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.volume1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(953, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 87);
            this.panel1.TabIndex = 12;
            // 
            // volume1
            // 
            this.volume1.BackColor = System.Drawing.Color.LightSlateGray;
            this.volume1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.volume1.Location = new System.Drawing.Point(0, 0);
            this.volume1.Name = "volume1";
            this.volume1.Size = new System.Drawing.Size(34, 135);
            this.volume1.TabIndex = 0;
            this.volume1.Voulme = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonX7
            // 
            this.buttonX7.BackColor = System.Drawing.SystemColors.Control;
            this.buttonX7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonX7.FlatAppearance.BorderSize = 0;
            this.buttonX7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonX7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonX7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX7.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.buttonX7.Icon = null;
            this.buttonX7.Image = null;
            this.buttonX7.Location = new System.Drawing.Point(20, 21);
            this.buttonX7.Name = "buttonX7";
            this.buttonX7.Radius = 10;
            this.buttonX7.Size = new System.Drawing.Size(91, 33);
            this.buttonX7.TabIndex = 10;
            this.buttonX7.TabStop = false;
            this.buttonX7.Text = "官方红";
            this.buttonX7.ThemeColor = System.Drawing.SystemColors.Control;
            this.buttonX7.UseVisualStyleBackColor = false;
            this.buttonX7.Click += new System.EventHandler(this.buttonX7_Click);
            // 
            // buttonX4
            // 
            this.buttonX4.BackColor = System.Drawing.SystemColors.Control;
            this.buttonX4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonX4.FlatAppearance.BorderSize = 0;
            this.buttonX4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonX4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonX4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX4.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX4.ForeColor = System.Drawing.Color.Black;
            this.buttonX4.Icon = null;
            this.buttonX4.Image = null;
            this.buttonX4.Location = new System.Drawing.Point(20, 75);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Radius = 10;
            this.buttonX4.Size = new System.Drawing.Size(91, 33);
            this.buttonX4.TabIndex = 10;
            this.buttonX4.TabStop = false;
            this.buttonX4.Text = "炫酷黑";
            this.buttonX4.ThemeColor = System.Drawing.SystemColors.Control;
            this.buttonX4.UseVisualStyleBackColor = false;
            this.buttonX4.Click += new System.EventHandler(this.buttonX7_Click);
            // 
            // buttonX6
            // 
            this.buttonX6.BackColor = System.Drawing.SystemColors.Control;
            this.buttonX6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonX6.FlatAppearance.BorderSize = 0;
            this.buttonX6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonX6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonX6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX6.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(180)))));
            this.buttonX6.Icon = null;
            this.buttonX6.Image = null;
            this.buttonX6.Location = new System.Drawing.Point(130, 75);
            this.buttonX6.Name = "buttonX6";
            this.buttonX6.Radius = 10;
            this.buttonX6.Size = new System.Drawing.Size(91, 33);
            this.buttonX6.TabIndex = 10;
            this.buttonX6.TabStop = false;
            this.buttonX6.Text = "可爱粉";
            this.buttonX6.ThemeColor = System.Drawing.SystemColors.Control;
            this.buttonX6.UseVisualStyleBackColor = false;
            this.buttonX6.Click += new System.EventHandler(this.buttonX7_Click);
            // 
            // buttonX8
            // 
            this.buttonX8.BackColor = System.Drawing.SystemColors.Control;
            this.buttonX8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonX8.FlatAppearance.BorderSize = 0;
            this.buttonX8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonX8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonX8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX8.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(172)))), ((int)(((byte)(98)))));
            this.buttonX8.Icon = null;
            this.buttonX8.Image = null;
            this.buttonX8.Location = new System.Drawing.Point(130, 21);
            this.buttonX8.Name = "buttonX8";
            this.buttonX8.Radius = 10;
            this.buttonX8.Size = new System.Drawing.Size(91, 33);
            this.buttonX8.TabIndex = 10;
            this.buttonX8.TabStop = false;
            this.buttonX8.Text = "土豪金";
            this.buttonX8.ThemeColor = System.Drawing.SystemColors.Control;
            this.buttonX8.UseVisualStyleBackColor = false;
            this.buttonX8.Click += new System.EventHandler(this.buttonX7_Click);
            // 
            // buttonX5
            // 
            this.buttonX5.BackColor = System.Drawing.SystemColors.Control;
            this.buttonX5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonX5.FlatAppearance.BorderSize = 0;
            this.buttonX5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonX5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonX5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX5.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(199)))), ((int)(((byte)(138)))));
            this.buttonX5.Icon = null;
            this.buttonX5.Image = null;
            this.buttonX5.Location = new System.Drawing.Point(227, 21);
            this.buttonX5.Name = "buttonX5";
            this.buttonX5.Radius = 10;
            this.buttonX5.Size = new System.Drawing.Size(91, 33);
            this.buttonX5.TabIndex = 10;
            this.buttonX5.TabStop = false;
            this.buttonX5.Text = "清新绿";
            this.buttonX5.ThemeColor = System.Drawing.SystemColors.Control;
            this.buttonX5.UseVisualStyleBackColor = false;
            this.buttonX5.Click += new System.EventHandler(this.buttonX7_Click);
            // 
            // pages
            // 
            this.pages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pages.AutoFlow = false;
            this.pages.BackColor = System.Drawing.Color.Transparent;
            this.pages.BorderColor = System.Drawing.Color.Red;
            this.pages.BorderWidth = new System.Windows.Forms.Padding(0);
            this.pages.ContentText = "";
            this.pages.Controls.Add(this.playView1);
            this.pages.Controls.Add(this.listView1);
            this.pages.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pages.ForeColor = System.Drawing.Color.White;
            this.pages.Location = new System.Drawing.Point(0, 51);
            this.pages.Name = "pages";
            this.pages.Size = new System.Drawing.Size(1022, 569);
            this.pages.TabIndex = 13;
            this.pages.TouchMove = false;
            // 
            // playView1
            // 
            this.playView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.playView1.Location = new System.Drawing.Point(240, 9);
            this.playView1.Name = "playView1";
            this.playView1.Size = new System.Drawing.Size(961, 573);
            this.playView1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Transparent;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1022, 569);
            this.listView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonX7);
            this.tabPage3.Controls.Add(this.buttonX8);
            this.tabPage3.Controls.Add(this.buttonX4);
            this.tabPage3.Controls.Add(this.buttonX5);
            this.tabPage3.Controls.Add(this.buttonX6);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(334, 167);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 70);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 70);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonX10
            // 
            this.buttonX10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX10.BackColor = System.Drawing.Color.Transparent;
            this.buttonX10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonX10.FlatAppearance.BorderSize = 0;
            this.buttonX10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonX10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonX10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX10.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX10.ForeColor = System.Drawing.Color.White;
            this.buttonX10.Icon = null;
            this.buttonX10.Image = global::LMusicPlay.Properties.Resources.皮肤1;
            this.buttonX10.Location = new System.Drawing.Point(913, 18);
            this.buttonX10.Name = "buttonX10";
            this.buttonX10.Radius = 0;
            this.buttonX10.Size = new System.Drawing.Size(17, 17);
            this.buttonX10.TabIndex = 9;
            this.buttonX10.TabStop = false;
            this.buttonX10.ThemeColor = System.Drawing.Color.Transparent;
            this.buttonX10.UseVisualStyleBackColor = false;
            this.buttonX10.Click += new System.EventHandler(this.buttonX7_Click);
            // 
            // fromBottom1
            // 
            this.fromBottom1.AutoFlow = false;
            this.fromBottom1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.fromBottom1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.fromBottom1.BorderWidth = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.fromBottom1.ContentText = "";
            this.fromBottom1.Controls.Add(this.progressBarX1);
            this.fromBottom1.Controls.Add(this.labelX2);
            this.fromBottom1.Controls.Add(this.labelX1);
            this.fromBottom1.Controls.Add(this.progressBarX2);
            this.fromBottom1.Controls.Add(this.buttonX3);
            this.fromBottom1.Controls.Add(this.buttonX1);
            this.fromBottom1.Controls.Add(this.yinliangBtn);
            this.fromBottom1.Controls.Add(this.nextbtn);
            this.fromBottom1.Controls.Add(this.playBtn);
            this.fromBottom1.Controls.Add(this.upBtn);
            this.fromBottom1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fromBottom1.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fromBottom1.ForeColor = System.Drawing.Color.White;
            this.fromBottom1.Location = new System.Drawing.Point(0, 620);
            this.fromBottom1.Name = "fromBottom1";
            this.fromBottom1.Size = new System.Drawing.Size(1022, 50);
            this.fromBottom1.TabIndex = 8;
            this.fromBottom1.TouchMove = false;
            // 
            // progressBarX1
            // 
            this.progressBarX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarX1.AsyncData = true;
            this.progressBarX1.AsyncShowIcon = false;
            this.progressBarX1.AutoFlow = false;
            this.progressBarX1.BackColor = System.Drawing.Color.LightGray;
            this.progressBarX1.BorderColor = System.Drawing.SystemColors.ControlText;
            this.progressBarX1.BorderWidth = new System.Windows.Forms.Padding(0);
            this.progressBarX1.ContentText = "";
            this.progressBarX1.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.progressBarX1.ForeColor = System.Drawing.Color.White;
            this.progressBarX1.Location = new System.Drawing.Point(778, 19);
            this.progressBarX1.Maximum = 100;
            this.progressBarX1.Name = "progressBarX1";
            this.progressBarX1.Size = new System.Drawing.Size(100, 16);
            this.progressBarX1.TabIndex = 13;
            this.progressBarX1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.progressBarX1.TouchMove = false;
            this.progressBarX1.Value = 50;
            this.progressBarX1.UserValueChange += new LSkin.ProgressBarX.ValueChangeEvent(this.progressBarX1_UserValueChange);
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX2.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.labelX2.Location = new System.Drawing.Point(696, 15);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(51, 23);
            this.labelX2.TabIndex = 12;
            this.labelX2.Text = "00:00";
            this.labelX2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.labelX1.Location = new System.Drawing.Point(187, 15);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(51, 23);
            this.labelX1.TabIndex = 11;
            this.labelX1.Text = "00:00";
            this.labelX1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBarX2
            // 
            this.progressBarX2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarX2.AsyncData = false;
            this.progressBarX2.AsyncShowIcon = true;
            this.progressBarX2.AutoFlow = false;
            this.progressBarX2.BackColor = System.Drawing.Color.LightGray;
            this.progressBarX2.BorderColor = System.Drawing.SystemColors.ControlText;
            this.progressBarX2.BorderWidth = new System.Windows.Forms.Padding(0);
            this.progressBarX2.ContentText = "";
            this.progressBarX2.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.progressBarX2.ForeColor = System.Drawing.Color.White;
            this.progressBarX2.Location = new System.Drawing.Point(240, 18);
            this.progressBarX2.Maximum = 300;
            this.progressBarX2.Name = "progressBarX2";
            this.progressBarX2.Size = new System.Drawing.Size(450, 16);
            this.progressBarX2.TabIndex = 10;
            this.progressBarX2.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.progressBarX2.TouchMove = false;
            this.progressBarX2.Value = 150;
            this.progressBarX2.UserValueChange += new LSkin.ProgressBarX.ValueChangeEvent(this.progressBarX2_UserValueChange);
            // 
            // buttonX3
            // 
            this.buttonX3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX3.BackColor = System.Drawing.Color.Transparent;
            this.buttonX3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonX3.FlatAppearance.BorderSize = 0;
            this.buttonX3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonX3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonX3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX3.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX3.ForeColor = System.Drawing.Color.Transparent;
            this.buttonX3.Icon = null;
            this.buttonX3.Image = global::LMusicPlay.Properties.Resources.ci__2_;
            this.buttonX3.Location = new System.Drawing.Point(930, 17);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Radius = 0;
            this.buttonX3.Size = new System.Drawing.Size(15, 15);
            this.buttonX3.TabIndex = 8;
            this.buttonX3.TabStop = false;
            this.buttonX3.ThemeColor = System.Drawing.Color.Transparent;
            this.buttonX3.UseVisualStyleBackColor = false;
            // 
            // buttonX1
            // 
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX1.BackColor = System.Drawing.Color.Transparent;
            this.buttonX1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonX1.FlatAppearance.BorderSize = 0;
            this.buttonX1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonX1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonX1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX1.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX1.ForeColor = System.Drawing.Color.Transparent;
            this.buttonX1.Icon = null;
            this.buttonX1.Image = global::LMusicPlay.Properties.Resources.listShunxu;
            this.buttonX1.Location = new System.Drawing.Point(891, 17);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Radius = 0;
            this.buttonX1.Size = new System.Drawing.Size(18, 18);
            this.buttonX1.TabIndex = 8;
            this.buttonX1.TabStop = false;
            this.buttonX1.ThemeColor = System.Drawing.Color.Transparent;
            this.buttonX1.UseVisualStyleBackColor = false;
            // 
            // yinliangBtn
            // 
            this.yinliangBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.yinliangBtn.Location = new System.Drawing.Point(748, 14);
            this.yinliangBtn.Name = "yinliangBtn";
            this.yinliangBtn.Radius = 0;
            this.yinliangBtn.Size = new System.Drawing.Size(25, 25);
            this.yinliangBtn.TabIndex = 8;
            this.yinliangBtn.TabStop = false;
            this.yinliangBtn.ThemeColor = System.Drawing.Color.Transparent;
            this.yinliangBtn.UseVisualStyleBackColor = false;
            this.yinliangBtn.Click += new System.EventHandler(this.yinliangBtn_Click);
            // 
            // nextbtn
            // 
            this.nextbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.nextbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextbtn.FlatAppearance.BorderSize = 0;
            this.nextbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nextbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nextbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextbtn.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nextbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.nextbtn.Icon = null;
            this.nextbtn.Image = global::LMusicPlay.Properties.Resources.next1;
            this.nextbtn.Location = new System.Drawing.Point(142, 12);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Radius = 32;
            this.nextbtn.Size = new System.Drawing.Size(28, 28);
            this.nextbtn.TabIndex = 8;
            this.nextbtn.TabStop = false;
            this.nextbtn.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.nextbtn.UseVisualStyleBackColor = false;
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.playBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.playBtn.FlatAppearance.BorderSize = 0;
            this.playBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.playBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.playBtn.ForeColor = System.Drawing.Color.White;
            this.playBtn.Icon = null;
            this.playBtn.Image = global::LMusicPlay.Properties.Resources.play;
            this.playBtn.Location = new System.Drawing.Point(84, 7);
            this.playBtn.Name = "playBtn";
            this.playBtn.Radius = 20;
            this.playBtn.Size = new System.Drawing.Size(36, 36);
            this.playBtn.TabIndex = 8;
            this.playBtn.TabStop = false;
            this.playBtn.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.ButtonX4_Click);
            // 
            // upBtn
            // 
            this.upBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.upBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.upBtn.FlatAppearance.BorderSize = 0;
            this.upBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.upBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.upBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upBtn.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.upBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.upBtn.Icon = null;
            this.upBtn.Image = global::LMusicPlay.Properties.Resources.up;
            this.upBtn.Location = new System.Drawing.Point(30, 12);
            this.upBtn.Name = "upBtn";
            this.upBtn.Radius = 30;
            this.upBtn.Size = new System.Drawing.Size(28, 28);
            this.upBtn.TabIndex = 8;
            this.upBtn.TabStop = false;
            this.upBtn.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.upBtn.UseVisualStyleBackColor = false;
            // 
            // searchBar1
            // 
            this.searchBar1.BackColor = System.Drawing.Color.Transparent;
            this.searchBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchBar1.BackgroundImage")));
            this.searchBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchBar1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.searchBar1.Location = new System.Drawing.Point(202, 13);
            this.searchBar1.MaximumSize = new System.Drawing.Size(200, 27);
            this.searchBar1.MinimumSize = new System.Drawing.Size(200, 27);
            this.searchBar1.Name = "searchBar1";
            this.searchBar1.Size = new System.Drawing.Size(200, 27);
            this.searchBar1.TabIndex = 8;
            this.searchBar1.callBackText += new LSkin.SearchBar.BackInputText(this.searchBar1_callBackText);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1022, 670);
            this.Controls.Add(this.pages);
            this.Controls.Add(this.fromBottom1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(0, 0);
            this.MinimumSize = new System.Drawing.Size(1022, 0);
            this.Name = "MainWindow";
            this.Text = "网易云音乐";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Controls.SetChildIndex(this.fromBottom1, 0);
            this.Controls.SetChildIndex(this.pages, 0);
            this.Controls.SetChildIndex(this.header, 0);
            this.header.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pages.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.fromBottom1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    
        private Volume volume1;
        private SearchBar searchBar1;
        private FromBottom fromBottom1;
        private ButtonX nextbtn;
        private ButtonX playBtn;
        private ButtonX upBtn;
        private  ProgressBarX progressBarX2;
        private System.Windows.Forms.Timer timer1;
        private LabelX labelX1;
        private LabelX labelX2;
        private ProgressBarX progressBarX1;
        private ButtonX yinliangBtn;
        private ButtonX buttonX1;
        private ButtonX buttonX3;
        private ButtonX buttonX7;
        private ButtonX buttonX4;
        private ButtonX buttonX5;
        private ButtonX buttonX6;
        private ButtonX buttonX8;
        private PanelX pages;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private LMusicPlay.UI.ListView listView1;
        private ButtonX buttonX10;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private LMusicPlay.UI.PlayView playView1;
    }
}

