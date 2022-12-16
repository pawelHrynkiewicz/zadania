// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


//****************zadanie 1*************


// int Silnia (int a){
//     int wynik=1;
//     for (int i=1; i<=a; i++){
//         wynik*=i;
//     }
//     return wynik;
// }

// Console.WriteLine(Silnia(3));
// Console.WriteLine(Silnia(4));
// Console.WriteLine(Silnia(5));
// Console.WriteLine(Silnia(6));
// Console.WriteLine(Silnia(7));


// int Silnia1 (int a){
//     int wynik=1;
//     int i=1;
//     while (i<=a){
//         wynik*=i;
//         i++;
//     }
//     return wynik;
// }

// Console.WriteLine(Silnia1(3));
// Console.WriteLine(Silnia1(4));
// Console.WriteLine(Silnia1(5));
// Console.WriteLine(Silnia1(6));
// Console.WriteLine(Silnia1(7));


// int Silnia2(int a){
//     int i=1;
//     int wynik=1;
//     do{
//         wynik*=i;
//         i++;
//     }
//     while (i<=a);
//     return wynik;
// }

// Console.WriteLine(Silnia2(3));
// Console.WriteLine(Silnia2(4));
// Console.WriteLine(Silnia2(5));
// Console.WriteLine(Silnia2(6));
// Console.WriteLine(Silnia2(7));

//************zadanie 2**************

// double Odleglosc (double x1, double y1, double x2, double y2){

//     double wynik;
//     wynik=(x1-x2)*(x1-x2)+(y1-y2)*(y1-y2);
//     wynik=Math.Sqrt(wynik);
//     return wynik;
    
// }

// Console.WriteLine(Odleglosc(0,0,3,4));

//***********zadanie 3*************

// double Pitagoras(double a, double b){
//     double c=a*a+b*b;
//     return Math.Sqrt(c);
// }

// Console.WriteLine(Pitagoras(3,4));


// ***************** zadanie 4 ****************
int Pierwsza (int ile){
    int count=0;
    int dzielna=2;
    bool pierwsza;
    while (true){
        pierwsza=true;
        for (int dzielnik=2; dzielnik<=Math.Sqrt(dzielna);dzielnik++){
            if (dzielna%dzielnik==0){
                pierwsza=false;
            }
        }
        if (pierwsza){
            count++;
            if (count==ile){
                return dzielna;
            }
        }
        dzielna++;

    }

}



for (int i=1;i<10;i++){
    Console.WriteLine(Pierwsza(i));
}



// ******************* zadanie 5 i 6*******************

// int NWD (int a, int b){
//     if (b>a){
//         int temp;
//         temp=a;
//         a=b;
//         b=temp;
//     }

//     while (true){
//         if (a%b==0){
//             return b;
//         }
//         else {
//             int temp=a;
//             a=b;
//             b=temp%b;
//         }
//     }

// }

// int NWW(int a, int b){
//     return a*b/NWD(a,b);
// }

// //Console.WriteLine(NWD(36,18));
// Console.WriteLine(NWW(6,8));

//***************** ZADANIE 7*************

// double Prostokat(double a, double b){
//     return a*b;
// }
// Console.WriteLine(Prostokat(20,30));

// ***************** ZADANIE 8*************

// double Trojkat(double a, double h){
//     return a*h/2;
// }
// Console.WriteLine(Trojkat(20,30));

// *************zadanie 9*************

// double Rownoleglobok(double a, double h){
//     return a*h;
// }
// Console.WriteLine(Rownoleglobok(20,30));


// *************zadanie 10*************

// double Trapez(double a, double b, double h){
//     return (a+b)*h/2;
// }
// Console.WriteLine(Trapez(20,30,30));