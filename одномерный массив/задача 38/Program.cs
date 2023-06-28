// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
// элементов массива.
// [3 7 22 2 78] -> 76

double[] GetArray(int size, double MinValue, double MaxValue)
{
    double[] result = new double[size];

    {
        for (int i = 0; i < size; i++)
        {
            result[i] = new Random().NextDouble() * (MaxValue - MinValue) + MinValue;
        }
        return result;
    }
}

double FindMax(double[] array)
{
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

Console.Clear();

double[] array = GetArray(6, 1, 10);
Console.WriteLine(String.Join(", ", array));

double dif = FindMax(array) - FindMin(array);
Console.WriteLine($"{dif}");