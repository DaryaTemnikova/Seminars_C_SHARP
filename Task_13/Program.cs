// Задача 13: Напишите программу, 
// которая выводит третью цифру 
// заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32 (Console.ReadLine());

int ThirdDigit(int number)
{
    int index = 0;
    while (number > 999)
    {
        number = number / 10;
    }
    int tirdDigit = number % 10;
    
    if(number < 100) return -1;
    else return tirdDigit;
}

int digit = ThirdDigit(num);

if(digit == -1)
{
    Console.WriteLine($"{num} -> третьей цифры нет");
}
else
{
    Console.WriteLine($"{num} -> {digit}.");
}