﻿// **********************INSTRUKCJA OBLUGI EXIT*********************************
// Zadanie 1 -> aby wyjsc z petli trzeba wpisac exit w momencie podawania liczby
// Zadanie 2 -> aby wysjsc z petli trzeba wpisac exit w momencie podawania zdanie
//              pisanie exit w moemncie podawania liczb nic nie da
// Zadanie 3 bez herezji -> exit zadziala tylko w momencie gdy program poprosi o wpisanie exit
//                      to jest jedyny przypadek gdzie koniecznie trzeba chociaz raz przejsc przez petle
// Zadanie 3 z potencjalna herezja -> exit mozna wpisywac zawsze i zadziala

//*************zadanie 1***************
Console.WriteLine("Zadanie 1");
Console.WriteLine("Podaj liczbe");
string a=Console.ReadLine();
int liczba;

while (!string.Equals(a.ToLower(),"exit")){
    


    try{
        liczba=int.Parse(a);
        Console.WriteLine("Podana liczba to *"+liczba+"* no i jestem INTem, wariacie");
    }
    // przykłady kiedy sie wywali: "elo", "1,65", "1e06", "$18" "100%"
    catch (FormatException ex1){
        Console.WriteLine(a+"->"+ex1.Message);
    }
    // przykłady kiedy sie wywali: "-2147483649", "2147483648"
    catch (OverflowException ex2){
        Console.WriteLine(a+"->"+ex2.Message);
    }

    // tu to nie wiem kiedy wbijemy - był wypisany na stronie microsoftu, ale bez przykłądu
    catch(ArgumentNullException ex3){
        Console.WriteLine(a+"->"+ex3.Message);
    }
    Console.WriteLine("Podaj liczbe");
    a=Console.ReadLine();

}

//******************************zadanie 2******************************

int WczytajLiczbe(){
    int liczba;
    var a=Console.ReadLine();
    try{
        liczba=int.Parse(a);
    }
    catch (FormatException ex1){
        Console.WriteLine(a+"->"+ex1.Message);
        Console.WriteLine("podaj prawidłową wartość");
        liczba=WczytajLiczbe();
    }

    catch (OverflowException ex2){
        Console.WriteLine(a+"->"+ex2.Message);
        Console.WriteLine("podaj prawidłową wartość");
        liczba=WczytajLiczbe();
    }

    catch(ArgumentNullException ex3){
        Console.WriteLine(a+"->"+ex3.Message);
        Console.WriteLine("podaj prawidłową wartość");
        liczba=WczytajLiczbe();
        
    }

    return liczba;


}

int start=0;
int stop=0;


Console.WriteLine("Zadanie 2");
Console.WriteLine("Podaj zdanie");
var zdanie=Console.ReadLine();
if (!string.Equals(zdanie.ToLower(),"exit")){
    Console.WriteLine("Podaj od ktorego indeksu wycinac");
    start=WczytajLiczbe();
    Console.WriteLine("Podaj ile znakow wyciac");
    stop=WczytajLiczbe();
}



while (!string.Equals(zdanie.ToLower(),"exit")){
    char[] destination=new char[Math.Abs(stop)]; // nie chce tutaj sprawdzac czy podana liczba jest ujemna
                                             // zeby moc wejsc w expection przy metodzie CopyTo
                                             //ktory to wylapie, wiec dalem na sile wartosc abs
    try{
        zdanie.CopyTo(start, destination,0, stop);
        Console.WriteLine("wyciety fragment to: ");
        foreach (char i in destination){
            Console.Write(i);
    }
    Console.Write("\n");
    }
    catch (ArgumentOutOfRangeException ex2) { // zdanie "Ala ma kota", wywali np przy start=-1 lub
        Console.WriteLine(ex2.Message);       // stop=-1 lub stop=1000
    }
    catch (ArgumentNullException ex1) { //znowu bez przykladu
        Console.WriteLine(ex1.Message);
    }


    Console.WriteLine("Podaj zdanie");
    zdanie=Console.ReadLine();
    if (!string.Equals(zdanie.ToLower(),"exit")){
        Console.WriteLine("Podaj od ktorego indeksu wycinac");
        start=WczytajLiczbe();
    Console.WriteLine("Podaj ile znakow wyciac");
        stop=WczytajLiczbe();
}
}


//****************zadanie 3 z brzydkim exitem, ale na pewno bez herezji XD ***********


decimal WczytajLiczbeDec(){
    decimal liczba;
    var a=Console.ReadLine();
    try{
        liczba=decimal.Parse(a);
    }
    catch (FormatException ex1){
        Console.WriteLine(a+"->"+ex1.Message);
        Console.WriteLine("podaj prawidłową wartość");
        liczba=WczytajLiczbeDec();
    }

    catch (OverflowException ex2){
        Console.WriteLine(a+"->"+ex2.Message);
        Console.WriteLine("podaj prawidłową wartość");
        liczba=WczytajLiczbeDec();
    }

    catch(ArgumentNullException ex3){
        Console.WriteLine(a+"->"+ex3.Message);
        Console.WriteLine("podaj prawidłową wartość");
        liczba=WczytajLiczbeDec();
        
    }

    return liczba;
}




