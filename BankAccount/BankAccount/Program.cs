using BankAccount;
using System.Runtime.InteropServices;

bool CloseApp = false;
while (!CloseApp)
{
    Console.WriteLine("Podaj numer rachunku");
    string nrRachunku = Console.ReadLine();
    Account account = new Account(nrRachunku);

    Console.WriteLine("Dostępne operacje: Wpłata, Wypłata, Podgląd salda");

    while (true)
    {
        Console.WriteLine("Wprowadż kwotę wpłaty lub z '-' dla wypłaty, 's' dla sprawdzenia salda");
        var input = Console.ReadLine();
        if (input == "s")
        {
            break;
        }

        try
        {
            account.AddCashflow(input);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    var statistics = account.GetStatistics();
    Console.WriteLine("==========================================");
    Console.WriteLine($"Typ rachunku: {statistics.Scorring}");
    Console.WriteLine($"Saldo: {statistics.Saldo}");
    Console.WriteLine($"Suma wpłat: {statistics.SumCashIn}");
    Console.WriteLine($"Suma wypłat: {statistics.SumCashOut}");
    Console.WriteLine("==========================================");
    
    Console.WriteLine("Naciśnij dowolny przycisk i kontynuuj dla innego rachunku lub 'q' - wyjście z programu"); 
    string command = Console.ReadLine();
    
    if (command == "q")
    {
        CloseApp = true;
    }
    else
    {
        continue;
    }
}
