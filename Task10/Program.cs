/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на
 выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/


Console.Write("Введите трехзначное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = 0;

if (number < 100 || number >= 1000) Console.WriteLine($"Введите трехзначное число!!!");

else
{
    result = MaxDigit(number);

    Console.WriteLine($"Вторая цифра числа -> {result}");
}

int MaxDigit(int num)
{
    int firstDigit = (num / 100) * 100;
    int secondDigit = num - firstDigit;
    int thirdDigit = secondDigit / 10;

    return thirdDigit;
}
