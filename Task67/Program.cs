﻿
Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int sumDigitsInNumberRec = SumDigitsInNumberRec(number);
Console.WriteLine($"Сумма цифр в числе {number} равна {sumDigitsInNumberRec}");



int SumDigitsInNumberRec(int n)
 {
     if (n == 0) return 0;
     return n % 10 + SumDigitsInNumberRec(n/10); // 453 45 4
 }