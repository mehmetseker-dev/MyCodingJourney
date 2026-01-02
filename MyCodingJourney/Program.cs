// See https://aka.ms/new-console-template for more information

//5 farklı EXcel dosyasının adını bir sepete koyuyıruz
using System.Runtime.CompilerServices;

string[] excelFiles = { "Satislar_Ocak", "Satislar_Subat", "Satislar_Mart", "Giderler_2025", "Personel_Prim", "1113", "1114" };

// Bu sepetin içindeki 1.dosyayı (yazılımda sayma 0'dan başlar) ekrana yazdıralım.
Console.WriteLine("Lstenin ilk dosyası: " + excelFiles[0]);

Console.WriteLine("--- Otomasyon Başlıyor ---");

for (int i = 0; i< excelFiles.Length; i++)
{
    if (excelFiles[i] == "Giderler_2025")
    {
        Console.WriteLine("DİKKAT: Bu bütçe dosyasıdır!");
    }
    else 
    {
    
    }
        //i her turda 0, 1 , 2, 3, 4 olacak...
        Console.WriteLine(excelFiles[i] + ".xlsx dosyası işleniyor...");
    Console.WriteLine("Veriler kopyalandı ve PDF'e dönüştürüldü.");
    Console.WriteLine("---------------------------------------");
}

Console.WriteLine("Tüm işlemler başarıyla tamamlandı!");