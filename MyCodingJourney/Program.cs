// See https://aka.ms/new-console-template for more information

//1.Kutularımızı hazırlayalım
decimal monthlyBudget = 5000.00m;
decimal totalExpenditures = 5500.00m;

bool emergencyMode = true;

// 2.Karar melanizması ()Kutuları karşılaştırıyoruz)
if(totalExpenditures > monthlyBudget && emergencyMode == true)
{
    Console.WriteLine("ATTENTİON: You exceeded the BUdget!");
    Console.WriteLine("CRİTİCAL WARNİNG: The Budget has been exceed and emergency mode has been activated!");
}
else
{
    Console.WriteLine("Congratulations, You are within Budget.");
}