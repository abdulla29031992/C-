﻿// Демо-Задача 2: Напишите программу, кторая выводит случайное число из отрезка [10,99] и показывает
// наибольшую цифру числа.
// 78 -> 8

Console.Clear();

int num = new Random().Next(10, 100); 

int a1 = num / 10;
int a2 = num % 10;

int max = a1;

if (a2 > max) 
{
    max = a2;
}

Console.WriteLine($"Максимальная цифра {num} равна {max}");
