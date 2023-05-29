/*Задача 44: Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8*/


Console.WriteLine("Введите кол-во символов массива: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] fibbonacci = Fibbonaci(number);

PrintArray(fibbonacci);

int[] Fibbonaci (int num)
{
    int[] array = new int [num];
    array[0] = 0;
    array[1] = 1;

    for (int i = 2; i < array.Length; i++)
    {
       array[i] = array[i-1] +array[i-2];
    }

    return array;

}

void PrintArray(int[] arr, string sep = ",")
{
    for (int i = 0; i < arr.Length/2; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]} ");
    }
}
