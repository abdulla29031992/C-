Console.Clear();

Console.Write("Введите координату x: ");
int x = int.Parse(Console.ReadLine()!);


Console.Write("Введите координату y: ");
int y = int.Parse(Console.ReadLine()!);


if (y > 0)
{
    if (x > 0)
    Console.Write($"Певая четверть");
    else
    {
        Console.Write("вторая четверть");
    }
}
else 
{
    if (x > 0)
    {
        Console.Write($"четвертая четверть");
    }
    else
    {
        Console.Write("третья четверть");
    }
}