// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или соббщает, что третьей цифры нет.
// 645 -> 5;
// 78 -> третьей цифры нет.

Console.Clear();

Console.WriteLine("print your number: ");
int number = int.Parse(Console.ReadLine()!);

if (number > 99)
{
    while (number > 999)
    {
        number = number / 10;
    }

    int result = number % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
