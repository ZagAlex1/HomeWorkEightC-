// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя 
// индексы каждого элемента.
// Массив размером 2 x 2 x 2

// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
Random random = new Random();

int[,,] array = FillArray(2, 2, 2);
ReadArray(array);


int[,,] FillArray(int row, int column, int width)
{
  int[,,] array = new int[row, column, width];

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {

      for (int k = 0; k < array.GetLength(2); k++)
      {
        array[i, j, k] = random.Next(10, 21);
      }
    }
  }

  return array;
}

void ReadArray(int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        System.Console.Write($" {array[i, j, k]:d2} ({i},{j},{k})");
      }
      System.Console.WriteLine();
    }
  }
}