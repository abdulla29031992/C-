// Задача 21: Напишите програграмму, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D  пространстве.

Console.Write("Введите ккординату точки x1: ");
int x1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите ккординату точки y1: ");
int y1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите ккординату точки x2: ");
int x2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите ккординату точки y2: ");
int y2 = int.Parse(Console.ReadLine()!);

double a = Math.Pow(x2 - x1, 2);
double b = Math.Pow(y2 - y1, 2);

double c = Math.Sqrt(a + b);

Console.Write(Math.Round(c, 2));