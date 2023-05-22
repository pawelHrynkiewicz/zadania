// **********************INSTRUKCJA OBLUGI EXIT*********************************
// Zadanie 1 -> aby wyjsc z petli trzeba wpisac exit w momencie podawania liczby
// Zadanie 2 -> aby wysjsc z petli trzeba wpisac exit w momencie podawania zdanie
//              pisanie exit w moemncie podawania liczb nic nie da
// Zadanie 3 bez herezji -> exit zadziala tylko w momencie gdy program poprosi o wpisanie exit
//                      to jest jedyny przypadek gdzie koniecznie trzeba chociaz raz przejsc przez petle
// Zadanie 3 z potencjalna herezja -> exit mozna wpisywac zawsze i zadziala

//****************zadanie 3 z brzydkim exitem, ale na pewno bez herezji XD ***********

using System;
using ObslugiwanieBledow1;

decimal WczytajLiczbeDec()
{
    decimal liczba;
    var numString = Console.ReadLine();

    try
    {
        liczba = decimal.Parse(numString);
    }
    catch (Exception ex)
    {
        throw new MyException(numString);
    }

    return liczba;
}


string przerwij = "";
decimal dzielna = 0;
decimal dzielnik = 0;
decimal iloraz = 0;

bool shutDown = false;

Console.WriteLine("Zadanie 3 bez herezji");

while (!shutDown)
{
    try
    {
        Console.WriteLine("Podaj dzielna");
        dzielna = WczytajLiczbeDec();

        Console.WriteLine("Podaj dzielnik");
        dzielnik = WczytajLiczbeDec();
    }
    catch (MyException ex)
    {
        if (ex.NumString == "exit")
        {
            shutDown = true;
        }

        System.Console.WriteLine("Podales zla liczbe!");
    }
}

while (!string.Equals(przerwij.ToLower(), "exit"))
{
    bool podzielone = false;
    Console.WriteLine("Podaj dzielna");
    dzielna = WczytajLiczbeDec();
    Console.WriteLine("Podaj dzielnik");
    dzielnik = WczytajLiczbeDec();

    while (!podzielone)
    {
        try
        {
            iloraz = decimal.Divide(dzielna, dzielnik);
            podzielone = true;
        }
        catch (DivideByZeroException ex1)
        {
            Console.WriteLine(ex1.Message);
            Console.WriteLine("Podaj dzielna");
            dzielna = WczytajLiczbeDec();
            Console.WriteLine("Podaj dzielnik rozny od zera!!!");
            dzielnik = WczytajLiczbeDec();
        }
        catch (OverflowException ex2)
        {
            Console.WriteLine(ex2.Message);
            Console.WriteLine("Podaj dzielna");
            dzielna = WczytajLiczbeDec();
            Console.WriteLine("Podaj dzielnik");
            dzielnik = WczytajLiczbeDec();
        }
    }

    Console.WriteLine(dzielna + "/" + dzielnik + "=" + iloraz);


    Console.WriteLine("aby wyjsc wpisz 'exit'");
    przerwij = Console.ReadLine();
}