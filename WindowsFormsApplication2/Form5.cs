using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form5 : Form
    {
        private Form1 formilk;
        public Form5(Form1 form1)
        {
            InitializeComponent();//iegeytek
            formilk = form1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//iegeytek
        }

        private void button1_Click(object sender, EventArgs e)
        {//iegeytek
            int satir = int.Parse(textBox1.Text);
            int index = formilk.richTextBox1.GetFirstCharIndexFromLine(satir - 1);//iegeytek

            if (index >= 0)
            {//iegeytek
                formilk.richTextBox1.Select(index, 0);
                formilk.richTextBox1.ScrollToCaret();//iegeytek
                formilk.richTextBox1.Focus();
                this.Close();
            }
        }
    }
}//iegeytek
