// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


double Pierwsze(double x){
    return -x*x*x+2*x*x-x-4;
}

Console.WriteLine(Pierwsze(3));
//**********

double Drugie(double x){
    return 9*x*x*x*x-12*x*x+4;
}

Console.WriteLine(Drugie(3));
//**********


double Trzecie(double x){
    return 9*x*x*x*x-4;
}

Console.WriteLine(Trzecie(3));
//**********

double Czwarte(double x){
    return 9*x*x*x*x+4;
}

Console.WriteLine(Czwarte(3));
//**********



double Piate(double x){
    return x*x-4*x+4;
}

Console.WriteLine(Piate(3));
//**********

double Szoste(double x){
    return x*x+2*x+4;
}

Console.WriteLine(Szoste(3));
//**********

double Siodme(double x){
    return (1-x)*(x+2)*(x*x-4);
}

Console.WriteLine(Siodme(3));
//**********

double Osme(double x){
    return (x-3)*(x+3)*(x*x-9);
}

Console.WriteLine(Osme(3));
//**********

double Dziewiate(double x){
    return (x*x+1)*(x*x+4)*(x*x+3);
}

Console.WriteLine(Dziewiate(3));
//**********

double Ostatnie(double x){
    return (2-x)*(x+3)*(x*x-1);
}

Console.WriteLine(Ostatnie(3));