﻿// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Clear();

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32 (Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32 (Console.ReadLine());

bool IsPow(int a, int b)
{
    return a * a == b || b * b == a;
}
bool res = IsPow(num1, num2);

if(res)
{
    Console.WriteLine($"{num1}, {num2} -> да");
}
else
{
    Console.WriteLine($"{num1}, {num2} -> нет");
}