string przerwij="";
decimal dzielna=0;
decimal dzielnik=0;
decimal iloraz=0;

Console.WriteLine("Zadanie 3 bez herezji");
while (!string.Equals(przerwij.ToLower(),"exit")){
    bool podzielone=false;
    Console.WriteLine("Podaj dzielna");
    dzielna=WczytajLiczbeDec();
    Console.WriteLine("Podaj dzielnik");
    dzielnik=WczytajLiczbeDec();

    while (!podzielone){
        try{
            iloraz=decimal.Divide(dzielna,dzielnik);
            podzielone=true;
        }
        catch (DivideByZeroException ex1){
            Console.WriteLine(ex1.Message);
            Console.WriteLine("Podaj dzielna");
            dzielna=WczytajLiczbeDec();
            Console.WriteLine("Podaj dzielnik rozny od zera!!!");
            dzielnik=WczytajLiczbeDec();   
        }
        catch (OverflowException ex2){
            Console.WriteLine(ex2.Message);
            Console.WriteLine("Podaj dzielna");
            dzielna=WczytajLiczbeDec();
            Console.WriteLine("Podaj dzielnik");
            dzielnik=WczytajLiczbeDec();
        }
    }
    
    Console.WriteLine(dzielna+"/"+dzielnik+"="+iloraz);


    Console.WriteLine("aby wyjsc wpisz 'exit'");
    przerwij=Console.ReadLine();


}




// ***** zadanie 3 - byc moze z herezja, ale z ladniejszym exitem XD*******************

Liczby pierwsza = new Liczby();
Liczby druga= new Liczby();
Liczby wynik= new Liczby();

Console.WriteLine("Zadanie 3 z potencjalna herezja");
while (true){
    Console.WriteLine("Podaj pierwsza liczbe");
    pierwsza.Przypisz();
    if (pierwsza.BylExit())
        break;

    Console.WriteLine("Podaj druga liczbe");
    druga.Przypisz();
    if (druga.BylExit())
        break;

    wynik=wynik.Podziel(pierwsza,druga);
    if (wynik.BylExit())
        break;
    Console.WriteLine("Wynik dzielenia to "+wynik.PokazWartosc());
}

struct Liczby{
    bool byl_exit;
    decimal wartosc;

    public Liczby(){
        byl_exit=false;
        wartosc=0;
    }

    public void Pokaz(){
        Console.WriteLine(wartosc);
    }
    public void Przypisz(){
        while (true){
            var zdanie=Console.ReadLine();
            if (string.Equals(zdanie.ToLower(),"exit")){
                byl_exit=true;
                break;
            }
            else{
                try {
                    wartosc=Decimal.Parse(zdanie);
                    break;
                }
                catch (FormatException ex1){
                    Console.WriteLine(zdanie+"->"+ex1.Message);
                    Console.WriteLine("podaj prawidłową wartość");
                }

                catch (OverflowException ex2){
                    Console.WriteLine(zdanie+"->"+ex2.Message);
                    Console.WriteLine("podaj prawidłową wartość");
                }

                catch(ArgumentNullException ex3){
                    Console.WriteLine(zdanie+"->"+ex3.Message);
                    Console.WriteLine("podaj prawidłową wartość");
                }
            }
            
            

                
            wartosc=0;
        }
    }
    public bool BylExit(){
        return byl_exit;
    }
    public decimal PokazWartosc(){
        return wartosc;
    }
    public Liczby Podziel(Liczby pierwsza, Liczby druga){
        Liczby wynik = new Liczby();
        pierwsza.byl_exit=false;
        druga.byl_exit=false;
        while (true){
            try{
                wynik.wartosc=decimal.Divide(pierwsza.wartosc,druga.wartosc);
                break;
            }
            catch (DivideByZeroException ex1){
                Console.WriteLine(ex1.Message);
                Console.WriteLine("podaj pierwsza liczbe");
                pierwsza.Przypisz();
                if (pierwsza.BylExit()){
                    wynik.byl_exit=true;
                    break;
                }
                Console.WriteLine("podaj druga liczbe");
                druga.Przypisz();
                if (druga.BylExit()){
                    wynik.byl_exit=true;
                    break;
                }

            }
            catch (OverflowException ex2){
                Console.WriteLine(ex2.Message);
                Console.WriteLine("podaj pierwsza liczbe");
                pierwsza.Przypisz();
                if (pierwsza.BylExit()){
                    wynik.byl_exit=true;
                    break;
                }
                Console.WriteLine("podaj druga liczbe");
                druga.Przypisz();
                if (druga.BylExit()){
                    wynik.byl_exit=true;
                    break;
                }

            }
        }
        return wynik;
    }

}