/* Напишите программу, которая будет выдавать название дня
недели по заданному номеру*/
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("День недели: ");

if (number == 1)
{
    Console.Write("Понедельник");
}
else if (number == 2)
{
    Console.Write("Вторник");
}
else if (number == 3)
{
    Console.Write("Среда");
}
else if (number == 4)
{
    Console.Write("Четверг");
}
else if (number == 5)
{
    Console.Write("Пятница");
}
else if (number == 6)
{
    Console.Write("Суббота");
}
else if (number == 7)
{
    Console.Write("Воскресенье");
}
else
{
    Console.Write("число не соответствует дню недели");
}