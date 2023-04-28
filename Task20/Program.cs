/*Задача 20: Напишите программу, которая
принимает на вход координаты двух точек и
находит расстояние между ними в 2D
пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
12 мин*/
Console.WriteLine("Введите координаты А(x1,y1): ");
Console.Write("X1: ");
double x1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
double y1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты B(x2,y2): ");
Console.Write("X2: ");
double x2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
double y2Coordinate = Convert.ToInt32(Console.ReadLine());

double dist = Distance(x1Coordinate, y1Coordinate, x2Coordinate, y2Coordinate);

double round = Math.Round(dist, 2, MidpointRounding.ToZero);

Console.WriteLine(round);


double Distance(double x1, double y1, double x2, double y2)
{
    double sumCatet = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2);

    double distance = Math.Sqrt(sumCatet);

    return distance;
}