using System;//iegeytek
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//iegeytek
namespace WindowsFormsApplication2
{
    public partial class Form4 : Form//iegeytek
    {
        private Form1 anaform;
        public Form4(Form1 ilk)
        {//iegeytek
            InitializeComponent();
            anaform = ilk;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;//iegeytek
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aranan = textBox1.Text;
            RichTextBox richbox = anaform.metin();
            int baslangic = richbox.Text.IndexOf(aranan);

            if (baslangic != -1)
            {
                richbox.Select(baslangic, aranan.Length);
                richbox.ScrollToCaret();
                richbox.Focus();
                this.Close();//iegeytek
            }
            else
                MessageBox.Show("Aradığınız Metin Bulunamadı.");//iegeytek
        }
    }
}
//iegeytek