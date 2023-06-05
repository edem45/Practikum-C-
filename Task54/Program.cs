/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки
 двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int[,] arra2s = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(arra2s);
Console.WriteLine();
ReplaceMatixNumberToMinByRows(arra2s);


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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],10} ");

        }
        Console.WriteLine();
    }
}




void ReplaceMatixNumberToMinByRows(int[,] matr)
{

    int[] arr = new int[matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            arr[j] = matr[i, j];

        }
        BubbleSort(arr);
        ArrToMatrix(i,arr,matr);
    }

    PrintMatrix(matr);

}


void BubbleSort(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        for (int j = 0; j < arr.Length - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
}

 void ArrToMatrix( int count, int[] arr, int[,] matrix)
        {
            for (int k = 0; k < arr.Length; k++)
            {
    
                 matrix[count, k] = arr[k];
              
            }
        }