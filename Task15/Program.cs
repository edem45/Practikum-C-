/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.Write("Введите первое целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 8)
{
    Console.WriteLine(WeekDays(number) ? "Да" : "Нет");

}
else Console.WriteLine("Введите корректное число!");

bool WeekDays (int num)
{
    return num == 7 || num == 6;
}