﻿// Задача 8: Напишите программу, 
// которая на вход принимает число (N), 
// а на выходе показывает 
// все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.Write("Введите число N: ");

int n = Convert.ToInt32 (Console.ReadLine());

int i = 2;

Console.WriteLine($"Все четные числа от 1 до {n}: ");
while (i <= n)
{
Console.Write($"{i} ");
i += 2;
}
