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
    public partial class Picturelabel : UserControl
    {
        public Picturelabel()
        {
            InitializeComponent();
        }

        public Bitmap Image
        {

            set
            {

                this.pictureBox1.Image = value;
            }
            get
            {
                return this.pictureBox1.Image as Bitmap;
            }

        }

        private Bitmap hoverBackground;
        public Bitmap HoverBackground
        {
            set
            {
                this.hoverBackground = value;
            }
            get
            {
                return hoverBackground;
            }
        }



        public string LableText
        {

            set
            {
                this.label1.Text = value;
            }
            get
            {
                return this.label1.Text;
            }

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void Picturelabel_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = hoverBackground;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void Picturelabel_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
        }
    }
}
