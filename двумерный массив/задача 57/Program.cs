int[,] GetArray(int row, int col, int minValue, int maxValue)
{
  int[,] result = new int[row, col];

  for (int i = 0; i < row; i++)

  {
    for (int j = 0; j < col; j++)
    {
      result[i, j] = new Random().Next(minValue, maxValue + 1);
    }
  }
  return result;
}

void PrintArray(int[,] inArray)
{
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      Console.Write($"{inArray[i, j]}\t ");
    }
    Console.WriteLine();
  }
}

int[] Transform2DTo1D(int[,] array2D)
{
  int[] array1D = new int[array2D.GetLength(0) * array2D.GetLength(1)];

  int k = 0;

  for (int i = 0; i < array2D.GetLength(0); i++)
  {
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
      array1D[k++] = array2D[i, j];
    }
  }
  return array1D;
}

void Sort(int[] array)
{
  for (int i = 0; i < array.Length - 1; i++)
  {
    for (int j = i + 1; j < array.Length; j++)
    {
      if (array[i] > array[j])
      {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
      }
    }
  }
}

void CountElements(int[] array)
{
  int count = 1;

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] == array[i + 1]) count++;
    else
    {
      Console.Write($"колличество элементов {array[i]} ровно {count} раз");
      count = 1;
    }
  }
}


Console.Clear();

Console.WriteLine("row: ");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("col: ");
int col = int.Parse(Console.ReadLine()!);

int[,] array2D = GetArray(row, col, 1, 10);
PrintArray(array2D);

int[] array1D = Transform2DTo1D(array2D);

Sort(array1D);

CountElements(array1D);


