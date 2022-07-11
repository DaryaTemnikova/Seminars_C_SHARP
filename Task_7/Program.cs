// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Clear();
Console.Write("Введите трехзначное число: ");

int num = Convert.ToInt32 (Console.ReadLine());

if (1000 > num)
{
    if (num > 99)
    {
    int lastDigit = num % 10;
    Console.Write(lastDigit);
    }
    else
    {
    Console.WriteLine("Ошибка! Введите корректное число");
    }
}
else
{
Console.WriteLine("Ошибка! Введите корректное число");
}
