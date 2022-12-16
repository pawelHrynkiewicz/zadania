//*******************zadanie 1 * ***************************


for (int i1 = -100; i1 <= 100; i1++)
{
    Console.WriteLine("zadanie pierwsze petla for " + i1);
}

int j1 = -100;
while (j1 <= 100)
{
    Console.WriteLine("zadanie 1 petla while " + j1);
    j1++;
}



int k1 = -100;
do
{
    Console.WriteLine("zadanie 1 petla do while " + k1);
    k1++;
}
while (k1 < 101);

//*******************Zadanie2 * ***************************
int count2 = 0;
for (int i2 = -100; i2 <= 100; i2++)
{
    if (i2 % 2 == 0)
    {
        count2++;
    }
}
Console.WriteLine("zadanie 2 petla for " + count2);


count2 = 0;
int j2 = -100;
while (j2 <= 100)
{
    if (j2 % 2 == 0)
    {
        count2++;
    }
    j2++;
}
Console.WriteLine("zdanie 2 petla while " + count2);


count2 = 0;
int k2 = -100;
do
{
    if (k2 % 2 == 0)
    {
        count2++;
    }
    k2++;
}
while (k2 < 101);
Console.WriteLine("zadanie 2 petla do while " + count2);

//*******************zadanie 3 * *********************

int count3 = 0;
for (int i3 = -100; i3 <= 100; i3++)
{
    if (i3 % 5 == 0)
    {
        count3++;
    }
}
Console.WriteLine("zadanie 3 petla for " + count3);

count3 = 0;
int j3 = -100;
while (j3 <= 100)
{
    if (j3 % 5 == 0)
    {
        count3++;
    }
    j3++;
}
Console.WriteLine("zadanie 3 petla while " + count3);

count3 = 0;
int k3 = -100;
do
{
    if (k3 % 5 == 0)
    {
        count3++;
    }
    k3++;
}
while (k3 < 101);
Console.WriteLine("zadanie 3 petla do while " + count3);

//**********************zadanie4 * **************
int count4 = 0;
for (int i4 = -1000; i4 <= 100; i4++)
{
    if (i4 % 5 == 0)
    {
        count4++;
    }
}
Console.WriteLine("zadanie 4 petla for " + count4);
count4 = 0;
int j4 = -1000;
while (j4 <= 100)
{
    if (j4 % 5 == 0)
    {
        count4++;
    }
    j4++;
}
Console.WriteLine("zadanie 4 petla while " + count4);

count4 = 0;
int k4 = -1000;
do
{
    if (k4 % 5 == 0)
    {
        count4++;
    }
    k4++;
}
while (k4 < 101);
Console.WriteLine("zadanie 4 petla do while " + count4);

//**************zadanie 5 * *************
int z5;
for (int i5 = -100; i5 <= 100; i5++)
{
    if (i5 % 8 > 4)
    {
        z5 = i5 * (i5 % 8);
    }
    else
    {
        z5 = i5;
    }
    Console.WriteLine("zadanie 5 petla for " + z5);
}
z5 = 0;
int j5 = -100;
while (j5 <= 100)
{

    if (j5 % 8 > 4)
    {
        z5 = j5 * (j5 % 8);
    }
    else
    {
        z5 = j5;
    }
    j5++;
    Console.WriteLine("zadanie 5 petla while " + z5);
}

z5 = 0;
int k5 = -100;
do
{
    if (k5 % 8 > 4)
    {
        z5 = k5 * (k5 % 8);
    }
    else
    {
        z5 = k5;
    }
    k5++;
    Console.WriteLine("zadanie 5 petla do while " + z5);
}
while (k5 < 101);

//**************zadanie7 * *******************
int max7 = 100;
bool pierwsza7;
for (int i7 = 2; i7 < max7; i7++)
{
    pierwsza7 = true;
    for (int j7 = 2; j7 <= Math.Sqrt(i7); j7++)
    {
        if (i7 % j7 == 0)
        {
            pierwsza7 = false;
            break;
        }
    }
    if (pierwsza7)
    {
        Console.WriteLine("zadanie 7 petla for " + i7);
    }
}
//***
max7 = 100;
for (int i7 = 2; i7 < max7; i7++)
{
    pierwsza7 = true;
    int j7 = 2;
    while (pierwsza7 == true && j7 <= Math.Sqrt(7))
    {
        if (i7 % j7 == 0)
        {
            pierwsza7 = false;
        }
        j7++;
    }
    if (pierwsza7)
    {
        Console.WriteLine("zadanie 7 petla kapke while " + i7);
    }
}
//*****************zadanie 8 * **********************

//sbyte
Console.WriteLine($"sbyte od {sbyte.MinValue} do {sbyte.MaxValue} zajmuje {sizeof(sbyte) * 8} bitów");

//byte
Console.WriteLine($"byte od {byte.MinValue} do {byte.MaxValue} zajmuje {sizeof(byte) * 8} bitów");

//short
Console.WriteLine($"short od {short.MinValue} do {short.MaxValue} zajmuje {sizeof(short) * 8} bitów");

//ushort
Console.WriteLine($"ushort od {ushort.MinValue} do {ushort.MaxValue} zajmuje {sizeof(ushort) * 8} bitów");

//int
Console.WriteLine($"int od {int.MinValue} do {int.MaxValue} zajmuje {sizeof(int) * 8} bitów");

//uint
Console.WriteLine($"uint od {uint.MinValue} do {uint.MaxValue} zajmuje {sizeof(uint) * 8} bitów");

//long 64 bit
Console.WriteLine($"long od {long.MinValue} do {long.MaxValue} zajmuje {sizeof(long) * 8} bitów");

//ulong 64 bit
Console.WriteLine($"ulong od {ulong.MinValue} do {ulong.MaxValue} zajmuje {sizeof(ulong) * 8} bitów");

//nint 32/64 bit
//Console.WriteLine($"nint od {nint.MinValue} do {nint.MaxValue} zajmuje {sizeof(nint)*8} bitów"); 
//**** dlaczego nie działa sizeof(nint) i sizeof(nuint)???
//nuint 32/64 bit
//Console.WriteLine($"nuint od {nuint.MinValue} do {nuint.MaxValue} zajmuje {sizeof(nuint)*8} bitów");

//float
Console.WriteLine($"float od {float.MinValue} do {float.MaxValue}, zajmuje {sizeof(float) * 8} bitów");

//double 
Console.WriteLine($"double od {double.MinValue} do {double.MaxValue} zajmuje {sizeof(double) * 8} bitów");

//decimal
Console.WriteLine($"decimal od {decimal.MinValue} do {decimal.MaxValue} zajmuje {sizeof(decimal) * 8} bitów");