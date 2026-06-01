using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace KelimeOyunu
{
      public partial class Form1 : Form
    {
        List<Kelime> havuz = new List<Kelime>();
        int dogruSayisi = 0;
        int yanlisSayisi = 0;
        Random rnd = new Random();
        Kelime suankiSoru;
        bool cevapVerildi = false;

        public Form1()
        {
            InitializeComponent();
            OlaylariBagla();
            DosyadanKelimeleriOku();
            OyunEkraniniGizle();
        }

        private void OlaylariBagla()
        {
            btnBaslat.Click += SınaviBaslat;
            btnBitir.Click += SınaviBitir;
            btnA.Click += SecenekSecildi;
            btnB.Click += SecenekSecildi;
            btnC.Click += SecenekSecildi;
            btnD.Click += SecenekSecildi;
            btnSonraki.Click += SonrakiSoruGec;
        }

        private void DosyadanKelimeleriOku()
        {
            if (File.Exists("kelimeler.txt"))
            {
                string[] satirlar = File.ReadAllLines("kelimeler.txt");
                foreach (string satir in satirlar)
                {
                    string[] parcalar = satir.Split(',');
                    if (parcalar.Length == 2)
                    {
                        havuz.Add(new Kelime(parcalar[0].Trim(), parcalar[1].Trim()));
                    }
                }
            }
            else
            {
                MessageBox.Show("HATA: kelimeler.txt bulunamadı!");
            }
        }

        private void OyunEkraniniGizle()
        {
            lblSkor.Visible = false;
            lblSoru.Visible = false;
            btnA.Visible = false;
            btnB.Visible = false;
            btnC.Visible = false;
            btnD.Visible = false;
            lblDurum.Visible = false;
            btnSonraki.Visible = false;
        }

        private void SınaviBaslat(object sender, EventArgs e)
        {
            btnBaslat.Visible = false;
            btnBitir.Visible = true;
            lblSkor.Visible = true;
            lblSoru.Visible = true;
            btnA.Visible = true;
            btnB.Visible = true;
            btnC.Visible = true;
            btnD.Visible = true;
            lblDurum.Visible = true;

            dogruSayisi = 0;
            yanlisSayisi = 0;
            lblSkor.Text = $"Doğru: {dogruSayisi}   |   Yanlış: {yanlisSayisi}";

            YeniSoruGetir();
        }

        private void YeniSoruGetir()
        {
            lblDurum.Text = "";
            btnSonraki.Visible = false;
            cevapVerildi = false;

            suankiSoru = havuz[rnd.Next(havuz.Count)];
            lblSoru.Text = $"'{suankiSoru.Ingilizce}' kelimesinin anlamı nedir?";

            List<string> siklar = new List<string> { suankiSoru.Turkce };
            while (siklar.Count < 4)
            {
                string rastgeleCevap = havuz[rnd.Next(havuz.Count)].Turkce;
                if (!siklar.Contains(rastgeleCevap))
                    siklar.Add(rastgeleCevap);
            }

            siklar = siklar.OrderBy(x => rnd.Next()).ToList();
            btnA.Text = siklar[0];
            btnB.Text = siklar[1];
            btnC.Text = siklar[2];
            btnD.Text = siklar[3];
        }

        private void SecenekSecildi(object sender, EventArgs e)
        {
            if (cevapVerildi) return;
            cevapVerildi = true;
            Button tiklananButon = (Button)sender;

            if (tiklananButon.Text == suankiSoru.Turkce)
            {
                dogruSayisi++;
                lblDurum.Text = "Tebrikler, doğru bildin!";
                lblDurum.ForeColor = Color.Green;
            }
            else
            {
                yanlisSayisi++;
                lblDurum.Text = $"Yanlış! Doğrusu '{suankiSoru.Turkce}' olacaktı.";
                lblDurum.ForeColor = Color.Red;
            }

            lblSkor.Text = $"Doğru: {dogruSayisi}   |   Yanlış: {yanlisSayisi}";
            btnSonraki.Visible = true;
        }

        private void SonrakiSoruGec(object sender, EventArgs e)
        {
            YeniSoruGetir();
        }

        private void SınaviBitir(object sender, EventArgs e)
        {
            OyunEkraniniGizle();
            btnBitir.Visible = false;

            lblSoru.Text = $"Sınav Bitti!\nToplam Doğru: {dogruSayisi}\nToplam Yanlış: {yanlisSayisi}";
            lblSoru.Visible = true;

            btnBaslat.Text = "Yeniden Başlat";
            btnBaslat.Visible = true;
        }
    }

       public class Kelime
    {
        public string Ingilizce { get; set; }
        public string Turkce { get; set; }
        public Kelime(string ingilizce, string turkce)
        {
            Ingilizce = ingilizce;
            Turkce = turkce;
        }
    }
}