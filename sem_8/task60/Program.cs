using static System.Console;

PrintThreeDMatrix(GetThreeDMatrix());


int[,,] GetThreeDMatrix()
{
    Random rnd = new Random();
    int[,,] matrix = new int[2, 2, 2];
    int[] nums = new int[6];
    int num = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                num = rnd.Next(10,100);
                if(nums.Contains(num)) k--;
                else matrix[i, j, k] = num;
            }
        }
    }
    return matrix;
}

void PrintThreeDMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Write($"{matr[i, j, k]} ({i}, {j}, {k})   ");
            }
            WriteLine();
        }
        
    }
}