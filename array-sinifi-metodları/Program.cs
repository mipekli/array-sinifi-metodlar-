﻿//Sort 

int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };
Console.WriteLine("****Sırasız Dizi****");
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);



}


Console.WriteLine("****Sıralı Dizi****");
Array.Sort(sayiDizisi);

foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}
//Clear
Console.WriteLine("****Array Dizi****");
//sayı dizisi elamnalarını kullanarak 2.index ten itibaren 2 tane elamnı 0'lar.
Array.Clear(sayiDizisi,2,2);
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}

//Reverse
Console.WriteLine("**** Array Reverse****");
Array.Reverse(sayiDizisi);
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}

//IndexOf
Array.IndexOf(sayiDizisi,23);
Console.WriteLine("****Array IndexOf****");
Console.WriteLine( Array.IndexOf(sayiDizisi,23));

//Resize
Console.WriteLine("****Array Resize****");
Array.Resize<int>(ref sayiDizisi, 9);
sayiDizisi[0]= 99;
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}
