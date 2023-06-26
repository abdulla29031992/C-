int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}


int GetSum(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}


Console.Clear();

int[] array = GetArray(4, 100, 1000);
Console.WriteLine(String.Join(", ", array));
int end = GetSum(array);
Console.WriteLine($"Сумма элементрв на нечетных позициях равна {end}");