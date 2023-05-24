/*Задайте массив , Напишите программу, которая определяет, присутствует ли заданное чисо в массиве.*/
/*4 массив (6,7,19,345,3)*/

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[] { 6, 7, 19, 345, 3 };

Console.Write($"{num}; масив ");

Console.Write("[");
PrintArray(array); 
Console.Write("] - >");

Console.WriteLine(SearchElem(array,num) ? " да":" нет");

void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]} ");
    }
    
}

bool SearchElem (int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) return true;
    }
    return false;
}
