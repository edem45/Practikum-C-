


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

int SumUnEvenNumbers (int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
         sum = sum + array[i];
    }
    return sum;
}

Console.WriteLine("Введите кол-во символов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число диапазона: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число диапазона: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRNDInt(size, min, max);
// можно использовать int[] array = CreateArrayRNDInt(4, -100, 100); вместо ввода данных в данном примере.
Console.Write("[");
PrintArray(array, ",");
Console.Write("] -->");
int sumelement = SumUnEvenNumbers(array);
Console.Write(sumelement);
