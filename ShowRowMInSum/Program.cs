// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

Console.Clear();
Random random = new Random();

int[,] array = FillArray(4, 4);
ReadArray(array);
int[] arrayOne = SumElements(array);
ReadOneDimArray(arrayOne);
FindMinSumRow(arrayOne);

int[,] FillArray(int row, int column)
{
  int[,] array = new int[row, column];

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = random.Next(1, 21);
    }
  }
  return array;
}

void ReadArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write($"{array[i, j]:d2} ");
    }
    System.Console.WriteLine();
  }
  System.Console.WriteLine();
}

void ReadOneDimArray(int[] array)
{
  System.Console.WriteLine(string.Join(" ", array));
}

int[] SumElements(int[,] array)
{
  int[] sumArray = new int[array.GetLength(0)];
  int sum = 0;

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      sum += array[i, j];
    }
    sumArray[i] = sum;
    sum = 0;
  }
  return sumArray;
}

void FindMinSumRow(int[] array)
{
  int minElement = array[0];
  int index = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] < minElement)
    {
      minElement = array[i];
      index = i;
    }
  }
  System.Console.WriteLine($"Строка под номером {index + 1} с наименьшей суммой элементов ");
}