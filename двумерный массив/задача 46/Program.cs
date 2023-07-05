int[,] GetArray(int row, int col, int MinValue, int MaxValue)
{
  int[,] result = new int[row, col];

  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < col; j++)
    {
      result[i, j] = new Random().Next(MinValue, MaxValue + 1);
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
      Console.Write($"{inArray[i, j]}\t");
    }
    Console.WriteLine();
  }
}

Console.Write("enter row: ");
int row = int .Parse(Console.ReadLine()!);

Console.Write("enter col: ");
int col = int.Parse(Console.ReadLine()!);

int[,] array2D = GetArray(row, col, -10, 10);

PrintArray(array2D);
