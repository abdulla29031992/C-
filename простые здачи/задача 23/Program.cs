// Задача 23: Напишите программу, которая на вход принимает число (N) 
// и выдает таблицу кубов чисел от 1 до N.
// 3 -> 1 8 27


Console.Clear();
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

int i = 1;

while(i <= N)
{
    Console.Write($"{Math.Pow(i, 3) + " "}");
    i++;
}