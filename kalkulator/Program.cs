// ---------------------------------
//          KALKULATOR
// ---------------------------------

// Napisz aplikacje ktora bedzie umozliwiac wykonywanie najprostszych
// zadan matematycznych w kalkulatorze:
// - dodawanie
// - odejmowanie
// - dzielenie
// - mnozenie

// - potegowanie
// - pierwiastkowanie

// Program ma byc przystepny wizualnie dla uzytkownika oraz umozliwiac w kazdej chwili wyjscie z 
// aplikacji przyciskiem ESC

var shutDown = false;

Console.WriteLine("Witaj w programie KALKULATOR\n\n");


while (!shutDown)
{
    Console.WriteLine("Aby wyjsc z programu wcisnij [ESC]. Wcisnij jakikolwiek inny przycisk jesli chcesz isc dalej");
    var pressedKey = Console.ReadKey();



    // jak sprawdzic czy wcisnelismy ESC
    //if (pressedKey.Key.ToString() == "Escape")
    //{
    //    // TODO Dla mnie i dla was -> dlaczego po wywoalniu ReadKey ucina nam pierwszy znak w nastepnym
    //    //  Console.WriteLine
    //    Console.WriteLine("WCISNALES ESCAPE");
    //}





    if (pressedKey.Key == ConsoleKey.Escape)
    {
        shutDown = true;
    }
    else
    {
        Console.WriteLine("Wybierz typ operatora matematycznego: [dod - dodawanie, od - odejmowanie, dz - dzielenie, mn - mnozenie]");
        var providedValue = Console.ReadLine();

        switch (providedValue)
        {
            case "dod":
                Console.WriteLine("Podaj liczby do dodania i po kazdej z nich kliknij enter. Aby zobaczyc wynik wpisz znak =");
                Add();
                break;
            case "od":
                Console.WriteLine("Podaj pierwsza liczbe od ktorej odejmowane nastepne i po kazdej nacisnij enter. Aby zoaczyc wynik wpisz znak");
                Odj(); 
                break;
            case "dz":
                Console.WriteLine("Zaczynam dzielenie...");
                break;
            case "mn":
                Console.WriteLine("Zaczynam mnozenie...");
                break;
        }
    }
}

void Add()
{
    var stopAdding = false;
    var sum = 0;

    while (!stopAdding)
    {
        var value = Console.ReadLine();

        // ten jeden raz uzyje TryParse by pokazac jak go dobrze uzyc
        // ALE dalej uzyje Parse ktory ryzykuje bledem jak ktos poda litere a nie liczbe
        // ZADANIE DOMOWE: uzyc wszedzie TryParse ALBO obsluzyc try...catchem mozliwe bledy

        // out to jest slowo kluczowe ktore powoduje ze z metody mozna zwrocic
        // wiecej niz jedna wartosc
        // WIEC metoda TryParse zwraca bool mowiacy czy konwersja sie udala
        // ORAZ out wyrzuca nam przekonwertowana wartosc
        var parseResult = int.TryParse(value, out int num);

        if (!parseResult)
        {
            // To uzycie tutaj jest ok, bo ta aplikacja jest mala i nierozbudowana
            // wiec nie musimy pisac jej doskonale na kazdym poziomie

            if (value == "=")
            {
                Console.WriteLine("Wynik: " + sum);
            }
            else
            {
                // Zakladam, ze jak ktos podal zla wartosc to pogram ma sie wylaczyc
                Console.WriteLine("Podales zla wartosc, mozesz podac tylko liczby!!!");
                shutDown = true;
            }
            stopAdding = true;
        }
        else
        {
            //sum = sum + num; // to jest to samo co ponizej
            sum += num;
        }
    }
}

void Odj()
{
    var stopSubtracting = false;
    var value1= Console.ReadLine();
    var parseResult= int.TryParse(value1, out int wynik);
    if (!parseResult){
        Console.WriteLine("Podales zla wartosc, mozesz podac tylko liczby!!!");
        stopSubtracting=true;

    }

    while (!stopSubtracting)
    {
        var value = Console.ReadLine();
        parseResult = int.TryParse(value, out int num);

        if (!parseResult)
        {

            if (value == "=")
            {
                Console.WriteLine("Wynik: " + wynik);
            }
            else
            {
                // Zakladam, ze jak ktos podal zla wartosc to pogram ma sie wylaczyc
                Console.WriteLine("Podales zla wartosc, mozesz podac tylko liczby!!!");
                shutDown = true;
            }
            stopSubtracting = true;
        }
        else
        {

            wynik -= num;
        }
    }
}
Console.WriteLine("Shutting down the app...");