// Задача 18: Напишите программу, которая по заданному номеру четверти, показываеь диапазон возможных 
// координат точек в этой четверти (x y)

Console.Clear();

Console.Write("Введите номер четверти n: ");
int n = int.Parse(Console.ReadLine()!);


if (n == 1)
{
    Console.Write("x > 0; y > 0");
}
else if (n == 2)
{
    Console.Write("x < 0; y > 0");
}
else if (n == 3)
{
    Console.Write("x < 0; y < 0");
}
else if (n == 4)
{
    Console.Write("x < 0; y < 0");
}
else
{
    Console.Write("Ввелите число от 1 до 4");
}