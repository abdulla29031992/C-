// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] GetArray(int size, int minValue, int maxValue)
{
  int[] result = new int[size];

  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(minValue, maxValue + 1);
  }
  return result;
}

int CountArray(int[] inArray)
{
  int result = 0;

  foreach (int el in inArray)
  {
    if (el > 0) result++;
  }
  return result;
}


int[] array = GetArray(4, -10, 10);
Console.WriteLine(string.Join(", ", array));
int end = CountArray(array);
Console.WriteLine($"колличество элементов больше нуля массива равно {end}");