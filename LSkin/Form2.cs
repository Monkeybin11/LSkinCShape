using LSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static DataGridViewX;

namespace ThicknessDetection
{
    public partial class Form2 : FormX
    {
        public Form2()
        {

            InitializeComponent();
            //dataGridViewX1.Rows.Add(new Cell[] {new Cell("测试1"), new Cell("测试2"), new Cell("测试3") });
            //dataGridViewX1.Rows.Add(new Cell[] { new Cell("测试1"), new Cell("测试2"), new Cell("测试3") });
            //dataGridViewX1.Rows.Add(new Cell[] { new Cell("测试1"), new Cell("测试2"), new Cell("测试3") });
            //dataGridViewX1.Rows.Add(new Cell[] { new Cell("测试1"), new Cell("测试2"), new Cell("测试3") });
            //dataGridViewX1.Rows.Add(new Cell[] { new Cell("测试1"), new Cell("测试2"), new Cell("测试3") });
            //dataGridViewX1.Rows.Add(new Cell[] { new Cell("测试1"), new Cell("测试2"), new Cell("测试3") });
            //dataGridViewX1.Rows.Add(new Cell[] { new Cell("测试1"), new Cell("测试2"), new Cell("测试3") });
            //dataGridViewX1.Rows.Add(new Cell[] { new Cell("测试1"), new Cell("测试2"), new Cell("测试3") });
            //dataGridViewX1.Rows.Add(new Cell[] { new Cell("测试1"), new Cell("测试2"), new Cell("测试3") });


        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            dataGridViewX1.Rows.Add(new Cell[] { new Cell("测试1"), new Cell("测试2"), new Cell("测试3") });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewX1.Rows[2][2].Style.BackColor = Color.Red;
            dataGridViewX1.Rows[2][2].Style.ForeColor = Color.White;

        }
    }
}
