double[] CreateArrayRNDInt(int size)
{
    double[] arr = new double [size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] =Math.Round((rnd.Next(1,100) + rnd.NextDouble()), 1);
    }
    return arr;
}

void PrintArray(double[] arr, string sep)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]} ");
    }
}

double MinNumbers (double[] array)
{
    double min =array[0];

        for (int i = 1; i < array.Length; i++)
    {
        if (array[i]< min) min = array[i];
    }
    return min;
}

double MaxNumbers (double[] array)
{
    double max =array[0];

        for (int i = 1; i < array.Length; i++)
    {
        if (array[i]> max) max = array[i];
    }
    return max;
}


Console.WriteLine("Введите кол-во символов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] array = CreateArrayRNDInt(size);
Console.Write("[");
PrintArray(array, ";");
Console.Write("]-->");
double minelement = MinNumbers(array);
double maxelement = MaxNumbers(array);
double difference = maxelement - minelement;
Console.WriteLine(Math.Round(difference,1));
