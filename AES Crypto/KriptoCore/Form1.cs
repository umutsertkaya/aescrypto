using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KriptoCore
{
    public partial class Form1 : Form
    {
        AES_ŞİFRELE aes = new AES_ŞİFRELE();
        string dosyayolu;
        public Form1()
        {
            InitializeComponent();
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
       
        private void sifrele_Click(object sender, EventArgs e)
        {
            sifmtn.Text = aes.AESSifrele(mtngir.Text);
        }

        private void cöz_Click(object sender, EventArgs e)
        {
            mtngir.Text = aes.AESsifre_Coz(sifmtn.Text);
        }

        private void search_Click(object sender, EventArgs e)
        {
            ara.ShowDialog();
            if(ara.ShowDialog() == DialogResult.OK)
            {
                dosyayolu = ara.FileName;
                FileStream fs = new FileStream(dosyayolu, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                txtmtngir.Text = sr.ReadToEnd();
            }
            else
            {

            }
        }

        private void txtsifrele_Click(object sender, EventArgs e)
        {
            txtsifmtn.Text = aes.AESSifrele(txtmtngir.Text);
        }

        private void txtcöz_Click(object sender, EventArgs e)
        {
            txtmtngir.Text = aes.AESsifre_Coz(txtsifmtn.Text);
        }
    }
}
