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

void SwapTwoRow(int[,] NewArray)
{
  for (int j = 0; j < NewArray.GetLength(1); j++)
  {
    int temp = NewArray[0, j];
    NewArray[0, j] = NewArray[NewArray.GetLength(0) - 1, j];
    NewArray[NewArray.GetLength(0) - 1, j] = temp;
  }
}


Console.Clear();
Console.Write("row = ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("col = ");
int col = int.Parse(Console.ReadLine()!);
int[,] array2D = GetArray(row, col, -10, 10);
PrintArray(array2D);

Console.WriteLine();
SwapTwoRow(array2D);
PrintArray(array2D);