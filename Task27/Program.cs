/*Напишите программу которая принимает на вход число и выдает сумму цифр в числе*/
/*452 - 11
82 - 10*/

Console.WriteLine("Введите целое число A: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int sumNumber  = Sumnumbers(num1);

int Sumnumbers (int num)
{
    int sum = 0;
    int digit = 0;

    while (num != 0)
    {
        digit = num % 10;
        num= num/10;
        sum = sum + digit;
        
    }

return sum;
}

Console.WriteLine(sumNumber);
