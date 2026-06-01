using System;
using System.Collections.Generic;
using System.Linq;
using System.IO; 

namespace KelimeOyunu
{
    class Kelime
    {
        public string Ingilizce { get; set; }
        public string Turkce { get; set; }

        public Kelime(string ingilizce, string turkce)
        {
            Ingilizce = ingilizce;
            Turkce = turkce;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Kelime> havuz = new List<Kelime>();
            string dosyaYolu = "kelimeler.txt";

            // 1. AŞAMA: DOSYAYI OKUMA VE HAVUZU DOLDURMA
            if (File.Exists(dosyaYolu))
            {
                // ReadAllLines: Dosyadaki tüm satırları okur ve bir diziye (array) atar
                string[] satirlar = File.ReadAllLines(dosyaYolu);

                // FOREACH YERİNE BİLDİĞİMİZ KLASİK FOR DÖNGÜSÜ KULLANDIK
                for (int j = 0; j < satirlar.Length; j++)
                {
                    string satir = satirlar[j]; // Sıradaki satırı alıyoruz
                    
                    // Split: Satırı virgülden (,) iki parçaya böler (0. index İngilizce, 1. index Türkçe olur)
                    string[] parcalar = satir.Split(','); 
                    
                    if (parcalar.Length == 2)
                    {
                        // Trim: Kelimelerin başındaki veya sonundaki gereksiz boşlukları temizler
                        havuz.Add(new Kelime(parcalar[0].Trim(), parcalar[1].Trim()));
                    }
                }
            }
            else
            {
                Console.WriteLine("HATA: 'kelimeler.txt' dosyası bulunamadı!");
                return; 
            }

            // 2. AŞAMA: OYUN MEKANİZMASI
            int puan = 0;
            Random rnd = new Random();

            Console.WriteLine("--- KELİME OYUNUNA HOŞ GELDİNİZ ---");
            Console.WriteLine($"Havuzda toplam {havuz.Count} kelime bulundu.");
            Console.WriteLine("Her doğru cevap 10 puan! Başlıyoruz...\n");

            for (int i = 0; i < havuz.Count; i++)
            {
                Kelime asilSoru = havuz[i];
                List<string> siklar = new List<string> { asilSoru.Turkce };

                while (siklar.Count < 4)
                {
                    int rastgeleIndex = rnd.Next(havuz.Count);
                    string rastgeleKelime = havuz[rastgeleIndex].Turkce;
                    
                    if (!siklar.Contains(rastgeleKelime))
                    {
                        siklar.Add(rastgeleKelime);
                    }
                }

                siklar = siklar.OrderBy(x => rnd.Next()).ToList();

                Console.WriteLine($"Soru {i + 1}: '{asilSoru.Ingilizce}' kelimesinin Türkçe anlamı nedir?");
                Console.WriteLine($"A) {siklar[0]}");
                Console.WriteLine($"B) {siklar[1]}");
                Console.WriteLine($"C) {siklar[2]}");
                Console.WriteLine($"D) {siklar[3]}");
                Console.Write("Cevabınız (A/B/C/D): ");

                string cevap = Console.ReadLine().ToUpper();
                string kullanicininSectigiMetin = "";

                if (cevap == "A") kullanicininSectigiMetin = siklar[0];
                else if (cevap == "B") kullanicininSectigiMetin = siklar[1];
                else if (cevap == "C") kullanicininSectigiMetin = siklar[2];
                else if (cevap == "D") kullanicininSectigiMetin = siklar[3];

                if (kullanicininSectigiMetin == asilSoru.Turkce)
                {
                    Console.WriteLine("Tebrikler! Doğru bildin.\n");
                    puan += 10;
                }
                else
                {
                    Console.WriteLine($"Yanlış cevap. Doğrusu '{asilSoru.Turkce}' olacaktı.\n");
                }
            }

            Console.WriteLine("--- OYUN BİTTİ ---");
            Console.WriteLine($"Toplam Puanınız: {puan}");
        }
    }
}