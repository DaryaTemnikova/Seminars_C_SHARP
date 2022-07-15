// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8


Console.Clear();

int num = new Random().Next(10, 100);
// // int firstDigit = num / 10;
// // int secontDigit = num % 10;

// if (firstDigit == secontDigit)
//     Console.WriteLine("Цифры одинаковые.");
// else if (firstDigit > secontDigit)
//     Console.WriteLine($"{num} -> {firstDigit}");
// else
//     Console.WriteLine($"{num} -> {secontDigit}");


int MaxDigit(int number)
{
    int firstDigit = num / 10;
    int secontDigit = num % 10;

    if (firstDigit == secontDigit) return 0;
    else if (firstDigit > secontDigit) return firstDigit;
    return secontDigit;
}

int maxDigit = MaxDigit(num);
if(maxDigit == 0) Console.WriteLine($"{num} -> Цифры одинаковые.");
else Console.WriteLine($"{num} -> {maxDigit}");

