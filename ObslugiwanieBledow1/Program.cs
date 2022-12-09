// See https://aka.ms/new-console-template for more information

//*************zadanie 1***************
Console.WriteLine("Podaje liczbe");
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



Console.WriteLine("Podaj zdanie");
var zdanie=Console.ReadLine();
if (!string.Equals(zdanie.ToLower(),"exit")){
    Console.WriteLine("Podaj od ktorego indeksu wycinac");
    start=WczytajLiczbe();
    Console.WriteLine("Podaj ile znakow wyciac");
    stop=WczytajLiczbe();
}
char[] destination=new char[Math.Abs(stop)]; // nie chce tutaj sprawdzac czy podana liczba jest ujemna
                                             // zeby moc wejsc w expection przy metodzie CopyTo
                                             //ktory to wylapie, wiec dalem na sile wartosc abs


while (!string.Equals(zdanie.ToLower(),"exit")){
    try{
        zdanie.CopyTo(start, destination,0, stop);
    }
    catch (ArgumentOutOfRangeException ex2) { // zdanie "Ala ma kota", wywali np przy start=-1 lub
        Console.WriteLine(ex2.Message);       // stop=-1 lub stop=1000
    }
    catch (ArgumentNullException ex1) { //znowu bez przykladu
        Console.WriteLine(ex1.Message);
    }

    Console.WriteLine(destination);
    Console.WriteLine("Podaj zdanie");
    zdanie=Console.ReadLine();
    if (!string.Equals(zdanie.ToLower(),"exit")){
        Console.WriteLine("Podaj od ktorego indeksu wycinac");
        start=WczytajLiczbe();
    Console.WriteLine("Podaj ile znakow wyciac");
        stop=WczytajLiczbe();
}
}







