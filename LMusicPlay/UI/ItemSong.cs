using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LSkin
{
    public partial class ItemSong : UserControl
    {


        public event EventHandler MvIconClick;

        EventHandler doubleClick;

        public ItemSong()
        {
            InitializeComponent();

        }

        //ItemSong its = new ItemSong(item.Songname, item.Singername, item.Extname, item.MvHash, item.DurationStr, SongdouClick);
        public ItemSong(Song  s,EventHandler doubleClick,EventHandler MvIconClick) {
            InitializeComponent();
            this.doubleClick = doubleClick;


            this.time.Text = s.DurationStr;
            this.Sname.Text = s.Songname;
            this.singer.Text = s.Singername;

            this.MV.Visible = s.MvHash == "" ? false : true;

            this.MvIconClick = MvIconClick;

        }
        public ItemSong(string songname, string singerName, string zhuanji,string mv,string time,EventHandler doubleClick)
        {
            InitializeComponent();
        
            this.time.Text = time;
            this.Sname.Text = songname;
            this.singer.Text = singerName;

            this.MV.Visible = mv == "" ? false : true;
            this.doubleClick = doubleClick;

        }

       

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        private void MV_Click(object sender, EventArgs e)
        {

            if (MvIconClick != null) MvIconClick(this.Tag,null);
        }


        private void songname_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            base.OnDoubleClick(e);
        }

        private void songname_MouseEnter(object sender, EventArgs e)
        {
            base.OnMouseEnter(e);
        }

        private void songname_MouseLeave(object sender, EventArgs e)
        {
            base.OnMouseLeave(e);

        }

        private void songname_MouseHover(object sender, EventArgs e)
        {
            base.OnMouseHover(e);
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {

            if (doubleClick != null) doubleClick(this, e);
            base.OnMouseDoubleClick(e);


        }

        private void time_DoubleClick(object sender, EventArgs e)
        {
            if (doubleClick != null) doubleClick(this, e);

            base.OnMouseDoubleClick(null);

        }

        private void zj_Click(object sender, EventArgs e)
        {


        }
    }
}
