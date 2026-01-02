// See https://aka.ms/new-console-template for more information

Console.WriteLine("---Budget Control Panel---");

Console.Write("Please Enter Your Monthly Budget: ");
//Kalvyeden girilen metni(string)okur. (kalvyeden geln herşey stringtir.)
string? enteredBudget = Console.ReadLine();

//DİKKAT: Klavyeden geşlen herşey 'string' (metin)olarak gelir.
//Hesap yapabilmek için onu 'decimal' kutusuna dönüştürmemiz (convert) gerekir.

decimal budget = Convert.ToDecimal(enteredBudget);

Console.Write("Enter The Amount Spent: ");
decimal spending = Convert.ToDecimal(Console.ReadLine());

if(spending > budget)
{
    Console.WriteLine("WARNİNG:You exceeded your budget by " + (spending - budget) + " TL");
}
else
{
    Console.WriteLine("Congratulations! You are save to " + (budget - spending) + " TL from your budget." );
}