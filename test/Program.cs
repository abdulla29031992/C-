Console.Clear();

int[] Getarray(int size; int MinValue, int MaxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size, i++)
    {
        result[i] = new Random().Next(MinValue, MaxValue + 1);
    }
    return result;
}

int CountElement(int[] array)
{
    int count = 0;

    foreach(int el in array)
    {
        if (el > 9 && el < 100)
        {
            count++;
        }
    }
    return count;
}

int[] array = Getarray(123, 1, 100);
Console.WriteLine(String.Join("," , array));