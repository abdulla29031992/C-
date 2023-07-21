int dim1 = ("введите размерность 1:");
int dim2 = ("введите размерность 2:");
int dim3 = ("введите размерность 3: ");
int countNumbers = 89;

if (dim1 * dim2 * dim3 > countNumbers)
{
  Console.WriteLine("слишком большой массив");
  return;
}

int[,,] resultNumbers = Create3DMassive(dim1, dim2, dim3)
{
  for (int i = 0; i < resultNumbers.GetLength(0); i++)
  {
    for (int j = 0; j < resultNumbers.GetLength(1); j++)
    {
      for (int k = 0; k < resultNumbers.GetLength(2); k++)
      {
        Console.WriteLine($"[{i}, {j}, {k}] - [resultNumbers{i, j, k}]");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

int[,,] Create3DMassive(int size1, int size2, int size3)
{
  int[,,] array = new int[size1, size2, size3];
  int[] values = new int[countNumbers];
  int num = 10;

  for (int i = 0; i < values.Length; i++)
  {
    values[i] = num;
    ++;
  }

  for (int i = 0; i < values.Length; i ++)
  {
    int randomInd = new Random().Next(0, values.Length);
    int temp = values[i];
    values[i]  = values[randomInd];
    values[randomInd] = temp;
  }

  valuesIndex = 0;

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        array[i, j, k] = values[valuesIndex++];
      }
    }
  }
  return array;
}

int InputInt(string output)
{
  Console.WriteLine(output);
  return int.Parse(Console.ReadLine()!);
}