/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1,
 y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/


Console.Write("Введите целое число: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число: ");
double k2 = Convert.ToInt32(Console.ReadLine());


bool StraightnessCheck (double numb1, double numb2, double numk1, double numk2)
{
    if (numb1 == numb2 && numk1 == numk2) return false;
     if (numk1 == numk2) return false;
    return true;
}

double[] IntersectionPoint (double numb1, double numb2, double numk1, double numk2)
{
    double[] arr = new double[2];
    int i = 0;
        
        arr[i] = (numb2-numb1)/ (numk1-numk2);
        arr[i+1] = numk1*((numb2-numb1)/ (numk1-numk2)) + b1;
    
    return arr;

}

void PrintArray(double[] arr, string sep = ",")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]} ");
    }
}


Console.WriteLine(StraightnessCheck(b1,b2,k1,k2) ? "Точка переcечения: " : "Прямые параллены либо совпадают!");
if (StraightnessCheck(b1,b2,k1,k2))
{
   double[] array = IntersectionPoint(b1,b2,k1,k2);
   PrintArray(array);
}



