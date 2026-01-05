// See https://aka.ms/new-console-template for more information

// 1.Bir dizi (çekmece)oluşturalım. İçinde 3 tane dosya adı olun.
string[] dosyalar = { "Rapor_1", "Rapor_2", "Rapor_3" };

Console.Write("Aramak istediğiniz dosya adını girin: ");
string? aranan = Console.ReadLine();

bool bulunduMu = false;

//2.Foreach döngüsü ile bu çekmecenin içine sırayla bakalım.
//Bilgisayara diyoruz ki: "dosyalar" dizisindeki her bir "dosya" için şunları yap.
foreach (string dosya  in dosyalar)
{
    if(dosya == aranan)
    {
        bulunduMu = true;
        break; // Dosyayı bulduysak döngüden çıkalım., boşuna devam etmesin.
    }
}
if (bulunduMu)
{
    Console.WriteLine("Sistem Mesajı: Dosya bulundu ve işleme alındı.");
}
else
{
    Console.WriteLine("Sistem Mesajı: Hata! Aranan dosya Listede yok.");
}