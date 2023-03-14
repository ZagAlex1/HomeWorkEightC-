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

int[,,] array = FillArray(3, 3, 3);
ReadArray(array);

int[] FillOneDimArray(int row, int column, int width)
{
  int[] randomArray = new int[row * column * width];

  for (int i = 0; i < randomArray.Length;)
  {
    bool alreadyThere = false;
    int randomValue = random.Next(10, 40);
    for (int j = 0; j < i; j++)
    {
      if (randomArray[j] == randomValue)
      {
        alreadyThere = true;
        break;
      }
    }
    if (!alreadyThere)
    {
      randomArray[i] = randomValue;
      i++;
    }
  }
  return randomArray;
}

int[,,] FillArray(int row, int column, int width)
{
  int[] randomArray = FillOneDimArray(row, column, width);
  int[,,] array = new int[row, column, width];
  int randomArrayIndex = 0;

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
          array[i,j,k] = randomArray[randomArrayIndex];
          randomArrayIndex++;
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
