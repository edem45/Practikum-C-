﻿
/*
Задача 49: Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты.*/

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

int[,] Replace(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j = j + 2)
        {

            matrix[i, j] = matrix[i, j] * matrix[i, j];
        }

    }

return matrix;
}


int[,] arra2s = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(arra2s);
Console.WriteLine();
Replace(arra2s);
PrintMatrix(arra2s);
