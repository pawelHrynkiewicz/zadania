//****************zadanie 1*************
int Silnia(int a)
{
    int wynik = 1;
    for (int i = 1; i <= a; i++)
    {
        wynik *= i;
    }
    return wynik;
}

Console.WriteLine("Zadanie 1 petla for\n");
Console.WriteLine("3!=" + Silnia(3));
Console.WriteLine("4!=" + Silnia(4));
Console.WriteLine("5!=" + Silnia(5));
Console.WriteLine("6!=" + Silnia(6));
Console.WriteLine("7!=" + Silnia(7));
Console.WriteLine("\n\n");


int Silnia1(int a)
{
    int wynik = 1;
    int i = 1;
    while (i <= a)
    {
        wynik *= i;
        i++;
    }
    return wynik;
}

Console.WriteLine("Zadanie 1 petla while");
Console.WriteLine("3!=" + Silnia1(3));
Console.WriteLine("4!=" + Silnia1(4));
Console.WriteLine("5!=" + Silnia1(5));
Console.WriteLine("6!=" + Silnia1(6));
Console.WriteLine("7!=" + Silnia1(7));
Console.WriteLine("\n\n");


int Silnia2(int a)
{
    int i = 1;
    int wynik = 1;
    do
    {
        wynik *= i;
        i++;
    }
    while (i <= a);
    return wynik;
}

Console.WriteLine("Zadanie 1 petla do while");
Console.WriteLine("3!=" + Silnia2(3));
Console.WriteLine("4!=" + Silnia2(4));
Console.WriteLine("5!=" + Silnia2(5));
Console.WriteLine("6!=" + Silnia2(6));
Console.WriteLine("7!=" + Silnia2(7));
Console.WriteLine("\n\n");

//************zadanie 2**************

double Odleglosc(double x1, double y1, double x2, double y2)
{
    double wynik;
    wynik = (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);
    wynik = Math.Sqrt(wynik);
    return wynik;
}

Console.WriteLine("zadanie 2");
double x1 = 0;
double y1 = 0;
double x2 = 3;
double y2 = 4;
Console.WriteLine($"Odleglosc miedzy punktami ({x1},{y1}), ({x2},{y2}) wynosi: {Odleglosc(x1, y1, x2, y2)}");
Console.WriteLine("\n\n");
//***********zadanie 3*************

double Pitagoras(double a, double b)
{
    double c = a * a + b * b;
    return Math.Sqrt(c);
}
double a = 3;
double b = 4;
Console.WriteLine("Zadanie3");
Console.WriteLine($"Przeciwprostokatna trojkata o przyprostokatnych {a} i {b} wynosi: {Pitagoras(a, b)}");
Console.WriteLine("\n");

// ***************** zadanie 4 ****************
int Pierwsza(int ile)
{
    int count = 0;
    int dzielna = 2;
    bool pierwsza;
    while (true)
    {
        pierwsza = true;
        for (int dzielnik = 2; dzielnik <= Math.Sqrt(dzielna); dzielnik++)
        {
            if (dzielna % dzielnik == 0)
            {
                pierwsza = false;
            }
        }
        if (pierwsza)
        {
            count++;
            if (count == ile)
            {
                return dzielna;
            }
        }
        dzielna++;
    }
}

Console.WriteLine("Zadanie 4");
for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"{Pierwsza(i)} to {i} liczba pierwsza z kolei");
}
Console.WriteLine("\n");

// ******************* zadanie 5 i 6*******************
int NWD(int a, int b)
{
    if (b > a)
    {
        int temp;
        temp = a;
        a = b;
        b = temp;
    }
    while (true)
    {
        if (a % b == 0)
        {
            return b;
        }
        else
        {
            int temp = a;
            a = b;
            b = temp % b;
        }
    }

}

int NWW(int a, int b)
{
    return a * b / NWD(a, b);
}
int a5 = 36;
int b5 = 18;
int a6 = 6;
int b6 = 8;
Console.WriteLine("zadanie 5");
Console.WriteLine($"NWD liczb {a5} i {b5} to {NWD(a5, b5)}\n");
Console.WriteLine("zadanie 6");
Console.WriteLine($"NWW liczb {a6} i {b6} to {NWW(a6, b6)}\n");

//***************** ZADANIE 7*************
double Prostokat(double a, double b)
{
    return a * b;
}
int a7 = 20;
int b7 = 30;
Console.WriteLine("zadanie 7");
Console.WriteLine($"Pole prostokata o wymiarach {a7}x{b7} wynosi {Prostokat(a7, b7)}\n");

//***************** ZADANIE 8*************

double Trojkat(double a, double h)
{
    return a * h / 2;
}
double a8 = 20;
double h8 = 30;
Console.WriteLine("zadanie 8");
Console.WriteLine($"Pole trojkata o podstawie {a8} i wysokosci {h8} wynosi {Trojkat(a8, h8)}\n");

// *************zadanie 9*************

double Rownoleglobok(double a, double h)
{
    return a * h;
}
int a9 = 20;
int h9 = 30;
Console.WriteLine("zadanie 9");
Console.WriteLine($"Pole rownolegloboku o podstawie {a9} i wysokosci {h9} wynosi {Rownoleglobok(a9, h9)}\n");

// *************zadanie 10*************

double Trapez(double a, double b, double h)
{
    return (a + b) * h / 2;
}
int a10 = 20;
int b10 = 30;
int h10 = 30;
Console.WriteLine("zadanie 10");
Console.WriteLine($"Pole trapezu o podstawach {a10}, {b10} i wysokosci {h10} wynosi {Trapez(a10, b10, h10)}\n");