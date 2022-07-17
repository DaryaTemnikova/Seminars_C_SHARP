// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int index = 1;

WriteSquareTable(n);

void WriteSquareTable(int n)
{
    while (index <= n)
    {
        Console.WriteLine($"| {index} | {index * index, 3} |");
        index += 1;
    }
}