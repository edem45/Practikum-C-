
int[] CreateArrayRNDInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr, string sep)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]} ");
    }
}

int[] ComposArrayElem(int[] arr)
{
    int size = arr.Length / 2;
    int newsize = arr.Length % 2;
    if (newsize == 1) size += 1;
    int[] newarr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        newarr[i] = arr[i] * arr[arr.Length -1 -i];
    }
     if (newsize == 1) newarr[size - 1] = arr[size];
    return newarr;
}

Console.WriteLine("Введите кол-во символов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число диапазона: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число диапазона: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRNDInt(size, min, max);
Console.Write("[");
PrintArray(array, ",");
Console.Write("]");
int[] resArr = ComposArrayElem(array);
Console.Write("[");
PrintArray(resArr, ",");
Console.Write("]");
