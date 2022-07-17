// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Clear();

Console.WriteLine("Введите номер четверти от 1 до 4:");
int quarter = Convert.ToInt32(Console.ReadLine());

string Quarter(int quart)
{
    if (quart == 1) return "Диапазон возможных координат точек в этой четверти: x > 0 и y > 0";
    if (quart == 2) return "Диапазон возможных координат точек в этой четверти: x < 0 и y > 0";
    if (quart == 3) return "Диапазон возможных координат точек в этой четверти: x < 0 и y < 0";
    if (quart == 4) return "Диапазон возможных координат точек в этой четверти: x > 0 и y < 0";
    return "Введены некорректные данные";
}

string result = Quarter(quarter);
Console.WriteLine(result);