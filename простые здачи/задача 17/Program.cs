// Задача 17: Напишите программу, которая принимает на вход координаты точки (x y), причем x/= 0, y/=0
// и выдает номер четверти плоскости, в которой находится это точка.

Console.Clear();

Console.Write("Введите координату x: ");
int x = int.Parse(Console.ReadLine()!);


Console.Write("Введите координату y: ");
int y = int.Parse(Console.ReadLine()!);

if (x > 0 && y > 0)
{
    Console.Write("первая четверть");
}
else if (x < 0 && y > 0)
{
    Console.Write("вторая четверть");
}
else if (x < 0 && y < 0)
{
    Console.Write("третья четверть");
}
else if (x > 0 && y < 0)
{
    Console.Write("четвертая четверть");
}