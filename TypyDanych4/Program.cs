// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// losowe tablice do sprawdzania metod
int[] array = { 1, 4, 35, 4, 6, 434, 4, 1, 76, 43, 43, 656, 33, 11, 11 };
double[] array1 = { 1.1, 4.1, 35.7, 4.1, 6.8, 434.7, 4.1, 1.7, 76.3, 43.8, 43.3, 656.32, 33.543, 11.54, 11.5435 };

double[] CopyArray(double[] array)
{
    double[] copy = new double[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copy[i] = array[i];
    }
    return copy;
}

double GenRandom2(int minValue, int maxValue)
{
    Random rand = new Random();
    return rand.Next(minValue, maxValue);
}

double[] GenRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = GenRandom2(minValue, maxValue);
    }
    return array;
}

foreach (double i in GenRandomArray(5, 0, 100))
{
    Console.Write(i + " ");
}
Console.Write("\n");

// **************zadanie 1**************

int GetMax(int[] array)
{
    var max = array[0];
    foreach (int i in array)
    {
        if (i > max)
        {
            max = i;
        }
    }
    return max;
}

double GetMax1(double[] array)
{
    var max = array[0];
    foreach (double i in array)
    {
        if (i > max)
        {
            max = i;
        }
    }
    return max;
}

Console.WriteLine("zadanie 1");
Console.WriteLine("maksymalna wartość w tablicy wynosi: " + GetMax(array));
Console.WriteLine("maksymalna wartość w tablicy wynosi: " + GetMax1(array1));
Console.WriteLine("\n");

// **************zadanie 2********************

int GetSecondMax(int[] array)
{
    if (array.Length < 2)
    {
        Console.WriteLine("Podano niewlasciwa tablice");
        return 0;
    }
    var max1 = 0;
    var max2 = 0;
    if (array[0] > array[1])
    {
        max1 = array[0];
        max2 = array[1];
    }
    else
    {
        max1 = array[1];
        max2 = array[0];
    }
    for (int i = 2; i < array.Length; i++)
    {
        if (array[i] > max1)
        {
            max2 = max1;
            max1 = array[i];
        }
        if ((array[i] > max2) && (array[i] < max1))
        {
            max2 = array[i];
        }
    }
    return max2;

}

double GetSecondMax1(double[] array)
{
    if (array.Length < 2)
        return 0;
    var max1 = 0.0;
    var max2 = 0.0;
    if (array[0] > array[1])
    {
        max1 = array[0];
        max2 = array[1];
    }
    else
    {
        max1 = array[1];
        max2 = array[0];
    }
    for (int i = 2; i < array.Length; i++)
    {
        if (array[i] > max1)
        {
            max2 = max1;
            max1 = array[i];
        }
        if ((array[i] > max2) && (array[i] < max1))
        {
            max2 = array[i];
        }
    }
    return max2;

}

Console.WriteLine(GetSecondMax(array));
Console.WriteLine(GetSecondMax1(array1));


//************zadanie 11*************** (tutej, bo fajno mieć chyba sortowanie przed liczeniem mediany)

double[] ShellSort(double[] array)
{
    int size = array.Length;
    for (int interval = size / 2; interval > 0; interval /= 2)
    {
        for (int i = interval; i < size; i++)
        {
            var current = array[i];
            var k = i;
            while (k >= interval && array[k - interval] > current)
            {
                array[k] = array[k - interval];
                k -= interval;
            }
            array[k] = current;
        }

    }
    return array;

}

//********* zadanie 3***********

double[] MeanMedianMode(double[] array1)
{
    double[] MeanMedianMode = { 0, 0, 0 };
    double[] array = CopyArray(array1);
    ShellSort(array);
    var suma = 0.0;
    foreach (double i in array)
    {
        suma += i;
    }
    MeanMedianMode[0] = suma / array.Length;

    if (array.Length % 2 == 1)
    {
        MeanMedianMode[1] = array[array.Length / 2];
    }
    else
    {
        MeanMedianMode[1] = (array[array.Length / 2] + array[array.Length / 2 + 1]) / 2;
    }
    return MeanMedianMode;
    // moda wariacie!
}
Console.WriteLine($"średnia={MeanMedianMode(array1)[0]}, mediana={MeanMedianMode(array1)[1]}, moda={MeanMedianMode(array1)[2]}");

// *********** zadanie 4 ******************************

int GetHowMany(double[] array, double number)
{
    var i = 0;
    foreach (var k in array)
    {
        if (number == k)
        {
            i++;
        }
    }
    return i;
}

Console.WriteLine(GetHowMany(array1, 4));

//***************zadanie 5****************
bool CheckPresence(double[] array, double number)
{
    var bylo = false;
    foreach (double i in array)
    {
        if (i == number)
        {
            bylo = true;
            break;
        }
    }
    return bylo;
}
Console.WriteLine(CheckPresence(array1, 4.5));

//************** zadanie 6 *************

double[] Combine(double[] array1, double[] array2)
{
    int size1 = array1.Length;
    int size2 = array2.Length;
    double[] array3 = new double[size1 + size2];
    for (int i = 0; i < size1; i++)
    {
        array3[i] = array1[i];
    }
    for (int i = 0; i < size2; i++)
    {
        array3[i + size1] = array2[i];
    }
    return array3;
}

foreach (double i in Combine(array1, array1))
{
    Console.Write(i + " ");
}
Console.Write("\n");

//************************zadanie 7*****************
double[] ReverseArray(double[] array1)
{
    double[] array2 = new double[array1.Length];
    var idx = 0;
    for (var i = array1.Length - 1; i >= 0; i--)
    {
        array2[idx] = array1[i];

        idx++;
    }
    return array2;
}

