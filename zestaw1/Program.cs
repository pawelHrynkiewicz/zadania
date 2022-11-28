// See https://aka.ms/new-console-template for more information
//Console.WriteLine("no elo!");
// *******************zadanie 1****************************


// for (int i=-100; i<=100; i++){
//     Console.WriteLine(i);
// }



// int j=-100;
// while (j<=100){
//     Console.WriteLine(j);
//     j++;
// }



// int k=-100;
// do{
//     Console.WriteLine(k);
//     k++;
// }
// while (k<101);

// *******************Zadanie2****************************
// int count=0;
// for (int i=-100; i<=100; i++){
//      if (i%2==0){
//          count++;}
// }
// Console.WriteLine(count);


// int count=0;
// int j=-100;
// while (j<=100){
    
//     if (j%2==0){
//         count++;
//     }
//     j++;
// }
// Console.WriteLine(count);


// int count=0;
// int k=-100;
// do{
//     if (k%2==0){
//         count++;
//     }
//     k++;
// }
// while (k<101);
// Console.WriteLine(count);

// ******************* zadanie 3**********************

// int count=0;
// for (int i=-100; i<=100; i++){
//      if (i%5==0){
//          count++;}
// }
// Console.WriteLine(count);


// int count=0;
// int j=-100;
// while (j<=100){
    
//     if (j%5==0){
//         count++;
//     }
//     j++;
// }
// Console.WriteLine(count);


// int count=0;
// int k=-100;
// do{
//     if (k%5==0){
//         count++;
//     }
//     k++;
// }
// while (k<101);
// Console.WriteLine(count);

//**********************zadanie4***************

// int count=0;
// for (int i=-1000; i<=100; i++){
//      if (i%5==0){
//          count++;}
// }
// Console.WriteLine(count);


// int count=0;
// int j=-1000;
// while (j<=100){
    
//     if (j%5==0){
//         count++;
//     }
//     j++;
// }
// Console.WriteLine(count);


// int count=0;
// int k=-1000;
// do{
//     if (k%5==0){
//         count++;
//     }
//     k++;
// }
// while (k<101);
// Console.WriteLine(count);

//**************zadanie 5**************
// int z;
// for (int i=-100; i<=100; i++){
//      if (i%8>4){
//          z=i*(i%8);
//          }
//     else{
//         z=i;
//     }
//     Console.WriteLine(z);
// }



// int z=0;
// int j=-100;
// while (j<=100){
    
//      if (j%8>4){
//          z=j*(j%8);
//          }
//     else{
//         z=j;
//     }
//     j++;
//     Console.WriteLine(z);
// }



// int z=0;
// int k=-100;
// do{
//     if (k%8>4){
//         z=k*(k%8);
//     }
//     else{
//         z=k;
//     }
//     k++;
//     Console.WriteLine(z);
// }
// while (k<101);

//**************zadanie7********************

// int max=100;
// bool pierwsza;
// for (int i=2;i<max;i++){
//     pierwsza=true;
//     for (int j=2; j<=Math.Sqrt(i); j++){
//         if (i%j==0){
//             pierwsza=false;
//             break;
//         }
//     }
//     if (pierwsza){
//         Console.WriteLine(i);
//     }

    
// }


//***

// int max=100;
// int j;
// bool pierwsza;
// for (int i=2;i<max;i++){
//     pierwsza=true;
//     j=2;
//     while (pierwsza==true&&j<=Math.Sqrt(i)){
//         if (i%j==0){
//             pierwsza=false;
            
//             }
//             j++;
//         }
//     if (pierwsza){
//         Console.WriteLine(i);
//     }

//}

// *****************zadanie 8***********************

// //sbyte
// Console.WriteLine($"sbyte od {sbyte.MinValue} do {sbyte.MaxValue} zajmuje {sizeof(sbyte)*8} bitów");

// //byte
// Console.WriteLine($"byte od {byte.MinValue} do {byte.MaxValue} zajmuje {sizeof(byte)*8} bitów");

// //short
// Console.WriteLine($"short od {short.MinValue} do {short.MaxValue} zajmuje {sizeof(short)*8} bitów");

// //ushort
// Console.WriteLine($"ushort od {ushort.MinValue} do {ushort.MaxValue} zajmuje {sizeof(ushort)*8} bitów");

// //int
// Console.WriteLine($"int od {int.MinValue} do {int.MaxValue} zajmuje {sizeof(int)*8} bitów");

// //uint
// Console.WriteLine($"uint od {uint.MinValue} do {uint.MaxValue} zajmuje {sizeof(uint)*8} bitów");

// //long 64 bit
// Console.WriteLine($"long od {long.MinValue} do {long.MaxValue} zajmuje {sizeof(long)*8} bitów");

// //ulong 64 bit
// Console.WriteLine($"ulong od {ulong.MinValue} do {ulong.MaxValue} zajmuje {sizeof(ulong)*8} bitów");

// //nint 32/64 bit
// //Console.WriteLine($"nint od {nint.MinValue} do {nint.MaxValue} zajmuje {sizeof(nint)*8} bitów"); 
// //**** dlaczego nie działa sizeof(nint) i sizeof(nuint)???
// //nuint 32/64 bit
// //Console.WriteLine($"nuint od {nuint.MinValue} do {nuint.MaxValue} zajmuje {sizeof(nuint)*8} bitów");
        
// //float
// Console.WriteLine($"float od {float.MinValue} do {float.MaxValue}, zajmuje {sizeof(float)*8} bitów");

// //double 
// Console.WriteLine($"double od {double.MinValue} do {double.MaxValue} zajmuje {sizeof(double)*8} bitów");

// //decimal
// Console.WriteLine($"decimal od {decimal.MinValue} do {decimal.MaxValue} zajmuje {sizeof(decimal)*8} bitów");





