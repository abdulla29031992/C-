int[] GetArray(int size, int MinValue, int MaxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(MinValue, MaxValue + 1);
    }

    return result;
}

void ReversArray1(int[] inArray)
{

    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int temp = inArray[i];
        inArray[i] = inArray[inArray.Length - 1 - i];
        inArray[inArray.Length - 1 - i] = temp;
    }
}

int[] ReversArray2(int[] inArray)
{
    int[] result = new int[inArray.Length];

    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }
    return result;

}


Console.Clear();

int[] array = GetArray(6, 1, 10);
Console.WriteLine(String.Join(", ", array));

ReversArray1(array);
Console.WriteLine(String.Join(", ", array));

int[] revered = ReversArray2(array);
Console.WriteLine(String.Join(", ", revered));
