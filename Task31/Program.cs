/*Андрей Булгаков: Задача 31: Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20.*/

int[] CreateArrayRNDInt (int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min,max+1);
    }
    return arr;
}

void PrintArray (int[] arr, string sep)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length -1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]} ");
    }
}

int[] GetSumPositiveNegativeElem(int[] arr)
{
    int sumpositive = 0;
    int sumnegaive = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
            sumpositive += arr[i];
        else
            sumnegaive += arr[i];
    }

    return new int[]{sumpositive,sumnegaive};
}

/*int GetSumPositiveElem(int[] arr)
{
    int sum=0;

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sum += arr[i];
    }
    return sum;

}*/


int[] array = CreateArrayRNDInt(12, -9, 9);
Console.Write("[");
PrintArray(array, ",");
Console.WriteLine("]");

int[] SumPositiveNegativeElem = GetSumPositiveNegativeElem(array);
Console.WriteLine($"Сумма положительных элементов рана {SumPositiveNegativeElem[0]}");
Console.WriteLine($"Сумма положительных элементов рана {SumPositiveNegativeElem[1]}");