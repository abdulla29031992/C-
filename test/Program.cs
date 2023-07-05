int[] GetArray(int size, int minValue, int maxValue)
{
  int[] result = new int[size];

  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(minValue, maxValue + 1);
  }
  return result;
}


int CountArray(int[] array)
{
  int result = 0;

  foreach (int el in array)
  {
    if (el > 0) result++
  }
  return result;
}

int[] array = GetArray(4, -10, 10);
Console.WriteLine(string.Join(", ", array));
int end = CountArray(array);
Console.WriteLine($"колличество элемнтов больше нуля {end}");