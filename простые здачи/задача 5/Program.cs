﻿// Задача 5: Напишите программу, которая на вход принимает одно число (N), а на выходе прказывает все целые числа
// от -N до N.
// 4-> "-4;-3;-2;-1;0;1;2;3;4"

Console.WriteLine("Enter your number N: ");
int N = int.Parse(Console.ReadLine()!);
int k = -N;
while (k <= N)
{
    Console.Write($"{k} ");
    k++;
}