Console.Clear();

Console.Write("Введите ккординату точки x1: ");
int x1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите ккординату точки y1: ");
int y1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите ккординату точки x2: ");
int x2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите ккординату точки y2: ");
int y2 = int.Parse(Console.ReadLine()!);

double x = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y2, 2);
double result = Math.Sqrt(x);

Console.Write(Math.Round(result, 2));