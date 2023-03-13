// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
Random random = new Random();

int[,] array = FillArray(4, 4);
ReadArray(array);

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

void SortReverseArray(int[,] array)
{
  int[] oneDimArray = new int[array.GetLength(0)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      oneDimArray[j] = array[i, j];
    }
    Array.Sort(oneDimArray);
    Array.Reverse(oneDimArray);
    System.Console.WriteLine(string.Join(" ", oneDimArray));
  }
}

SortReverseArray(array);
