// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

FindPalindrom(number);

void FindPalindrom(int num)
{
    int num1 = num / 10000;
    int num2 = num / 1000 % 10;
    int num3 = num / 100 % 10;
    int num4 = num / 10 % 10;
    int num5 = num % 10;
    if (Convert.ToString(number).Length != 5) Console.WriteLine("Введите корректное число");
    else if(num1 == num5 && num2 == num4) Console.WriteLine($"{number} -> да, это палиндром");
    else Console.WriteLine($"{number} -> нет, это не палиндром");
}
