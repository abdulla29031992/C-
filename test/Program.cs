int DigitCount(int A)

{
    int count = 0;
    while(A != 0)
    {
        A /= 10;
        count ++;
    }
    return count;
}

Console.Clear();

Console.WriteLine("введите число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"колличество цифр в числе равно {DigitCount(N)}");