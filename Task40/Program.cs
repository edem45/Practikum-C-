/*Задача 40: Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.*/

Console.Write("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int number3 = Convert.ToInt32(Console.ReadLine());


bool Treug(int a, int b, int c)
{
    return a + b > c && a + c > b && b + c > a ;

}

Console.WriteLine(Treug(number1, number2, number3) ? "да" : "нет");
