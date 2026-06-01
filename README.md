# 🎮 İngilizce Kelime Oyunu 

Bu proje, C# Windows Forms kullanılarak geliştirilmiş, kullanıcıların İngilizce kelime dağarcıklarını test etmelerini ve geliştirmelerini sağlayan interaktif bir masaüstü uygulamasıdır. 

## 🌟 Projenin Özeti
Öğrenim sürecini oyunlaştırarak daha keyifli hale getirmeyi hedefleyen bu uygulama, **B2 (Upper-Intermediate)** seviyesindeki kelimelerden oluşan geniş bir veri havuzundan rastgele sorular seçerek kullanıcıya sunar. Eğitim ve yazılım mantığını bir araya getiren bir pratik aracıdır.

## 🚀 Öne Çıkan Özellikler
* **Dinamik Veri Havuzu:** Kelimeler kod içine gömülmek yerine dışarıdan bir `kelimeler.txt` dosyasından (File I/O) okunur. Bu sayede kodlara dokunmadan kelime havuzu sınırsızca genişletilebilir.
* **Gelişmiş Rastgelelik:** Her sınavda hem sorulan kelime hem de şıkların dizilimi algoritma (Random & LINQ) tarafından tamamen rastgele oluşturulur.
* **Katmanlı Mimari:** Profesyonel kodlama standartlarına sadık kalınarak, uygulamanın görsel tasarımı (`Designer.cs`) ile arka plandaki oyun mantığı (`Form1.cs`) birbirinden izole edilmiştir.
* **Anlık Geri Bildirim:** Kullanıcının doğru/yanlış istatistikleri ve anlık oyun durumu ekrana dinamik olarak yansıtılır.

## 💻 Kullanılan Teknolojiler
* **Programlama Dili:** C#
* **Platform:** .NET / Windows Forms
* **Veri Yönetimi:** System.IO, LINQ ve Generic Listeler (`List<T>`)

## ⚙️ Nasıl Çalıştırılır?
1. Bu depoyu sağ üstteki yeşil **Code** butonuna tıklayıp **Download ZIP** diyerek bilgisayarınıza indirin.
2. İndirdiğiniz klasörü ZIP'ten çıkartın.
3. İçerisindeki **`KelimeOyunu.slnx`** dosyasına çift tıklayarak projeyi Visual Studio'da aç
