// Задача 7: Напишите программу, которое на входе принимает трехзначное число, 
// а на выходе выдает последнее
// 456 -> 6

Console.Clear();

Console.Write("Enter your number number: ");
int number = int.Parse(Console.ReadLine()!);

int n = number % 10;

Console.WriteLine($"{n}");