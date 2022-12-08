// See https://aka.ms/new-console-template for more information
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






