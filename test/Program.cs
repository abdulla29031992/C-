Console.Clear();

int[] GetArray(int size, int MinValue, int MaxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random { }.Next(MinValue, MaxValue + 1);
    }
    return result;
}

bool FindElement(int number, int[] collection)
{
    foreach (int el in collection)
    {
        if (el == number)
        {
            return true;
        }
    }
    return false;
}

int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(", ", array));

Console.WriteLine("ВВЕДИТЕ ЧИСЛО N: ");
int N = int.Parse(Console.ReadLine()!);

if (FindElement(N, array))
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}