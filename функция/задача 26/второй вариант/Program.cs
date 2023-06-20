int DigitCount(int a)
{
    int count = 0;
    if (a == 0)
    {
        count = 1;
    }
    else
    while(a != 0)
    {
        a /= 10;
        count ++;
    }
    return count;
}

Console.Clear();

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(DigitCount(N));