foreach (double i in ReverseArray(array1))
{
    Console.Write(i + " ");
}
Console.Write("\n");

//***********zadanie 8***************
// pomysle nad tym twoim rozwiazaniem tego - na razie dodam komentarze do swojego
// moze z tym bedzie ci latwiej to ogarnac 
double[] Squeeze(double[] array1)
{
    int size = array1.Length; // rozmiar tablic array1 i array2
    // array2 to tablica przejciowa - wyrazy juz nie beda sie powtarzac, ale bedzie miala 
    // rozmiar tablicy array1 (czyli moze byc za duza), bo musze podac wielkos przy deklaracji
    double[] array2 = new double[size1];
    array2[0] = array1[0]; // przekazuej pierwasza wartosc
    var NumbersInArray2 = 1; // tyle liczb mamy w array2
    var bylo = false;
    //size3 to rozmiar tablicy array3 - przed wejsciem w petle rowny size1
    //ale jak natknietmy sie na powtorzenie, to wykonujemy size3--
    //tak zeby w array3 nie bylo juz pustych komorek
    var size3 = size;
    for (int i = 1; i < size; i++)
    {
        bylo = false;
        for (int j = 0; j < NumbersInArray2; j++)
        {
            if (array1[i] == array2[j])
            {
                bylo = true;
            }
        }
        if (!bylo)
        {
            array2[NumbersInArray2] = array1[i];
            NumbersInArray2++;
        }
        else
        {
            size3--;
        }
    }
    double[] array3 = new double[size3];
    for (int i = 0; i < size3; i++)
    {
        array3[i] = array2[i];
    }
    return array3;
}
string result = string.Join(' ', array1);
string result7 = string.Join(' ', Squeeze(array1));
Console.WriteLine(result);
Console.WriteLine(result7);
// **************zadanie 9******************888

double[] AddAtBeginnig(double[] array, double num)
{
    int size = array.Length;
    double[] array1 = new double[size + 1];
    array1[0] = num;
    for (int i = 0; i < size; i++)
    {
        array1[i + 1] = array[i];
    }
    return array1;
}

Console.Write("\n");
foreach (double i in AddAtBeginnig(array1, 5))
{
    Console.Write(i + " ");
}
Console.Write("\n");


// **************zadanie 10************************

double[] AddOnIndex(double[] array, double num, int index)
{
    int size = array.Length;
    double[] array1 = new double[size + 1];
    array1[index] = num;
    for (int i = 0; i < index; i++)
    {
        array1[i] = array[i];
    }
    for (int i = index; i < size; i++)
    {
        array1[i + 1] = array[i];
    }
    return array1;
}

Console.Write("\n");
foreach (double i in AddOnIndex(array1, 5, 2))
{
    Console.Write(i + " ");
}
Console.Write("\n");



//******************zadanie 11 cd **********************
//**** Bubble Sort
double[] BubbleSort(double[] array)
{
    int n = array.Length;
    var temp = 0.0;
    var swap = false;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - 1 - i; j++)
        {
            if (array[j] > array[j + 1])
            {
                temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
                swap = true;
            }
        }
        if (!swap)
        {
            break;
        }
    }
    return array;

}


Console.Write("\n");
foreach (double i in (array1))
{
    Console.Write(i + " ");
}
Console.Write("\n");


Console.Write("\n");
foreach (double i in BubbleSort(GenRandomArray(10, 0, 100)))
{
    Console.Write(i + " ");
}
Console.Write("\n");

//*****quicksort**************

double[] Qsort(double[] array1, int minIndex, int maxIndex)
{
    int i = minIndex;
    int j = maxIndex;
    var pivot = array1[maxIndex];

    while (i < j)
    {
        while (array1[i] < pivot)
        {
            i++;
        }
        while (array1[j] > pivot)
        {
            j--;
        }
        if (i <= j)
        {
            var temp = array1[i];
            array1[i] = array1[j];
            array1[j] = temp;
            i++;
            j--;
        }
    }

    if (minIndex < j)
    {
        Qsort(array1, minIndex, j);
    }
    if (i < maxIndex)
    {
        Qsort(array1, i, maxIndex);
    }
    return array1;
}
Console.Write("\n");
foreach (double i in Qsort(GenRandomArray(10, 0, 100), 0, 9))
{
    Console.Write(i + " ");
}
Console.Write("\n");

//**** Insertion Sort*********

double[] InsertionSort(double[] array1)
{
    int size = array1.Length;
    for (int i = 1; i < size; i++)
    {
        var current = array1[i];
        for (int j = i - 1; j >= 0; j--)
        {
            if (current < array1[j])
            {
                array1[j + 1] = array1[j];
                array1[j] = current;
            }
            else
            {
                break;
            }
        }
    }
    return array1;
}

Console.Write("Insertion sort:\n");
Console.Write("\n");
foreach (double i in InsertionSort(GenRandomArray(10, 0, 100)))
{
    Console.Write(i + " ");
}
Console.Write("\n");

//***** Selection sort****

double[] SelectionSort(double[] array1)
{
    int size = array1.Length;
    for (int i = 0; i < size - 1; i++)
    {
        var min = i;
        for (int j = i + 1; j < size; j++)
        {
            if (array1[j] < array1[min])
            {
                min = j;
            }
        }

        var temp = array1[min];
        array1[min] = array1[i];
        array1[i] = temp;
    }

    return array1;

}

Console.Write("\n");
foreach (double i in SelectionSort(GenRandomArray(10, 0, 100)))
{
    Console.Write(i + " ");
}
Console.Write("\n");