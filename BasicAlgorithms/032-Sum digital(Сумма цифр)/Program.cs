//Сумма цифр 
//Punto switcher утилита для переключения раскладки

// int SumDigit(int N)
// {
//     if (N==0) return 0;
//     else
//       return SumDigit(N/10)+N%10;
// }

// System.Console.WriteLine(SumDigit(123));
using System;

int n=int.Parse(Console.ReadLine());
System.Console.WriteLine(n/100);