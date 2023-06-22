//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

Console.Write("введите число a: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("введите число b: ");
int b = int.Parse(Console.ReadLine()!);

double MathPow(int num, int st)
{
    double n = Math.Pow(num, st);
    return n;
}

double math = Math.Pow(a, b);
Console.WriteLine($"{a}, {b} -> {math}");