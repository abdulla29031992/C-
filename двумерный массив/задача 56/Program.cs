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

void GetMinSum(int[,] minArray)
{
  int sum;
  int min = 0;
  int minRow = 1;
  bool isStrated = false;

  for (int i = 0; i < minArray.GetLength(0); i++)
  {
    sum = 0;

    for (int j = 0; j < minArray.GetLength(1); j++)
    {
      sum += minArray[i, j];
    }
      if (isStrated || sum < min)
      {
        isStrated = true;
        sum = min;
        minRow = i + 1;
      }
    
  }
  Console.WriteLine($"{minRow} строка");
}

Console.Clear();
Console.Write("row = ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("col = ");
int col = int.Parse(Console.ReadLine()!);
int[,] newArray = GetArray(row, col, 1, 10);
Console.WriteLine();
PrintArray(newArray);
GetMinSum(newArray);