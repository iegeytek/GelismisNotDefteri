using System;//iegeytek
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;//iegeytek
using System.Windows.Forms;//iegeytek

namespace WindowsFormsApplication2
{
    public partial class Form6 : Form
    {//iegeytek
        public Form6()
        {
            InitializeComponent();
            
            this.FormBorderStyle = FormBorderStyle.FixedDialog;//iegeytek
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)//iegeytek
        {
            MessageBox.Show("Geri Bildirimde Bulunduğunuz İçin Teşekkür Ederiz...");//iegeytek
            this.Close();//iegeytek
        }

        private void button2_Click(object sender, EventArgs e)//iegeytek
        {//iegeytek
            this.Close();
        }//iegeytek
    }
}//iegeytek
