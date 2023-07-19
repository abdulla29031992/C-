// Задача 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] GetMatrix(int row, int col, int minValue, int maxValue)
{
    int[,] result = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
} 

void PrintMatrix(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j =0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i,j]}\t ");
        }
        Console.WriteLine();
    }
} 

int[,] MultiMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        Console.WriteLine("матрицы умножить невозможно");
        return matrixC;
    }
        
    for (int i = 0; i < matrixC.GetLength(0); i++)
    {
        for (int j = 0; j < matrixC.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i,j] += matrixA[i,k] * matrixB[k, j];
            } 
        }
    }
    return matrixC;

}
    

Console.Clear();

Console.Write("Введите размерность MatrixA через запятую: ");
int[] dimensionA = Array.ConvertAll(Console.ReadLine().Split(","), Convert.ToInt32);
int[,] matrixA = GetMatrix(dimensionA[0], dimensionA[1], -9, 9);

Console.Write("Введите размерность MatrixB через запятую: ");
int[] dimensionB = Array.ConvertAll(Console.ReadLine().Split(","), Convert.ToInt32);
int[,] matrixB = GetMatrix(dimensionB[0], dimensionB[1], -9, 9);

PrintMatrix(matrixA);
Console.WriteLine();
PrintMatrix(matrixB);
