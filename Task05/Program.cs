/*Написать программу, которая на вход принимает одно целое число 
(N), на выходе выводит все цисла от -N до N*/
Console.WriteLine("Введите целое положитльное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = -number;
while (count <= number)
{
    Console.Write($"{count} ");
    count++;
}