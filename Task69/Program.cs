
Console.WriteLine("Введите целое число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B");
int numberB = Convert.ToInt32(Console.ReadLine());


int degree = Degree(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} равно {degree}");



/*
int Degree(int numA, int numB)
{
     if (numB == 0) return 1;
     return numA * Degree(numA, numB-1); //A 3 3 3 3 3   B 5 4 3 2 1
}
*/

 int Degree(int numA, int numB)
 {
    return numB == 0 ? 1 : numA * Degree(numA, numB-1);
 }
