/* Напишите программу , которая принимает на вход 
трехзначное число и на выходе показывает последнюю цифру*/

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number *= -1;
if (number >= 100 && number <= 999)
{
    int LastNumber = number % 10;
    Console.WriteLine($"Последняя цифра числа {number} => {LastNumber}");
}
else
    Console.WriteLine("Некорректный ввод!");
