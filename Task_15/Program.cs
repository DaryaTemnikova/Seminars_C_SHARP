// Задача 15: Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите число дня недели: ");
int num = Convert.ToInt32 (Console.ReadLine());

bool WeeksDay(int number)
{
    return number == 6 || number == 7;
}

bool res = WeeksDay(num);

if(num < 1 || num > 7)
{
    Console.WriteLine("Введено некорректное число! Введите число от 1 до 7");
}
else if(res)
{
    Console.WriteLine($"{num} -> да");
}
else
{
    Console.WriteLine($"{num} -> нет");
}
