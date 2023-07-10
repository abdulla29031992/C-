double[,] GetArray(int row, int col, double minValue, double maxValue)
{
  double[,] result = new double[row, col];

  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < col; j++)
    {
      result[i, j] = Math.Round(minValue + new Random().NextDouble() * (maxValue - minValue), 1);
    }
  }
  return result;
}

void PrintArray(double[,] inArray)
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


Console.Clear();
Console.Write("enter row: ");
double row = int.Parse(Console.ReadLine()!);
Console.Write("enter col: ");
double col = int.Parse(Console.ReadLine()!);
double[,] array = GetArray(3, 4, -10, 10);
PrintArray(array);
