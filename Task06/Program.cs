﻿/* Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
//if (number < 0) number *= -1;
if (number % 2 == 0)
{
    Console.Write($"Число {number} => Четное");
}
else
    Console.Write($"Число {number} => Нечетное");