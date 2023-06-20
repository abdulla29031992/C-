// Задача 26: Напишите программу, которая принимает на вход число и выдает количество цифр в чисел
// 45 -> 2

int DigitCount(int A)

{
    int count = 0;
    while (A != 0)
    {
        A /= 10;
        count++;
    }
    return count;
}

Console.Clear();

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(DigitCount(N));