Console.Clear();

int[] GetArray(int size, int MinValue, int MaxValue)
{
    int[] result = new int[size];

    for ( int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(MinValue, MaxValue + 1);
    }

    return result;
}

void SigChange(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}

int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(", ", array));
SigChange(array);
Console.WriteLine(String.Join(", ", array));