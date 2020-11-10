using System;
using System.Windows.Forms;

namespace LSkin
{
    public partial class InputDiolog : FormX
    {
        public InputDiolog()
        {
            InitializeComponent();
        }

       

        public InputDiolog(string titleText)
        {
            InitializeComponent();
            this.Text = titleText;
        }

        public string inputStr = "";
        private void button1_Click(object sender, EventArgs e)
        {
            inputStr = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1_Click(null, null);
        }
        private void InputDiolog_Load(object sender, EventArgs e)
        {
            this.ShowIcon = false;
        }
    }
}

