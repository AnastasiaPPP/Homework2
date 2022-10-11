using static System.Console;
int n = int.Parse(ReadLine()!);
int m = int.Parse(ReadLine()!);
int[,] matr = GetMatrix(n, m);
PrintMatrix(matr);
WriteLine();
SortingMatrix(matr);
PrintMatrix(matr);

int[,] GetMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
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

int[,] SortingMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                if(matrix[i, j] <= matrix[i, k]) continue;
                int temp = matrix[i, j];
                matrix[i, j] = matrix[i, k];
                matrix[i, k] = temp;
            }
            
        }
        
    }
return matrix;
}