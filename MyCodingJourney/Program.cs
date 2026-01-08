// See https://aka.ms/new-console-template for more information


static bool SifreKontrolEt()
{
    Console.Write("Sistem Şifresini Giriniz: ");
    string? girilen =Console.ReadLine();

    if(girilen == "1234")
    {
        Console.WriteLine("Giriş Başarılı!");
        return true;
    }
    else
    {
        return false;
    }
}

static int UrunSayisiniGetir(string[] liste)
{
    int sayi = liste.Length;
    return sayi;
}
static void UrunleriListele(string[] liste)
{
    
    

    Console.WriteLine("\nÜrünler Listesi");
    foreach (string urun in liste)
    {
        Console.WriteLine("- " + urun);
    }
}

static void Selamla()
{
    Console.WriteLine("Sisteme Hoş Geldiniz.");
}

Selamla();

// Şifre kontrolü doğru olmadığı sürece programın devamına izin vermeyelim.
if(SifreKontrolEt() == false)
{
    Console.WriteLine("Yetkisiz Giriş! Programda kapatılıyor.");
    return; // Main metodundan çıkar, yani programı bitirir.
}

// --- Şifre doğruysa burdaki eski kodların çalışmaya devam eder ---
// bool programCalışıyor = true; ... diye devam eden o meşhur while döngün.

string[] urunler = { "Klavye", "Mouse", "Monitör" };
bool programCalisiyor = true;

int toplamUrun =UrunSayisiniGetir(urunler);
Console.WriteLine("Sistemde toplam " + toplamUrun + " ürün kayıtlı.");

while (programCalisiyor)
{
    Console.WriteLine("\n--- OTOMASYON PANELİ ---");
    Console.WriteLine("\n1 - Dosya Durumu Kontrol Et");
    Console.WriteLine("2 - Çıkış Yap");

    

    Console.Write("Seçiminiz: ");
    string? secim = Console.ReadLine();


    if (secim == "1")
    {
        UrunleriListele(urunler);
    }
    else if(secim == "2")
    {
        programCalisiyor = false; // Döngüyü kırar ve programı bitirir.
        Console.WriteLine("Otomasyon kapatılıyor. İyi günler!");
    }
    else
    {
        Console.WriteLine("Geçersiz secim, lütfen tekrar deneyin");
    }



}