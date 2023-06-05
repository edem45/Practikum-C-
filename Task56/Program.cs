/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/



int[,] arra2s = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(arra2s);
Console.WriteLine();

int minSum = 0;
int Sum = SumLineElements(arra2s, 0);
for (int i = 1; i < arra2s.GetLength(0); i++)
{
  int tempSum = SumLineElements(arra2s, i);
  if (Sum > tempSum)
  {
    Sum = tempSum;
    minSum = i;
  }
}

Console.WriteLine($"{minSum+1} - строкa");


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



int SumLineElements(int[,] matr, int i)
{
  int Sum = matr[i,0];
  for (int j = 1; j < matr.GetLength(1); j++)
  {
    Sum += matr[i,j];
  }
  return Sum;
}