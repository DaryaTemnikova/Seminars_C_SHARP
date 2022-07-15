// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Clear();

Console.Write("Введите число: ");
int num = Convert.ToInt32 (Console.ReadLine());

int MultDigit(int number)
{
    int result1 = number % 7;
    int result2 = number % 23;
    
    if (result1 == 0 & result2 == 0) return 0;
    else return -1;
}


int multDigit = MultDigit(num);
if(multDigit == 0) Console.WriteLine($"{num} -> да");
else Console.WriteLine($"{num} -> нет");
    