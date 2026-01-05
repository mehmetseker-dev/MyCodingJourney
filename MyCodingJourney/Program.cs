// See https://aka.ms/new-console-template for more information

Console.WriteLine("---Budget Control Panel---");

try
{
    // Hata yapma ihtimali olan kodlar buraya yazılır.
    Console.Write("Please! Enter a numerical budget; ");
    decimal budget = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Your budget has been successfully saved: " + budget);

    Console.Write("\nYou've entered your expense.; ");
    decimal totalExpence = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Your expence has been successfully saved: " + totalExpence);

    decimal budgetGap = budget - totalExpence;
    Console.WriteLine("\nYour Budget difference:" + budgetGap);

    if (budgetGap >= 0)
    {
        Console.WriteLine("\nConguratulations! You did not exceed the budget.");
    }
    else
    {
        Console.WriteLine("Warning! Your budget has been exceeded.");
    }

}
catch (Exception)
{
    //Eğer yukarıda bir hata olursa, program kapanmaz ve buraya atlar.
    Console.WriteLine("ERROR: Please enter just numeral! The program crash was prevented.");
}