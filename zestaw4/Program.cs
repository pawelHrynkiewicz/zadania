// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// losowe tablice do sprawdzania metod
int[] elo={1,4,35,4,6,434,4,1,76,43,43,656,33,11,11};
double[] elo1={1,4,35,4,6,434,4,1,76,43,43,656,33,11,11};


double GenRandom2(int minValue, int maxValue)
{
    Random rand = new Random();
    return rand.Next(minValue, maxValue);
}

double[] GenRandomArray(int size, int minValue,int maxValue){
    double[] tab= new double[size];
    for (int i=0;i<size;i++){
        tab[i]=GenRandom2(minValue,maxValue);
    }
    return tab;
}

foreach(double i in GenRandomArray(5,0,100)){
    Console.Write(i+" ");
}
Console.Write("\n");

// **************zadanie 1**************



// int ArrayMax (int[]tab){
//     int max=tab[0];
//     foreach(int i in tab){
//         if (i>max){
//             max=i;
//         }
//     }
//     return max;
// }

// double ArrayMax1 (double[]tab){
//     double max=tab[0];
//     foreach(double i in tab){
//         if (i>max){
//             max=i;
//         }
//     }
//     return max;
// }
// Console.WriteLine(ArrayMax(elo));
// Console.WriteLine(ArrayMax1(elo1));

// **************zadanie 2********************

int PrawieMax(int[] tab){
    if (tab.Length<2)
        return 0;
    int max1, max2;
    if (tab[0]>tab[1]){
        max1=tab[0];
        max2=tab[1];
    }
    else {
        max1=tab[1];
        max2=tab[0];
    }
    for (int i=2; i<tab.Length;i++){
        if (tab[i]>max1){
            max2=max1;
            max1=tab[i];
        }
        if((tab[i]>max2)&&(tab[i]<max1)){
            max2=tab[i];
        }
    }
    return max2;

}

double PrawieMax1(double[] tab){
    if (tab.Length<2)
        return 0;
    double max1, max2;
    if (tab[0]>tab[1]){
        max1=tab[0];
        max2=tab[1];
    }
    else {
        max1=tab[1];
        max2=tab[0];
    }
    for (int i=2; i<tab.Length;i++){
        if (tab[i]>max1){
            max2=max1;
            max1=tab[i];
        }
        if((tab[i]>max2)&&(tab[i]<max1)){
            max2=tab[i];
        }
    }
    return max2;

}


int[] tab1={50};
Console.WriteLine(PrawieMax(elo));
Console.WriteLine(PrawieMax1(elo1));
Console.WriteLine(PrawieMax(tab1));

//************zadanie 11*************** (tutej, bo fajno mieć chyba sortowanie przed liczeniem mediany)



double[] ShellSort(double[] tab){
    int size=tab.Length;
    for (int interval=size/2; interval>0;interval/=2){
        for (int i=interval; i<size; i++){
             double current=tab[i];
             int k=i;
             while (k>=interval && tab[k-interval]>current){
                tab[k]=tab[k-interval];
                k-= interval;
             }
             tab[k]=current;
        }

    }
    return tab;

}

// ShellSort(elo1);
// foreach(double i in elo1){
//     Console.WriteLine(i);
// }



//********* zadanie 3***********

double[] SMM (double[] tab1){
    double[] smm={0,0,0};
    double[] tab = new double[tab1.Length]; // uznałem, że zrobie sobie kopie oryginalnej tablicy
    for (int i=0; i<tab1.Length;i++){       // bo inaczej po użyciu funkcji oryginalna byłaby posortowana
        tab[i]=tab1[i];                     // a uznałem, że nie zawse chcemy ją segregować
    }
    ShellSort(tab);
    double suma=0;
    foreach (double i in tab){
        suma+=i;
    }
    smm[0]=suma/tab.Length;
    
    if (tab.Length%2==1){
        smm[1]=tab[tab.Length/2];
    }
    else{
        smm[1]=(tab[tab.Length/2]+tab[tab.Length/2+1])/2;
    }
    return smm;

}


Console.WriteLine($"średnia={SMM(elo1)[0]}, mediana={SMM(elo1)[1]}, moda={SMM(elo1)[2]}");


// *********** zadanie 4 ******************************


int Ile(double[] tab, double liczba){
    int i=0;
    foreach(double k in tab){
        if(liczba==k){
            i++;
        }
    }
    return i;
}

Console.WriteLine(Ile(elo1,4));

//***************zadanie 5****************
bool Sprawdz(double[]tab, double liczba){
    bool bylo=false;
    foreach(double i in tab){
        if(i==liczba){
            bylo=true;
            break;
        }
    }
    return bylo;
}
Console.WriteLine(Sprawdz(elo1,4.5));

//************** zadanie 6 *************

double[] Polacz(double[] tab1,double[] tab2){
    int size1=tab1.Length;
    int size2=tab2.Length;
    double[] tab3=new double[size1+size2];
    for (int i=0; i<size1;i++){
        tab3[i]=tab1[i];
    }
        for (int i=0; i<size2;i++){
        tab3[i+size1]=tab2[i];
    }
    return tab3;
}

