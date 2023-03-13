// Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Random random = new Random();

int[,] array = { { 1, 2, 2 }, { 3, 1, 1 } };
int[,] array1 = { { 4, 2 }, { 3, 1 }, { 1, 5 } };
ReadArray(array);
int[,] array2 = MatrixMultiply(array, array1);
ReadArray(array2);

// int[,] FillArray(int row, int column)
// {
//   int[,] array = new int[row, column];

//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = random.Next(1, 21);
//     }
//   }
//   return array;
// }

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

int[,] MatrixMultiply(int[,] matrixOne, int[,] matrixTwo)
{
  int[,] multiplyMatrix = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];

  if (matrixOne.GetLength(1) != matrixTwo.GetLength(0))
  {
    System.Console.WriteLine("Матрицы не получится перемножить, подайте другие!!!");
  }
  else
  {
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
      for (int j = 0; j < matrixTwo.GetLength(1); j++)
      {
        multiplyMatrix[i, j] = 0;
        for (int k = 0; k < matrixOne.GetLength(1); k++)
        {
          multiplyMatrix[i, j] += matrixOne[i, k] * matrixTwo[k, j];
        }
      }
    }
  }
  return multiplyMatrix;
}

