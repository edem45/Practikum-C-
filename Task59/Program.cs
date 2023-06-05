/*Задача 59: Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 2 3
4 2 4
2 6 7*/
int[,] array2d = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(array2d);
Console.WriteLine();
int[] min = MinElements(array2d);
Console.WriteLine(min[2]);
Console.WriteLine();
int[,] newarray2d = RemoveRowColumn(array2d,min[0], min[1]);
PrintMatrix(newarray2d);


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
        //Console.Write(i + "|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write($"{matrix[i, j],5} ");

        }

        Console.WriteLine();
    }
}


int[] MinElements(int[,] matr)
{
    int min = matr[0, 0];
    int row = 0;
    int column = 0;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] <= min )
            {
                min = matr[i, j]; 
                row = i;
                column = j;
            }
        }
    }

    return new int[] { row, column, min };

}

int[,] RemoveRowColumn(int[,] matr, int delrow, int delcolumn)
{
    int[,] newMatrix = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
    int m = 0, n = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        n = 0;
        if (m == delrow) m++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (n == delcolumn) n++;

            newMatrix[i, j] = matr[m, n];
            n++;

        }
        m++;
        n = 0;
    }
    return newMatrix;
}
