using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydetme = new SaveFileDialog();
            kaydetme.Filter = "Text Dosyası |*.txt| Word Dosyasi|*.docx";
            DialogResult cevap = MessageBox.Show("Değişiklikleri Kaydetmek İstiyor musunuz?", "Not Defteri", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if(cevap == DialogResult.Yes)
            {
                DialogResult kaydet = kaydetme.ShowDialog();
                if(kaydet == DialogResult.OK)
                {
                    System.Diagnostics.Process.Start(Application.ProductName);
                }
            }//iegeytek
            else if (cevap == DialogResult.No)
            {
                
                System.Diagnostics.Process.Start(Application.ProductName);
                Application.Exit();
                //iegeytek
            }
            else
                MessageBox.Show("Yeni Dosya Açılmadı, Kaydetme İşlemi İptal Edildi.");

            //iegeytek

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog acma = new OpenFileDialog();
            acma.Filter = "Text Dosyası |*.txt| Word Dosyasi|*.docx";
            DialogResult ac = acma.ShowDialog();//iegeytek
            if (ac == DialogResult.OK)
            {
                richTextBox1.LoadFile(acma.FileName, RichTextBoxStreamType.PlainText);
            }

        }//iegeytek

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydetme = new SaveFileDialog();
            kaydetme.Filter = "Text Dosyası |*.txt| Word Dosyasi|*.docx";
            DialogResult kaydet = kaydetme.ShowDialog();
            if(kaydet == DialogResult.OK)
            {//iegeytek
                richTextBox1.SaveFile(kaydetme.FileName, RichTextBoxStreamType.PlainText);
            }
        }
        
        PageSetupDialog sayfayapisi = new PageSetupDialog();
        PrintDialog yazdir = new PrintDialog();
        PrintPreviewDialog onizleme = new PrintPreviewDialog();
        private void sayfaYapısıToolStripMenuItem_Click(object sender, EventArgs e)
        {//iegeytek
            sayfayapisi.Document = printDocument1;
            sayfayapisi.ShowDialog();
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)//iegeytek
        {
            yazdir.Document = printDocument1; 
            DialogResult cevap = yazdir.ShowDialog();
            if(cevap == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        //iegeytek
        private void yazdırmaÖnizlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            onizleme.Document = printDocument1;
            onizleme.ShowDialog();
        }//iegeytek

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, new Point(100, 100));
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydetme = new SaveFileDialog();
            kaydetme.Filter = "Text Dosyası |*.txt| Word Dosyasi|*.docx";
            DialogResult cevap = MessageBox.Show("Değişiklikleri Kaydetmek İstiyor musunuz?", "Not Defteri", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                DialogResult kaydet = kaydetme.ShowDialog();//iegeytek
                if (kaydet == DialogResult.OK)
                {
                    Application.Exit();
                }
                if (kaydet == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                //iegeytek
            }
            else if (cevap == DialogResult.No)
            {


                Application.Exit();

            }
        }//iegeytek

        private void uygulamaHakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.ShowDialog();
        }
        //iegeytek
        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(Console.NumberLock == true)
            {
                toolStripStatusLabel1.Text = "Number Lock Açık";
                toolStripStatusLabel1.ForeColor = Color.Green;
            }
            else if(Console.NumberLock == false)
            {//iegeytek
                toolStripStatusLabel1.Text = "Number Lock Kapalı";
                toolStripStatusLabel1.ForeColor = Color.Red;
            }
            if (Console.CapsLock == true)
            {
                toolStripStatusLabel2.Text = "Caps Lock Açık";
                toolStripStatusLabel2.ForeColor = Color.Green;
            }
            else if (Console.CapsLock == false)//iegeytek
            {
                toolStripStatusLabel2.Text = "Caps Lock Kapalı";
                toolStripStatusLabel2.ForeColor = Color.Red;
            }
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {//iegeytek
            int satir = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart) + 1;
            int sutun = richTextBox1.SelectionStart - richTextBox1.GetFirstCharIndexOfCurrentLine() + 1;

            toolStripStatusLabel3.Text = "Satir: " + satir + " Sütün: " + sutun;

////////////////////////////////////////////////////////////////////
            bool seciliVar = richTextBox1.SelectionLength > 0;
            //iegeytek
            kopyalaToolStripMenuItem.Enabled = seciliVar;
            kesToolStripMenuItem.Enabled = seciliVar;
            silToolStripMenuItem.Enabled = seciliVar;
            googledaAraToolStripMenuItem.Enabled = seciliVar;

            yapıştırToolStripMenuItem.Enabled = Clipboard.ContainsText();

        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }
        //iegeytek
        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //iegeytek
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)//iegeytek
        {
            richTextBox1.Paste();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {//iegeytek
            richTextBox1.SelectedText = "";
        }

        private void durumÇubuğuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }

        private void açToolStripMenuItem1_Click(object sender, EventArgs e)
        {//iegeytek
            statusStrip1.Visible = true;
            return;
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)//iegeytek
        {
            statusStrip1.Visible = false;
            return;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }

        private void açToolStripMenuItem2_Click(object sender, EventArgs e)//iegeytek
        {
            toolStrip1.Visible = true;
            return;
        }

        private void kapatToolStripMenuItem1_Click(object sender, EventArgs e)
        {//iegeytek
            toolStrip1.Visible = false;
            return;
        }

        private void googledaAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ara = richTextBox1.SelectedText.Trim();
            if (!string.IsNullOrEmpty(ara))
            {//iegeytek
                Form3 form3 = new Form3();
                form3.Show();
                form3.Googleara(ara);
            }
    
            
        }
        public RichTextBox metin()//iegeytek
        {
            return richTextBox1;
        }

        private void bulToolStripMenuItem_Click(object sender, EventArgs e)//iegeytek
        {
            Form4 bul = new Form4(this);
            bul.ShowDialog();
        }

        private void gitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 git = new Form5(this);
            git.ShowDialog();
        }

        private void hepsiniSecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();//iegeytek


        }

        private void saatTarihToolStripMenuItem_Click(object sender, EventArgs e)//iegeytek
        {
            richTextBox1.Text += DateTime.Now + Environment.NewLine;
        }

        private void yaziTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if(font.ShowDialog() == DialogResult.OK)//iegeytek
            {
                richTextBox1.Font = font.Font;
            }
        }

        private void yakınlaştırToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor += 0.2f;//iegeytek
        }

        private void uzaklaştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.ZoomFactor > 0.2f)
                richTextBox1.ZoomFactor -= 0.2f;
        }

        private void varsayılanYakınlaştırmayaGeriYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 1.0f;//iegeytek
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ColorDialog renk = new ColorDialog();
            if(renk.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = renk.Color;//iegeytek
            }
            
        }

        private void yardımıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)//iegeytek
        {
            Form3 web = new Form3();
            web.yardim("https://www.bing.com/search?q=windows+10%e2%80%99da+not+defteriyle+ilgili+yard%c4%b1m+alma&filters=guid:%224466414-tr-dia%22%20lang:%22tr%22&form=T00032&ocid=HelpPane-BingIA"); 
            web.Show();
        }

        private void geriBildirimGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 geribildirim = new Form6();
            geribildirim.ShowDialog();
        }
        //iegeytek
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //iegeytek
        }
    }
}
