// Задача 24: Напишите программу котрая на вход принимает число N и выдает сумму чисел от 1 до N
// 7 -> 28

int GetSum(int N)
{
int sum = 0;
for (int i = 1; i <= N; i++)
{
sum += i; // sum = sum + i
}
return sum;
}

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма чисел от 1 до {number} равна {GetSum(number)}");
