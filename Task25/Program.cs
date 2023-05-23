/*/*Напишите цикл, который принисает на вход два числа а и b и 
возводит число а в натуральную степень В*/


Console.WriteLine("Введите целое число A: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число B: ");
int num2 = Convert.ToInt32(Console.ReadLine());



int Power(int powerbase, int exponent)
{
    int power = 1;

    for (int i = 0; i < exponent; i++)
    {

        power = power * powerbase;
    }
    return power;
}

bool NaturB(int num)
{
    if (num < 0)
    {
        Console.WriteLine("Показатель не должен быть меньше ноля!");
        return false;
    }
    return true;

}

if (NaturB(num2))
{
    Console.WriteLine($"Число {num1} в степени {num2} равно {Power(num1,num2)}");
}