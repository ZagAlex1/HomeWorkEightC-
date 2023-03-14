// Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:

// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

int[,] array = FillArraySpiral(4);
ReadArray(array);

int[,] FillArraySpiral(int size)
{
  int[,] spiralArray = new int[size, size];
  int count = 1;
  int row = 0;
  int column = 0;


  while (count <= size * size)
  {
    for (int i = column; i < size - column; i++)
    {
      spiralArray[row, i] = count;
      count++;
    }
    row++;

    for (int i = row; i < size - row + 1; i++)
    {
      spiralArray[i, size - column - 1] = count;
      count++;
    }
    column++;

    for (int i = size - column - 1; i >= column - 1; i--)
    {
      spiralArray[size - row, i] = count;
      count++;
    }

    for (int i = size - row - 1; i >= row; i--)
    {
      spiralArray[i, column - 1] = count;
      count++;
    }
  }
  return spiralArray;
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
