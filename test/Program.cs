int[] GetArray(int size,int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i]= new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

int CountElement(int[] array)
{
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) result++;
    }
    return result;
}

Console.Clear();

int[] array = GetArray(4, 100, 1000);
Console.WriteLine(String.Join(", ", array));
int end = CountElement(array);
Console.WriteLine($"колличество четных элементов массива равно {end}");