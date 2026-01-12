// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic; // LİSTELER İÇİN ŞART!

class Program
{
    //1.ADIM: Listeyi metotların DIŞINDA, class' ın altında tanımlıyoruz.
    // Eski "string[] urunler " satırını tamamen sil, yerine bunu yaz:
    static List<string> urunler = new List<string> { "Klavye", "Mouse", "Monitör" };

    static void Main(string[] args)
    {
        Selamla();

        // Şifre kontrolü doğru olmadığı sürece programın devamına izin vermeyelim.
        if (SifreKontrolEt() == false)
        {
            Console.WriteLine("Yetkisiz Giriş! Programda kapatılıyor.");
            return; // Main metodundan çıkar, yani programı bitirir.
        }

        // --- Şifre doğruysa burdaki eski kodların çalışmaya devam eder ---
        // bool programCalışıyor = true; ... diye devam eden o meşhur while döngün.

        //Şifre ve Selamla metotlarını burada çağırıyoruz.
        bool programCalisiyor = true;

        while (programCalisiyor)
        {
            Console.WriteLine("\n--- ENVANTER YÖNETİMİ ---");
            Console.WriteLine("1 - Listele | 2- Ürün Ekle | 3-Ürün kaldır | 4-Ürün Arama | 5-Çıkış");
            Console.Write("Seçiminiz: ");
            string? secim = Console.ReadLine();


            if (secim == "1")
            {
                UrunleriListele();
            }
            else if (secim == "2")
            {
                UrunEkle();
            }
            else if (secim == "3")
            {
                UrunSil();
            }
            else if (secim == "4")
            {
                UrunAra();
            }
            else if (secim == "5")
            {
                programCalisiyor = false;
            }
        }
    }

    //2.ADIM: Listeleme Metodu (Parametre almsına gereke kalmadı, global listeyi kullanıyor.
    static void UrunleriListele()
    {
        Console.WriteLine("\nGüncel Ürünler:");
        foreach (string urun in urunler)
        {
            Console.WriteLine("- " + urun);
        }
    }

    //3.ADIM: Yeni ürün Ekleme Metodu
    static void UrunEkle()
    {
        Console.Write("Yeni ürün adı: ");
        string? yeni =Console.ReadLine();
        if (!string.IsNullOrEmpty(yeni))
        { 
        urunler.Add(yeni); // Listeye ekleme yapar.
        Console.WriteLine("Ürün başarıyla eklendi!");
        }
    }

    static void UrunSil()
    {
        Console.Write("Kaldırılacak Ürün Adı: ");
        string? silinecek = Console.ReadLine();

        if(!string.IsNullOrEmpty(silinecek))
        {
            bool silindiMi = urunler.Remove(silinecek);
            if (silindiMi)
            {
                Console.WriteLine("İleti: " + silinecek + " başarıyla silindi.");
            }
            else
            {
                Console.WriteLine("Hata: Listede '" + silinecek + "' bulunamadığı için silinemedi.");
            }
                urunler.Remove(silinecek);
            
        }
    }

    static void UrunAra()
    {
        Console.Write("Aranılacak Ürün Adı: ");
        string? aranan = Console.ReadLine();

        if (!string.IsNullOrEmpty(aranan))
        {
            if(urunler.Contains(aranan))
            {
                Console.WriteLine("Sonuç: " + aranan + " stoklarımızda mevcuttur.");
            }
            else
            {
                Console.WriteLine("Sonuç: '" + aranan + "' isimli bir ürün bulunamadı.");
            }
        }
    }
    static bool SifreKontrolEt()
    {
        Console.Write("Sistem Şifresini Giriniz: ");
        string? girilen = Console.ReadLine();

        if (girilen == "1234")
        {
            Console.WriteLine("Giriş Başarılı!");
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Selamla()
    {
        Console.WriteLine("Sisteme Hoş Geldiniz.");
    }


}