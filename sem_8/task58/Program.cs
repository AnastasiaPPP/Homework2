using static System.Console;

// Задача 58: Задайте две матрицы.
//  Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int n = 2;
int m = 2;
int[,] matr = GetMatrix(n, m);
PrintMatrix(matr);
int[,] secMatr = GetMatrix(n, m);
WriteLine();
PrintMatrix(secMatr);
WriteLine();
PrintMatrix(GetSumOfMatrix(matr, secMatr));




int[,] GetMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = rnd.Next(1, 5);
        }
    }
    return matrix;
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write($"{matrix[i, j]} ");
        }
        WriteLine();
    }
}

int[,] GetSumOfMatrix(int[,] matr, int[,] matr2)
{
    int[,] resMatrix = new int[matr.GetLength(0), matr.GetLength(1)];
    for (int i = 0; i < resMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resMatrix.GetLength(1); j++)
        {
          int temp = 0;
          for (int k = 0; k < resMatrix.GetLength(1); k++)
          {
            temp += matr[i, k] * matr2[k, j];
          }
          resMatrix[i, j] = temp;
        }
    }
    return resMatrix;
}