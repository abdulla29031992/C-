// Задача 12: Напишите программу, которое на вход будет принимать два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа
// выводит остаток от деления.
// 34, 5 -> не кратно осаток 4;
// 16, 4 -> кратно.

Console.Clear();

Console.Write("Print nubmer a: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Print nubmer b: ");
int b = int.Parse(Console.ReadLine()!);

int c = a % b;

if (c == 0)
{
    Console.WriteLine($"Кратно");
}
else 
{
    
    Console.WriteLine($"Остаток от деления {c}");
}