// See https://aka.ms/new-console-template for more information

//1.Metinsel veriler (Dosya yolları, isimler)
string userName = "User";
string filePath = "C:\\Document\\Report.xlsx";

//2.Sayısal veriler (Maaş, harcama ,döngü sayısı)
int dailyTaskCount = 5;
decimal expenseAmount = 1500.75m; // 'm' harfi para birimi (decimal) olduğunu belirtir.

// 3.Mantıksal veriler (İş bitti mi? Dosya bulundu mu?)
bool isTaskCompleted = true;

if (isTaskCompleted)
{
    Console.WriteLine("Harika! Dosya hazır.");
}
else
{
    Console.WriteLine("Dosya hazırlanma aşamasında");
}

//Ekrana yazdırma
Console.WriteLine("Hos geldin " + userName);
Console.WriteLine("Bugünkü görev sayısı: " + dailyTaskCount);