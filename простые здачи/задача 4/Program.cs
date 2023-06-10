//Задача 4: Напишите программу, котрое на вход принимет три числа и выдает максимальное
// a = 5; b = 7 С = 8 -> max = 8

Console.Clear();

Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Введите число c: ");
int c = int.Parse(Console.ReadLine()!);

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max= ");
Console.WriteLine(max);