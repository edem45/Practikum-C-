


int[] array = new int[] { -4, -8, 8, 2 };

Console.Write("[");
PrintArray(array); 
Console.WriteLine("]");

Console.Write("[");
InverseArrElem(array); 
Console.Write("]");

void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]} ");
    }
    
}

void InverseArrElem (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]} ");

    }
}
