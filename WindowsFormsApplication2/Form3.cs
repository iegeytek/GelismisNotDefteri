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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();//iegeytek
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();//iegeytek
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();//iegeytek
        }

        private void toolStripButton3_Click(object sender, EventArgs e)//iegeytek
        {
            webBrowser1.Navigate(toolStripTextBox1.Text);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)//iegeytek
        {
            webBrowser1.Navigate("https://www.google.com/search?q=" + toolStripTextBox2);
        }
        public void Googleara(string kelime)
        {
            string url = "https://www.google.com/search?q=" + Uri.EscapeDataString(kelime);//iegeytek
            webBrowser1.Navigate(url);
        }
        public void yardim(string destek)
        {
            
            webBrowser1.Navigate(destek);
        }
    }
}
//iegeytek