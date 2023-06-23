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



int[] array1 = Getarray(4, 1, 10);
Console.WriteLine(String.Join("," , array1));