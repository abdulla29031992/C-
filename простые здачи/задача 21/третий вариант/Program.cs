// Задача 21: Напишите программу, которая на вход принимает координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

Console.Clear();

Console.Write("Введите ккординату точки z1: ");
int z1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите ккординату точки x1: ");
int x1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите ккординату точки y1: ");
int y1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите ккординату точки x2: ");
int x2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите ккординату точки y2: ");
int y2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите ккординату точки z2: ");
int z2 = int.Parse(Console.ReadLine()!);

double x = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2);

double result = Math.Sqrt(x);

Console.Write(Math.Round(result, 2));