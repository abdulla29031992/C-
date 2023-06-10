// Задача 2: Напишите программу, котрое на вход принимет два числа и выдает какое больше, а какое меньше
// a = 5; b  7 -> max = 7

Console.Clear();

Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);

int max = a;

if (a > b)
{
    Console.WriteLine($"{max = a}");
}
else
{
    Console.WriteLine($"{max = b}");
}
