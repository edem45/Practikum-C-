
/*Задача 28: Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120*/



Console.WriteLine("Введите целон положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int fact = Composition(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {fact}");

int Composition(int num)
{
    int comp = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
        comp = comp * i;
        }
    }
    return comp;
}

