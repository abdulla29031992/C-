Console.Clear();

Console.WriteLine("введите число a: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("введите число b: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine("введите число c: ");
int c = int.Parse(Console.ReadLine()!);

bool CheckTriangele(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

if (CheckTriangele(a, b, c))
{
    Console.WriteLine("Треугольник существует");
}
else
{
    Console.WriteLine("Треугольника не существует");
}