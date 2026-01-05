 // See https://aka.ms/new-console-template for more information

string[] products = { "Elma", "Armut", "Portakal", "Mandalina", "Limon" };

Console.Write("Ürün seçiniz: ");
string? secim = Console.ReadLine();

bool varMı = false;

foreach (string product in products)
{
    if (product == secim)
    {
        varMı = true;
        break;
    }
}
if (varMı)
{
    Console.WriteLine(" Ürün stoktaki mevcut");
}
else
{
    Console.WriteLine("Ürün stokta mevcut değil.");
}