/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

-1, -7, 567, 89, 223-> 3*/

Console.WriteLine("Введите количество чисел: ");
int size = Convert.ToInt32(Console.ReadLine());

void PrintArray(int[] arr, string sep = ",")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]} ");
    }
}


int[] CreateArray(int num)
{
    int[] arr = new int[size];
    int j =1;
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Введите число {j}: ");
        int number = Convert.ToInt32(Console.ReadLine());
        arr[i] = number;
        j++;

    }
    return arr;
}

int CountNumberslessZero (int[] arr2 )
{
    int count = 0;
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i] < 0) count++;
    }
    return count;
}

int[] array = CreateArray(size);
Console.Write("[");
PrintArray(array);
Console.Write("] -> ");
int countNumberlessZero = CountNumberslessZero(array);
Console.Write(countNumberlessZero);