// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].


Console.Clear();

int[] GetArray(int size, int MinValue, int MaxValue)
{
    int[] Result = new int[size];

    for (int i = 0; i < size; i++)
    {
        Result[i] = new Random().Next(MinValue, MaxValue + 1);
    }
    return Result;
}

int CountElement(int[] array)
{
    int count = 0;

    foreach (int el in array)
    {
        if (el > 9 && el < 100)
        {
            count++;
        }
    }
    return count;
}

int[] array = GetArray(123, 1, 20);
Console.WriteLine(String.Join(", ", array));

int end = CountElement(array);
Console.WriteLine($"колличество элементов удовлетвряющих условию равна {end}");