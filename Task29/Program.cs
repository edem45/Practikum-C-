/*Напишите программу которая задает массив из 8 элементов, 
заполненный псевдослучайными числами и выводит на экран*/

int[] arr = new int[8];

FillArray(arr);
Console.Write("[");
PrintArray(arr); 
Console.Write("]");

void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]} ");
    }
    
}

void FillArray(int[] array)
{
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 15);
    }
}
