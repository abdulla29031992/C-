// Задача 1: Напишите прогрпмму, котрое на вход принимаеет два числа 
// и проверяет, является ли первое квадратом второго
// а=25, b=5 -> да

Console.Clear();

Console.Write("Введите число a ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b ");
int b = int.Parse(Console.ReadLine()!);
if (b * b == a)
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}
