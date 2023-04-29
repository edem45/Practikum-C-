/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
5 ->
1 | 1
2 | 8
3 | 27
4 | 64
5 | 125*/

Console.Write("Введите целое число: ");
int numberN = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите степень: ");
int numberS = Convert.ToInt32(Console.ReadLine());

Square(numberN, numberS);


void Square(int num, int num2)
{
    int i = 0;
    while (i < num2)
    {
        i++;
    }
    int count = 1;
    if (num < 0)
    {
        num = num * -1;

        while (count <= num)
        {
            Console.WriteLine($"{count,3} {-1 * Math.Pow(count, i),8}");
            count++;
        }
    }
    else
    {
        while (count <= num)
        {
            Console.WriteLine($"{count,3} {Math.Pow(count, i),8}");
            count++;
        }
    }
}