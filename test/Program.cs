int[,] GetArray(int row, int col, int minValue, int maxValue)
{
  int[,] result = new int[row, col];

  for (int i = 0; i < row; i++)
  {
    for (j = 0;  j < col; j++)
    {
      result[i, j] = new Random().Next(minValue, maxValue + 1);
    }
  }
  return result;
}

void GetSqrArray(int[,] array2D)
{
  for (int i = 0; i < array2D.GetLength; i++)
  {
    for (int j = 0; j < array2D.GetLength; j++)
    {
      array2D[i, j] *= array2D[i, j];
    }
  }
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

Console.Write("enter row: ");
int row = int.Parse(Console.ReadLine()!);

Console.Write("enter col: ");
int col = int.Parse(Console.ReadLine()!);

int[,] array2D = GetArray(row, col, -10, 10);
PrintArray(array2D);
Console.WriteLine();
GetSqrArray(array2D);
PrintArray(array2D);