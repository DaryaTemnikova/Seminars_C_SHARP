// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32 (Console.ReadLine());

int SecondDigit(int number)
{
    int firstDigit = number / 100;
    int secondDigit = (number - (firstDigit * 100)) / 10;

    if(number < 100 || number > 999) return -1;
    else return secondDigit;
}

int digit = SecondDigit(num);

if(digit == -1)
{
    Console.WriteLine("Введено некорректное число!");
}
else
{
    Console.WriteLine($"{num} -> {digit}.");
}
