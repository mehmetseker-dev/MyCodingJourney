// See https://aka.ms/new-console-template for more information

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

string[] urunler = { "Klavye", "Mouse", "Monitör" };
bool programCalisiyor = true;

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