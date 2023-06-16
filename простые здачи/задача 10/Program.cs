// Задача 10: Напишите прогрпамму, которое на вход принимает трехзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456->5.


Console.Clear();

Console.Write("Print nubmer n: ");
int n = int.Parse(Console.ReadLine()!);

int a = n / 10;

int res = a % 10;

Console.WriteLine($"{a}");
