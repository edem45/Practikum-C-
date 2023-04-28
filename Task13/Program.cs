/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number <0) 
{
    number *=-1;
    if(TrueNumber(number))
    {
        Console.WriteLine(ThirdFigure(number)* -1);
    }
}
else
{
    if(TrueNumber(number))
    {
        Console.WriteLine(ThirdFigure(number));
    }
}
int ThirdFigure(int num)
{
    while (num > 999)
    {
        num /=10;
    }
    return num % 10;
}

bool TrueNumber(int num)
{
    if (number < 100) 
    {
        Console.WriteLine("третьей цифры нет");
        return false;
    }
    return true;
}