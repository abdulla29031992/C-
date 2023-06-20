int GetSum(int A)
{
    int sum = 0;
    for (int i = 0; i <= A; i ++)
    {
        sum = sum + i;
    }

    return sum;
}

Console.WriteLine("введите число n: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"сумма чисел от 1 до n равна {GetSum(n)}");