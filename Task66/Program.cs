/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


Console.WriteLine("Введите целое число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 0 || numberN < 0) Console.WriteLine("Введите натуральные числа!");
//else if (numberM > numberN) Console.WriteLine(NaturalNumbersSum(numberM,numberN)); //результат одинаковый
else Console.WriteLine(NaturalNumbersSum(numberN,numberM));


int NaturalNumbersSum (int numM, int numN)
{
    if(numM == numN) return numM;
    return numM + NaturalNumbersSum(numM-1,numN);

}