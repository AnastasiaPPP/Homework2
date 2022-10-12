using static System.Console;
using System.Linq;

int[] array = GetUniqueNumsArray();
PrintThreeDMatrix(GetThreeDMatrix(array));


int[,,] GetThreeDMatrix(int[] arr)
{
    int c = 0;
    int[,,] matrix = new int[2, 2, 2];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i,j,k] = arr[c];
                c++;
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


int[] GetUniqueNumsArray()
{
    int[] arr = new int[8];
    int num = 0;
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        num = rnd.Next(10, 100);
        if(arr.Contains(num)) 
        {
            i--; 
            continue;
        }
        arr[i] = num;
        }
    return arr;
}