using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace anahtarli_metin_sifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSifrele_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            string anahtar = textBox3.Text;
            //www.gorselprogramlama.com
            string sifreli_metin = "";
           int j = 0;
            //Metni karakter karakter sonuna kadar tara.
            for (int k = 0; k <= metin.Length - 1; k++)
            {
                sifreli_metin = sifreli_metin +Convert.ToChar((Convert.ToInt32(metin[k]) + Convert.ToInt32(anahtar[j])) % 255);
                //Şifreli metni, her bir karakterinin koduna anahtar kelimenin sıradaki karakterinin kodunu ekleyerek bul.
                //Neden Mod 255? Çünkü toplam 255 değerini aşabilir.
                j = j + 1;
                //www.gorselprogramlama.com
                if (j == anahtar.Length)
                    j = 0;
                //Anahtar kelimenin indisi ayrı tutulmalı. Yoksa indisde değer aşımı olur.
            }
            textBox2.Text = sifreli_metin;
        }

        private void btnSifreCoz_Click(object sender, EventArgs e)
        {
            string sifreli_metin = textBox1.Text;
            string anahtar = textBox3.Text;
            string metin = "";
            int kod = 0;
            //www.gorselprogramlama.com
           int j = 0;
            for (int k = 0; k <= sifreli_metin.Length - 1; k++)
            {
                kod = Convert.ToInt32(sifreli_metin[k]) - Convert.ToInt32(anahtar[j]);
                if (kod <= 0)
                    kod = kod + 255;
                else
                    kod = kod % 255;
                metin = metin + Convert.ToChar(kod);
                //www.gorselprogramlama.com
                j = j + 1;
                if (j == anahtar.Length)
                    j = 0;
            }
            textBox2.Text = metin;
            //www.gorselprogramlama.com
        }
    }
}
