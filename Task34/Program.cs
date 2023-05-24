
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

int QuantityEvenNumbers (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count +=1;
    }
    return count;
}

Console.WriteLine("Введите кол-во символов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число диапазона: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число диапазона: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRNDInt(size, min, max);
// можно использовать int[] array = CreateArrayRNDInt(4, 100, 999); вместо ввода данных в данном примере.
Console.Write("[");
PrintArray(array, ",");
Console.Write("] -->");
int newcount = QuantityEvenNumbers(array);
Console.Write(newcount);

