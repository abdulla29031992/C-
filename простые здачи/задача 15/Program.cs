// Задача 15: Напишите программу, которая на вход принимает цифру, обозначаюшую день недели, и проверяет 
// является ли этот день выходным.


Console.Clear();

Console.Write("Print nubmer n: ");
int n = int.Parse(Console.ReadLine()!);

if (n == 6 || n == 7)
{
    Console.Write("выходной");
}
else
{
    Console.Write("не выходной");
}