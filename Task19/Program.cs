/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

14212 -> нет

12821 -> да

23432 -> да*/

/*Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number < 0)
{
    number = number * -1;
    if (number < 100000 && number > 9999)
    {
        bool result = Palindrome(number);
        Console.WriteLine(result ? $"Число {-1 * number} является полиндромом"
                                : $"Число {-1 * number} не является полиндромом");
    }
    else Console.WriteLine("Введите корректное число!");

}
else if (number < 100000 && number > 9999)
{
    bool result = Palindrome(number);
    Console.WriteLine(result ? $"Число {number} является полиндромом"
                            : $"Число {number} не является полиндромом");
}

else Console.WriteLine("Введите корректное число!");



bool Palindrome(int num)
{
    int a = num / 10000;
    int a1 = num % 10;
    int b = (num / 1000) % 10;
    int b1 = (num % 100) / 10;
    return (a == a1 && b == b1);
}*/ /*РЕШЕНИЕ БЕЗ ЗВЕЗДОЧКИ*/


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int reverseNumber = Reverse(number);
bool result = Polindrome(number, reverseNumber);

Console.WriteLine(result? "да" : "нет");

int Reverse (int num)
{
    int temp,reverse=0;
    while (num !=0)
    {
        temp = num %10;
        reverse = reverse*10+temp;
        num /= 10;
    }
   return reverse; 
}


bool Polindrome (int num, int num1)
{
return num == num1;
}
