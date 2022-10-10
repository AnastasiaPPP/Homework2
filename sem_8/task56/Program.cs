using static System.Console;

int n = int.Parse(ReadLine()!);
int m = int.Parse(ReadLine()!);
int[,] matr = GetMatrix(n, m);
PrintMatrix(matr);
GetSum(matr);

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

void GetSum(int[,] matrix)
{
    int res = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if(sum > res) res = sum;
        
    }
    WriteLine(res);
}
