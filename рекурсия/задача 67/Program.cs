// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


int NumberFor(int n)
{
    if (n == 0) return 0;
    return n % 10 + NumberFor(n / 10);
}

Console.Clear();
Console.Write("enter your number: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(NumberFor(n));