// Задача 28: Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N
// 4 -> 24

int GetMultiNumber(int A)
{
    int number = 1;
    for (int i = 1; i <= A; i++)
    {
        number = number * i;
    }
    return number;
}

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"произведение чисел от 1 до {n} ровно {GetMultiNumber(n)}");