// Демо-задача: Напишите программу которое на вход принимает число  и выдает его квадрат 
// (число умноженное на самого себя)
// 2 -> 4
// 3 -> 9

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int sqr = number * number;
double sqr2 = Math.Pow(number, 2);
Console.WriteLine($"Квадрат {number} равен {sqr}");
Console.WriteLine($"Квадрат {number} равен {sqr2}");







