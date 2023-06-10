// Задача 8: Напишите программу которое на вход принимает число N,
//  а на выходе показывает все четные числа от 1 до N 
//  5->2,4

Console.Clear();

Console.Write("print your number N: ");
int N = int.Parse(Console.ReadLine()!);

int a = 1;

do 
{
    if (a % 2 == 0)
    {
         Console.WriteLine($"{a} ");
    }
    a++;
}
while (a < N);