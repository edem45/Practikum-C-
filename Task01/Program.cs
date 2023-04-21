/* Напишите программу которая на вход принимает два числа и проверяет,
является ли первое число кадратом второго*/

Console.Write("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int square = number2 * number2;
Console.Write("Является ли Первое число Квадратом Второго: ");

if (number1 == square)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}