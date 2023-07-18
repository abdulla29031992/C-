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

void SortArray(int[,] array2D)
{
  for (int i = 0; i < array2D.GetLength(0); i++)
  {
    for (int j = 0; j < array2D.GetLength(1) - 1; j++)
    {
      for (int k = j + 1; k < array2D.GetLength(1); k++)
      {
        if (array2D[i, j] < array2D[i, k])
        {
          int temp = array2D[i , j];
          array2D[i, j] = array2D[i, k];
          array2D[i, k] = temp;
        }
      }
    }
  }
}

Console.WriteLine("row= ");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("col= ");
int col = int.Parse(Console.ReadLine()!);
int[,] newArray = GetArray(row, col, 1, 10);
Console.WriteLine();
PrintArray(newArray);
SortArray(newArray);
Console.WriteLine();
PrintArray(newArray);