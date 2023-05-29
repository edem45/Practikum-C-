/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1, 7 -> такого элемента в массиве нет*/

Console.Write("Введите номер строки массива: ");
int rowsEnter = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца массива: ");
int columnsEnter = Convert.ToInt32(Console.ReadLine());
int rowsConst = 4;
int columnsConst = 4;
int minNumber = -10;
int maxNumber = 10;


int [,] arra2s = CreateMatrixRndInt(rowsConst,columnsConst, minNumber, maxNumber);
PrintMatrix(arra2s);
Console.WriteLine();

if(ComparisonOfIndexes(rowsConst,columnsConst,rowsEnter,columnsEnter) == 0) 
Console.WriteLine($"{rowsEnter},{columnsEnter} --> введите натуральные целые числа !!");

if (ComparisonOfIndexes(rowsConst,columnsConst,rowsEnter,columnsEnter) == 1)
Console.WriteLine($"{rowsEnter},{columnsEnter} -->такого элемента в массиве нет");

if (ComparisonOfIndexes(rowsConst,columnsConst,rowsEnter,columnsEnter) == 2)
Console.WriteLine($"{rowsEnter},{columnsEnter} --> {arra2s[rowsEnter,columnsEnter]}");



int ComparisonOfIndexes (int rows, int columns, int rowsEnt , int columnsEnt)
{
    if (rowsEnt < 0 || columnsEnt < 0) return 0;
    if (rowsEnt > rowsConst || columnsEnt > columnsConst ) return 1;
    return 2;
}


int[,] CreateMatrixRndInt (int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows,columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max +1);
        }
    }
    return matrix;
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j], 5} ");
    
        }
        Console.WriteLine();
    }
}


