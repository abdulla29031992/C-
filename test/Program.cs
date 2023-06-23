Console.Clear();

int[] GetArray(int size, int MinValue, int MaxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(MinValue, MaxValue +1);
    }
    return result;
}

int[] MultiArray(int[] array)
{
    int size = array.Length / 2;

    if (array.Length % 2 != 0) size++;

    int[] result = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }

    if (array.Length % 2 != 0)
    array[size - 1] = array[array.Length / 2];
    return result;
}

int[] array1 = GetArray(4, -9, 9);
Console.WriteLine(String.Join(", ", array1));

int[] array2 = MultiArray(array1);
Console.WriteLine(String.Join(", ", array2));