foreach (double i in Polacz(elo1,elo1)){
    Console.Write(i+" ");
}
Console.Write("\n");

//************************zadanie 7*****************
double[] Odwrot (double[]tab1){
    double[] tab2= new double[tab1.Length];
    for (int i=0;i<tab1.Length;i++){
        tab2[tab1.Length-i-1]=tab1[i];
    }
    return tab2;
}

foreach (double i in Odwrot(elo1)){
    Console.Write(i+" ");
}
Console.Write("\n");

//***********zadanie 8***************

double[] Squeeze(double[] tab1){
    int size1=tab1.Length;
    double[] tab2=new double[size1];
    tab2[0]=tab1[0];
    int k=1;
    bool bylo;
    int size2=size1;
    for (int i=1;i<size1;i++){
        bylo=false;
        for (int j=0;j<k;j++){
            if(tab1[i]==tab2[j]){
                bylo=true;
            }
        }
        if(!bylo){
            tab2[k]=tab1[i];
            k++;
        }
        else{
            size2--;
        }

    }
    double[] tab3=new double[size2];
    for (int i=0;i<size2;i++){
        tab3[i]=tab2[i];
        
     
    }
    return tab3;
    
}

foreach(double i in Squeeze(elo1)){
    Console.Write(i+" ");
}
Console.Write("\n");
foreach(double i in elo1){
    Console.Write(i+" ");
}
Console.Write("\n");

// **************zadanie 9******************888

double[] AddAtBeginnig (double[] tab, double num){
    int size=tab.Length;
    double[] tab1=new double[size+1];
    tab1[0]=num;
    for(int i=0;i<size;i++){
        tab1[i+1]=tab[i];
    }
    return tab1;
}

Console.Write("\n");
foreach(double i in AddAtBeginnig(elo1, 5)){
    Console.Write(i+" ");
}
Console.Write("\n");


// **************zadanie 10************************

double[] AddOnIndex (double[] tab, double num, int index){
    int size=tab.Length;
    double[] tab1=new double[size+1];
    tab1[index]=num;
    for(int i=0;i<index;i++){
        tab1[i]=tab[i];
    }
    for(int i=index;i<size;i++){
        tab1[i+1]=tab[i];
    }
    return tab1;
}

Console.Write("\n");
foreach(double i in AddOnIndex(elo1, 5,2)){
    Console.Write(i+" ");
}
Console.Write("\n");



//******************zadanie 11 cd **********************
//**** Bubble Sort
double[] BubbleSort (double[] tab){
    int n=tab.Length;
    double temp;
    bool swap=false;
    for (int i=0;i<n-1;i++){
        for(int j=0; j<n-1-i;j++){
            if(tab[j]>tab[j+1]){
                temp=tab[j];
                tab[j]=tab[j+1];
                tab[j+1]=temp;
                swap=true;
            }
        }
        if(!swap){
            break;
        }
    }
    return tab;

}


Console.Write("\n");
foreach(double i in (elo1)){
    Console.Write(i+" ");
}
Console.Write("\n");


Console.Write("\n");
foreach(double i in BubbleSort(GenRandomArray(10,0,100))){
    Console.Write(i+" ");
}
Console.Write("\n");
//*****quicksort
double[] Qsort(double[] tab1, int minIndex, int maxIndex){
    int i= minIndex;
    int j= maxIndex;
    var pivot= tab1[maxIndex];

    while (i<j){

        while(tab1[i]<pivot){
            i++;
        }
        while (tab1[j]>pivot){
            j--;
        }
        if (i<=j){
            var temp=tab1[i];
            tab1[i]=tab1[j];
            tab1[j]=temp;
            i++;
            j--;
        }
    }

    if (minIndex<j){
        Qsort(tab1, minIndex, j);
    }
    if (i<maxIndex){
        Qsort(tab1,i,maxIndex);
    }
    return tab1;

}


Console.Write("\n");
foreach(double i in Qsort(GenRandomArray(10,0,100),0,9)){
    Console.Write(i+" ");
}
Console.Write("\n");

//**** Insertion Sort*********

double[] InsertionSort (double[] tab1){
    int size =tab1.Length;
    for (int i=1; i<size;i++){
        var current=tab1[i];

        for (int j =i-1; j>=0; j--){
            if (current<tab1[j]){
                tab1[j+1]=tab1[j];
                tab1[j]=current;
            }
            else{
                break;
            }
        }
    }
    return tab1;
}

Console.Write("Insertion sort:\n");
Console.Write("\n");
foreach(double i in InsertionSort(GenRandomArray(10,0,100))){
    Console.Write(i+" ");
}
Console.Write("\n");




//***** Selection sort****

double[] SelectionSort(double[] tab1){
    int size=tab1.Length;
    for (int i=0; i<size-1;i++){
        var min=i;
        for (int j=i+1;j<size;j++){
            if(tab1[j]<tab1[min]){
                min=j;
            }
        }
    
        var temp=tab1[min];
        tab1[min]=tab1[i];
        tab1[i]=temp;
    }

    return tab1;

}

Console.Write("\n");
foreach(double i in SelectionSort(GenRandomArray(10,0,100))){
    Console.Write(i+" ");
}
Console.Write("\n");