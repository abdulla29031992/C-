// Задача 22: Напишите программу, которая на вход принимает число (N) и выдает таблицу квадратов чисел
// от 1 до N
// 5 -> 1,2,3,16,25


Console.Clear();
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int i = 1;
while (i <= N)

{
Console.Write($"{Math.Pow(i, 2) + " "}");
i++;
}
