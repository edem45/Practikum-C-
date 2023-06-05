/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int rowFirstMatr = 2;
int columnFirstMatr = 2;
int rowSecondMatr = 2;
int columnSecondtMatr  = 2;

int[,] firstMatrix = CreateMatrixRndInt(rowFirstMatr, columnFirstMatr, 0, 9);
int[,] secondMatrix = CreateMatrixRndInt(rowSecondMatr, columnSecondtMatr, 0, 9);
if (columnFirstMatr == rowSecondMatr)
{
    PrintMatrix(firstMatrix);
    Console.WriteLine();
    PrintMatrix(secondMatrix);
    Console.WriteLine();
    int[,] compositionMatrix = new int [rowFirstMatr,columnSecondtMatr];
    CompositionMatrix(firstMatrix,secondMatrix,compositionMatrix);
    PrintMatrix(compositionMatrix);
}
else Console.WriteLine("Введите равное количество строк и столбцов в 1-ой и во 2-й матрице");


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
            Console.Write($"{matrix[i, j],2} ");

        }
        Console.WriteLine();
    }
}

void CompositionMatrix(int[,] matrix, int[,] matrixSecond, int[,] matrixNew)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int count = 0; count < matrix.GetLength(1); count++)
            {
                sum += matrix[i, count] * matrixSecond[count, j];
            }

            matrixNew[i, j] = sum;

        }

    }
}