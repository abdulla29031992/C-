﻿// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int SqrNumber(int a, int b)
{
    if (b == 0) return 1;
    return SqrNumber(a, b - 1) * a;
}

Console.Clear();
Console.Write($"Enter number a: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write($"Enter number b: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine(SqrNumber(a, b));
