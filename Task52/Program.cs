/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
int rows = 6;
int columns = 6;
int[,] array2d = CreateMatrixRndInt(rows, columns, 0, 100);
//double[] columsnum = ColumnsNum(columns);
//PrintArray(columsnum);
//Console.WriteLine();
//Line("_____", columns);
//Console.WriteLine();
PrintMatrix(array2d);
Console.WriteLine();
double[] array = SumColumnsMatrix(array2d);
Console.Write("Среднее арифметическое каждого столбца: ");
Console.Write("[");
PrintArray(array);
Console.Write("]");

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

/*double[] ColumnsNum (int size)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = i;
    }
    return arr;
}
*/
/*void Line (string a, int size)
{
   for (int i = 0; i < size; i++)
   {
     Console.Write("_", 5);
   }
}
*/
double[] SumColumnsMatrix(int[,] matrix)
{
    double sum = 0;
    double [] arr = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        arr[j] = Math.Round(sum/matrix.GetLength(0), 1);
        sum = 0;
    }

    return arr;

}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i], 5} ");
        else Console.Write($"{arr[i],5} ");
    }
}



void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        //Console.Write(i + "|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
            Console.Write($"{matrix[i, j], 5} ");

        }
        
        Console.WriteLine();
    }
}

