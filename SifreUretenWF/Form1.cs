using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifreUretenWF
{
    public partial class Form1 : Form
    {
        bool kucukHarfVarMi, buyukHarfVarMi, rakamVarMi, ozelKarakterVarMi;
        int sifreSayisi, sifreUzunlugu;
        string seciliKarakterler = "";

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            textBox1.Text = "";  // her ürettiğinde textbox ı temizlemesi için...

            kucukHarfVarMi = cbKharf.Checked;
            buyukHarfVarMi = cbBharf.Checked;
            rakamVarMi = cbRakam.Checked;
            ozelKarakterVarMi = cbOzel.Checked;

            sifreSayisi = (int)numericUpDown1.Value;
            sifreUzunlugu = (int)numericUpDown2.Value;
            Random rnd = new Random();

            if (!(ozelKarakterVarMi || rakamVarMi || buyukHarfVarMi || kucukHarfVarMi))
            {
                MessageBox.Show("En az bir parametre seçiniz.");
                return;
            }

            seciliKarakterler += KucukHarfEkle();

            seciliKarakterler += BuyukHarfEkle();

            seciliKarakterler += RakamlarEkle();

            seciliKarakterler += OzelKarakterEkle();

            char[] passDizi = new char[] { };

            passDizi = seciliKarakterler.ToCharArray();

            string pass = "";

            for (int j = 1; j <= sifreSayisi; j++)
            {
                pass = "";
                for (int i = 0; i <= sifreUzunlugu - 1; i++)
                {
                    pass += passDizi[rnd.Next(passDizi.Length)];

                }
                textBox1.Text += pass + "\r\n";


            }

        }

        private string KucukHarfEkle()
        {
            string uretilen = "";
            if (kucukHarfVarMi)
            {
                for (int i = 97; i <= 122; i++)
                {
                    uretilen += Convert.ToChar(i);
                }

            }
            return uretilen;
        }

        private string BuyukHarfEkle()
        {
            string uretilen = "";
            if (buyukHarfVarMi)
            {
                for (int i = 65; i <= 90; i++)
                {
                    uretilen += Convert.ToChar(i);
                }

            }
            return uretilen;
        }

        private string RakamlarEkle()
        {
            string uretilen = "";
            if (rakamVarMi)
            {
                for (int i = 48; i <= 57; i++)
                {
                    uretilen += Convert.ToChar(i);
                }

            }
            return uretilen;
        }

        private string OzelKarakterEkle()
        {
            string uretilen="";
            if (ozelKarakterVarMi)
            {
                for (int i = 33; i <= 64; i++)
                {
                    uretilen += Convert.ToChar(i);
                }

            }
            return uretilen;
        }

        public Form1()
        {
            InitializeComponent();
        }


    }
}
