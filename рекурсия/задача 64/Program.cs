/*Задача 64: Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от  N до 1.
N = 5. -> ""5,4,3,2,1""*/

string NumberFor(int n)
{
if (n == 1) return $"{n}";
return $"{n}, " + NumberFor(n - 1);
}

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(NumberFor(n));
