using static System.Console;

int[,] matrix = new int[4, 4];

PrintMatrix(MakeSpiral(matrix));


int[,] MakeSpiral(int[,] cube)
{
    int n = 4;
    int start = 1;
    for (int del = 0; del < n - 2; del++)
    {

        for (int i = 0 + del; i < n - del; i++)
        {
            cube[0 + del, i] = start;
            start++;
        }
        start--;
        for (int i = 0 + del; i < n - del; i++)
        {
            cube[i, 3 - del] = start;
            start++;
        }
        start--;
        for (int i = n - 1 - del; i >= 0 + del; i--)
        {
            cube[3 - del, i] = start;
            start++;
        }
        start--;
        for (int i = n - 1 - del; i >= 1 + del; i--)
        {
            cube[i, 0 + del] = start;
            start++;
        }
    }
    return cube;
}





void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (matr[i, j] < 10) Write($"0{matr[i, j]} ");
            else Write($"{matr[i, j]} ");
        }
        WriteLine();
    }
}
