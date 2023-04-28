// Напишите программу, которая выводит
// случайное трехзначное число и удаляет второе цифру
int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайнок число з отрезка 100 - 1000 -> {number}");

int result = MaxDigit (number);
Console.WriteLine($"Новое двузначное число -> {result}");

int MaxDigit(int num)
{
    int firstDigit = num / 100; // получаем первую цифру
    int thirdDigit = num % 10; // получаем третью цифру
    int maxDigit = firstDigit*10 + thirdDigit; //получаем число без второй
    return maxDigit; //возвращаем результат
}
